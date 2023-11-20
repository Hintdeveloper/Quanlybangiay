using _1_DAL.DomainMolder;
using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewMolder;
using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace _3_GUI.View
{
	public partial class FrmBanHang : Form
	{
		ISanPhamChiTietServices _ISanPhamChiTietServices;
		IHinhThucThanhToanServices _IHTTTServices;
		IKhachHangServices _IKhachHangServices;
		INhanVienServices _INhanVienServices;
		IHoaDonServices _IHoaDonServices;
		IHoaDonChiTietServices _IHoaDonChiTietServices;
		List<ViewSanPhamChiTiet> _lstViewSpct;
		List<ViewHoaDonCT> _lstViewHDct;
		List<ViewHoaDon> _lstViewHD;
		List<ViewGioHang> _lstViewGH;
		ViewSanPhamChiTiet _vspct;
		FilterInfoCollection FilterInfoCollection;
		VideoCaptureDevice VideoCaptureDevice;
		List<GioHangItem> gioHangItems = ViewGioHang.Instance.GetItems();
		private decimal tongtien = 0;
		private bool isFound = false;
		public Guid _ID;
		public Guid _ID2;
		public Guid _ID3;
		public Guid _ID4;
		public Guid _ID5;
		public string _Ma;
		public string _Images;
		decimal _TongTien = 0;
		public FrmBanHang()
		{
			InitializeComponent();
			_INhanVienServices = new NhanVienServices();
			_IHoaDonServices = new HoaDonServices();
			_lstViewHD = new List<ViewHoaDon>();
			_vspct = new ViewSanPhamChiTiet();
			_IHTTTServices = new HinhThucThanhToanServices();
			_lstViewHDct = new List<ViewHoaDonCT>();
			_ISanPhamChiTietServices = new SanPhamChiTietServices();
			_lstViewSpct = new List<ViewSanPhamChiTiet>();
			_lstViewGH = new List<ViewGioHang>();
			_IKhachHangServices = new KhachHangServices();
			_IHoaDonChiTietServices = new HoaDonChiTietServices();
			FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
			LoadDataSp();
			LoadHTTT();
			loadCam();
			LoadGioHang();
			LoadHoaDonChuaThanhToan();
			LoadCheckBox();
			tb_tongiatri.Enabled = false;
			tb_tensp.Enabled = false;
			tb_loaisp.Enabled = false;
			tb_size.Enabled = false;
			tb_mausac.Enabled = false;
			tb_nsx.Enabled = false;
			tb_ncc.Enabled = false;
			tb_khuyenmai.Enabled = false;
			tb_soluongton.Enabled = false;
			//   tb_gianhap.Enabled = false;
			tb_giaban.Enabled = false;
			tb_mota.Enabled = false;
			rd_conhang.Enabled = false;
			tb_giatrigiohang.Enabled = false;
			rd_hethang.Enabled = false;
			tb_pont.Enabled = false;
			tb_ma.Enabled = false;
			dtg_giohang.AllowUserToAddRows = false;
			dtg_sanpham.AllowUserToAddRows = false;
			dtg_hd.AllowUserToAddRows = false;
			dtg_sanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtg_giohang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dtg_hd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			tb_mahdchuathanhtoan.Visible = false;
		}
		public void Clear()
		{
			_vspct = null;
			tb_tensp.Text = "";
			tb_loaisp.Text = "";
			tb_size.Text = "";
			tb_mausac.Text = "";
			tb_nsx.Text = "";
			tb_ncc.Text = "";
			tb_khuyenmai.Text = "";
			tb_soluongton.Text = "";
			//tb_gianhap.Text = "";
			tb_giaban.Text = "";
			tb_mota.Text = "";
			rd_conhang.Checked = false;
			rd_hethang.Checked = false;
			ptb_imagesSp.Image = null;
		}
		public void loadCam()
		{
			foreach (FilterInfo item in FilterInfoCollection)
			{
				cbb_cam.Items.Add(item.Name);
			}
			cbb_cam.SelectedIndex = 0;
		}
		public void LoadDataSp()
		{
			dtg_sanpham.Rows.Clear();
			dtg_sanpham.ColumnCount = 14;
			dtg_sanpham.Columns[0].Name = "ID";
			dtg_sanpham.Columns[0].Visible = false;
			dtg_sanpham.Columns[1].Name = "Tên sản phẩm";
			dtg_sanpham.Columns[2].Name = "Loại sản phẩm";
			dtg_sanpham.Columns[3].Name = "Size";
			dtg_sanpham.Columns[4].Name = "Màu sắc";
			dtg_sanpham.Columns[5].Name = "Nhà sản xuất";
			dtg_sanpham.Columns[6].Name = "Nhà cung cấp";
			dtg_sanpham.Columns[7].Name = "Khuyến mại";
			dtg_sanpham.Columns[8].Name = "Số lượng tồn";
			dtg_sanpham.Columns[9].Name = "Giá nhập";
			dtg_sanpham.Columns[9].Visible = false;
			dtg_sanpham.Columns[10].Name = "Giá bán";
			dtg_sanpham.Columns[11].Name = "Mô tả";
			dtg_sanpham.Columns[12].Name = "Trạng thái";
			dtg_sanpham.Columns[13].Name = "Images";
			dtg_sanpham.Columns[13].Visible = false;
			_lstViewSpct = _ISanPhamChiTietServices.GetViewChiTietSps();
			if (tb_timkiem.Text != "")
			{
				_lstViewSpct = _lstViewSpct.Where(c => c.TenSP.Contains(tb_timkiem.Text)).ToList();
			}
			foreach (var a in _lstViewSpct)
			{
				dtg_sanpham.Rows.Add(a.ID, a.TenSP, a.TenLOAI, a.TenSZ, a.TenMS, a.TenNSX, a.TenNCC, a.TenKM, a.SoLuongTon, a.GiaBan, a.GiaNhap, a.MoTa, a.TrangThai == 1 ? "Còn hàng" : "Hết hàng", a.HinhAnh);
			}
		}
		public void LoadHTTT()
		{
			foreach (var a in _IHTTTServices.GetAll())
			{
				cbb_httt.Items.Add(a.Ten);
			}
		}
		private void LoadGioHang()
		{

			dtg_giohang.Rows.Clear();
			dtg_giohang.ColumnCount = 0;
			dtg_giohang.Columns.Add("Ma", "Ma");
			dtg_giohang.Columns.Add("TenSP", "Ten San Pham");
			dtg_giohang.Columns.Add("IDSPCT", "IDSPCT");
			dtg_giohang.Columns.Add("SoLuong", "Số lượng");
			dtg_giohang.Columns.Add("DonGia", "Đơn giá");
			foreach (var item in gioHangItems)
			{
				dtg_giohang.Rows.Add(item.Ma, item.Ten, item.IDSPCT, item.SoLuong, item.DonGia);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (pictureCam.Image != null)
			{
				BarcodeReader Reader = new BarcodeReader();
				Result result = Reader.Decode((Bitmap)pictureCam.Image);
				if (result != null)
				{
					_Ma = result.ToString();
					var z = _ISanPhamChiTietServices.GetViewChiTietSps().Where(x => x.TrangThai == 1 && x.SoLuongTon > 0).FirstOrDefault(p => p.Ma == _Ma);

					//string a = _ISanPhamChiTietServices.GetViewChiTietSps().FirstOrDefault(p => p.ID == z.ID).Ma;
					if (z != null)
					{
						_ID = z.ID;
						ptb_imagesSp.Image = Image.FromFile(z.HinhAnh);
						ptb_imagesSp.SizeMode = PictureBoxSizeMode.StretchImage;
						tb_tensp.Text = z.TenSP;
						tb_loaisp.Text = z.TenLOAI;
						tb_size.Text = z.TenSZ;
						tb_mausac.Text = z.TenMS;
						tb_ncc.Text = z.TenNCC;
						tb_nsx.Text = z.TenNSX;
						tb_khuyenmai.Text = z.TenKM;
						tb_soluongton.Text = Convert.ToString(z.SoLuongTon);
						tb_giaban.Text = Convert.ToString(z.GiaBan);
						///  tb_gianhap.Text = Convert.ToString(z.GiaNhap);
						tb_mota.Text = z.MoTa;
						Boolean tt = z.TrangThai == 1 ? true : false;
						if (tt == true)
						{
							rd_conhang.Checked = true;
						}
						else
						{
							rd_hethang.Checked = true;
						}


					}
					else
					{
						MessageBox.Show("Sản phẩm không tồn tại trong cửa hàng");
					}

					timer1.Stop();
					if (VideoCaptureDevice.IsRunning)
					{
						VideoCaptureDevice.SignalToStop();
						VideoCaptureDevice = null;
					}
					pictureCam.Image = null;
				}
			}
		}

		private void dtg_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow r = dtg_sanpham.Rows[e.RowIndex];
				_ID = Guid.Parse(dtg_sanpham.Rows[e.RowIndex].Cells[0].Value.ToString());
				var _wspct = _ISanPhamChiTietServices.GetViewChiTietSps().FirstOrDefault(c => c.ID == _ID);
				tb_tensp.Text = _wspct.TenSP;
				tb_loaisp.Text = _wspct.TenLOAI;
				tb_size.Text = _wspct.TenSZ;
				tb_mausac.Text = _wspct.TenMS;
				tb_nsx.Text = _wspct.TenNSX;
				tb_ncc.Text = _wspct.TenNCC;
				tb_khuyenmai.Text = _wspct.TenKM;
				tb_soluongton.Text = Convert.ToString(_wspct.SoLuongTon);
				if (_wspct.SoLuongTon <= 0)
				{
					_wspct.TrangThai = 0;
				}
				else
				{
					_wspct.TrangThai = 1;
				}
				//tb_gianhap.Text = Convert.ToString(_wspct.GiaNhap);
				tb_giaban.Text = Convert.ToString(_wspct.GiaBan);
				tb_mota.Text = _wspct.MoTa;
				if (_wspct.TrangThai == 1)
				{
					rd_conhang.Checked = true;
				}
				else
				{
					rd_hethang.Checked = true;
				}
				_Images = _wspct.HinhAnh;
				if (_Images != null && File.Exists(_Images))
				{
					ptb_imagesSp.Image = Image.FromFile(_Images);
					ptb_imagesSp.SizeMode = PictureBoxSizeMode.StretchImage;
				}
			}
		}

		private void tb_timkiem_TextChanged(object sender, EventArgs e)
		{
			LoadDataSp();
		}
		private void XuLyGioHang()
		{
			var p = _ISanPhamChiTietServices.GetViewChiTietSps().FirstOrDefault(x => x.ID == _ID);
			var data = ViewGioHang.Instance.GetItems().FirstOrDefault(x => x.ID == p.ID);
			if (p.SoLuongTon == 0)
			{
				MessageBox.Show("Sản phẩm này đã không còn! Vui lòng chọn sản phẩm khác");
			}
			else if (data == null)
			{
				GioHangItem item = new GioHangItem()
				{
					ID = p.ID,
					Ma = p.Ma,
					IDSPCT = p.ID,
					Ten = p.TenSP,
					SoLuong = 1,
					DonGia = p.GiaBan
				};
				ViewGioHang.Instance.AddItem(item);
				tongtien = 0;
				tb_giatrigiohang.Text = "0";
			}
			else
			{
				if (data.SoLuong == p.SoLuongTon)
				{
					MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
				}
				else
				{
					data.SoLuong++;
				}
			}
			tb_giatrigiohang.Text = "0";
			LoadGioHang();
			LoadCheckBox();
		}

		private void btn_themgiohang_Click(object sender, EventArgs e)
		{
			XuLyGioHang();
		}

		private void dtg_hd_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow r = dtg_hd.Rows[e.RowIndex];

				_ID4 = Guid.Parse(dtg_hd.Rows[e.RowIndex].Cells[0].Value.ToString());
				var selectedHd = _lstViewHD.FirstOrDefault(c => c.ID == _ID4);
				tb_ma.Text = r.Cells[1].Value.ToString();
				tb_tongiatri.Text = r.Cells[7].Value.ToString();


				//loadHDCT(_ID5);
			}
		}

		private void tb_tienkhachtra_TextChanged(object sender, EventArgs e)
		{
			decimal tienKhachDua;
			if (!decimal.TryParse(tb_tienkhachtra.Text, out tienKhachDua))
			{
				MessageBox.Show("Giá trị không hợp lệ");
				tb_tienkhachtra.Text = "0";
				return;
			}
			decimal tienCanTra = decimal.Parse(tb_tongiatri.Text);
			decimal tienThoiLai = tienKhachDua - tienCanTra;
			tb_tientralai.Text = tienThoiLai.ToString(/*"N0", CultureInfo.CreateSpecificCulture("vi-VN")*/);
		}

		private void btn_qr_Click(object sender, EventArgs e)
		{
			VideoCaptureDevice = new VideoCaptureDevice(FilterInfoCollection[cbb_cam.SelectedIndex].MonikerString);
			VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame; ;
			VideoCaptureDevice.Start();
			timer1.Start();
		}

		private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
		{
			pictureCam.Image = (Bitmap)eventArgs.Frame.Clone();
		}

		private void LoadCheckBox()
		{
			// Kiểm tra nếu cột checkbox chưa được thêm vào bảng thì mới thêm
			if (!dtg_giohang.Columns.Contains("chk_SelectProduct"))
			{
				// Tạo ra một đối tượng checkbox
				DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
				checkBoxColumn.Name = "chk_SelectProduct";
				checkBoxColumn.HeaderText = "Chọn";
				checkBoxColumn.Width = 50;
				// Thêm checkbox vào DataGridView
				dtg_giohang.Columns.Add(checkBoxColumn);
			}
		}
		private void ClearGioHang()
		{
			if (gioHangItems.Any())
			{

				gioHangItems.Clear(); // Xóa hết các sản phẩm trong danh sách
				tb_giatrigiohang.Text = "0"; // Cập nhật giá trị hiển thị trên textbox
				tb_sodienthoai.Text = "";
				tb_hotenkhachang.Text = "";
				tb_pont.Text = "";
				tb_mahdchuathanhtoan.Text = "";
				LoadGioHang();
			}
			else
			{
				MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
			}
		}

		private void dtg_giohang_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow r = dtg_giohang.Rows[e.RowIndex];
				//pID = Convert.ToInt32(r.Cells[0].Value.ToString());
				_ID2 = _ISanPhamChiTietServices.GetViewChiTietSps().FirstOrDefault(x => x.Ma == r.Cells[0].Value.ToString()).ID;

			}
		}

		private void dtg_giohang_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dtg_giohang.Columns[e.ColumnIndex].Name == "chk_SelectProduct")
			{
				decimal price = Convert.ToDecimal(dtg_giohang.Rows[e.RowIndex].Cells["DonGia"].Value);
				int quantity = Convert.ToInt32(dtg_giohang.Rows[e.RowIndex].Cells["SoLuong"].Value);
				decimal total = price * quantity * -1;
				DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)dtg_giohang.Rows[e.RowIndex].Cells["chk_SelectProduct"];
				bool isChecked = Convert.ToBoolean(checkBox.Value);
				if (isChecked)
				{
					tongtien += total;
				}
				else
				{
					tongtien -= total;
				}
				checkBox.Value = !isChecked;
				tb_giatrigiohang.Text = tongtien.ToString();
				LoadCheckBox();
			}
		}

		private void tb_sodienthoai_TextChanged(object sender, EventArgs e)
		{
			if (int.TryParse(tb_sodienthoai.Text, out int x))
			{
				var a = _IKhachHangServices.GetAllViewKhachHang().FirstOrDefault(c => c.SDT == tb_sodienthoai.Text);
				if (a != null)
				{
					tb_hotenkhachang.Text = a.HovaTen;
					tb_pont.Text = Convert.ToString(a.Poin);
					isFound = true; // Đã tìm thấy khách hàng
				}
				else
				{
					tb_hotenkhachang.Text = "";
					isFound = false; // Khách hàng không tồn tại
				}
			}
			if (!isFound) // Nếu chưa tìm thấy khách hàng
			{
				tb_hotenkhachang.Enabled = true;
			}
			else // Nếu đã tìm thấy khách hàng
			{
				tb_hotenkhachang.Enabled = false;
			}
		}

		private void btn_clear_Click(object sender, EventArgs e)
		{
			Clear();
		}
		private void LoadHoaDonChuaThanhToan()
		{
			dtg_hd.Rows.Clear();
			dtg_hd.ColumnCount = 9;
			dtg_hd.Columns[0].Name = "ID";
			dtg_hd.Columns[0].Visible = false;
			dtg_hd.Columns[1].Name = "Ma";
			dtg_hd.Columns[2].Name = "NV";
			dtg_hd.Columns[2].Visible = false;
			dtg_hd.Columns[3].Name = "KH";
			dtg_hd.Columns[4].Name = "Ngay Tao";
			dtg_hd.Columns[5].Name = "Ngay Thanh Toan";
			dtg_hd.Columns[5].Visible = false;
			dtg_hd.Columns[6].Name = "So Dien Thoai";
			dtg_hd.Columns[7].Name = "Thanh Tien";
			dtg_hd.Columns[8].Name = "Trang Thai";
			foreach (var a in _lstViewHD)
			{
				dtg_hd.Rows.Add(a.ID, a.Ma, a.TenNV, a.TenKH, a.NgayTao, a.NgayThanhToan, a.SDT, a.ThanhTien, a.TrangThai == 0 ? "Chưa thanh toán" : "Đã thanh toán");
			}
		}
		private void ClearSauThanhToan()
		{
			if (_lstViewHD.Count == 0)
			{
				MessageBox.Show("Không có đơn hàng để xóa");
			}
			else
			{
				_lstViewHD.Clear();
				LoadHoaDonChuaThanhToan();
			}
		}
		public void TaoHoaDon()
		{
			DateTime now = DateTime.Now;
			string maHoaDon = $"HD-{now.Year}-{now.Month}-{now.Day}-{now.Hour}-{now.Minute}-{now.Second}";
			var check = _IHoaDonServices.GetAll().FirstOrDefault(c => c.Ma == tb_mahdchuathanhtoan.Text);

			if (check != null)
			{
				MessageBox.Show("Ma hoa don da ton tai");
			}
			else
			{
				_ID3 = _INhanVienServices.GetAllViewNhanVien().FirstOrDefault(x => x.Username == Properties.Settings.Default.User).ID;
				var kh = _IKhachHangServices.GetAllViewKhachHang().FirstOrDefault(c => c.SDT == tb_sodienthoai.Text);


				ViewHoaDon wHd = new ViewHoaDon()
				{
					ID = Guid.NewGuid(),
					Ma = maHoaDon,
					IDNV = _ID3,
					IDKH = kh.ID,
					TrangThai = 0,
					NgayTao = DateTime.Now,
					SDT = tb_sodienthoai.Text,
					TenKH = tb_hotenkhachang.Text,
					ThanhTien = Convert.ToDecimal(tongtien)
				};

				_lstViewHD.Add(wHd);

				foreach (DataGridViewRow row in dtg_giohang.Rows)
				{
					DataGridViewCheckBoxCell checkBox = row.Cells["chk_SelectProduct"] as DataGridViewCheckBoxCell;
					bool isChecked = Convert.ToBoolean(checkBox.Value);
					if (isChecked)
					{
						Guid idSPCT = new Guid(row.Cells["IDSPCT"].Value.ToString());
						int quantity = Convert.ToInt32(row.Cells["SoLuong"].Value.ToString());
						string ma = row.Cells["ma"].Value.ToString();
						string tensp = row.Cells["TenSP"].Value.ToString();
						ViewHoaDonCT whdct = new ViewHoaDonCT()
						{
							ID = Guid.NewGuid(),
							IDHD = wHd.ID,
							Ma = ma,
							TenSP = tensp,
							IDSPCT = idSPCT,
							DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value),
							SoLuong = quantity,
						};
						_lstViewHDct.Add(whdct);
					}
				}
				MessageBox.Show($"Đã tạo hóa đơn có mã là [{wHd.Ma}]");
				LoadDataSp();
				LoadGioHang();
				LoadHoaDonChuaThanhToan();
				ClearGioHang();
			}
		}

		private void btn_addhoadon_Click(object sender, EventArgs e)
		{
			bool hasSelectedProduct = false;
			foreach (DataGridViewRow row in dtg_giohang.Rows)
			{
				DataGridViewCheckBoxCell checkBoxCell = row.Cells["chk_SelectProduct"] as DataGridViewCheckBoxCell;
				if (checkBoxCell.Value != null && (bool)checkBoxCell.Value == true)
				{
					hasSelectedProduct = true;
					break;
				}
			}

			if (hasSelectedProduct == false)
			{
				MessageBox.Show("Không có sản phẩm nào được chọn");
				return;
			}
			else
			{
				var checkkh = _IKhachHangServices.GetAllViewKhachHang().FirstOrDefault(c => c.SDT == tb_sodienthoai.Text);
				if (checkkh != null)
				{
					TaoHoaDon();

				}
				else
				{
					MessageBox.Show("Khách hàng này chưa tồn tại trong cửa hàng");
					DialogResult dg = MessageBox.Show("Nếu muốn thêm thông tin của khách hàng thì chọn (Yes)!!", "Thong bao", MessageBoxButtons.YesNo);
					if (dg == DialogResult.Yes)
					{
						ViewKhachHang vkh = new ViewKhachHang()
						{
							ID = new Guid(),
							HovaTen = tb_hotenkhachang.Text,
							SDT = tb_sodienthoai.Text,
							TrangThai = 1,
							Poin = 0
						};
						_IKhachHangServices.Add(vkh);
						MessageBox.Show("Thông tin khách hàng đã được thêm vào mục đơn hàng! Hãy tiếp tục hành động của mình");
						TaoHoaDon();
					}
					else
					{

					}
				}
			}
		}

		private void btn_thanhtoan_Click(object sender, EventArgs e)
		{
			foreach (var item in _lstViewHDct)
			{
				_TongTien += item.SoLuong * item.DonGia;
			}
			DateTime now = DateTime.Now;
			string maHoaDon = $"HD-{now.Year}-{now.Month}-{now.Day}-{now.Hour}-{now.Minute}-{now.Second}";
			string maHoaDonCT = $"HDCT-{now.Year}-{now.Month}-{now.Day}-{now.Hour}-{now.Minute}-{now.Second}";

			if (_lstViewHD.Count == 0)
			{
				MessageBox.Show("Không có hóa đơn để thanh toán");
			}
			else
			{
				var selectedHd = _lstViewHD.FirstOrDefault(c => c.Ma == tb_ma.Text);
				//  var customer = _IKhachHangServices.GetAll().FirstOrDefault(x => x.ID == selectedHd.IDKH);
				//lbl_Diem.Text = $"(Tối đa : {customer.Poin})";
				if (selectedHd == null)
				{
					MessageBox.Show("Không tìm thấy hóa đơn");
				}
				else
				{
					selectedHd.Ma = maHoaDon;
					selectedHd.TrangThai = 1;
					selectedHd.NgayThanhToan = DateTime.Now;
					selectedHd.ThanhTien = _TongTien;
					//  lbl_Diem.Text = $"(Tối đa : {customer.Poin})";
					string tenHTTT = cbb_httt.SelectedItem.ToString();
					HinhThucThanhToan hinhThucThanhToan = _IHTTTServices.GetAll().FirstOrDefault(httt => httt.Ten == tenHTTT);
					if (hinhThucThanhToan != null)
					{
						selectedHd.IDHTTT = hinhThucThanhToan.ID;
					}
					_IHoaDonServices.Add(selectedHd);
					KhachHang kh = _IKhachHangServices.GetByID(selectedHd.IDKH);

					// Nếu trạng thái khách hàng là khách quen (trạng thái = 1)
					if (kh.TrangThai == 1)
					{
						// Tính số điểm khách hàng nhận được từ tổng tiền
						int Diem = (int)_TongTien / 10000;
						// Trừ điểm khách hàng đã tích lũy vào tổng tiền
						_TongTien -= Convert.ToDecimal(kh.Poin);
						// Cập nhật lại số điểm khách hàng
						kh.Poin += Diem;
						// Cập nhật lại thông tin khách hàng trong CSDL
						_IKhachHangServices.UpdateKhachHang(kh);
					}
					// Nếu trạng thái khách hàng là khách mới (trạng thái = 0)
					else if (kh.TrangThai == 0)
					{
						// Không có gì để xử lý
					}
					foreach (var hdct in _lstViewHDct)
					{
						ViewHoaDonCT whdct = new ViewHoaDonCT()
						{
							ID = new Guid(),
							Ma = maHoaDonCT,
							IDHD = selectedHd.ID,
							DonGia = hdct.DonGia,
							SoLuong = hdct.SoLuong,
						};
						_IHoaDonChiTietServices.Add(hdct);
						var sp = _ISanPhamChiTietServices.GetViewChiTietSps().FirstOrDefault(c => c.ID == hdct.IDSPCT);
						sp.SoLuongTon = sp.SoLuongTon - hdct.SoLuong;
						if (sp.SoLuongTon <= 0)
						{
							sp.TrangThai = 0;
						}
						else
						{
							sp.TrangThai = 1;
						}

						_ISanPhamChiTietServices.updateSanPhamChiTiet(sp);

						LoadDataSp();
					}
					MessageBox.Show($"Thanh toán hóa đơn có mã :[{selectedHd.Ma}] thành công");
					ClearSauThanhToan();
					var cc = _IHoaDonServices.GetAll().FirstOrDefault(c => c.Ma == maHoaDon).ID;
					FrmThongTinHoaDon frmThongTinHD = new FrmThongTinHoaDon(cc);
					frmThongTinHD.Show();

				}
			}
		}
		public int TinhDiemKhachHang(double tongGiaTriDonHang, int soLanMuaHang, int thoiGianMuaHang, int soLuongSanPham, bool danhGiaTichCuc)
		{
			int diem = 0;
			// Tính điểm dựa trên tổng giá trị đơn hàng
			if (tongGiaTriDonHang > 0)
			{
				diem += (int)(tongGiaTriDonHang / 10000) * 10; // Tính 10 điểm cho mỗi 10000 đồng
			}

			// Tính điểm dựa trên tần suất mua hàng
			if (soLanMuaHang > 0)
			{
				diem += soLanMuaHang * 5; // Tính 5 điểm cho mỗi lần mua hàng
			}
			// Tính điểm dựa trên số lượng sản phẩm đã mua
			if (soLuongSanPham > 0)
			{
				diem += (int)(soLuongSanPham / 10) * 5; // Tính 5 điểm cho mỗi 10 sản phẩm
			}
			return diem;
		}

		private void cb_nullin4_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_nullin4.Checked == true)
			{
				tb_hotenkhachang.Text = "Khách vãng lai";
				tb_sodienthoai.Text = "00-000-000";
				tb_sodienthoai.Enabled = false;
				tb_hotenkhachang.Enabled = false;
			}
			else
			{
				tb_sodienthoai.Enabled = true;
				tb_hotenkhachang.Enabled = true;
				tb_hotenkhachang.Text = "";
				tb_sodienthoai.Text = "";
			}
		}

		private void btn_huyhoadon_Click(object sender, EventArgs e)
		{
			ClearSauThanhToan();
		}

		private void tb_diem_TextChanged(object sender, EventArgs e)
		{
			int diemSuDung = 0;
			if (!int.TryParse(tb_diem.Text, out diemSuDung) || diemSuDung < 0)
			{
				diemSuDung = 0;
				tb_diem.Text = "0";
			}

			decimal TongTien = 0;
			foreach (var item in _lstViewHDct)
			{
				TongTien += item.SoLuong * item.DonGia;
			}

			decimal tienCanThanhToan = TongTien - diemSuDung * 10000;
			if (tienCanThanhToan < 0)
			{
				tienCanThanhToan = 0;
			}

			tb_tongiatri.Text = tienCanThanhToan.ToString();
		}

		private void btn_giam1_Click(object sender, EventArgs e)
		{
			GioHangItem item = ViewGioHang.Instance.GetItems().FirstOrDefault(x => x.ID == _ID);
			if (item != null && item.SoLuong > 1)
			{
				item.SoLuong--;
				LoadGioHang();
				LoadCheckBox();
			}
		}

		private void btn_tang1_Click(object sender, EventArgs e)
		{
			GioHangItem item = ViewGioHang.Instance.GetItems().FirstOrDefault(x => x.ID == _ID);
			if (item != null && item.SoLuong < _ISanPhamChiTietServices.GetViewChiTietSps().FirstOrDefault(x => x.ID == _ID).SoLuongTon)
			{
				item.SoLuong++;
				LoadGioHang();
				LoadCheckBox();
			}
		}

		private void btn_cleargiohang_Click(object sender, EventArgs e)
		{
			ClearGioHang();
		}

		private void btn_xoatheoclick_Click(object sender, EventArgs e)
		{
			if (_lstViewHDct.Any())
			{
				var item = _lstViewHDct.FirstOrDefault(x => x.IDSPCT == _ID5);
				tongtien = 0; // Đặt tổng giá trị về 0
				tb_giatrigiohang.Text = "0"; // Cập nhật giá trị hiển thị trên textbox
				_lstViewHDct.Remove(item);
				LoadGioHang();
			}
			else
			{
				MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
			}
		}
	}
}
