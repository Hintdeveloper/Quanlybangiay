using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewMolder;
using QRCoder;
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
	public partial class FrmSanPhamChiTiet : Form
	{
		private ISanPhamChiTietServices _isanPhamChiTietServices;
		private INhaCCServices _inhaCCServices;
		private ISanPhamServices _isanPhamServices;
		private INSXServices _nSXServices;
		private ISizeServices _isizeServices;
		private ILoaiSanPhamServices _loaiSanPhamServices;
		private IKhuyenMaiServices _khuyenMaiServices;
		private ViewSanPhamChiTiet _viewSanPhamChiTiet;
		private IMauSacServices _imauSacServices;
		private List<ViewSanPhamChiTiet> _lstviewSanPhamChiTiets;
		private Guid _id;
		string linkanh = "";
		public FrmSanPhamChiTiet()
		{
			InitializeComponent();
			_isanPhamChiTietServices = new SanPhamChiTietServices();
			_isanPhamServices = new SanPhamServices();
			_inhaCCServices = new NhaCCServices();
			_isizeServices = new SizeServices();
			_nSXServices = new NSXServices();
			_loaiSanPhamServices = new LoaiSanPhamServices();
			_khuyenMaiServices = new KhuyenMaiServices();
			_imauSacServices = new MauSacServices();
			_lstviewSanPhamChiTiets = new List<ViewSanPhamChiTiet>();
			chk_CH.Checked = true;
			LoadSanPham();
			LoadSize();
			LoadLoai();
			LoadMS();
			LoadNCC();
			LoadNSX();
			LoadKM();
			LoadDataChiTietSP();
		}
		private void LoadSanPham()
		{
			foreach (var x in _isanPhamServices.GetAll())
			{
				cmb_TSP.Items.Add(x.Ten);
			}
		}
		private void LoadSize()
		{
			foreach (var x in _isizeServices.GetAll())
			{
				cmb_SZ.Items.Add(x.Ten);
			}

		}
		private void LoadLoai()
		{
			foreach (var x in _loaiSanPhamServices.GetAll())
			{
				cmb_Loai.Items.Add(x.Ten);
			}

		}
		private void LoadMS()
		{
			foreach (var x in _imauSacServices.GetAll())
			{
				cmb_MS.Items.Add(x.Ten);
			}
		}
		private void LoadNCC()
		{
			foreach (var x in _inhaCCServices.GetAll())
			{
				cmb_NCC.Items.Add(x.Ten);
			}
		}
		private void LoadNSX()
		{
			foreach (var x in _nSXServices.GetAll())
			{
				cmb_NSX.Items.Add(x.Ten);
			}
		}
		private void LoadKM()
		{
			foreach (var x in _khuyenMaiServices.GetAll())
			{
				cmb_KM.Items.Add(x.Ten);
			}
		}
		private void LoadDataChiTietSP()
		{
			int stt = 1;
			dgrid_SPCT.ColumnCount = 15;
			dgrid_SPCT.Columns[0].Name = "STT";
			dgrid_SPCT.Columns[1].Name = "ID";
			dgrid_SPCT.Columns[1].Visible = false;
			dgrid_SPCT.Columns[2].Name = "Mã";
			dgrid_SPCT.Columns[3].Name = "Tên Sản Phẩm";
			dgrid_SPCT.Columns[4].Name = "Size";
			dgrid_SPCT.Columns[5].Name = "Loại";
			dgrid_SPCT.Columns[6].Name = "Màu sắc";
			dgrid_SPCT.Columns[7].Name = "Nhà sản xuất";
			dgrid_SPCT.Columns[8].Name = "Nhà cung cấp";
			dgrid_SPCT.Columns[9].Name = "SLT";
			dgrid_SPCT.Columns[10].Name = "Gía Nhập";
			dgrid_SPCT.Columns[11].Name = "Gía Bán";
			dgrid_SPCT.Columns[12].Name = "Mô Tả";
			dgrid_SPCT.Columns[13].Name = "Trạng thái";
			dgrid_SPCT.Columns[14].Name = "Khuyến mãi";

			dgrid_SPCT.Rows.Clear();
			_lstviewSanPhamChiTiets = _isanPhamChiTietServices.GetViewChiTietSps();
			if (textBox1.Text != "")
			{
				_lstviewSanPhamChiTiets = _lstviewSanPhamChiTiets.Where(x => x.Ma.Contains(textBox1.Text) || x.TenSP.StartsWith(textBox1.Text)).ToList();
			}

			foreach (var x in _lstviewSanPhamChiTiets)
			{
				dgrid_SPCT.Rows.Add(stt++, x.ID, x.Ma, x.TenSP, x.TenSZ, x.TenLOAI, x.TenMS, x.TenNSX, x.TenNCC, x.SoLuongTon, x.GiaNhap.ToString("N0") + "VND", x.GiaBan.ToString("N0") + "VND", x.MoTa, x.TrangThai, x.TenKM);
			}

		}
		private ViewSanPhamChiTiet GetData()
		{
			var KM = _khuyenMaiServices.GetAll().FirstOrDefault(c => c.Ten == cmb_KM.Text);
			var Sp = _isanPhamServices.GetAll().FirstOrDefault(c => c.Ten == cmb_TSP.Text);
			var Ms = _imauSacServices.GetAll().FirstOrDefault(c => c.Ten == cmb_MS.Text);
			var Loai = _loaiSanPhamServices.GetAll().FirstOrDefault(c => c.Ten == cmb_Loai.Text);
			var size = _isizeServices.GetAll().FirstOrDefault(c => c.Ten == cmb_SZ.Text);
			var nsx = _nSXServices.GetAll().FirstOrDefault(c => c.Ten == cmb_NSX.Text);
			var ncc = _inhaCCServices.GetAll().FirstOrDefault(c => c.Ten == cmb_NCC.Text);
			string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
			File.Copy(linkanh, Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(linkanh)), true);
			linkanh = Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(linkanh));
			ViewSanPhamChiTiet CTSP = new ViewSanPhamChiTiet()
			{
				ID = Guid.Empty,
				IDLOAI = Loai.ID,
				IDKM = KM.ID,
				Ma = txt_Ma.Text,
				IDSP = Sp.ID,
				IDNCC = ncc.ID,
				IDMS = Ms.ID,
				IDNSX = nsx.ID,
				IDSZ = size.ID,
				HinhAnh = linkanh,
				SoLuongTon = Convert.ToInt32(txt_SLT.Text),
				GiaBan = Convert.ToDecimal(txt_GiaBan.Text),
				GiaNhap = Convert.ToDecimal(txt_GiaNhap.Text),
				MoTa = txt_MoTa.Text,
				TrangThai = chk_HH.Checked ? 0 : 1,
			};
			return CTSP;
		}
		public bool checknhap()
		{
			if (txt_SLT.Text == "" || txt_GiaBan.Text == "" || txt_GiaNhap.Text == "" || cmb_TSP.Text == "" || cmb_SZ.Text == "" || cmb_NSX.Text == "" || cmb_NCC.Text == "" || cmb_Loai.Text == "" || cmb_MS.Text == "" || txt_Ma.Text == "") return false;
			return true;
		}

		private void ptb_QR_Click(object sender, EventArgs e)
		{
			QRCodeGenerator qr = new QRCodeGenerator();
			QRCodeData data = qr.CreateQrCode(txt_Ma.Text, QRCodeGenerator.ECCLevel.Q);
			QRCode qRCode = new QRCode(data);
			ptb_QR.Image = qRCode.GetGraphic(9);
		}

		private void dgrid_SPCT_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow r = dgrid_SPCT.Rows[e.RowIndex];
				_id = Guid.Parse(dgrid_SPCT.Rows[e.RowIndex].Cells[1].Value.ToString());
				var CTSP = _isanPhamChiTietServices.GetChiTietSPs().FirstOrDefault(p => p.ID == _id);
				txt_Ma.Text = CTSP.Ma.ToString();
				cmb_KM.Text = _khuyenMaiServices.GetAll().FirstOrDefault(p => p.ID == CTSP.IDKM).Ten;
				cmb_TSP.Text = _isanPhamServices.GetAll().FirstOrDefault(p => p.ID == CTSP.IDSP).Ten;
				cmb_SZ.Text = _isizeServices.GetAll().FirstOrDefault(p => p.ID == CTSP.IDSZ).Ten;
				cmb_Loai.Text = _loaiSanPhamServices.GetAll().FirstOrDefault(p => p.ID == CTSP.IDLOAI).Ten;
				cmb_MS.Text = _imauSacServices.GetAll().FirstOrDefault(p => p.ID == CTSP.IDMS).Ten;
				cmb_NCC.Text = _inhaCCServices.GetAll().FirstOrDefault(p => p.ID == CTSP.IDNCC).Ten;
				cmb_NSX.Text = _nSXServices.GetAll().FirstOrDefault(p => p.ID == CTSP.IDNSX).Ten;
				txt_GiaBan.Text = CTSP.GiaBan.ToString();
				txt_GiaNhap.Text = CTSP.GiaNhap.ToString();
				txt_MoTa.Text = CTSP.MoTa;
				linkanh = CTSP.HinhAnh;
				txt_SLT.Text = CTSP.SoLuongTon.ToString();
				if (linkanh != null && File.Exists(linkanh))
				{
					pictureBox1.Image = Image.FromFile(linkanh);
					pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
				}
				else
				{
					pictureBox1.Image = null;
				}
				if (CTSP.TrangThai == 1)
				{
					chk_CH.Checked = true;
					chk_HH.Checked = false;
				}
				else
				{
					chk_CH.Checked = false;
					chk_HH.Checked = true;
				}
			}
		}

		private void btn_Them_Click(object sender, EventArgs e)
		{
			var p = _isanPhamChiTietServices.GetViewChiTietSps().FirstOrDefault(x => x.Ma == txt_Ma.Text);
			var tsp = _isanPhamChiTietServices.GetViewChiTietSps().FirstOrDefault(p => p.TenSP == cmb_TSP.Text);
			int gn, gb;

			if (checknhap() == false)
			{
				MessageBox.Show("Không được để trống các trường", "Chú ý");
			}
			else if (p != null)
			{
				MessageBox.Show("Mã sản phẩm đã tồn tại", "Chú ý");
			}
			else if (Convert.ToDecimal(txt_GiaNhap.Text) > Convert.ToDecimal(txt_GiaBan.Text))
			{
				MessageBox.Show("Giá bán phải cao hơn giá nhập", "Chú ý");
			}
			else if(linkanh == "")
			{
                MessageBox.Show("Thiếu ảnh", "Chú ý");
            }
            else
			{
				OpenFileDialog op = new OpenFileDialog();
				DialogResult dialog = MessageBox.Show("Bạn có muốn thêm sản phẩm không?", "Thêm", MessageBoxButtons.YesNo);
				if (dialog == DialogResult.Yes)
				{
					_isanPhamChiTietServices.addSanPhamChiTiet(GetData());
					LoadDataChiTietSP();
					Utilities.Utilities.ResetControlValues(this);
				}
			}
		}

		private void btn_Sua_Click(object sender, EventArgs e)
		{
			var temp = GetData();
			var _product = _isanPhamChiTietServices.GetViewChiTietSps().FirstOrDefault(p => p.Ma == txt_Ma.Text);
			if (_product == null)
			{
				MessageBox.Show("Không tìm thấy mã sản phẩm", "Cảnh báo");
			}
			else
			{
				if (checknhap() == false)
				{
					MessageBox.Show("Không được để trống các trường", "Chú ý");
				}
				else if (Convert.ToDecimal(txt_GiaNhap.Text) > Convert.ToDecimal(txt_GiaBan.Text))
				{
					MessageBox.Show("Giá bán phải cao hơn giá nhập", "Chú ý");
				}
				else if (pictureBox1.Image == null)
				{
					MessageBox.Show("Bạn chưa thêm ảnh cho sản phẩm", "Chú ý");
				}
				else
				{
					OpenFileDialog op = new OpenFileDialog();
					DialogResult dialog = MessageBox.Show("Bạn có muốn cập nhật sản phẩm không?", "Chú ý", MessageBoxButtons.YesNo);
					if (dialog == DialogResult.Yes)
					{
						if (temp.HinhAnh != linkanh)
						{
							string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
							File.Copy(linkanh, Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(linkanh)), true);
							linkanh = Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(linkanh));
						}
						temp.ID = _id;
						_isanPhamChiTietServices.updateSanPhamChiTiet(temp);
						LoadDataChiTietSP();
						Utilities.Utilities.ResetControlValues(this);
					}
				}
			}
		}

		private void btn_Xoa_Click(object sender, EventArgs e)
		{
			OpenFileDialog op = new OpenFileDialog();
			DialogResult dialog = MessageBox.Show("Bạn có muốn xóa sản phẩm không?", "Chú ý", MessageBoxButtons.YesNo);
			if (dialog == DialogResult.Yes)
			{
				_isanPhamChiTietServices.deleteSanPhamChiTiet(_id);
				LoadDataChiTietSP();
				Utilities.Utilities.ResetControlValues(this);
			}
		}

		private void btn_Clear_Click(object sender, EventArgs e)
		{
			Utilities.Utilities.ResetControlValues(this);
			cmb_TSP.Text = "";
			cmb_SZ.Text = "";
			cmb_NSX.Text = "";
			cmb_NCC.Text = "";
			cmb_MS.Text = "";
			cmb_Loai.Text = "";
			cmb_KM.Text = "";
			txt_GiaBan.Text = "";
			txt_GiaNhap.Text = "";
			txt_MoTa.Text = "";
			chk_HH.Checked = true;
			chk_CH.Checked = false;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			LoadDataChiTietSP();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog op = new OpenFileDialog();
			if (op.ShowDialog() == DialogResult.OK)
			{
				linkanh = op.FileName;
				pictureBox1.Image = Image.FromFile(op.FileName);
				pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			}
		}

		private void btn_QR_Click(object sender, EventArgs e)
		{

		}
	}
}
