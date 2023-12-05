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
    public class Test_FrmKhachHang
    {
        private FrmKhachHang form;
        private DataGridView dtg_kh;
        private Mock<ISanPhamServices> mocksanphamservice;
        [SetUp]
        public void Init()
        {
            mocksanphamservice = new Mock<ISanPhamServices>();
            form = new();
            dtg_kh = new DataGridView();
            form.Controls.Add(dtg_kh);
        }

        [TearDown]
        public void Dispose()
        {
            form.Dispose();
        }

        [Test]
        //Them voi gia tri trong
        public void Btn_Them_Click_WhenCalled_ChecksForEmptyFields()
        {
            // Arrange
            form.tb_hoten.Text = string.Empty;
            form.tb_sdt.Text = string.Empty;
            form.tb_point.Text = string.Empty;
            form.rd_khachquen.Checked = false;
            form.rd_khachvanglai.Checked = false;
            // Act
            form.btn_them_Click(new object(), new EventArgs());

            // Assert
            // Here you should check if the MessageBox with the message "Không được để trống các trường" was shown
            Assert.That(form.AddSuccessful, Is.False);
        }
        [Test]
        //Them voi gia tri day du
        public void Btn_Them_Click_WhenCalled_ChecksForFullFilled()
        {
            // Arrange
            form.tb_hoten.Text = "Tran Le Gia Hien";
            form.tb_sdt.Text = "jdđ";
            form.tb_point.Text = "10";
            form.rd_khachquen.Checked = true;
            form.rd_khachvanglai.Checked = false;
            // Act
            form.btn_them_Click(new object(), new EventArgs());

            // Assert
            // Here you should check if the MessageBox with the message "Không được để trống các trường" was shown
            Assert.That(form.AddSuccessful, Is.True);
        }
        [Test]
        public void Test1_CellClick_ShouldUpdateTextBoxes()
        {
            // Arrange
            var e = new DataGridViewCellEventArgs(0, 1);

            // Act
            form.dtg_show_CellClick(null, e);

            // Assert
            Assert.That(form.ViewSuccessful, Is.True);
            // ... Assert the rest of your text boxes here ...
        }

        [Test]
        //Update gia tri trong
        public void CheckUpdateonNull()
        {
            // Arrange
            var e = new DataGridViewCellEventArgs(0, 1);

            // Act
            form.dtg_show_CellClick(null, e);

            // Assert
            Assert.That(form.ViewSuccessful, Is.True);

            // Arrange
            form.tb_hoten.Text = string.Empty;
            form.tb_sdt.Text = string.Empty;
            form.tb_point.Text = string.Empty;
            form.rd_khachquen.Checked = false;
            form.rd_khachvanglai.Checked = false;

            // Act
            form.btn_sua_Click(null, null);

            // Assert
            Assert.IsFalse(form.EditSuccessful);
        }
        [Test]
        //Update gia tri du
        public void CheckUpdateOnFilled()
        {
           

            // Arrange
            var e = new DataGridViewCellEventArgs(1, 2);

            // Act
            form.dtg_show_CellClick(null, e);

            // Assert
            Assert.That(form.ViewSuccessful, Is.True);
            // ... Assert the rest of your text boxes here ...

            // Arrange
            form.tb_hoten.Text = "Tran Le B";
            form.tb_sdt.Text = "0123456987";
            form.tb_point.Text = "20";
            form.rd_khachquen.Checked = true;
            form.rd_khachvanglai.Checked = false;
            // Act
            form.btn_sua_Click(null, null);

            // Assert
            Assert.IsTrue(form.EditSuccessful);
        }
        [Test]
        public void check_Delete()
        {

            // Arrange
            var e = new DataGridViewCellEventArgs(0, 1);

            // Act
            form.dtg_show_CellClick(null, e);

            // Assert
            Assert.That(form.ViewSuccessful, Is.True);
            // ... Assert the rest of your text boxes here ...

            form.btn_xoa_Click(null, null);

            Assert.IsTrue(form.DeleteSuccessful);
        }
    }
}
