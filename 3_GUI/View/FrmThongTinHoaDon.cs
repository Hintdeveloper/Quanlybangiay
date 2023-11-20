using _2_BUS.IServices;
using _2_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI.View
{
	public partial class FrmThongTinHoaDon : Form
	{
		IHoaDonServices _IHDServices;
		IKhachHangServices _IKHServices;
		IHoaDonChiTietServices _IHDCTServices;
		INhanVienServices _INVServices;
		ISanPhamChiTietServices _isanPhamChiTietServices;
		public Guid _ID;
		private PrintDialog printDialog;
		private PrintDocument printDocument;
		public FrmThongTinHoaDon(Guid ID)
		{
			InitializeComponent();
			_IHDServices = new HoaDonServices();
			_IKHServices = new KhachHangServices();
			_IHDCTServices = new HoaDonChiTietServices();
			_INVServices = new NhanVienServices();
			_isanPhamChiTietServices = new SanPhamChiTietServices();
			loadHDCT(_ID);
			this._ID = ID;
			this.printDialog = new PrintDialog();
			this.printDocument = new PrintDocument();
			this.printDocument.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
		}

		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			var hd = _IHDServices.GetAll().FirstOrDefault(c => c.ID == _ID);
			var nv = _INVServices.GetAllNhanVien().FirstOrDefault(c => c.ID == hd.IDNV);
			var kh = _IKHServices.GetAll().FirstOrDefault(c => c.ID == hd.IDKH);
			e.Graphics.DrawString("Welcome to Cửa hàng No.1", new Font("Arial", 15), Brushes.Black, new Point(300, 100));
			// e.Graphics.DrawString(lbl_dc.Text, new Font("Arial", 10), Brushes.Black, new Point(300, 130));
			e.Graphics.DrawString("REG :", new Font("Arial", 10), Brushes.Black, new Point(300, 150));
			e.Graphics.DrawString(hd.NgayTao.ToString(), new Font("Arial", 10), Brushes.Black, new Point(370, 150));
			e.Graphics.DrawString("..............................................................................................", new Font("Arial", 10), Brushes.Black, new Point(300, 160));
			e.Graphics.DrawString("Mã Hóa Đơn :", new Font("Arial", 10), Brushes.Black, new Point(300, 180));
			e.Graphics.DrawString(hd.Ma, new Font("Arial", 10), Brushes.Black, new Point(420, 180));
			e.Graphics.DrawString("Tên Khách Hàng", new Font("Arial", 10), Brushes.Black, new Point(300, 200));
			e.Graphics.DrawString(lb_tenkh.Text, new Font("Arial", 10), Brushes.Black, new Point(420, 200));
			e.Graphics.DrawString("..............................................................................................", new Font("Arial", 10), Brushes.Black, new Point(300, 220));
			e.Graphics.DrawString("Sản phẩm", new Font("Arial", 10), Brushes.Black, new Point(300, 240));
			e.Graphics.DrawString("Số lượng", new Font("Arial", 10), Brushes.Black, new Point(400, 240));
			e.Graphics.DrawString("Đơn giá", new Font("Arial", 10), Brushes.Black, new Point(500, 240));
			e.Graphics.DrawString("Thành tiền", new Font("Arial", 10), Brushes.Black, new Point(600, 240));
			int i = 0;
			foreach (var item in _IHDCTServices.GetAll(_ID))
			{
				int x = 260;
				int y = 261;
				e.Graphics.DrawString(item.TenSP.ToString(), new Font("Arial", 10), Brushes.Black, new Point(300, x + (i * 45)));
				e.Graphics.DrawString(item.SoLuong.ToString(), new Font("Arial", 10), Brushes.Black, new Point(400, y + (i * 45)));
				e.Graphics.DrawString(item.DonGia.ToString(), new Font("Arial", 10), Brushes.Black, new Point(500, y + (i * 45)));
				e.Graphics.DrawString(item.thanhTien.ToString(), new Font("Arial", 10), Brushes.Black, new Point(600, y + (i * 45)));
				i++;
			}
			int sl = _IHDCTServices.GetAll(_ID).Count;
			e.Graphics.DrawString("Thành Tiền", new Font("Arial", 15), Brushes.Black, new Point(300, 245 + ((sl + 1) * 45)));
			e.Graphics.DrawString(lb_thanhtien.Text, new Font("Arial", 15), Brushes.Black, new Point(470, 245 + ((sl + 1) * 45)));
			e.Graphics.DrawString("CẢM ƠN QUÝ KHÁCH", new Font("Arial", 10), Brushes.Black, new Point(300, 295 + ((sl + 1) * 45)));
			e.Graphics.DrawString("HẸN GẶP LẠI!", new Font("Arial", 10), Brushes.Black, new Point(300, 315 + ((sl + 1) * 45)));
		}

		public void loadHDCT(Guid id)
		{
			_ID = id;
			dataGridView1.Rows.Clear();
			dataGridView1.ColumnCount = 4;
			dataGridView1.Columns[0].Name = "IDSPCT";
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[1].Name = "Tên sản phẩm";
			dataGridView1.Columns[2].Name = "Số lượng";
			dataGridView1.Columns[3].Name = "Đơn giá";
			foreach (var item in _IHDCTServices.GetAll().Where(c => c.IDHD == id))
			{
				dataGridView1.Rows.Add(item.IDSPCT, item.TenSP, item.SoLuong, item.DonGia);
			}
		}

		private void FrmThongTinHoaDon_Load(object sender, EventArgs e)
		{
			var hd = _IHDServices.GetAll().FirstOrDefault(c => c.ID == _ID);
			var nv = _INVServices.GetAllNhanVien().FirstOrDefault(c => c.ID == hd.IDNV);
			var kh = _IKHServices.GetAll().FirstOrDefault(c => c.ID == hd.IDKH);
			//  var ch = _cuaHangServices.GetAll().FirstOrDefault(c => c.ID == nv.IDCH);
			//  lbl_id.Text = _ID.ToString();
			lb_ma.Text = hd.Ma;
			lb_tenkh.Text = kh.HovaTen;
			lb_tennv.Text = nv.HoTen;

			lb_thanhtien.Text = hd.ThanhTien.ToString();
			loadHDCT(_ID);
		}


		private void btn_in_Click(object sender, EventArgs e)
		{
			this.printDialog.Document = this.printDocument;

			if (printDialog.ShowDialog() == DialogResult.OK)
			{
				printDocument.Print();
			}
		}
	}
}
