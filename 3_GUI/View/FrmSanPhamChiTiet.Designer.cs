namespace _3_GUI.View
{
	partial class FrmSanPhamChiTiet
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
			groupBox1 = new GroupBox();
			txt_SLT = new TextBox();
			ptb_QR = new PictureBox();
			chk_HH = new CheckBox();
			pictureBox1 = new PictureBox();
			chk_CH = new CheckBox();
			txt_GiaNhap = new TextBox();
			txt_MoTa = new TextBox();
			txt_GiaBan = new TextBox();
			cmb_NCC = new ComboBox();
			cmb_NSX = new ComboBox();
			cmb_Loai = new ComboBox();
			cmb_MS = new ComboBox();
			cmb_SZ = new ComboBox();
			cmb_TSP = new ComboBox();
			txt_Ma = new TextBox();
			label12 = new Label();
			label11 = new Label();
			label10 = new Label();
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
			btn_Clear = new Button();
			btn_Xoa = new Button();
			btn_Sua = new Button();
			btn_Them = new Button();
			textBox1 = new TextBox();
			dgrid_SPCT = new DataGridView();
			btn_QR = new Button();
			label13 = new Label();
			cmb_KM = new ComboBox();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ptb_QR).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgrid_SPCT).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(cmb_KM);
			groupBox1.Controls.Add(label13);
			groupBox1.Controls.Add(txt_SLT);
			groupBox1.Controls.Add(ptb_QR);
			groupBox1.Controls.Add(chk_HH);
			groupBox1.Controls.Add(pictureBox1);
			groupBox1.Controls.Add(chk_CH);
			groupBox1.Controls.Add(txt_GiaNhap);
			groupBox1.Controls.Add(txt_MoTa);
			groupBox1.Controls.Add(txt_GiaBan);
			groupBox1.Controls.Add(cmb_NCC);
			groupBox1.Controls.Add(cmb_NSX);
			groupBox1.Controls.Add(cmb_Loai);
			groupBox1.Controls.Add(cmb_MS);
			groupBox1.Controls.Add(cmb_SZ);
			groupBox1.Controls.Add(cmb_TSP);
			groupBox1.Controls.Add(txt_Ma);
			groupBox1.Controls.Add(label12);
			groupBox1.Controls.Add(label11);
			groupBox1.Controls.Add(label10);
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
			groupBox1.Location = new Point(1, 33);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(849, 383);
			groupBox1.TabIndex = 9;
			groupBox1.TabStop = false;
			groupBox1.Text = "Sản Phẩm Chi Tiết";
			// 
			// txt_SLT
			// 
			txt_SLT.Location = new Point(57, 285);
			txt_SLT.Name = "txt_SLT";
			txt_SLT.Size = new Size(205, 30);
			txt_SLT.TabIndex = 27;
			// 
			// ptb_QR
			// 
			ptb_QR.BorderStyle = BorderStyle.FixedSingle;
			ptb_QR.Location = new Point(571, 96);
			ptb_QR.Name = "ptb_QR";
			ptb_QR.Size = new Size(272, 281);
			ptb_QR.TabIndex = 26;
			ptb_QR.TabStop = false;
			ptb_QR.Click += ptb_QR_Click;
			// 
			// chk_HH
			// 
			chk_HH.AutoSize = true;
			chk_HH.Location = new Point(667, 75);
			chk_HH.Name = "chk_HH";
			chk_HH.Size = new Size(104, 27);
			chk_HH.TabIndex = 24;
			chk_HH.Text = "Hết hàng";
			chk_HH.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			pictureBox1.BorderStyle = BorderStyle.FixedSingle;
			pictureBox1.Location = new Point(332, 93);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(234, 290);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// chk_CH
			// 
			chk_CH.AutoSize = true;
			chk_CH.Location = new Point(669, 51);
			chk_CH.Name = "chk_CH";
			chk_CH.Size = new Size(107, 27);
			chk_CH.TabIndex = 23;
			chk_CH.Text = "Còn hàng";
			chk_CH.UseVisualStyleBackColor = true;
			// 
			// txt_GiaNhap
			// 
			txt_GiaNhap.Location = new Point(655, 15);
			txt_GiaNhap.Name = "txt_GiaNhap";
			txt_GiaNhap.Size = new Size(194, 30);
			txt_GiaNhap.TabIndex = 22;
			// 
			// txt_MoTa
			// 
			txt_MoTa.Location = new Point(368, 60);
			txt_MoTa.Name = "txt_MoTa";
			txt_MoTa.Size = new Size(198, 30);
			txt_MoTa.TabIndex = 21;
			// 
			// txt_GiaBan
			// 
			txt_GiaBan.Location = new Point(371, 13);
			txt_GiaBan.Name = "txt_GiaBan";
			txt_GiaBan.Size = new Size(195, 30);
			txt_GiaBan.TabIndex = 20;
			// 
			// cmb_NCC
			// 
			cmb_NCC.FormattingEnabled = true;
			cmb_NCC.Location = new Point(59, 249);
			cmb_NCC.Name = "cmb_NCC";
			cmb_NCC.Size = new Size(203, 31);
			cmb_NCC.TabIndex = 18;
			// 
			// cmb_NSX
			// 
			cmb_NSX.FormattingEnabled = true;
			cmb_NSX.Location = new Point(61, 211);
			cmb_NSX.Name = "cmb_NSX";
			cmb_NSX.Size = new Size(201, 31);
			cmb_NSX.TabIndex = 17;
			// 
			// cmb_Loai
			// 
			cmb_Loai.FormattingEnabled = true;
			cmb_Loai.Location = new Point(66, 173);
			cmb_Loai.Name = "cmb_Loai";
			cmb_Loai.Size = new Size(196, 31);
			cmb_Loai.TabIndex = 16;
			// 
			// cmb_MS
			// 
			cmb_MS.FormattingEnabled = true;
			cmb_MS.Location = new Point(83, 136);
			cmb_MS.Name = "cmb_MS";
			cmb_MS.Size = new Size(179, 31);
			cmb_MS.TabIndex = 15;
			// 
			// cmb_SZ
			// 
			cmb_SZ.FormattingEnabled = true;
			cmb_SZ.Location = new Point(57, 96);
			cmb_SZ.Name = "cmb_SZ";
			cmb_SZ.Size = new Size(205, 31);
			cmb_SZ.TabIndex = 14;
			// 
			// cmb_TSP
			// 
			cmb_TSP.FormattingEnabled = true;
			cmb_TSP.Location = new Point(74, 59);
			cmb_TSP.Name = "cmb_TSP";
			cmb_TSP.Size = new Size(188, 31);
			cmb_TSP.TabIndex = 13;
			// 
			// txt_Ma
			// 
			txt_Ma.Location = new Point(54, 19);
			txt_Ma.Name = "txt_Ma";
			txt_Ma.Size = new Size(207, 30);
			txt_Ma.TabIndex = 12;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(571, 55);
			label12.Name = "label12";
			label12.Size = new Size(91, 23);
			label12.TabIndex = 11;
			label12.Text = "Trạng thái:";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(296, 55);
			label11.Name = "label11";
			label11.Size = new Size(60, 23);
			label11.TabIndex = 10;
			label11.Text = "Mô tả:";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(571, 19);
			label10.Name = "label10";
			label10.Size = new Size(83, 23);
			label10.TabIndex = 9;
			label10.Text = "Giá nhập:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(296, 13);
			label9.Name = "label9";
			label9.Size = new Size(73, 23);
			label9.TabIndex = 8;
			label9.Text = "Giá bán:";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(6, 283);
			label8.Name = "label8";
			label8.Size = new Size(39, 23);
			label8.TabIndex = 7;
			label8.Text = "SLT:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(9, 249);
			label7.Name = "label7";
			label7.Size = new Size(49, 23);
			label7.TabIndex = 6;
			label7.Text = "NCC:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(8, 209);
			label6.Name = "label6";
			label6.Size = new Size(47, 23);
			label6.TabIndex = 5;
			label6.Text = "NSX:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(11, 173);
			label5.Name = "label5";
			label5.Size = new Size(45, 23);
			label5.TabIndex = 4;
			label5.Text = "Loại:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(6, 131);
			label4.Name = "label4";
			label4.Size = new Size(78, 23);
			label4.TabIndex = 3;
			label4.Text = "Màu sắc:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(11, 93);
			label3.Name = "label3";
			label3.Size = new Size(44, 23);
			label3.TabIndex = 2;
			label3.Text = "Size:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(9, 55);
			label2.Name = "label2";
			label2.Size = new Size(64, 23);
			label2.TabIndex = 1;
			label2.Text = "Tên SP:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(9, 21);
			label1.Name = "label1";
			label1.Size = new Size(39, 23);
			label1.TabIndex = 0;
			label1.Text = "Mã:";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btn_Clear);
			groupBox2.Controls.Add(btn_Xoa);
			groupBox2.Controls.Add(btn_Sua);
			groupBox2.Controls.Add(btn_Them);
			groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox2.Location = new Point(878, 33);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(214, 383);
			groupBox2.TabIndex = 10;
			groupBox2.TabStop = false;
			groupBox2.Text = "Chức năng";
			// 
			// btn_Clear
			// 
			btn_Clear.Location = new Point(56, 203);
			btn_Clear.Name = "btn_Clear";
			btn_Clear.Size = new Size(94, 29);
			btn_Clear.TabIndex = 17;
			btn_Clear.Text = "Clear";
			btn_Clear.UseVisualStyleBackColor = true;
			btn_Clear.Click += btn_Clear_Click;
			// 
			// btn_Xoa
			// 
			btn_Xoa.Location = new Point(56, 138);
			btn_Xoa.Name = "btn_Xoa";
			btn_Xoa.Size = new Size(94, 29);
			btn_Xoa.TabIndex = 16;
			btn_Xoa.Text = "Xóa";
			btn_Xoa.UseVisualStyleBackColor = true;
			btn_Xoa.Click += btn_Xoa_Click;
			// 
			// btn_Sua
			// 
			btn_Sua.Location = new Point(56, 87);
			btn_Sua.Name = "btn_Sua";
			btn_Sua.Size = new Size(94, 29);
			btn_Sua.TabIndex = 15;
			btn_Sua.Text = "Sửa";
			btn_Sua.UseVisualStyleBackColor = true;
			btn_Sua.Click += btn_Sua_Click;
			// 
			// btn_Them
			// 
			btn_Them.Location = new Point(56, 38);
			btn_Them.Name = "btn_Them";
			btn_Them.Size = new Size(94, 29);
			btn_Them.TabIndex = 14;
			btn_Them.Text = "Thêm";
			btn_Them.UseVisualStyleBackColor = true;
			btn_Them.Click += btn_Them_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(1, 435);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(340, 27);
			textBox1.TabIndex = 12;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// dgrid_SPCT
			// 
			dgrid_SPCT.BackgroundColor = Color.SeaShell;
			dgrid_SPCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgrid_SPCT.Location = new Point(7, 468);
			dgrid_SPCT.Name = "dgrid_SPCT";
			dgrid_SPCT.RowHeadersWidth = 51;
			dgrid_SPCT.RowTemplate.Height = 29;
			dgrid_SPCT.Size = new Size(1069, 210);
			dgrid_SPCT.TabIndex = 13;
			dgrid_SPCT.CellClick += dgrid_SPCT_CellClick;
			// 
			// btn_QR
			// 
			btn_QR.Location = new Point(723, 433);
			btn_QR.Name = "btn_QR";
			btn_QR.Size = new Size(94, 29);
			btn_QR.TabIndex = 18;
			btn_QR.Text = "Lấy mã QR";
			btn_QR.UseVisualStyleBackColor = true;
			btn_QR.Click += btn_QR_Click;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(6, 336);
			label13.Name = "label13";
			label13.Size = new Size(105, 23);
			label13.TabIndex = 29;
			label13.Text = "Khuyến mãi:";
			// 
			// cmb_KM
			// 
			cmb_KM.FormattingEnabled = true;
			cmb_KM.Location = new Point(117, 333);
			cmb_KM.Name = "cmb_KM";
			cmb_KM.Size = new Size(162, 31);
			cmb_KM.TabIndex = 30;
			// 
			// FrmSanPhamChiTiet
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1149, 720);
			Controls.Add(btn_QR);
			Controls.Add(dgrid_SPCT);
			Controls.Add(textBox1);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "FrmSanPhamChiTiet";
			Text = "FrmSanPhamChiTiet";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)ptb_QR).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgrid_SPCT).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBox1;
		private TextBox txt_SLT;
		private PictureBox ptb_QR;
		private CheckBox chk_HH;
		private PictureBox pictureBox1;
		private CheckBox chk_CH;
		private TextBox txt_GiaNhap;
		private TextBox txt_MoTa;
		private TextBox txt_GiaBan;
		private ComboBox cmb_NCC;
		private ComboBox cmb_NSX;
		private ComboBox cmb_Loai;
		private ComboBox cmb_MS;
		private ComboBox cmb_SZ;
		private ComboBox cmb_TSP;
		private TextBox txt_Ma;
		private Label label12;
		private Label label11;
		private Label label10;
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
		private Button btn_Them;
		private TextBox textBox1;
		private DataGridView dgrid_SPCT;
		private Button btn_Clear;
		private Button btn_Xoa;
		private Button btn_Sua;
		private Button btn_QR;
		private ComboBox cmb_KM;
		private Label label13;
	}
}