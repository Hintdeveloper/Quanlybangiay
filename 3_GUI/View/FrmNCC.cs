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
	public partial class FrmNCC : Form
	{
		private INhaCCServices _inhaCCServices;
		private Guid _id;
		private NhaCungCap _ncc;
		public FrmNCC()
		{
			InitializeComponent();
			_inhaCCServices = new NhaCCServices();
			_ncc = new NhaCungCap();
			rbtn_HD.Checked = true;
			txt_Ma.Enabled = false;
			LoadDataFormDb();
		}
		public void LoadDataFormDb()
		{
			dgrid_NCC.ColumnCount = 5;
			dgrid_NCC.Columns[0].Name = "Id";
			dgrid_NCC.Columns[0].Visible = false;
			dgrid_NCC.Columns[1].Name = "Mã";
			dgrid_NCC.Columns[2].Name = "Tên";

			dgrid_NCC.Columns[3].Name = "Trạng thái";
			dgrid_NCC.Columns[4].Name = "Ghi chú";
			dgrid_NCC.Rows.Clear();
			foreach (var x in _inhaCCServices.GetAll())
			{
				dgrid_NCC.Rows.Add(x.ID, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động", x.GhiChu);
			}
		}
		public void LoadDataFormDb(string input)
		{
			dgrid_NCC.ColumnCount = 5;
			dgrid_NCC.Columns[0].Name = "Id";
			dgrid_NCC.Columns[0].Visible = false;
			dgrid_NCC.Columns[1].Name = "Mã";
			dgrid_NCC.Columns[2].Name = "Tên";

			dgrid_NCC.Columns[3].Name = "Trạng thái";
			dgrid_NCC.Columns[4].Name = "Ghi chú";
			dgrid_NCC.Rows.Clear();
			foreach (var x in _inhaCCServices.GetAll(input))
			{
				dgrid_NCC.Rows.Add(x.ID, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động", x.GhiChu);
			}
		}
		public void Reset()
		{
			LoadDataFormDb();
			_ncc = null;
			txt_Ma.Text = "";
			txt_Ten.Text = "";
			rbtn_KHD.Checked = true;
			rbtn_HD.Checked = false;
			txt_GhiChu.Text = "";
		}
		public bool checknhap()
		{
			if (txt_Ma.Text == "" || txt_Ten.Text == "") return false;
			return true;
		}

		private void dgrid_NCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int row = e.RowIndex;
			if (row >= 0)
			{
				DataGridViewRow r = dgrid_NCC.Rows[e.RowIndex];
				_ncc = _inhaCCServices.GetAll().FirstOrDefault(c => c.ID == Guid.Parse(r.Cells[0].Value.ToString()));
				txt_Ma.Text = r.Cells[1].Value.ToString();
				txt_Ten.Text = r.Cells[2].Value.ToString();
				rbtn_HD.Checked = r.Cells[3].Value.ToString() == "Hoạt động";
				rbtn_KHD.Checked = r.Cells[3].Value.ToString() == "Không hoạt động";
				txt_GhiChu.Text = r.Cells[4].Value.ToString();
			}
		}

		private void btn_Them_Click(object sender, EventArgs e)
		{
			var p = _inhaCCServices.GetAll().FirstOrDefault(x => x.Ma == txt_Ma.Text);
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
					var a = new NhaCungCap()
					{
						ID = new Guid(),
						Ma = txt_Ma.Text,
						Ten = txt_Ten.Text,
						TrangThai = rbtn_HD.Checked == true ? 1 : 0,
						GhiChu = txt_GhiChu.Text

					};
					_inhaCCServices.Add(a);
					MessageBox.Show("Thêm thành công");
					Reset();
				}
			}
		}

		private void btn_Sua_Click(object sender, EventArgs e)
		{
			if (_ncc == null)
			{
				MessageBox.Show("Không tìm thấy mã nhà cung cấp", "Cảnh báo");
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
					if (_ncc.Ma == txt_Ma.Text || _ncc.Ma != txt_Ma.Text && _inhaCCServices.GetAll().FirstOrDefault(c => c.Ma == txt_Ma.Text) == null)
					{
						_ncc.Ma = txt_Ma.Text;
						_ncc.Ten = txt_Ten.Text;
						_ncc.GhiChu = txt_GhiChu.Text;
						_ncc.TrangThai = rbtn_HD.Checked ? 1 : 0;
						_inhaCCServices.Update(_ncc);
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
				if (_ncc == null)
				{
					MessageBox.Show("Không tìm thấy");
				}
				else
				{
					_inhaCCServices.Delete(_ncc);
					MessageBox.Show("Xóa thành công");
					Reset();
				}
			}
		}

		private void btn_Reset_Click(object sender, EventArgs e)
		{
			Reset();
		}

		private void txt_Ten_TextChanged(object sender, EventArgs e)
		{
			txt_Ma.Text = "TH" + Utilities.Utilities.GetMaTuSinh(txt_Ten.Text) + (_inhaCCServices.GetAll().Count + 1);
		}

		private void txt_TimKiem_TextChanged(object sender, EventArgs e)
		{
			LoadDataFormDb(txt_TimKiem.Text);
		}

		private void txt_TimKiem_Leave(object sender, EventArgs e)
		{
			txt_TimKiem.Text = "Tìm kiếm...";
		}

		private void txt_TimKiem_MouseClick(object sender, MouseEventArgs e)
		{
			txt_TimKiem.Text = "";
		}
	}
}
