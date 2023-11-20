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
	public partial class FrmCV_NV : Form
	{
		public FrmCV_NV()
		{
			InitializeComponent();
		}

		private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.Controls.Clear();
			FrmNhanVien frmQuanLySanPham = new FrmNhanVien() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			this.panel1.Controls.Add(frmQuanLySanPham);
			frmQuanLySanPham.Show();
		}

		private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.Controls.Clear();
			FrmChucVu frmQuanLySanPham = new FrmChucVu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
			this.panel1.Controls.Add(frmQuanLySanPham);
			frmQuanLySanPham.Show();
		}
	}
}
