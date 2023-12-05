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
	public partial class FrmMain : Form
	{
		INhanVienServices _inhanVienServices;
		IChucVuServices _chucVuServices;

		public bool canAccess { get; set; }
		public FrmMain()
		{
			InitializeComponent();
			_inhanVienServices = new NhanVienServices();
			_chucVuServices = new ChucVuServices();
		}

        public void btn_NhanVien_Click(object sender, EventArgs e)
        {
            var allViewNhanVien = _inhanVienServices.GetAllViewNhanVien();
            if (allViewNhanVien != null)
            {
                var user = allViewNhanVien.FirstOrDefault(x => x.Username == Properties.Settings.Default.TKdaLogin);
                if (user != null)
                {
                    Guid idRole = user.ID;
                    var nhanVien = _inhanVienServices.GetAllNhanVien().FirstOrDefault(p => p.ID == idRole);
                    if (nhanVien != null)
                    {
                        var id = nhanVien.IDCV;
                        var chucVu = _chucVuServices.GetAll().FirstOrDefault(p => p.ID == id);
                        if (chucVu != null)
                        {
                            var idcv = chucVu.Ten;
                            if (idcv == "Trưởng phòng")
                            {
                                this.panel3.Controls.Clear();
                                FrmCV_NV frmQLNhanVien = new FrmCV_NV() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                                this.panel3.Controls.Add(frmQLNhanVien);
                                frmQLNhanVien.Show();
								canAccess = true;
                            }
                            else if (idcv != "Trưởng phòng")
                            {
                                MessageBox.Show("Nhân viên không có quyền sử dụng chức năng này");
								canAccess = false;
                            }
                        }
                    }
                }
				else
				{
					MessageBox.Show("Không tìm thấy tài khoản");
				}
            }
        }

        public void btn_SP_Click(object sender, EventArgs e)
		{
			this.panel3.Controls.Clear();
			FrmQuanLySanPham frmQLChiTietSP = new FrmQuanLySanPham() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			this.panel3.Controls.Add(frmQLChiTietSP);
			frmQLChiTietSP.Show();
		}

		public void btn_KH_Click(object sender, EventArgs e)
		{
			this.panel3.Controls.Clear();
			FrmKhachHang frmQLChiTietSP = new FrmKhachHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			this.panel3.Controls.Add(frmQLChiTietSP);
			frmQLChiTietSP.Show();
		}

		public void btn_BanHang_Click(object sender, EventArgs e)
		{
			this.panel3.Controls.Clear();
			FrmBanHang frmQLChiTietSP = new FrmBanHang() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			this.panel3.Controls.Add(frmQLChiTietSP);
			frmQLChiTietSP.Show();
		}

		public void btn_HD_Click(object sender, EventArgs e)
		{
			this.panel3.Controls.Clear();
			FrmHoaDon frmQLChiTietSP = new FrmHoaDon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			this.panel3.Controls.Add(frmQLChiTietSP);
			frmQLChiTietSP.Show();
		}

		public void btn_DMK_Click(object sender, EventArgs e)
		{
			
		}

		public void button1_Click(object sender, EventArgs e)
		{
            MessageBox.Show("Log out successful");
            this.Hide();
            FrmDangNhap frmDangNhap = new FrmDangNhap();
			frmDangNhap.ShowDialog();
		}

		public void btn_TK_Click(object sender, EventArgs e)
		{
			this.panel3.Controls.Clear();
			FrmThongKe frmQLChiTietSP = new FrmThongKe() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			this.panel3.Controls.Add(frmQLChiTietSP);
			frmQLChiTietSP.Show();
		}
	}
}
