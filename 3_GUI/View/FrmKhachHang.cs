using _1_DAL.DomainMolder;
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
	public partial class FrmKhachHang : Form
	{
		IKhachHangServices _IKhachHangServices;
		public Guid ID;
		List<ViewKhachHang> _lstViewKhachHang;
		public KhachHang khachHang;

		public KhachHang TestKH
		{
            get { return khachHang; }
            set { khachHang = value; }
        }
        public bool AddSuccessful { get; set; }
        public bool EditSuccessful { get; set; }
        public bool ViewSuccessful { get; set; }

        public FrmKhachHang()
		{
			InitializeComponent();
			_IKhachHangServices = new KhachHangServices();
			_lstViewKhachHang = new List<ViewKhachHang>();
			LoadData();
		}
		public void LoadData()
		{
			dtg_show.Rows.Clear();
			dtg_show.ColumnCount = 5;
			dtg_show.Columns[0].Name = "ID";
			dtg_show.Columns[0].Visible = false;
			dtg_show.Columns[1].Name = "Ho va Ten";
			dtg_show.Columns[2].Name = "So dien thoai";
			dtg_show.Columns[3].Name = "Point";
			dtg_show.Columns[4].Name = "Trang thai";
			_lstViewKhachHang = _IKhachHangServices.GetAllViewKhachHang();
			if (txt_TimKiem.Text != "")
			{
				_lstViewKhachHang = _lstViewKhachHang.Where(x => x.HovaTen.Contains(txt_TimKiem.Text) || x.SDT.StartsWith(txt_TimKiem.Text)).ToList();
			}
			foreach (var a in _lstViewKhachHang)
			{
				dtg_show.Rows.Add(a.ID, a.HovaTen, a.SDT, a.Poin, a.TrangThai == 1 ? "Khách quen" : "Khách vãng lai");
			}
		}
		public bool checknhap()
		{
			if (tb_hoten.Text == "" || tb_sdt.Text == "") return false;
			return true;
		}

		public void btn_them_Click(object sender, EventArgs e)
		{
			if (checknhap() == false)
			{
				MessageBox.Show("Không được để trống các trường", "Chú ý");
				AddSuccessful = false;
			}
			else
			{
				ViewKhachHang kh = new ViewKhachHang()
				{
					HovaTen = tb_hoten.Text,
					Poin = Convert.ToInt32(tb_point.Text),
					SDT = tb_sdt.Text,
					TrangThai = rd_khachquen.Checked == true ? 1 : 0,
				};
				_IKhachHangServices.Add(kh);
				LoadData();
				MessageBox.Show("Thêm khách hàng thành công");
				AddSuccessful = true;
			}
		}

		public void btn_sua_Click(object sender, EventArgs e)
		{
			DialogResult dg = MessageBox.Show("Bạn có muốn sửa khách hàng?","Confirm" ,MessageBoxButtons.YesNo);
			if (dg == DialogResult.Yes)
			{
                if (checknhap() == false)
                {
                    MessageBox.Show("Không được để trống các trường", "Chú ý");
                    EditSuccessful = false;
                }
                else
                {
                    ViewKhachHang kh = new ViewKhachHang()
                    {
                        ID = ID,
                        HovaTen = tb_hoten.Text,
                        Poin = Convert.ToInt32(tb_point.Text),
                        SDT = tb_sdt.Text,
                        TrangThai = rd_khachquen.Checked == true ? 1 : 0,
                    };
                    _IKhachHangServices.Update(kh);
                    LoadData();
                    MessageBox.Show("Sửa khách hàng thành công");
                    EditSuccessful = true;
                }
            }
			else
			{
				EditSuccessful = false;
			}
		}

		public void btn_xoa_Click(object sender, EventArgs e)
		{
			DialogResult dialog = MessageBox.Show("Bạn có muốn xóa khách hàng không?", "Chú ý", MessageBoxButtons.YesNo);
			if (dialog == DialogResult.Yes)
			{
				_IKhachHangServices.Delete(ID);
				MessageBox.Show("Xóa thành công");
				LoadData();
			}
		}

		public void btn_clear_Click(object sender, EventArgs e)
		{
			Reset();
		}
		public void Reset()
		{
			LoadData();
			_lstViewKhachHang = null;
			tb_hoten.Text = "";

			tb_sdt.Text = "";

			txt_TimKiem.Text = "";
			tb_point.Text = "";

			rd_khachquen.Checked = true;
			rd_khachvanglai.Checked = false;


		}

		public void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow r = dtg_show.Rows[e.RowIndex];
				ID = Guid.Parse(dtg_show.Rows[e.RowIndex].Cells[0].Value.ToString());
				var kh = _IKhachHangServices.GetAllViewKhachHang().FirstOrDefault(x => x.ID == ID);
				tb_hoten.Text = kh.HovaTen;
				tb_point.Text = Convert.ToString(kh.Poin);
				tb_sdt.Text = Convert.ToString(kh.SDT);
				rd_khachvanglai.Checked = (kh.TrangThai == 0) ? true : false;
				rd_khachquen.Checked = (kh.TrangThai != 0) ? true : false;

				ViewSuccessful = true;
			}
			else
			{
				ViewSuccessful = false;
			}
		}

		public void txt_TimKiem_TextChanged(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}
