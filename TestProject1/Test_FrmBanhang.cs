using _3_GUI.View;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject1
{
    [TestFixture]
    public class Test_FrmBanhang
    {
        FrmBanHang form;
        FrmDangNhap frmDangNhap;
        [SetUp]
        public void Init()
        {
            form = new FrmBanHang();
            frmDangNhap = new FrmDangNhap();
        }
        [TearDown]
        public void CleanUp()
        {
            form.Dispose();
        }
        [Test]
        public void ThemgiohangonNull()
        {
            form.btn_themgiohang_Click(null, null);
            Assert.That(form.Flag, Is.False);
        }
        [Test]
        public void ThemgiohangonFull()
        {
            //Select first row
            var e = new DataGridViewCellEventArgs(0, 0);
            form.dtg_sanpham_CellClick(null, e);
            //Perform click
            form.btn_themgiohang_Click(null, null);

            Assert.IsTrue(form.Flag);

        }
        [Test]
        public void Themgiohang_with_Morethanoneproducts()
        {
            //Select first row
            var e = new DataGridViewCellEventArgs(0, 0);
            form.dtg_sanpham_CellClick(null, e);
            //Perform click
            form.btn_themgiohang_Click(null, null);

            //select second row
            var _e = new DataGridViewCellEventArgs(0, 1);
            form.dtg_sanpham_CellClick(null, _e);
            //Perform click
            form.btn_themgiohang_Click(null, null);

            Assert.IsTrue(form.Flag);

        }
        [Test]
        public void AddHoaDonwithnoselectediteminCart()
        {
            //Select first row
            var e = new DataGridViewCellEventArgs(0, 0);
            form.dtg_sanpham_CellClick(null, e);
            //Perform click
            form.btn_themgiohang_Click(null, null);
            //press button to add hoa don
            form.btn_addhoadon_Click(null, null);

            Assert.IsFalse(form.Flag);

        }

        [Test]
        public void AddHoaDonwith_noKHinformation()
        {
            var e = new DataGridViewCellEventArgs(0, 0);
            form.dtg_sanpham_CellClick(null, e);
            //Perform click
            form.btn_themgiohang_Click(null, null);

            //Get last index of the row
            int last_row_Index = form.dtg_giohang.RowCount - 1;
            int last_col_Index = form.dtg_giohang.ColumnCount - 1;

            var _e = new DataGridViewCellEventArgs(last_col_Index, last_row_Index);
            //Select the product
            form.dtg_giohang_CellClick(null, _e);
            form.dtg_giohang_CellContentClick(null, _e);

            form.btn_addhoadon_Click(null, null);

            Assert.IsFalse(form.Flag);
        }
        [Test]
        public void AddHoaDon_with_addedKH()
        {
            frmDangNhap.tb_taikhoan.Text = "A";
            frmDangNhap.tb_matkhau.Text = "1";

            frmDangNhap.btn_dangnhap_Click(null, null);

            var e = new DataGridViewCellEventArgs(0, 0);
            form.dtg_sanpham_CellClick(null, e);
            //Perform click
            form.btn_themgiohang_Click(null, null);

            //Get last index of the row
            int last_row_Index = form.dtg_giohang.RowCount - 1;
            int last_col_Index = form.dtg_giohang.ColumnCount - 1;

            var _e = new DataGridViewCellEventArgs(last_col_Index, last_row_Index);
            //Select the product
            form.dtg_giohang_CellClick(null, _e);
            form.dtg_giohang_CellContentClick(null, _e);

            form.tb_sodienthoai_TextChanged(null, null);
            form.tb_sodienthoai.Text = "0123456987";
            Assert.IsTrue(form.isFound);

            form.btn_addhoadon_Click(null, null);

            Assert.IsTrue(form.Flag);

        }
        [Test]
        public void AddHoaDon_with_newKH()
        {
            frmDangNhap.tb_taikhoan.Text = "A";
            frmDangNhap.tb_matkhau.Text = "1";

            frmDangNhap.btn_dangnhap_Click(null, null);

            var e = new DataGridViewCellEventArgs(0, 0);
            form.dtg_sanpham_CellClick(null, e);
            //Perform click
            form.btn_themgiohang_Click(null, null);

            //Get last index of the row
            int last_row_Index = form.dtg_giohang.RowCount - 1;
            int last_col_Index = form.dtg_giohang.ColumnCount - 1;

            var _e = new DataGridViewCellEventArgs(last_col_Index, last_row_Index);
            //Select the product
            form.dtg_giohang_CellClick(null, _e);
            form.dtg_giohang_CellContentClick(null, _e);

            form.tb_sodienthoai_TextChanged(null, null);
            form.tb_sodienthoai.Text = "0465321879";
            form.tb_hotenkhachang.Text = "Le Van C";
            Assert.IsFalse(form.isFound);

            form.btn_addhoadon_Click(null, null);

            Assert.IsTrue(form.Flag);

        }
        [Test]
        public void ThanhToan_on_noHoaDoninDGV()
        {
            frmDangNhap.tb_taikhoan.Text = "A";
            frmDangNhap.tb_matkhau.Text = "1";

            frmDangNhap.btn_dangnhap_Click(null, null);

            form.btn_thanhtoan_Click(null, null);

            Assert.IsFalse(form.Flag);
        }
        [Test]
        public void ThanhToan_on_noselectedHoaDon()
        {
            frmDangNhap.tb_taikhoan.Text = "A";
            frmDangNhap.tb_matkhau.Text = "1";

            frmDangNhap.btn_dangnhap_Click(null, null);

            var e = new DataGridViewCellEventArgs(0, 0);
            form.dtg_sanpham_CellClick(null, e);
            //Perform click
            form.btn_themgiohang_Click(null, null);

            //Get last index of the row
            int last_row_Index = form.dtg_giohang.RowCount - 1;
            int last_col_Index = form.dtg_giohang.ColumnCount - 1;

            var _e = new DataGridViewCellEventArgs(last_col_Index, last_row_Index);
            //Select the product
            form.dtg_giohang_CellClick(null, _e);
            form.dtg_giohang_CellContentClick(null, _e);

            form.tb_sodienthoai_TextChanged(null, null);
            form.tb_sodienthoai.Text = "0658923147";

            form.btn_addhoadon_Click(null, null);

            form.btn_thanhtoan_Click(null, null);

            Assert.IsFalse(form.Flag);

        }

        [Test]
        public void ThanhToan_on_selectedHoaDon()
        {
            frmDangNhap.tb_taikhoan.Text = "A";
            frmDangNhap.tb_matkhau.Text = "1";

            frmDangNhap.btn_dangnhap_Click(null, null);

            var e = new DataGridViewCellEventArgs(0, 0);
            form.dtg_sanpham_CellClick(null, e);
            //Perform click
            form.btn_themgiohang_Click(null, null);

            //Get last index of the row
            int last_row_Index = form.dtg_giohang.RowCount - 1;
            int last_col_Index = form.dtg_giohang.ColumnCount - 1;

            var _e = new DataGridViewCellEventArgs(last_col_Index, last_row_Index);
            //Select the product
            form.dtg_giohang_CellClick(null, _e);
            form.dtg_giohang_CellContentClick(null, _e);

            form.tb_sodienthoai_TextChanged(null, null);
            form.tb_sodienthoai.Text = "0123456987";

            form.btn_addhoadon_Click(null, null);
            //Select hoa don
            var eHD = new DataGridViewCellEventArgs(0, 0);
            form.dtg_hd_CellClick(null, eHD);
            form.tb_tienkhachtra.Text = "15000";
            form.cbb_httt.SelectedItem = "Tiền mặt";
            form.btn_thanhtoan_Click(null, null);

            Assert.IsTrue(form.Flag);
        }
    }
}
