using NUnit.Framework;
using _2_BUS.IServices;
using _2_BUS.Services;
using _3_GUI.View;
using System.Linq;
using System.Windows.Forms;
namespace TestProject1
{

    [TestFixture]
    public class FrmMainTest
    {
        private FrmMain form;
        FrmDangNhap FrmDangNhap;
        FrmNhanVien frmNhanVien;
        [SetUp]
        public void Init()
        {
            form = new FrmMain();
            frmNhanVien = new FrmNhanVien();
            FrmDangNhap = new FrmDangNhap();
        }

        [TearDown]
        public void Dispose()
        {
            form.Dispose();
        }


        [Test]
        public void DangXuat()
        {
            form.button1_Click(new object(), new EventArgs());
            // Assert: Check that the expected result occurred
            form.Hide();
            FrmDangNhap.ShowDialog();
        }
        [Test]
        public void check_loadformNhanVien_onNhanVienAccount()
        {
            FrmDangNhap.tb_taikhoan.Text = "A";
            FrmDangNhap.tb_matkhau.Text = "1";

            FrmDangNhap.btn_dangnhap_Click(null, null);
            // Assert: Check that the expected result occurred
            Assert.That(FrmDangNhap.LoginSuccessful, Is.True);
            FrmDangNhap.Hide();

            form.ShowDialog();

            form.btn_NhanVien_Click(null, null);

            Assert.IsFalse(form.canAccess);
            
        }
        [Test]
        public void check_loadformNhanVien_onTruongPhongAccount()
        {
            FrmDangNhap.tb_taikhoan.Text = "C";
            FrmDangNhap.tb_matkhau.Text = "TP";

            FrmDangNhap.btn_dangnhap_Click(null, null);
            // Assert: Check that the expected result occurred
            Assert.That(FrmDangNhap.LoginSuccessful, Is.True);
            FrmDangNhap.Hide();

            form.ShowDialog();

            form.btn_NhanVien_Click(null, null);

            frmNhanVien.ShowDialog();
            Assert.IsTrue(form.canAccess);
            
        }
    }
}