using _1_DAL.DomainMolder;
using _2_BUS.IServices;
using _2_BUS.Services;
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
	public partial class FrmKhuyenMai : Form
	{
		private IKhuyenMaiServices _ikhuyenMaiServices;
		private Guid _id;
		private KhuyenMai _km;
		public FrmKhuyenMai()
		{
			InitializeComponent();
			_ikhuyenMaiServices = new KhuyenMaiServices();
			_km = new KhuyenMai();
			rbtn_HD.Checked = true;
			LoadDataFormDb();
			txt_Ma.Enabled = false;
		}
		public void LoadDataFormDb()
		{
			dgrid_KM.ColumnCount = 7;
			dgrid_KM.Columns[0].Name = "Id";
			dgrid_KM.Columns[0].Visible = false;
			dgrid_KM.Columns[1].Name = "Mã";
			dgrid_KM.Columns[2].Name = "Tên";
			dgrid_KM.Columns[3].Name = "Hình thức";
			dgrid_KM.Columns[4].Name = "Ngày bắt đầu";
			dgrid_KM.Columns[5].Name = "Ngày kết thúc";
			dgrid_KM.Columns[6].Name = "Trạng thái";

			dgrid_KM.Rows.Clear();
			foreach (var x in _ikhuyenMaiServices.GetAll())
			{
				dgrid_KM.Rows.Add(x.ID, x.Ma, x.Ten, x.HinhThuc, x.NgayBatDau, x.NgayKetThuc, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
			}
		}
		public void LoadDataFormDb(string input)
		{
			dgrid_KM.ColumnCount = 7;
			dgrid_KM.Columns[0].Name = "Id";
			dgrid_KM.Columns[0].Visible = false;
			dgrid_KM.Columns[1].Name = "Mã";
			dgrid_KM.Columns[2].Name = "Tên";
			dgrid_KM.Columns[3].Name = "Hình thức";
			dgrid_KM.Columns[4].Name = "Ngày bắt đầu";
			dgrid_KM.Columns[5].Name = "Ngày kết thúc";
			dgrid_KM.Columns[6].Name = "Trạng thái";

			dgrid_KM.Rows.Clear();
			foreach (var x in _ikhuyenMaiServices.GetAll(input))
			{
				dgrid_KM.Rows.Add(x.ID, x.Ma, x.Ten, x.HinhThuc, x.NgayBatDau, x.NgayKetThuc, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động");
			}
		}
		public void Reset()
		{
			LoadDataFormDb();
			_km = null;
			txt_Ma.Text = "";
			txt_Ten.Text = "";
			rbtn_KHD.Checked = true;
			rbtn_HD.Checked = false;
			txt_hinhthuc.Text = "";
			date1.Text = "";
			date2.Text = "";

		}
		public bool checknhap()
		{
			if (txt_Ma.Text == "" || txt_Ten.Text == "" || txt_hinhthuc.Text == "") return false;
			return true;
		}

		private void btn_Them_Click(object sender, EventArgs e)
		{
			var p = _ikhuyenMaiServices.GetAll().FirstOrDefault(x => x.Ma == txt_Ma.Text);
			if (checknhap() == false)
			{
				MessageBox.Show("Không được để trống các trường", "Chú ý");
			}
			else if (p != null)
			{
				MessageBox.Show("Mã đã tồn tại", "Chú ý");
			}
			else
			{
				OpenFileDialog op = new OpenFileDialog();
				DialogResult dialog = MessageBox.Show("Bạn có muốn thêm  không?", "Thêm", MessageBoxButtons.YesNo);
				if (dialog == DialogResult.Yes)
				{
					var a = new KhuyenMai()
					{
						ID = new Guid(),
						Ma = txt_Ma.Text,
						Ten = txt_Ten.Text,
						TrangThai = rbtn_HD.Checked == true ? 1 : 0,
						HinhThuc = txt_hinhthuc.Text,
						NgayBatDau = date1.Value,
						NgayKetThuc = date2.Value

					};
					_ikhuyenMaiServices.Add(a);
					MessageBox.Show("Thêm thành công");
					Reset();
				}
			}
		}

		private void btn_Sua_Click(object sender, EventArgs e)
		{

			if (_km == null)
			{
				MessageBox.Show("Không tìm thấy mã khuyến mãi", "Cảnh báo");
			}
			else if (checknhap() == false)
			{
				MessageBox.Show("Không được để trống các trường", "Chú ý");
			}
			else
			{
				OpenFileDialog op = new OpenFileDialog();
				DialogResult dialog = MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo);
				if (dialog == DialogResult.Yes)
				{
					if (_km.Ma == txt_Ma.Text || _km.Ma != txt_Ma.Text && _ikhuyenMaiServices.GetAll().FirstOrDefault(c => c.Ma == txt_Ma.Text) == null)
					{
						_km.Ma = txt_Ma.Text;
						_km.Ten = txt_Ten.Text;
						_km.HinhThuc = txt_hinhthuc.Text;
						_km.NgayKetThuc = date2.Value;
						_km.NgayBatDau = date1.Value;
						_km.TrangThai = rbtn_HD.Checked ? 1 : 0;
						_ikhuyenMaiServices.Update(_km);
						MessageBox.Show("Sửa thành công");
						Reset();
					}
					else
					{
						MessageBox.Show("Không thành công");
					}
				}
			}
		}

		private void btn_Xoa_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				if (_km == null)
				{
					MessageBox.Show("Không tìm thấy");
				}
				else
				{
					_ikhuyenMaiServices.Delete(_km);
					MessageBox.Show("Xóa thành công");
					Reset();
				}
			}
		}

		private void btn_Reset_Click(object sender, EventArgs e)
		{
			Reset();
		}

		private void txt_TimKiem_TextChanged(object sender, EventArgs e)
		{
			LoadDataFormDb(txt_TimKiem.Text);
		}

		private void txt_TimKiem_MouseClick(object sender, MouseEventArgs e)
		{
			txt_TimKiem.Text = "";
		}

		private void txt_TimKiem_Leave(object sender, EventArgs e)
		{
			txt_TimKiem.Text = "Tìm kiếm...";
		}

		private void txt_Ten_TextChanged(object sender, EventArgs e)
		{
			txt_Ma.Text = "TH" + Utilities.Utilities.GetMaTuSinh(txt_Ten.Text) + (_ikhuyenMaiServices.GetAll().Count + 1);
		}

		private void dgrid_KM_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int row = e.RowIndex;
			if (row >= 0)
			{
				DataGridViewRow r = dgrid_KM.Rows[e.RowIndex];
				_km = _ikhuyenMaiServices.GetAll().FirstOrDefault(c => c.ID == Guid.Parse(r.Cells[0].Value.ToString()));
				txt_Ma.Text = r.Cells[1].Value.ToString();
				txt_Ten.Text = r.Cells[2].Value.ToString();
				rbtn_HD.Checked = r.Cells[6].Value.ToString() == "Hoạt động";
				rbtn_KHD.Checked = r.Cells[6].Value.ToString() == "Không hoạt động";
				txt_hinhthuc.Text = r.Cells[3].Value.ToString();
				date1.Text = r.Cells[4].Value.ToString();
				date2.Text = r.Cells[5].Value.ToString();
			}
		}
	}
}
