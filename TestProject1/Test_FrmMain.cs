using NUnit.Framework;
using _2_BUS.IServices;
using _2_BUS.Services;
using _3_GUI.View;
using System.Linq;
using System.Windows.Forms;
namespace TestProject1
{

    [TestFixture]
    public class FrmDangXuatTests
    {
        private FrmMain form;
        [SetUp]
        public void Init()
        {
            form = new FrmMain();
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
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            form.Hide();
            frmDangNhap.ShowDialog();
        }
    }
}