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
	public partial class FrmChucVu : Form
	{
		private IChucVuServices _ichucVuServices;
		private ChucVu _cv;
		private Guid _id;
		public FrmChucVu()
		{
			InitializeComponent();
			_ichucVuServices = new ChucVuServices();
			_cv = new ChucVu();
			rbtn_HD.Checked = true;
			LoadDataFormDb();
			txt_Ma.Enabled = false;
		}
		public void LoadDataFormDb()
		{
			dgrid_CV.ColumnCount = 5;
			dgrid_CV.Columns[0].Name = "Id";
			dgrid_CV.Columns[0].Visible = false;
			dgrid_CV.Columns[1].Name = "Mã";
			dgrid_CV.Columns[2].Name = "Tên";

			dgrid_CV.Columns[3].Name = "Trạng thái";
			dgrid_CV.Columns[4].Name = "Ghi chú";
			dgrid_CV.Rows.Clear();
			foreach (var x in _ichucVuServices.GetAll())
			{
				dgrid_CV.Rows.Add(x.ID, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động", x.GhiChu);
			}
		}
		public void LoadDataFormDb(string input)
		{
			dgrid_CV.ColumnCount = 5;
			dgrid_CV.Columns[0].Name = "Id";
			dgrid_CV.Columns[0].Visible = false;
			dgrid_CV.Columns[1].Name = "Mã";
			dgrid_CV.Columns[2].Name = "Tên";

			dgrid_CV.Columns[3].Name = "Trạng thái";
			dgrid_CV.Columns[4].Name = "Ghi chú";
			dgrid_CV.Rows.Clear();
			foreach (var x in _ichucVuServices.GetAll(input))
			{
				dgrid_CV.Rows.Add(x.ID, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động", x.GhiChu);
			}
		}
		public void Reset()
		{
			LoadDataFormDb();
			_cv = null;
			txt_Ma.Text = "";
			txt_Ten.Text = "";
			rbtn_KHD.Checked = true;
			rbtn_HD.Checked = false;
			txt_GhiChu.Text = "";
		}
		public bool checknhap()
		{
			if (txt_Ten.Text == "") return false;
			return true;
		}

		private void dgrid_CV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int row = e.RowIndex;
			if (row >= 0)
			{
				DataGridViewRow r = dgrid_CV.Rows[e.RowIndex];
				_cv = _ichucVuServices.GetAll().FirstOrDefault(c => c.ID == Guid.Parse(r.Cells[0].Value.ToString()));
				txt_Ma.Text = r.Cells[1].Value.ToString();
				txt_Ten.Text = r.Cells[2].Value.ToString();
				rbtn_HD.Checked = r.Cells[3].Value.ToString() == "Hoạt động";
				rbtn_KHD.Checked = r.Cells[3].Value.ToString() == "Không hoạt động";
				txt_GhiChu.Text = r.Cells[4].Value.ToString();
			}
		}

		private void btn_Them_Click(object sender, EventArgs e)
		{
			var p = _ichucVuServices.GetAll().FirstOrDefault(x => x.Ma == txt_Ma.Text);
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
					var a = new ChucVu()
					{
						ID = new Guid(),
						Ma = txt_Ma.Text,
						Ten = txt_Ten.Text,
						TrangThai = rbtn_HD.Checked == true ? 1 : 0,
						GhiChu = txt_GhiChu.Text

					};
					_ichucVuServices.Add(a);
					MessageBox.Show("Thêm thành công");
					Reset();
				}
			}
		}

		private void btn_Sua_Click(object sender, EventArgs e)
		{
			if (_cv == null)
			{
				MessageBox.Show("Không tìm thấy mã", "Cảnh báo");
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
					if (_cv.Ma == txt_Ma.Text || _cv.Ma != txt_Ma.Text && _ichucVuServices.GetAll().FirstOrDefault(c => c.Ma == txt_Ma.Text) == null)
					{
						_cv.Ma = txt_Ma.Text;
						_cv.Ten = txt_Ten.Text;
						_cv.GhiChu = txt_GhiChu.Text;
						_cv.TrangThai = rbtn_HD.Checked ? 1 : 0;
						_ichucVuServices.Update(_cv);
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
				if (_cv == null)
				{
					MessageBox.Show("Không tìm thấy");
				}
				else
				{
					_ichucVuServices.Delete(_cv);
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

		private void txt_Ten_TextChanged(object sender, EventArgs e)
		{
			txt_Ma.Text = "TH" + Utilities.Utilities.GetMaTuSinh(txt_Ten.Text) + (_ichucVuServices.GetAll().Count + 1);
		}

		private void txt_TimKiem_MouseClick(object sender, MouseEventArgs e)
		{
			txt_TimKiem.Text = "";
		}

		private void txt_TimKiem_Leave(object sender, EventArgs e)
		{
			txt_TimKiem.Text = "Tìm kiếm...";
		}
	}
}
