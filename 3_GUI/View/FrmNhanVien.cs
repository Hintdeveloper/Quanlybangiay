using _1_DAL.DomainMolder;
using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewMolder;
using _3_GUI.Utilities;
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
	public partial class FrmNhanVien : Form
	{
		private INhanVienServices _inhanVienServices;
		private IChucVuServices _ichucVuServices;
		private Guid _id;
		private NhanVien _nv;
		private List<ViewNhanVien> _lstviewNhanViens;
		string linkanh = "";
		public FrmNhanVien()
		{
			InitializeComponent();
			_inhanVienServices = new NhanVienServices();
			_ichucVuServices = new ChucVuServices();
			_nv = new NhanVien();
			_lstviewNhanViens = new List<ViewNhanVien>();
			loadData();
			txt_user.Text = "***";
			txt_user.Enabled = false;
			loadcbx();
		}
		public void loadData()
		{

			dgrid_NhanVien.Rows.Clear();
			dgrid_NhanVien.ColumnCount = 13;
			dgrid_NhanVien.Columns[0].Name = "ID";
			dgrid_NhanVien.Columns[0].Visible = false;
			dgrid_NhanVien.Columns[1].Name = "Username";
			dgrid_NhanVien.Columns[2].Name = "Họ và tên";
			dgrid_NhanVien.Columns[3].Name = "Giới tính";
			dgrid_NhanVien.Columns[4].Name = "Ngày sinh";
			dgrid_NhanVien.Columns[5].Name = "CCCD";
			dgrid_NhanVien.Columns[6].Name = "SDT";
			dgrid_NhanVien.Columns[7].Name = "Email";
			dgrid_NhanVien.Columns[8].Name = "Mật khẩu";
			dgrid_NhanVien.Columns[9].Name = "Chức vụ";
			dgrid_NhanVien.Columns[10].Name = "Địa chỉ";
			dgrid_NhanVien.Columns[11].Name = "Trạng thái";
			dgrid_NhanVien.Columns[12].Name = "Ghi chú";

			_lstviewNhanViens = _inhanVienServices.GetAllViewNhanVien();
			if (txt_TimKiem.Text != "")
			{
				_lstviewNhanViens = _lstviewNhanViens.Where(x => x.HoTen.Contains(txt_TimKiem.Text) || x.SoDienThoai.StartsWith(txt_TimKiem.Text)).ToList();
			}

			foreach (var item in _lstviewNhanViens)
			{
				dgrid_NhanVien.Rows.Add(item.ID, item.Username, item.HoTen, item.GioiTinh, item.NgaySinh, item.CCCD, item.SoDienThoai, item.Email, item.MatKhau, item.ChucVu, item.DiaChi, item.TrangThai, item.GhiChu, item.AnhNv);
			}

		}
		public void reset()
		{
			loadData();
			txt_user.Text = "";
			txt_HoTen.Text = "";
			txt_CCCD.Text = "";
			txt_SDT.Text = "";
			txt_Email.Text = "";
			txt_GhiChu.Text = "";
			txt_DC.Text = "";
			date.Text = "";
			txt_MatKhau.Text = "";
			rbtn_HD.Checked = false;
			rbtn_KHD.Checked = false;
			cmb_CV.Text = "";
			rbtn_Nam.Checked = false;
			rbtn_Nu.Checked = false;

		}
		public void loadcbx()
		{
			foreach (var item in _ichucVuServices.GetAll())
			{
				cmb_CV.Items.Add(item.Ten);
			}

		}
		public bool checknhap()
		{
			if (txt_MatKhau.Text == "" || txt_DC.Text == "" || txt_HoTen.Text == "" /*|| txt_user.Text == "" */|| txt_Email.Text == "" || txt_SDT.Text == "" || txt_Email.Text == "" || txt_CCCD.Text == "" || cmb_CV.Text == "") return false;
			return true;
		}

		private void txt_TimKiem_TextChanged(object sender, EventArgs e)
		{
			loadData();
		}

		private void dgrid_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow r = dgrid_NhanVien.Rows[e.RowIndex];
				_id = Guid.Parse(dgrid_NhanVien.Rows[e.RowIndex].Cells[0].Value.ToString());
				_nv = _inhanVienServices.GetAllNhanVien().FirstOrDefault(x => x.ID == _id);
				txt_user.Text = _nv.Username;
				cmb_CV.Text = _ichucVuServices.GetAll().FirstOrDefault(p => p.ID == _nv.IDCV).Ten;
				txt_HoTen.Text = _nv.HoTen;
				txt_CCCD.Text = _nv.CCCD;
				txt_SDT.Text = _nv.SoDienThoai;
				txt_Email.Text = _nv.Email;
				txt_GhiChu.Text = _nv.GhiChu;
				txt_DC.Text = _nv.DiaChi;
				date.Value = _nv.NgaySinh;
				txt_MatKhau.Text = _nv.MatKhau;

				linkanh = _nv.AnhNv;
				if (linkanh != null && File.Exists(linkanh))
				{
					pictureBox1.Image = Image.FromFile(linkanh);
					pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
				}
				else
				{
					pictureBox1.Image = null;
				}
				if (_nv.TrangThai == 1)
				{
					rbtn_HD.Checked = true;
				}
				else
				{
					rbtn_KHD.Checked = true;
				}
				if (_nv.GioiTinh == 1)
				{
					rbtn_Nam.Checked = true;
				}
				else
				{
					rbtn_Nu.Checked = true;
				}
			}
		}

		private void btn_Them_Click(object sender, EventArgs e)
		{
			var cv = _ichucVuServices.GetAll().FirstOrDefault(p => p.Ten == cmb_CV.Text);
			var p = _inhanVienServices.GetAllViewNhanVien().FirstOrDefault(c => c.Username == txt_user.Text);
			string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
			File.Copy(linkanh, Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(linkanh)), true);
			linkanh = Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(linkanh));
			if (checknhap() == false)
			{
				MessageBox.Show("Không được để trống các trường", "Chú ý");
			}
			else if (p != null)
			{
				MessageBox.Show("Username Nhân viên đã tồn tại", "Chú ý");
			}
			else
			{
				OpenFileDialog op = new OpenFileDialog();
				DialogResult dialog = MessageBox.Show("Bạn có muốn thêm Nhân viên không?", "Thêm", MessageBoxButtons.YesNo);
				if (dialog == DialogResult.Yes)
				{
					ViewNhanVien nv = new ViewNhanVien()
					{
						IDCV = cv.ID,
						Username = CheckThuocTinh.Generate(txt_HoTen.Text),
						HoTen = txt_HoTen.Text,
						MatKhau = txt_MatKhau.Text,
						AnhNv = linkanh,
						CCCD = txt_CCCD.Text,
						GioiTinh = rbtn_Nam.Checked ? 1 : 0,
						NgaySinh = date.Value,
						SoDienThoai = txt_SDT.Text,
						Email = txt_Email.Text,
						DiaChi = txt_DC.Text,
						GhiChu = txt_GhiChu.Text,
						TrangThai = rbtn_HD.Checked ? 1 : 0,
					};
					_inhanVienServices.AddNhanVien(nv);
					MessageBox.Show($"Thêm thành công, Ma use cua ban la [ {txt_user.Text} ]hay ghi nho no");

					reset();

				}
			}
		}

		private void btn_Sua_Click(object sender, EventArgs e)
		{
			var cv = _ichucVuServices.GetAll().FirstOrDefault(p => p.Ten == cmb_CV.Text);
			var _product = _inhanVienServices.GetAllViewNhanVien().FirstOrDefault(p => p.Username == txt_user.Text);
			string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
			File.Copy(linkanh, Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(linkanh)), true);
			linkanh = Path.Combine(projectDirectory, "Resources", "Images", Path.GetFileName(linkanh));
			if (_product == null)
			{
				MessageBox.Show("Không tìm thấy username Nhân viên", "Cảnh báo");
			}
			else
			{
				if (checknhap() == false)
				{
					MessageBox.Show("Không được để trống các trường", "Chú ý");
				}
				else
				{
					OpenFileDialog op = new OpenFileDialog();
					DialogResult dialog = MessageBox.Show("Bạn có muốn cập nhật Nhân viên không?", "Chú ý", MessageBoxButtons.YesNo);
					if (dialog == DialogResult.Yes)
					{
						ViewNhanVien nv = new ViewNhanVien()
						{
							ID = _id,
							IDCV = cv.ID,
							Username = txt_user.Text,
							HoTen = txt_HoTen.Text,
							MatKhau = txt_MatKhau.Text,
							AnhNv = linkanh,
							CCCD = txt_CCCD.Text,
							GioiTinh = rbtn_Nam.Checked ? 1 : 0,
							NgaySinh = date.Value,
							SoDienThoai = txt_SDT.Text,
							Email = txt_Email.Text,
							DiaChi = txt_DC.Text,
							GhiChu = txt_GhiChu.Text,
							TrangThai = rbtn_HD.Checked ? 1 : 0,
						};
						_inhanVienServices.UpdateNhanVien(nv);
						MessageBox.Show("Sửa thành công");
						reset();
					}
				}
			}
		}

		private void btn_Xoa_Click(object sender, EventArgs e)
		{
			if (_id == Guid.Empty)
			{
				MessageBox.Show("Bạn chưa chọn Nhân viên để xóa");
			}
			else
			{
				OpenFileDialog op = new OpenFileDialog();
				DialogResult dialog = MessageBox.Show("Bạn có muốn xóa Nhân viên không?", "Chú ý", MessageBoxButtons.YesNo);
				if (dialog == DialogResult.Yes)
				{
					_inhanVienServices.DeleteNhanVien(_id);
					reset();
				}
			}
		}

		private void btn_Clear_Click(object sender, EventArgs e)
		{
			reset();
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

	}
}
