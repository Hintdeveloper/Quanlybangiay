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
using System.Windows.Forms;
using _2_BUS.Services;
namespace TestProject1
{
    [TestFixture]
    public class Test_FrmSanPham
    {
        private FrmSanPham form;
        private DataGridView _dgrid_SP;
        private Mock<ISanPhamServices> mocksanphamservice;
        [SetUp]
        public void Init()
        {
            mocksanphamservice = new Mock<ISanPhamServices>();
            form = new FrmSanPham();
            _dgrid_SP = new DataGridView();
            form.Controls.Add(_dgrid_SP);
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
            form.txt_Ten.Text = "SP3";
            form.txt_GhiChu.Text= "";
            // Act
            form.btn_Them_Click(new object(), new EventArgs());

            // Assert
            // Here you should check if the MessageBox with the message "Không được để trống các trường" was shown
            Assert.That(form.AddSuccessful, Is.True);
        }
        [Test]
        public void Test1_CellClick_ShouldUpdateTextBoxes()
        {
            // Arrange
            var e = new DataGridViewCellEventArgs(0, 0);

            // Act
            form.dgrid_SP_CellClick(null, e);

            // Assert
            Assert.That(form.ViewSuccessful, Is.True);
            // ... Assert the rest of your text boxes here ...
        }

        [Test]
        public void CheckUpdateonNull()
        {
            // Arrange
            form.TestSp = null;

            // Act
            form.btn_Sua_Click(null, null);

            // Assert
            Assert.IsFalse(form.EditSuccessful);
        }
        [Test]
        public void CheckUpdateOnFilled()
        {
            // Arrange
            var e = new DataGridViewCellEventArgs(0, 0);

            // Act
            form.dgrid_SP_CellClick(null, e);

            // Assert
            Assert.That(form.ViewSuccessful, Is.True);
            // ... Assert the rest of your text boxes here ...

            // Arrange
            form.TestSp.Ten = "new";

            // Act
            form.btn_Sua_Click(null, null);

            // Assert
            Assert.IsTrue(form.EditSuccessful);
        }
        [Test]
        public void Check_Delete()
        {
            // Arrange
            var e = new DataGridViewCellEventArgs(0, 0);

            // Act
            form.dgrid_SP_CellClick(null, e);

            // Assert
            Assert.That(form.ViewSuccessful, Is.True);

            form.btn_Xoa_Click(null, null);

            Assert.IsTrue(form.DeleteSuccessful);
        }
    }
}
