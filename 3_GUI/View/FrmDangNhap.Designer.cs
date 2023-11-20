namespace _3_GUI.View
{
	partial class FrmDangNhap
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		public System.ComponentModel.IContainer components = null;

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
		public void InitializeComponent()
		{
			label4 = new Label();
			label1 = new Label();
			tb_taikhoan = new TextBox();
			label2 = new Label();
			tb_matkhau = new TextBox();
			btn_dangnhap = new RJControls.RJButton();
			ck_nmk = new CheckBox();
			lbl_qmk = new Label();
			SuspendLayout();
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Times New Roman", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.ActiveCaptionText;
			label4.Location = new Point(281, 83);
			label4.Name = "label4";
			label4.Size = new Size(100, 37);
			label4.TabIndex = 20;
			label4.Text = "Login";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ActiveCaptionText;
			label1.Location = new Point(75, 161);
			label1.Name = "label1";
			label1.Size = new Size(133, 23);
			label1.TabIndex = 21;
			label1.Text = "Tên đăng nhập:";
			// 
			// tb_taikhoan
			// 
			tb_taikhoan.Location = new Point(236, 161);
			tb_taikhoan.Margin = new Padding(3, 4, 3, 4);
			tb_taikhoan.Name = "tb_taikhoan";
			tb_taikhoan.Size = new Size(215, 27);
			tb_taikhoan.TabIndex = 22;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ActiveCaptionText;
			label2.Location = new Point(75, 208);
			label2.Name = "label2";
			label2.Size = new Size(91, 23);
			label2.TabIndex = 23;
			label2.Text = "Mật khẩu:";
			// 
			// tb_matkhau
			// 
			tb_matkhau.Location = new Point(236, 207);
			tb_matkhau.Margin = new Padding(3, 4, 3, 4);
			tb_matkhau.Name = "tb_matkhau";
			tb_matkhau.PasswordChar = '*';
			tb_matkhau.Size = new Size(215, 27);
			tb_matkhau.TabIndex = 24;
			// 
			// btn_dangnhap
			// 
			btn_dangnhap.BackColor = Color.MediumSeaGreen;
			btn_dangnhap.FlatAppearance.BorderSize = 0;
			btn_dangnhap.FlatStyle = FlatStyle.Flat;
			btn_dangnhap.ForeColor = Color.White;
			btn_dangnhap.Location = new Point(267, 313);
			btn_dangnhap.Name = "btn_dangnhap";
			btn_dangnhap.Size = new Size(150, 52);
			btn_dangnhap.TabIndex = 25;
			btn_dangnhap.Text = "Đăng nhập";
			btn_dangnhap.UseVisualStyleBackColor = false;
			btn_dangnhap.Click += btn_dangnhap_Click;
			// 
			// ck_nmk
			// 
			ck_nmk.AutoSize = true;
			ck_nmk.BackColor = Color.Transparent;
			ck_nmk.Location = new Point(75, 259);
			ck_nmk.Name = "ck_nmk";
			ck_nmk.Size = new Size(147, 24);
			ck_nmk.TabIndex = 26;
			ck_nmk.Text = "Ghi nhớ mật khẩu";
			ck_nmk.UseVisualStyleBackColor = false;
			ck_nmk.CheckedChanged += ck_nmk_CheckedChanged;
			// 
			// lbl_qmk
			// 
			lbl_qmk.AutoSize = true;
			lbl_qmk.BackColor = Color.Transparent;
			lbl_qmk.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			lbl_qmk.ForeColor = Color.LightCoral;
			lbl_qmk.Location = new Point(435, 258);
			lbl_qmk.Name = "lbl_qmk";
			lbl_qmk.Size = new Size(130, 23);
			lbl_qmk.TabIndex = 27;
			lbl_qmk.Text = "Quên mật khẩu";
			lbl_qmk.Click += lbl_qmk_Click;
			// 
			// FrmDangNhap
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(734, 452);
			Controls.Add(lbl_qmk);
			Controls.Add(ck_nmk);
			Controls.Add(btn_dangnhap);
			Controls.Add(tb_matkhau);
			Controls.Add(label2);
			Controls.Add(tb_taikhoan);
			Controls.Add(label1);
			Controls.Add(label4);
			Name = "FrmDangNhap";
			Text = "FrmDangNhap";
			Load += FrmDangNhap_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		public Label label4;
		public Label label1;
		public TextBox tb_taikhoan;
		public Label label2;
		public TextBox tb_matkhau;
		public RJControls.RJButton btn_dangnhap;
		public CheckBox ck_nmk;
		public Label lbl_qmk;
	}
}