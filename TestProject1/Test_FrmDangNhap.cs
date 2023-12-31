﻿using NUnit.Framework;
using _2_BUS.IServices;
using _2_BUS.Services;
using _3_GUI.View;
using System.Linq;
using System.Windows.Forms;
namespace TestProject1
{
    [TestFixture]
    public class FrmDangNhapTests
    {
        private FrmDangNhap form;
        //Cái này chạy như constructor
        [SetUp]
        public void Init()
        {
            form = new FrmDangNhap();
        }
        //Cái này để dọn dự án
        [TearDown]
        public void Dispose()
        {
            form.Dispose();
        }
        [Test]
        public void LoginwithTrueData()
        {

            form.tb_taikhoan.Text = "A";
            form.tb_matkhau.Text = "1";

            form.btn_dangnhap_Click(null, null);
            // Assert: Check that the expected result occurred
            Assert.That(form.LoginSuccessful, Is.True);
        }
        [Test]
        public void LoginwithFalseData()
        {

            form.tb_taikhoan.Text = "B";
            form.tb_matkhau.Text = "2";

            form.btn_dangnhap_Click(null, null);
            // Assert: Check that the expected result occurred
            Assert.That(form.LoginSuccessful, Is.False);
        }
        [Test]
        public void LoginwithEmptyData()
        {

            form.tb_taikhoan.Text = "";
            form.tb_matkhau.Text = "";

            form.btn_dangnhap_Click(null, null);
            // Assert: Check that the expected result occurred
            Assert.That(form.LoginSuccessful, Is.False);
        }

    }
}
