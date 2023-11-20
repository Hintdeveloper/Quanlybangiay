namespace _3_GUI.View
{
	partial class FrmMain
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
			Button btn_SP;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			panel1 = new Panel();
			panel2_Load = new Panel();
			btn_DMK = new Button();
			button1 = new Button();
			btn_TK = new Button();
			btn_HD = new Button();
			btn_BanHang = new Button();
			btn_NhanVien = new Button();
			btn_KH = new Button();
			pictureBox1 = new PictureBox();
			panel3 = new Panel();
			btn_SP = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// btn_SP
			// 
			btn_SP.BackColor = Color.SeaShell;
			btn_SP.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btn_SP.ForeColor = Color.Black;
			btn_SP.Image = (Image)resources.GetObject("btn_SP.Image");
			btn_SP.ImageAlign = ContentAlignment.MiddleLeft;
			btn_SP.Location = new Point(0, 147);
			btn_SP.Name = "btn_SP";
			btn_SP.Size = new Size(212, 58);
			btn_SP.TabIndex = 1;
			btn_SP.Text = "Sản phẩm";
			btn_SP.UseVisualStyleBackColor = false;
			btn_SP.Click += btn_SP_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.SeaShell;
			panel1.Controls.Add(panel2_Load);
			panel1.Controls.Add(btn_DMK);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(btn_TK);
			panel1.Controls.Add(btn_HD);
			panel1.Controls.Add(btn_BanHang);
			panel1.Controls.Add(btn_NhanVien);
			panel1.Controls.Add(btn_KH);
			panel1.Controls.Add(btn_SP);
			panel1.Controls.Add(pictureBox1);
			panel1.Location = new Point(12, 11);
			panel1.Name = "panel1";
			panel1.Size = new Size(212, 1032);
			panel1.TabIndex = 4;
			// 
			// panel2_Load
			// 
			panel2_Load.BackColor = Color.SeaShell;
			panel2_Load.Location = new Point(217, 110);
			panel2_Load.Name = "panel2_Load";
			panel2_Load.Size = new Size(1358, 674);
			panel2_Load.TabIndex = 1;
			// 
			// btn_DMK
			// 
			btn_DMK.BackColor = Color.SeaShell;
			btn_DMK.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btn_DMK.Image = (Image)resources.GetObject("btn_DMK.Image");
			btn_DMK.ImageAlign = ContentAlignment.MiddleLeft;
			btn_DMK.Location = new Point(1, 507);
			btn_DMK.Name = "btn_DMK";
			btn_DMK.Size = new Size(212, 50);
			btn_DMK.TabIndex = 8;
			btn_DMK.Text = "Tài khoản";
			btn_DMK.UseVisualStyleBackColor = false;
			btn_DMK.Click += btn_DMK_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.SeaShell;
			button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			button1.Image = (Image)resources.GetObject("button1.Image");
			button1.ImageAlign = ContentAlignment.MiddleLeft;
			button1.Location = new Point(-1, 554);
			button1.Name = "button1";
			button1.Size = new Size(212, 49);
			button1.TabIndex = 7;
			button1.Text = "Đăng xuất";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// btn_TK
			// 
			btn_TK.BackColor = Color.SeaShell;
			btn_TK.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btn_TK.Image = (Image)resources.GetObject("btn_TK.Image");
			btn_TK.ImageAlign = ContentAlignment.MiddleLeft;
			btn_TK.Location = new Point(0, 456);
			btn_TK.Name = "btn_TK";
			btn_TK.Size = new Size(211, 57);
			btn_TK.TabIndex = 6;
			btn_TK.Text = "Thống kê";
			btn_TK.UseVisualStyleBackColor = false;
			btn_TK.Click += btn_TK_Click;
			// 
			// btn_HD
			// 
			btn_HD.BackColor = Color.SeaShell;
			btn_HD.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btn_HD.Image = (Image)resources.GetObject("btn_HD.Image");
			btn_HD.ImageAlign = ContentAlignment.MiddleLeft;
			btn_HD.Location = new Point(1, 396);
			btn_HD.Name = "btn_HD";
			btn_HD.Size = new Size(211, 54);
			btn_HD.TabIndex = 5;
			btn_HD.Text = "Hóa đơn";
			btn_HD.UseVisualStyleBackColor = false;
			btn_HD.Click += btn_HD_Click;
			// 
			// btn_BanHang
			// 
			btn_BanHang.BackColor = Color.SeaShell;
			btn_BanHang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btn_BanHang.Image = (Image)resources.GetObject("btn_BanHang.Image");
			btn_BanHang.ImageAlign = ContentAlignment.MiddleLeft;
			btn_BanHang.Location = new Point(0, 335);
			btn_BanHang.Name = "btn_BanHang";
			btn_BanHang.Size = new Size(212, 55);
			btn_BanHang.TabIndex = 4;
			btn_BanHang.Text = "Bán hàng";
			btn_BanHang.UseVisualStyleBackColor = false;
			btn_BanHang.Click += btn_BanHang_Click;
			// 
			// btn_NhanVien
			// 
			btn_NhanVien.BackColor = Color.SeaShell;
			btn_NhanVien.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			btn_NhanVien.Image = (Image)resources.GetObject("btn_NhanVien.Image");
			btn_NhanVien.ImageAlign = ContentAlignment.MiddleLeft;
			btn_NhanVien.Location = new Point(0, 272);
			btn_NhanVien.Name = "btn_NhanVien";
			btn_NhanVien.Size = new Size(212, 57);
			btn_NhanVien.TabIndex = 3;
			btn_NhanVien.Text = "Nhân viên";
			btn_NhanVien.UseVisualStyleBackColor = false;
			btn_NhanVien.Click += btn_NhanVien_Click;
			// 
			// btn_KH
			// 
			btn_KH.BackColor = Color.SeaShell;
			btn_KH.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			btn_KH.Image = (Image)resources.GetObject("btn_KH.Image");
			btn_KH.ImageAlign = ContentAlignment.MiddleLeft;
			btn_KH.Location = new Point(0, 211);
			btn_KH.Name = "btn_KH";
			btn_KH.Size = new Size(212, 55);
			btn_KH.TabIndex = 2;
			btn_KH.Text = "Khách hàng";
			btn_KH.UseVisualStyleBackColor = false;
			btn_KH.Click += btn_KH_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImageLayout = ImageLayout.Center;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(29, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(134, 141);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// panel3
			// 
			panel3.BackColor = Color.SeaShell;
			panel3.Location = new Point(232, 12);
			panel3.Name = "panel3";
			panel3.Size = new Size(1296, 1031);
			panel3.TabIndex = 6;
			// 
			// FrmMain
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1604, 973);
			Controls.Add(panel3);
			Controls.Add(panel1);
			Name = "FrmMain";
			Text = "FrmMain";
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2_Load;
		private Button btn_DMK;
		private Button button1;
		private Button btn_TK;
		private Button btn_HD;
		private Button btn_BanHang;
		private Button btn_NhanVien;
		private Button btn_KH;
		private PictureBox pictureBox1;
		private Panel panel3;
	}
}