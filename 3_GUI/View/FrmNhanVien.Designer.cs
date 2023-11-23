namespace _3_GUI.View
{
	partial class FrmNhanVien
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
			groupBox1 = new GroupBox();
			panel1 = new Panel();
			rbtn_KHD = new RadioButton();
			label10 = new Label();
			rbtn_HD = new RadioButton();
			cmb_CV = new ComboBox();
			label12 = new Label();
			pictureBox1 = new PictureBox();
			rbtn_Nu = new RadioButton();
			rbtn_Nam = new RadioButton();
			date = new DateTimePicker();
			txt_GhiChu = new TextBox();
			txt_MatKhau = new TextBox();
			txt_DC = new TextBox();
			txt_CCCD = new TextBox();
			txt_SDT = new TextBox();
			txt_Email = new TextBox();
			txt_HoTen = new TextBox();
			txt_user = new TextBox();
			label11 = new Label();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			groupBox2 = new GroupBox();
			btn_Clear = new RJControls.RJButton();
			btn_Xoa = new RJControls.RJButton();
			btn_Sua = new RJControls.RJButton();
			btn_Them = new RJControls.RJButton();
			txt_TimKiem = new TextBox();
			dgrid_NhanVien = new DataGridView();
			groupBox1.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgrid_NhanVien).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(panel1);
			groupBox1.Controls.Add(cmb_CV);
			groupBox1.Controls.Add(label12);
			groupBox1.Controls.Add(pictureBox1);
			groupBox1.Controls.Add(rbtn_Nu);
			groupBox1.Controls.Add(rbtn_Nam);
			groupBox1.Controls.Add(date);
			groupBox1.Controls.Add(txt_GhiChu);
			groupBox1.Controls.Add(txt_MatKhau);
			groupBox1.Controls.Add(txt_DC);
			groupBox1.Controls.Add(txt_CCCD);
			groupBox1.Controls.Add(txt_SDT);
			groupBox1.Controls.Add(txt_Email);
			groupBox1.Controls.Add(txt_HoTen);
			groupBox1.Controls.Add(txt_user);
			groupBox1.Controls.Add(label11);
			groupBox1.Controls.Add(label9);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox1.Location = new Point(12, 11);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(796, 462);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin nhân viên";
			// 
			// panel1
			// 
			panel1.Controls.Add(rbtn_KHD);
			panel1.Controls.Add(label10);
			panel1.Controls.Add(rbtn_HD);
			panel1.Location = new Point(370, 63);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(344, 48);
			panel1.TabIndex = 27;
			// 
			// rbtn_KHD
			// 
			rbtn_KHD.AutoSize = true;
			rbtn_KHD.Location = new Point(238, 13);
			rbtn_KHD.Name = "rbtn_KHD";
			rbtn_KHD.Size = new Size(103, 27);
			rbtn_KHD.TabIndex = 23;
			rbtn_KHD.TabStop = true;
			rbtn_KHD.Text = "Nghỉ việc";
			rbtn_KHD.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(14, 15);
			label10.Name = "label10";
			label10.Size = new Size(91, 23);
			label10.TabIndex = 9;
			label10.Text = "Trạng thái:";
			// 
			// rbtn_HD
			// 
			rbtn_HD.AutoSize = true;
			rbtn_HD.Location = new Point(116, 11);
			rbtn_HD.Name = "rbtn_HD";
			rbtn_HD.Size = new Size(105, 27);
			rbtn_HD.TabIndex = 22;
			rbtn_HD.TabStop = true;
			rbtn_HD.Text = "Đang làm";
			rbtn_HD.UseVisualStyleBackColor = true;
			// 
			// cmb_CV
			// 
			cmb_CV.FormattingEnabled = true;
			cmb_CV.Location = new Point(96, 390);
			cmb_CV.Name = "cmb_CV";
			cmb_CV.Size = new Size(197, 31);
			cmb_CV.TabIndex = 26;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(5, 390);
			label12.Name = "label12";
			label12.Size = new Size(78, 23);
			label12.TabIndex = 25;
			label12.Text = "Chức vụ:";
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.Fixed3D;
			pictureBox1.Location = new Point(402, 204);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(286, 248);
			pictureBox1.TabIndex = 24;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// rbtn_Nu
			// 
			rbtn_Nu.AutoSize = true;
			rbtn_Nu.Location = new Point(202, 178);
			rbtn_Nu.Name = "rbtn_Nu";
			rbtn_Nu.Size = new Size(55, 27);
			rbtn_Nu.TabIndex = 21;
			rbtn_Nu.TabStop = true;
			rbtn_Nu.Text = "Nữ";
			rbtn_Nu.UseVisualStyleBackColor = true;
			// 
			// rbtn_Nam
			// 
			rbtn_Nam.AutoSize = true;
			rbtn_Nam.Location = new Point(100, 178);
			rbtn_Nam.Name = "rbtn_Nam";
			rbtn_Nam.Size = new Size(68, 27);
			rbtn_Nam.TabIndex = 20;
			rbtn_Nam.TabStop = true;
			rbtn_Nam.Text = "Nam";
			rbtn_Nam.UseVisualStyleBackColor = true;
			// 
			// date
			// 
			date.Format = DateTimePickerFormat.Short;
			date.Location = new Point(100, 138);
			date.Name = "date";
			date.Size = new Size(193, 30);
			date.TabIndex = 19;
			// 
			// txt_GhiChu
			// 
			txt_GhiChu.Location = new Point(459, 168);
			txt_GhiChu.Name = "txt_GhiChu";
			txt_GhiChu.Size = new Size(255, 30);
			txt_GhiChu.TabIndex = 18;
			// 
			// txt_MatKhau
			// 
			txt_MatKhau.Location = new Point(459, 118);
			txt_MatKhau.Name = "txt_MatKhau";
			txt_MatKhau.Size = new Size(255, 30);
			txt_MatKhau.TabIndex = 17;
			// 
			// txt_DC
			// 
			txt_DC.Location = new Point(459, 17);
			txt_DC.Name = "txt_DC";
			txt_DC.Size = new Size(255, 30);
			txt_DC.TabIndex = 16;
			// 
			// txt_CCCD
			// 
			txt_CCCD.Location = new Point(95, 338);
			txt_CCCD.Name = "txt_CCCD";
			txt_CCCD.Size = new Size(196, 30);
			txt_CCCD.TabIndex = 15;
			// 
			// txt_SDT
			// 
			txt_SDT.Location = new Point(95, 283);
			txt_SDT.Name = "txt_SDT";
			txt_SDT.Size = new Size(196, 30);
			txt_SDT.TabIndex = 14;
			// 
			// txt_Email
			// 
			txt_Email.Location = new Point(98, 226);
			txt_Email.Name = "txt_Email";
			txt_Email.Size = new Size(195, 30);
			txt_Email.TabIndex = 13;
			// 
			// txt_HoTen
			// 
			txt_HoTen.Location = new Point(99, 81);
			txt_HoTen.Name = "txt_HoTen";
			txt_HoTen.Size = new Size(195, 30);
			txt_HoTen.TabIndex = 12;
			// 
			// txt_user
			// 
			txt_user.Location = new Point(99, 24);
			txt_user.Name = "txt_user";
			txt_user.Size = new Size(194, 30);
			txt_user.TabIndex = 11;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(370, 171);
			label11.Name = "label11";
			label11.Size = new Size(73, 23);
			label11.TabIndex = 10;
			label11.Text = "Ghi chú:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(370, 24);
			label9.Name = "label9";
			label9.Size = new Size(66, 23);
			label9.TabIndex = 8;
			label9.Text = "Địa chỉ:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(370, 121);
			label8.Name = "label8";
			label8.Size = new Size(88, 23);
			label8.TabIndex = 7;
			label8.Text = "Mật khẩu:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(2, 341);
			label7.Name = "label7";
			label7.Size = new Size(59, 23);
			label7.TabIndex = 6;
			label7.Text = "CCCD:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(6, 290);
			label6.Name = "label6";
			label6.Size = new Size(44, 23);
			label6.TabIndex = 5;
			label6.Text = "SĐT:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(6, 226);
			label5.Name = "label5";
			label5.Size = new Size(55, 23);
			label5.TabIndex = 4;
			label5.Text = "Email:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(6, 178);
			label4.Name = "label4";
			label4.Size = new Size(79, 23);
			label4.TabIndex = 3;
			label4.Text = "Giới tính:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 131);
			label3.Name = "label3";
			label3.Size = new Size(91, 23);
			label3.TabIndex = 2;
			label3.Text = "Ngày sinh:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 78);
			label2.Name = "label2";
			label2.Size = new Size(67, 23);
			label2.TabIndex = 1;
			label2.Text = "Họ tên:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(5, 27);
			label1.Name = "label1";
			label1.Size = new Size(91, 23);
			label1.TabIndex = 0;
			label1.Text = "Username:";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btn_Clear);
			groupBox2.Controls.Add(btn_Xoa);
			groupBox2.Controls.Add(btn_Sua);
			groupBox2.Controls.Add(btn_Them);
			groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox2.Location = new Point(829, 11);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(181, 462);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			groupBox2.Text = "Chức năng";
			// 
			// btn_Clear
			// 
			btn_Clear.BackColor = Color.MediumSeaGreen;
			btn_Clear.FlatAppearance.BorderSize = 0;
			btn_Clear.FlatStyle = FlatStyle.Flat;
			btn_Clear.ForeColor = Color.White;
			btn_Clear.Image = (Image)resources.GetObject("btn_Clear.Image");
			btn_Clear.ImageAlign = ContentAlignment.MiddleLeft;
			btn_Clear.Location = new Point(19, 313);
			btn_Clear.Name = "btn_Clear";
			btn_Clear.Size = new Size(150, 37);
			btn_Clear.TabIndex = 3;
			btn_Clear.Text = "Clear";
			btn_Clear.UseVisualStyleBackColor = false;
			btn_Clear.Click += btn_Clear_Click;
			// 
			// btn_Xoa
			// 
			btn_Xoa.BackColor = Color.MediumSeaGreen;
			btn_Xoa.FlatAppearance.BorderSize = 0;
			btn_Xoa.FlatStyle = FlatStyle.Flat;
			btn_Xoa.ForeColor = Color.White;
			btn_Xoa.Image = (Image)resources.GetObject("btn_Xoa.Image");
			btn_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
			btn_Xoa.Location = new Point(19, 219);
			btn_Xoa.Name = "btn_Xoa";
			btn_Xoa.Size = new Size(150, 37);
			btn_Xoa.TabIndex = 2;
			btn_Xoa.Text = "Xóa";
			btn_Xoa.UseVisualStyleBackColor = false;
			btn_Xoa.Click += btn_Xoa_Click;
			// 
			// btn_Sua
			// 
			btn_Sua.BackColor = Color.MediumSeaGreen;
			btn_Sua.FlatAppearance.BorderSize = 0;
			btn_Sua.FlatStyle = FlatStyle.Flat;
			btn_Sua.ForeColor = Color.White;
			btn_Sua.Image = (Image)resources.GetObject("btn_Sua.Image");
			btn_Sua.ImageAlign = ContentAlignment.MiddleLeft;
			btn_Sua.Location = new Point(19, 124);
			btn_Sua.Name = "btn_Sua";
			btn_Sua.Size = new Size(150, 37);
			btn_Sua.TabIndex = 1;
			btn_Sua.Text = "Sửa";
			btn_Sua.UseVisualStyleBackColor = false;
			btn_Sua.Click += btn_Sua_Click;
			// 
			// btn_Them
			// 
			btn_Them.BackColor = Color.MediumSeaGreen;
			btn_Them.FlatAppearance.BorderSize = 0;
			btn_Them.FlatStyle = FlatStyle.Flat;
			btn_Them.ForeColor = Color.White;
			btn_Them.Image = (Image)resources.GetObject("btn_Them.Image");
			btn_Them.ImageAlign = ContentAlignment.MiddleLeft;
			btn_Them.Location = new Point(19, 29);
			btn_Them.Name = "btn_Them";
			btn_Them.Size = new Size(150, 37);
			btn_Them.TabIndex = 0;
			btn_Them.Text = "Thêm";
			btn_Them.UseVisualStyleBackColor = false;
			btn_Them.Click += btn_Them_Click;
			// 
			// txt_TimKiem
			// 
			txt_TimKiem.Location = new Point(12, 479);
			txt_TimKiem.Name = "txt_TimKiem";
			txt_TimKiem.Size = new Size(978, 27);
			txt_TimKiem.TabIndex = 4;
			txt_TimKiem.TextChanged += txt_TimKiem_TextChanged;
			// 
			// dgrid_NhanVien
			// 
			dgrid_NhanVien.BackgroundColor = Color.SeaShell;
			dgrid_NhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgrid_NhanVien.Location = new Point(12, 526);
			dgrid_NhanVien.Name = "dgrid_NhanVien";
			dgrid_NhanVien.RowHeadersWidth = 51;
			dgrid_NhanVien.RowTemplate.Height = 29;
			dgrid_NhanVien.Size = new Size(979, 200);
			dgrid_NhanVien.TabIndex = 5;
			dgrid_NhanVien.CellClick += dgrid_NhanVien_CellClick;
			// 
			// FrmNhanVien
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1054, 728);
			Controls.Add(dgrid_NhanVien);
			Controls.Add(txt_TimKiem);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "FrmNhanVien";
			Text = "FrmNhanVien";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgrid_NhanVien).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBox1;
		private Panel panel1;
		private RadioButton rbtn_KHD;
		private Label label10;
		private RadioButton rbtn_HD;
		private ComboBox cmb_CV;
		private Label label12;
		private PictureBox pictureBox1;
		private RadioButton rbtn_Nu;
		private RadioButton rbtn_Nam;
		private DateTimePicker date;
		private TextBox txt_GhiChu;
		private TextBox txt_MatKhau;
		private TextBox txt_DC;
		private TextBox txt_CCCD;
		private TextBox txt_SDT;
		private TextBox txt_Email;
		private TextBox txt_HoTen;
		private TextBox txt_user;
		private Label label11;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private GroupBox groupBox2;
		private RJControls.RJButton btn_Clear;
		private RJControls.RJButton btn_Xoa;
		private RJControls.RJButton btn_Sua;
		private RJControls.RJButton btn_Them;
		private TextBox txt_TimKiem;
		private DataGridView dgrid_NhanVien;
	}
}