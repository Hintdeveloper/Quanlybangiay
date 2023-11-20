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
	public partial class FrmQuenMatKhau : Form
	{
		private INhanVienServices _inhanVienServices;
		public NhanVien _nv;
		public FrmQuenMatKhau()
		{
			InitializeComponent();
			_inhanVienServices = new NhanVienServices();
		}

		private void FrmQuenMatKhau_Load(object sender, EventArgs e)
		{
			txt_user.Text = _nv.Username;
			txt_user.Enabled = false;
			txt_gmail.Text = _nv.Email;
			txt_gmail.Enabled = false;
		}

		private void btn_XacNhan_Click(object sender, EventArgs e)
		{
			var a = _inhanVienServices.GetAllNhanVien().FirstOrDefault(c => c.Email == txt_gmail.Text).ID;
			var d = _inhanVienServices.GetAllNhanVien().FirstOrDefault(p => p.ID == a);
			d.MatKhau = txt_pass.Text;
			_inhanVienServices.updateSanPhamChiTiets(d);
			MessageBox.Show("Thay đổi mật khẩu thành công");
			this.Hide();
			FrmDangNhap frmdn = new FrmDangNhap();
			frmdn.ShowDialog();
		}
	}
}
