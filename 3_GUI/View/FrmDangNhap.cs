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
	public partial class FrmDangNhap : Form
	{ 
		public bool LoginSuccessful {  get; private set; }
        public INhanVienServices _inhanVienServices;
		public FrmDangNhap()
		{
			InitializeComponent();
			_inhanVienServices = new NhanVienServices();
		}
		public void saveInfor()
		{

			if (ck_nmk.Checked == true)
			{
				Properties.Settings.Default.User = tb_taikhoan.Text;
				Properties.Settings.Default.Pass = tb_matkhau.Text;
				Properties.Settings.Default.TKdaLogin = tb_taikhoan.Text;
				Properties.Settings.Default.MKdaLogin = tb_matkhau.Text;
				Properties.Settings.Default.Save();

			}
			else
			{
				Properties.Settings.Default.User = "";
				Properties.Settings.Default.Pass = "";
				Properties.Settings.Default.TKdaLogin = tb_taikhoan.Text;
				Properties.Settings.Default.MKdaLogin = tb_matkhau.Text;
				Properties.Settings.Default.Save();
			}
		}

		public void ck_nmk_CheckedChanged(object sender, EventArgs e)
		{
			if (tb_taikhoan.Text != "" && tb_matkhau.Text != "")
			{
				if (ck_nmk.Checked == true)
				{
					string use = tb_taikhoan.Text;
					string pass = tb_matkhau.Text;
					Properties.Settings.Default.User = use;
					Properties.Settings.Default.Pass = pass;
					Properties.Settings.Default.Save();
				}
				else
				{
					Properties.Settings.Default.Reset();
				}
			}
		}

		public void btn_dangnhap_Click(object sender, EventArgs e)
		{
            var login = _inhanVienServices.GetAllViewNhanVien().Where(p => p.Username == tb_taikhoan.Text && p.MatKhau == tb_matkhau.Text).FirstOrDefault();
			if (login != null)
			{
				LoginSuccessful = true;
				//saveInfor();
				MessageBox.Show("Log in successful");
                this.Hide();
				FrmMain frmBanHang = new FrmMain();
				frmBanHang.ShowDialog();
			}
			else
			{
				LoginSuccessful=false;
				MessageBox.Show("Đăng nhập thất bại");
			}
		}

		public void FrmDangNhap_Load(object sender, EventArgs e)
		{
			tb_taikhoan.Text = Properties.Settings.Default.User;
			tb_matkhau.Text = Properties.Settings.Default.Pass;
			if (Properties.Settings.Default.User != "")
			{
				ck_nmk.Checked = true;
			}
		}

		public void lbl_qmk_Click(object sender, EventArgs e)
		{
			FrmTimKiemTaiKhoan frmtk = new FrmTimKiemTaiKhoan();
			frmtk.ShowDialog();
		}


    }
}
