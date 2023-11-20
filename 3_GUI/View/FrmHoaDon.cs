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
	public partial class FrmHoaDon : Form
	{

		IHoaDonChiTietServices _IHDCTServices;
		IHoaDonServices _IHDServices;
		ISanPhamChiTietServices _ISPServices;
		public Guid _ID;
		private List<ViewHoaDon> _lstviewHoaDons;
		public FrmHoaDon()
		{
			InitializeComponent();
			_IHDCTServices = new HoaDonChiTietServices();
			_IHDServices = new HoaDonServices();
			_ISPServices = new SanPhamChiTietServices();
			_lstviewHoaDons = new List<ViewHoaDon>();
			dtg_hd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtg_hdct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			loadHD();
		}
		public void loadHD()
		{
			dtg_hd.ColumnCount = 9;
			dtg_hd.Columns[0].Name = " ID";
			dtg_hd.Columns[1].Name = " Mã";
			dtg_hd.Columns[2].Name = " Ngày Tạo";
			dtg_hd.Columns[3].Name = " Tên NV";
			dtg_hd.Columns[4].Name = " Tên KH";
			dtg_hd.Columns[5].Name = " SDT";
			dtg_hd.Columns[6].Name = " Thành Tiền";
			dtg_hd.Columns[7].Name = " Trạng Thái";

			dtg_hd.Rows.Clear();
			/*  _lstviewHoaDons = _IHDServices.GetAll();
			  if (tb_timkiem.Text != "")
			  {
				  _lstviewHoaDons = _lstviewHoaDons.Where(x => x.TenNV.Contains(tb_timkiem.Text) || x.TenKH.StartsWith(tb_timkiem.Text)).ToList();
			  }*/


			foreach (var item in _IHDServices.GetAll())
			{
				dtg_hd.Rows.Add(item.ID, item.Ma, item.NgayTao, item.TenNV, item.TenKH, item.SDT, item.ThanhTien/*.ToString("N0") + "VND"*/, item.TrangThai == 1 ? "Đã thanh toán" : "Chờ thanh toán");
			}
		}
		public void loadHDCT(Guid id)
		{
			_ID = id;
			dtg_hdct.Columns.Clear(); // xóa các cột hiện có
			dtg_hdct.Rows.Clear();
			dtg_hdct.ColumnCount = 6;
			dtg_hdct.Columns[0].Name = "ID";
			dtg_hdct.Columns[0].Visible = false;
			dtg_hdct.Columns[1].Name = "IDHD";
			dtg_hdct.Columns[2].Name = "IDSPCT";
			dtg_hdct.Columns[3].Name = "Tên SP";
			dtg_hdct.Columns[4].Name = "Số Lượng";
			dtg_hdct.Columns[5].Name = "Đơn Giá";
			foreach (var item in _IHDCTServices.GetAll().Where(c => c.IDHD == id))
			{
				dtg_hdct.Rows.Add(item.ID, item.IDHD, item.IDSPCT, item.TenSP, item.SoLuong, item.DonGia);
			}
		}

		private void FrmHoaDon_Load(object sender, EventArgs e)
		{

		}

		private void dtg_hd_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				_ID = Guid.Parse(dtg_hd.Rows[e.RowIndex].Cells[0].Value.ToString());
				loadHDCT(_ID);
			}
		}

		private void btn_Xoa_Click(object sender, EventArgs e)
		{
			if (_ID == null)
			{
				MessageBox.Show("Vui lòng chọn hóa đơn");
			}
			else
			{
				var o = _IHDServices.GetAll().FirstOrDefault(x => x.ID == _ID);
				if (o.TrangThai == 1)
				{
					MessageBox.Show("Chỉ được xóa các hóa đơn chưa thanh toán");
				}
				else
				{
					var _lstOd = _IHDCTServices.GetAll().Where(x => x.IDHD == _ID);
					foreach (var item in _lstOd)
					{
						var p = _ISPServices.GetViewChiTietSps().FirstOrDefault(x => x.ID == item.IDSPCT);
						p.SoLuongTon += item.SoLuong;
						_ISPServices.updateSanPhamChiTiet(p);
						_IHDCTServices.Delete(item);
					}
					_IHDServices.Delete(o);
					MessageBox.Show("Xóa thành công");
					loadHD();
					dtg_hd.Rows.Clear();
				}
			}
		}

		private void btn_TimKiem_Click(object sender, EventArgs e)
		{
			dtg_hd.Rows.Clear();
			var items = _IHDServices.GetAll().Where(x => x.Ma == Text);
			if (items.Any())
			{
				foreach (var item in _IHDServices.GetAll(tb_timkiem.Text))
				{
					dtg_hd.Rows.Add(item.ID, item.Ma, item.NgayTao, item.TenNV, item.TenKH, item.SDT, item.ThanhTien, item.TrangThai == 1 ? "Đã thanh toán" : "Chờ thanh toán");
				}
			}
			else
			{
				MessageBox.Show("Không có hóa đơn nào có Mã hóa đơn tương ứng");
			}
		}
	}
}
