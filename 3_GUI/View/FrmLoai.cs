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
	public partial class FrmLoai : Form
	{
		private ILoaiSanPhamServices _iloaiSanPhamServices;
		private Guid _id;
		private LoaiSanPham _lsp;
		public FrmLoai()
		{
			_iloaiSanPhamServices = new LoaiSanPhamServices();
			InitializeComponent();
			_lsp = new LoaiSanPham();
			rbtn_HD.Checked = true;
			txt_Ma.Enabled = false;
			LoadDataFormDb();
		}
		public void LoadDataFormDb()
		{
			dgrid_LoaiSanPham.ColumnCount = 5;
			dgrid_LoaiSanPham.Columns[0].Name = "Id";
			dgrid_LoaiSanPham.Columns[0].Visible = false;
			dgrid_LoaiSanPham.Columns[1].Name = "Mã";
			dgrid_LoaiSanPham.Columns[2].Name = "Tên";

			dgrid_LoaiSanPham.Columns[3].Name = "Trạng thái";
			dgrid_LoaiSanPham.Columns[4].Name = "Ghi chú";
			dgrid_LoaiSanPham.Rows.Clear();
			foreach (var x in _iloaiSanPhamServices.GetAll())
			{
				dgrid_LoaiSanPham.Rows.Add(x.ID, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động", x.GhiChu);
			}
		}
		public void LoadDataFormDb(string input)
		{
			dgrid_LoaiSanPham.ColumnCount = 5;
			dgrid_LoaiSanPham.Columns[0].Name = "Id";
			dgrid_LoaiSanPham.Columns[0].Visible = false;
			dgrid_LoaiSanPham.Columns[1].Name = "Mã";
			dgrid_LoaiSanPham.Columns[2].Name = "Tên";

			dgrid_LoaiSanPham.Columns[3].Name = "Trạng thái";
			dgrid_LoaiSanPham.Columns[4].Name = "Ghi chú";
			dgrid_LoaiSanPham.Rows.Clear();
			foreach (var x in _iloaiSanPhamServices.GetAll(input))
			{
				dgrid_LoaiSanPham.Rows.Add(x.ID, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động", x.GhiChu);
			}
		}
		public void Reset()
		{
			LoadDataFormDb();
			_lsp = null;
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
			var p = _iloaiSanPhamServices.GetAll().FirstOrDefault(x => x.Ma == txt_Ma.Text);
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
				DialogResult dialog = MessageBox.Show("Bạn có muốn thêm không?", "Thêm", MessageBoxButtons.YesNo);
				if (dialog == DialogResult.Yes)
				{
					var th = new LoaiSanPham()
					{
						ID = new Guid(),
						Ma = txt_Ma.Text,
						Ten = txt_Ten.Text,
						GhiChu = txt_GhiChu.Text,
						TrangThai = rbtn_HD.Checked ? 1 : 0,

					};
					_iloaiSanPhamServices.Add(th);
					MessageBox.Show("Thêm thành công");
					Reset();
				}
			}
		}

		private void btn_Sua_Click(object sender, EventArgs e)
		{
			if (_lsp == null)
			{
				MessageBox.Show("Không tìm thấy mã loại sản phẩm", "Cảnh báo");
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
					if (_lsp.Ma == txt_Ma.Text || _lsp.Ma != txt_Ma.Text && _iloaiSanPhamServices.GetAll().FirstOrDefault(c => c.Ma == txt_Ma.Text) == null)
					{
						_lsp.Ma = txt_Ma.Text;
						_lsp.Ten = txt_Ten.Text;
						_lsp.GhiChu = txt_GhiChu.Text;
						_lsp.TrangThai = rbtn_HD.Checked ? 1 : 0;
						_iloaiSanPhamServices.Update(_lsp);
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
				if (_lsp == null)
				{
					MessageBox.Show("Không tìm thấy");
				}
				else
				{
					_iloaiSanPhamServices.Delete(_lsp);
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
			txt_Ma.Text = "TH" + Utilities.Utilities.GetMaTuSinh(txt_Ten.Text) + (_iloaiSanPhamServices.GetAll().Count + 1);

		}

		private void dgrid_LoaiSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int row = e.RowIndex;
			if (row >= 0)
			{
				DataGridViewRow r = dgrid_LoaiSanPham.Rows[e.RowIndex];
				_lsp = _iloaiSanPhamServices.GetAll().FirstOrDefault(c => c.ID == Guid.Parse(r.Cells[0].Value.ToString()));
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
