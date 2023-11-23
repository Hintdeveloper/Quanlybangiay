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
    public partial class FrmQuanLySanPham : Form
    {
        public FrmQuanLySanPham()
        {
            InitializeComponent();
        }

        private void quảnLýSảnPhẩmChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            FrmSanPhamChiTiet frmQuanLySanPham = new FrmSanPhamChiTiet() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(frmQuanLySanPham);
            frmQuanLySanPham.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            FrmSanPham frmQuanLySanPham = new FrmSanPham() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(frmQuanLySanPham);
            frmQuanLySanPham.Show();
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            FrmSize frmQuanLySanPham = new FrmSize() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(frmQuanLySanPham);
            frmQuanLySanPham.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            FrmNCC frmQuanLySanPham = new FrmNCC() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(frmQuanLySanPham);
            frmQuanLySanPham.Show();
        }

        private void nhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            FrmNSX frmQuanLySanPham = new FrmNSX() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(frmQuanLySanPham);
            frmQuanLySanPham.Show();
        }

        private void loạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            FrmLoai frmQuanLySanPham = new FrmLoai() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(frmQuanLySanPham);
            frmQuanLySanPham.Show();
        }

        private void màuSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            FrmMauSac frmQuanLySanPham = new FrmMauSac() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(frmQuanLySanPham);
            frmQuanLySanPham.Show();
        }

        private void hìnhThứcThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            FrmHinhThucThanhToan frmQuanLySanPham = new FrmHinhThucThanhToan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(frmQuanLySanPham);
            frmQuanLySanPham.Show();
        }

        private void khuyếnMạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            FrmKhuyenMai frmKhuyenMai = new FrmKhuyenMai() { Dock = DockStyle.Fill, TopLevel=false, TopMost = true };
            this.panel2.Controls.Add(frmKhuyenMai);
            frmKhuyenMai.Show();
        }
    }
}
