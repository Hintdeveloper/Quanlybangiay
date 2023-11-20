using _1_DAL.DomainMolder;
using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewMolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI.View
{
	public partial class FrmThongKe : Form
	{
		private IHoaDonChiTietServices _hoaDonChiTietServices;
		private IHoaDonServices _ihoaDonServices;
		private INhanVienServices _nhanVienServices;
		private IKhachHangServices _ikhachHangServices;
		private ISanPhamChiTietServices _sanPhamChiTietServices;
		public List<ViewHoaDon> viewHoaDons;
		public List<ViewHoaDonCT> viewHoaDonCTs;
		public List<KhachHang> _lstkhachHangs;
		public FrmThongKe()
		{
			InitializeComponent();
			_hoaDonChiTietServices = new HoaDonChiTietServices();
			_ihoaDonServices = new HoaDonServices();
			_nhanVienServices = new NhanVienServices();
			_ikhachHangServices = new KhachHangServices();
			_sanPhamChiTietServices = new SanPhamChiTietServices();
			viewHoaDons = _ihoaDonServices.GetAll();
			LoadSanPham();
			loadDate();
			loadData1();
		}
		private void LoadSanPham()
		{
			foreach (var x in _sanPhamChiTietServices.GetViewChiTietSps())
			{
				cmb_ten.Items.Add(x.TenSP);
			}
		}
		public void loadDate()
		{
			for (int i = 1; i < 13; i++)
			{
				cmb_Thang.Items.Add(i);
			}
			var x = Convert.ToInt32(_ihoaDonServices.GetAll().First().NgayTao.ToString("yyyy"));
			var y = Convert.ToInt32(_ihoaDonServices.GetAll().Last().NgayTao.ToString("yyyy"));
			for (int i = x; i <= y; i++)
			{
				cmb_Nam.Items.Add(i);
			}

		}
		public void loadData()
		{
			dgrid_Show.Rows.Clear();
			dgrid_Show.ColumnCount = 6;
			dgrid_Show.Columns[0].Name = " ID";
			dgrid_Show.Columns[1].Name = " Tên sản phẩm";
			dgrid_Show.Columns[2].Name = " Số lượng";
			dgrid_Show.Columns[3].Name = "Đơn giá";
			dgrid_Show.Columns[4].Name = "Tổng tiền";
			dgrid_Show.Columns[5].Name = " SĐT";
			var x = (from a in viewHoaDons
					 join b in _ikhachHangServices.GetAll() on a.IDKH equals b.ID
					 join c in _hoaDonChiTietServices.GetAll() on a.ID equals c.IDHD
					 join d in _sanPhamChiTietServices.GetViewChiTietSps() on c.IDSPCT equals d.ID
					 where b.SDT.Contains(txt_Sdt.Text) && d.TenSP.ToLower().Contains(txt_TK.Text.ToLower())
					 select new { a, b, c, d });

			foreach (var i in x)
			{
				dgrid_Show.Rows.Add(i.a.ID, i.d.TenSP, i.c.SoLuong, i.c.DonGia, i.c.SoLuong * i.c.DonGia, i.b.SDT == "0" ? "Khách vãng lai" : i.b.SDT);
			}
			lbl_DoanhThu.Text = x.Select(x => x.a).Distinct().Sum(x => x.ThanhTien).ToString();
			lbl_HD.Text = x.GroupBy(x => x.a).Count().ToString();
			Decimal tongTien = 0;

			foreach (var i in x)
			{
				Decimal gia1 = i.c.DonGia * i.c.SoLuong;
				Decimal gia2 = i.d.GiaNhap * i.c.SoLuong;
				tongTien += (gia1 - gia2);
			}

			lbl_LN.Text = tongTien.ToString() + "VND"; ;
			lbl_KH.Text = x.GroupBy(x => x.b).Count().ToString();

			// Thống kê theo sản phẩm
			var text = cmb_ten.Text;
			text = "giày Nike";
			var giayNike = x.Where(x => x.d.TenSP.ToLower().Contains(text.ToLower())).ToList();
			Decimal TongTien = 0;
			foreach (var z in giayNike)
			{
				Decimal gia1 = z.c.DonGia * z.c.SoLuong;
				Decimal gia2 = z.d.GiaNhap * z.c.SoLuong;
				TongTien += (gia1 - gia2);
			}
			lbl_SP.Text = Convert.ToString(TongTien);

		}

		private void date_Ngay_ValueChanged(object sender, EventArgs e)
		{
			dgrid_Show.Rows.Clear();
			var x = (from a in _ihoaDonServices.GetAll().Where(x => x.NgayTao.ToString("dd-MM-yyyy") == date_Ngay.Value.ToString("dd-MM-yyyy")).ToList()
					 join b in _ikhachHangServices.GetAll() on a.IDKH equals b.ID
					 join c in _hoaDonChiTietServices.GetAll() on a.ID equals c.IDHD
					 join d in _sanPhamChiTietServices.GetViewChiTietSps() on c.IDSPCT equals d.ID
					 where b.SDT.Contains(txt_Sdt.Text) && d.TenSP.ToLower().Contains(txt_TK.Text.ToLower())
					 select new { a, b, c, d });

			foreach (var i in x)
			{
				dgrid_Show.Rows.Add(i.a.ID, i.d.TenSP, i.c.SoLuong, i.c.DonGia, i.c.SoLuong * i.c.DonGia, i.b.SDT == "0" ? "Khách vãng lai" : i.b.SDT);
			}

			lbl_DoanhThu.Text = x.Select(x => x.a).Distinct().Sum(x => x.ThanhTien).ToString();
			lbl_HD.Text = x.GroupBy(x => x.a).Count().ToString();

			lbl_KH.Text = x.GroupBy(x => x.b).Count().ToString();
		}

		private void cmb_Nam_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmb_Thang.Text != "")
			{
				viewHoaDons = _ihoaDonServices.GetAll().Where(x => (x.NgayTao.Month.ToString() == cmb_Thang.Text && x.NgayTao.Year.ToString() == cmb_Nam.Text)).ToList();
				loadData();
			}
			else
			{
				viewHoaDons = _ihoaDonServices.GetAll().Where(x => x.NgayTao.Year.ToString() == cmb_Nam.Text).ToList();
				loadData();
			}
		}

		private void cmb_Thang_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmb_Nam.Text != "")
			{
				viewHoaDons = _ihoaDonServices.GetAll().Where(x => (x.NgayTao.Month.ToString() == cmb_Thang.Text && x.NgayTao.Year.ToString() == cmb_Nam.Text)).ToList();
				loadData();
			}
		}

		private void txt_Sdt_TextChanged(object sender, EventArgs e)
		{
			if (int.TryParse(txt_Sdt.Text, out int x) || txt_Sdt.Text.Length <= 10)
			{
				loadData();
			}
			else
			{
				dgrid_Show.Rows.Clear();
			}
		}

		private void cmb_ten_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmb_ten.Text != "")
			{
				//  viewHoaDons = _ihoaDonServices.GetAll().Where(i => i.  == cmb_ten.Text).ToList();
				loadData1();
			}
		}
		public void loadData1()
		{
			dgrid_Show.Rows.Clear();
			dgrid_Show.ColumnCount = 6;
			dgrid_Show.Columns[0].Name = " ID";
			dgrid_Show.Columns[1].Name = " Tên sản phẩm";
			dgrid_Show.Columns[2].Name = " Số lượng";
			dgrid_Show.Columns[3].Name = "Đơn giá";
			dgrid_Show.Columns[4].Name = "Tổng tiền";
			dgrid_Show.Columns[5].Name = " SĐT";
			var x = (from a in viewHoaDons
					 join b in _ikhachHangServices.GetAll() on a.IDKH equals b.ID
					 join c in _hoaDonChiTietServices.GetAll() on a.ID equals c.IDHD
					 join d in _sanPhamChiTietServices.GetViewChiTietSps() on c.IDSPCT equals d.ID
					 where b.SDT.Contains(txt_Sdt.Text) && d.TenSP.ToLower().Contains(txt_TK.Text.ToLower())
					 select new { a, b, c, d });

			foreach (var i in x.Where(x => x.d.TenSP == cmb_ten.Text))
			{
				dgrid_Show.Rows.Add(i.a.ID, i.d.TenSP, i.c.SoLuong, i.c.DonGia, i.c.SoLuong * i.c.DonGia, i.b.SDT == "0" ? "Khách vãng lai" : i.b.SDT);
			}
			lbl_DoanhThu.Text = x.Where(x => x.d.TenSP == cmb_ten.Text).Select(x => x.a).Distinct().Sum(x => x.ThanhTien).ToString();
			lbl_HD.Text = x.Where(x => x.d.TenSP == cmb_ten.Text).GroupBy(x => x.a).Count().ToString();
			Decimal tongTien = 0;

			foreach (var i in x)
			{
				Decimal gia1 = i.c.DonGia * i.c.SoLuong;
				Decimal gia2 = i.d.GiaNhap * i.c.SoLuong;
				tongTien += (gia1 - gia2);
			}


			lbl_KH.Text = x.Where(x => x.d.TenSP == cmb_ten.Text).GroupBy(x => x.b).Count().ToString();

			// Thống kê theo sản phẩm
			var text = cmb_ten.Text;
			/* text = "giày Nike";*/
			var giayNike = x.Where(x => x.d.TenSP.ToLower().Contains(text.ToLower())).ToList();
			Decimal TongTien = 0;
			foreach (var z in giayNike)
			{
				Decimal gia1 = z.c.DonGia * z.c.SoLuong;
				Decimal gia2 = z.d.GiaNhap * z.c.SoLuong;
				TongTien += (gia1 - gia2);
			}
			lbl_SP.Text = Convert.ToString(TongTien);


			lbl_LN.Text = TongTien.ToString() + "VND";

		}

		private void txt_TK_TextChanged(object sender, EventArgs e)
		{
			loadData();
		}
	}
}
