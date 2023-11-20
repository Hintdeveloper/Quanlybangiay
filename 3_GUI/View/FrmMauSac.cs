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
    public partial class FrmMauSac : Form
    {
        private IMauSacServices _imauSacServices;
        private Guid _id;
        private MauSac _ms;
        public FrmMauSac()
        {
            InitializeComponent();
            _imauSacServices = new MauSacServices();
            _ms = new MauSac();
            rbtn_HD.Checked = true;
            txt_Ma.Enabled = false;
            LoadDataFormDb();

        }

        public void LoadDataFormDb()
        {
            dgrid_MauSac.ColumnCount = 5;
            dgrid_MauSac.Columns[0].Name = "Id";
            dgrid_MauSac.Columns[0].Visible = false;
            dgrid_MauSac.Columns[1].Name = "Mã";
            dgrid_MauSac.Columns[2].Name = "Tên";

            dgrid_MauSac.Columns[3].Name = "Trạng thái";
            dgrid_MauSac.Columns[4].Name = "Ghi chú";
            dgrid_MauSac.Rows.Clear();
            foreach (var x in _imauSacServices.GetAll())
            {
                dgrid_MauSac.Rows.Add(x.ID, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động", x.GhiChu);
            }
        }
        public void LoadDataFormDb(string input)
        {
            dgrid_MauSac.ColumnCount = 5;
            dgrid_MauSac.Columns[0].Name = "Id";
            dgrid_MauSac.Columns[0].Visible = false;
            dgrid_MauSac.Columns[1].Name = "Mã";
            dgrid_MauSac.Columns[2].Name = "Tên";

            dgrid_MauSac.Columns[3].Name = "Trạng thái";
            dgrid_MauSac.Columns[4].Name = "Ghi chú";
            dgrid_MauSac.Rows.Clear();
            foreach (var x in _imauSacServices.GetAll(input))
            {
                dgrid_MauSac.Rows.Add(x.ID, x.Ma, x.Ten, x.TrangThai == 1 ? "Hoạt động" : "Không hoạt động", x.GhiChu);
            }
        }
        public void Reset()
        {
            LoadDataFormDb();
            _ms = null;
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

        private void dgrid_MauSac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                DataGridViewRow r = dgrid_MauSac.Rows[e.RowIndex];
                _ms = _imauSacServices.GetAll().FirstOrDefault(c => c.ID == Guid.Parse(r.Cells[0].Value.ToString()));
                txt_Ma.Text = r.Cells[1].Value.ToString();
                txt_Ten.Text = r.Cells[2].Value.ToString();
                rbtn_HD.Checked = r.Cells[3].Value.ToString() == "Hoạt động";
                rbtn_KHD.Checked = r.Cells[3].Value.ToString() == "Không hoạt động";
                txt_GhiChu.Text = r.Cells[4].Value.ToString();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var p = _imauSacServices.GetAll().FirstOrDefault(x => x.Ma == txt_Ma.Text);
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
                    var a = new MauSac()
                    {
                        ID = new Guid(),
                        Ma = txt_Ma.Text,
                        Ten = txt_Ten.Text,
                        TrangThai = rbtn_HD.Checked == true ? 1 : 0,
                        GhiChu = txt_GhiChu.Text

                    };
                    _imauSacServices.Add(a);
                    MessageBox.Show("Thêm thành công");
                    Reset();
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (_ms == null)
            {
                MessageBox.Show("Không tìm thấy mã màu sắc", "Cảnh báo");
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
                    if (_ms.Ma == txt_Ma.Text || _ms.Ma != txt_Ma.Text && _imauSacServices.GetAll().FirstOrDefault(c => c.Ma == txt_Ma.Text) == null)
                    {
                        _ms.Ma = txt_Ma.Text;
                        _ms.Ten = txt_Ten.Text;
                        _ms.GhiChu = txt_GhiChu.Text;
                        _ms.TrangThai = rbtn_HD.Checked ? 1 : 0;
                        _imauSacServices.Update(_ms);
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
                if (_ms == null)
                {
                    MessageBox.Show("Không tìm thấy");
                }
                else
                {
                    _imauSacServices.Delete(_ms);
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
            txt_Ma.Text = "TH" + Utilities.Utilities.GetMaTuSinh(txt_Ten.Text) + (_imauSacServices.GetAll().Count + 1);
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadDataFormDb(txt_TimKiem.Text);
        }
    }
}
