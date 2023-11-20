using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS.IServices;
using _3_GUI.View;
using NUnit.Framework;
using Moq;
using _1_DAL.DomainMolder;
namespace TestProject1
{
    [TestFixture]
    public class Test_FrmSanPham
    {
        private FrmSanPham form;

        private Mock<ISanPhamServices> mocksanphamservice;
        [SetUp]
        public void Init()
        {
            mocksanphamservice = new Mock<ISanPhamServices>();
            form = new FrmSanPham();
        }

        [TearDown]
        public void Dispose()
        {
            form.Dispose();
        }

        [Test]
        public void Btn_Them_Click_WhenCalled_ChecksForEmptyFields()
        {
            // Arrange
            form.txt_Ma.Text = string.Empty;
            form.txt_Ten.Text = string.Empty;
            form.txt_GhiChu.Text = string.Empty;

            // Act
            form.btn_Them_Click(new object(), new EventArgs());

            // Assert
            // Here you should check if the MessageBox with the message "Không được để trống các trường" was shown
            Assert.That(form.AddSuccessful, Is.False);
        }
        [Test]
        public void Btn_Them_Click_WhenCalled_ChecksForFullFilled()
        {
            // Arrange
            form.txt_Ten.Text = "aert";
            form.txt_GhiChu.Text= "basdfasdf";
            // Act
            form.btn_Them_Click(new object(), new EventArgs());

            // Assert
            // Here you should check if the MessageBox with the message "Không được để trống các trường" was shown
            Assert.That(form.AddSuccessful, Is.True);
        }

    }
}
