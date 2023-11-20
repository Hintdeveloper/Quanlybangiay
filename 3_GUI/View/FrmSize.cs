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
	public partial class FrmSize : Form
	{
		private ISizeServices _iSizeServices;
		private KichThuoc _size;
		private Guid _id;
		public FrmSize()
		{
			InitializeComponent();
			_iSizeServices = new SizeServices();
			_size = new KichThuoc();
			rbtn_HD.Checked = true;
			txt_Ma.Enabled = false;
			LoadDataFormDb();
		}
		public void LoadDataFormDb()
		{
			dgrid_Size.ColumnCount = 5;
			dgrid_Size.Columns[0].Name = "Id";
			dgrid_Size.Columns[0].Visible = false;
			dgrid_Size.Columns[1].Name = "Mã";
			dgrid_Size.Columns[2].Name = "Tên";

			dgrid_Size.Columns[3].Name = "Trạng thái";
			dgrid_Size.Columns[4].Name = "Ghi chú";
			dgrid_Size.Rows.Clear();
			foreach (var x in _iSizeServices.GetAll())
			{
				dgrid_Size.Rows.Add(x.ID, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động", x.GhiChu);
			}
		}
		public void LoadDataFormDb(string input)
		{
			dgrid_Size.ColumnCount = 5;
			dgrid_Size.Columns[0].Name = "Id";
			dgrid_Size.Columns[0].Visible = false;
			dgrid_Size.Columns[1].Name = "Mã";
			dgrid_Size.Columns[2].Name = "Tên";

			dgrid_Size.Columns[3].Name = "Trạng thái";
			dgrid_Size.Columns[4].Name = "Ghi chú";
			dgrid_Size.Rows.Clear();
			foreach (var x in _iSizeServices.GetAll(input))
			{
				dgrid_Size.Rows.Add(x.ID, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động", x.GhiChu);
			}
		}
		public void Reset()
		{
			LoadDataFormDb();
			_size = null;
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

		private void btn_Them_Click(object sender, EventArgs e)
		{
			var p = _iSizeServices.GetAll().FirstOrDefault(x => x.Ma == txt_Ma.Text);
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
					var a = new KichThuoc()
					{
						ID = new Guid(),
						Ma = txt_Ma.Text,
						Ten = txt_Ten.Text,
						TrangThai = rbtn_HD.Checked == true ? 1 : 0,
						GhiChu = txt_GhiChu.Text

					};
					_iSizeServices.Add(a);
					MessageBox.Show("Thêm thành công");
					Reset();
				}
			}
		}

		private void btn_Sua_Click(object sender, EventArgs e)
		{
			if (_size == null)
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
					if (_size.Ma == txt_Ma.Text || _size.Ma != txt_Ma.Text && _iSizeServices.GetAll().FirstOrDefault(c => c.Ma == txt_Ma.Text) == null)
					{
						_size.Ma = txt_Ma.Text;
						_size.Ten = txt_Ten.Text;
						_size.GhiChu = txt_GhiChu.Text;
						_size.TrangThai = rbtn_HD.Checked ? 1 : 0;
						_iSizeServices.Update(_size);
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
				if (_size == null)
				{
					MessageBox.Show("Không tìm thấy");
				}
				else
				{
					_iSizeServices.Delete(_size);
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
			txt_Ma.Text = "TH" + Utilities.Utilities.GetMaTuSinh(txt_Ten.Text) + (_iSizeServices.GetAll().Count + 1);
		}

		private void dgrid_Size_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int row = e.RowIndex;
			if (row >= 0)
			{
				DataGridViewRow r = dgrid_Size.Rows[e.RowIndex];
				_size = _iSizeServices.GetAll().FirstOrDefault(c => c.ID == Guid.Parse(r.Cells[0].Value.ToString()));
				txt_Ma.Text = r.Cells[1].Value.ToString();
				txt_Ten.Text = r.Cells[2].Value.ToString();
				rbtn_HD.Checked = r.Cells[3].Value.ToString() == "Hoạt động";
				rbtn_KHD.Checked = r.Cells[3].Value.ToString() == "Không hoạt động";
				txt_GhiChu.Text = r.Cells[4].Value.ToString();
			}
		}

		private void txt_TimKiem_TextChanged(object sender, EventArgs e)
		{
			LoadDataFormDb(txt_TimKiem.Text);
		}

		private void txt_TimKiem_DoubleClick(object sender, EventArgs e)
		{

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
