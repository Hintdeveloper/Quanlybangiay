namespace _3_GUI.View
{
	partial class FrmCV_NV
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCV_NV));
			menuStrip1 = new MenuStrip();
			nhânViênToolStripMenuItem = new ToolStripMenuItem();
			chứcVụToolStripMenuItem = new ToolStripMenuItem();
			panel1 = new Panel();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.BackColor = Color.SeaShell;
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { nhânViênToolStripMenuItem, chứcVụToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1320, 28);
			menuStrip1.TabIndex = 4;
			menuStrip1.Text = "menuStrip1";
			// 
			// nhânViênToolStripMenuItem
			// 
			nhânViênToolStripMenuItem.Image = (Image)resources.GetObject("nhânViênToolStripMenuItem.Image");
			nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
			nhânViênToolStripMenuItem.Size = new Size(109, 24);
			nhânViênToolStripMenuItem.Text = "Nhân viên";
			nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
			// 
			// chứcVụToolStripMenuItem
			// 
			chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
			chứcVụToolStripMenuItem.Size = new Size(75, 24);
			chứcVụToolStripMenuItem.Text = "Chức vụ";
			chứcVụToolStripMenuItem.Click += chứcVụToolStripMenuItem_Click;
			// 
			// panel1
			// 
			panel1.Location = new Point(0, 31);
			panel1.Name = "panel1";
			panel1.Size = new Size(1308, 725);
			panel1.TabIndex = 2;
			// 
			// FrmCV_NV
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1320, 804);
			Controls.Add(panel1);
			Controls.Add(menuStrip1);
			Name = "FrmCV_NV";
			Text = "FrmCV_NV";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem nhânViênToolStripMenuItem;
		private ToolStripMenuItem chứcVụToolStripMenuItem;
		private Panel panel1;
	}
}