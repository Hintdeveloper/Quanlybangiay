namespace _3_GUI.View
{
	partial class FrmKhuyenMai
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
			date2 = new DateTimePicker();
			date1 = new DateTimePicker();
			txt_hinhthuc = new TextBox();
			label6 = new Label();
			label4 = new Label();
			label5 = new Label();
			rbtn_KHD = new RadioButton();
			rbtn_HD = new RadioButton();
			txt_Ten = new TextBox();
			txt_Ma = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			groupBox2 = new GroupBox();
			btn_Reset = new Button();
			btn_Xoa = new Button();
			btn_Sua = new Button();
			btn_Them = new Button();
			txt_TimKiem = new TextBox();
			dgrid_KM = new DataGridView();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgrid_KM).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(date2);
			groupBox1.Controls.Add(date1);
			groupBox1.Controls.Add(txt_hinhthuc);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(rbtn_KHD);
			groupBox1.Controls.Add(rbtn_HD);
			groupBox1.Controls.Add(txt_Ten);
			groupBox1.Controls.Add(txt_Ma);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox1.ForeColor = Color.Black;
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(517, 317);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			groupBox1.Text = "Khuyến mại";
			// 
			// date2
			// 
			date2.Format = DateTimePickerFormat.Short;
			date2.Location = new Point(137, 232);
			date2.Name = "date2";
			date2.Size = new Size(250, 30);
			date2.TabIndex = 14;
			// 
			// date1
			// 
			date1.Format = DateTimePickerFormat.Short;
			date1.Location = new Point(137, 176);
			date1.Name = "date1";
			date1.Size = new Size(250, 30);
			date1.TabIndex = 13;
			// 
			// txt_hinhthuc
			// 
			txt_hinhthuc.Location = new Point(137, 131);
			txt_hinhthuc.Name = "txt_hinhthuc";
			txt_hinhthuc.Size = new Size(250, 30);
			txt_hinhthuc.TabIndex = 12;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(15, 228);
			label6.Name = "label6";
			label6.Size = new Size(123, 23);
			label6.TabIndex = 11;
			label6.Text = "Ngày kết thúc:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(11, 183);
			label4.Name = "label4";
			label4.Size = new Size(119, 23);
			label4.TabIndex = 10;
			label4.Text = "Ngày bắt đầu:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(11, 136);
			label5.Name = "label5";
			label5.Size = new Size(91, 23);
			label5.TabIndex = 9;
			label5.Text = "Hình thức:";
			// 
			// rbtn_KHD
			// 
			rbtn_KHD.AutoSize = true;
			rbtn_KHD.Location = new Point(245, 271);
			rbtn_KHD.Name = "rbtn_KHD";
			rbtn_KHD.Size = new Size(166, 27);
			rbtn_KHD.TabIndex = 8;
			rbtn_KHD.TabStop = true;
			rbtn_KHD.Text = "Không hoạt động";
			rbtn_KHD.UseVisualStyleBackColor = true;
			// 
			// rbtn_HD
			// 
			rbtn_HD.AutoSize = true;
			rbtn_HD.Location = new Point(103, 269);
			rbtn_HD.Name = "rbtn_HD";
			rbtn_HD.Size = new Size(114, 27);
			rbtn_HD.TabIndex = 7;
			rbtn_HD.TabStop = true;
			rbtn_HD.Text = "Hoạt động";
			rbtn_HD.UseVisualStyleBackColor = true;
			// 
			// txt_Ten
			// 
			txt_Ten.Location = new Point(137, 80);
			txt_Ten.Name = "txt_Ten";
			txt_Ten.Size = new Size(250, 30);
			txt_Ten.TabIndex = 5;
			txt_Ten.TextChanged += txt_Ten_TextChanged;
			// 
			// txt_Ma
			// 
			txt_Ma.Location = new Point(138, 31);
			txt_Ma.Name = "txt_Ma";
			txt_Ma.Size = new Size(249, 30);
			txt_Ma.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(15, 269);
			label3.Name = "label3";
			label3.Size = new Size(91, 23);
			label3.TabIndex = 2;
			label3.Text = "Trạng thái:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(11, 37);
			label2.Name = "label2";
			label2.Size = new Size(39, 23);
			label2.TabIndex = 1;
			label2.Text = "Mã:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(11, 83);
			label1.Name = "label1";
			label1.Size = new Size(40, 23);
			label1.TabIndex = 0;
			label1.Text = "Tên:";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btn_Reset);
			groupBox2.Controls.Add(btn_Xoa);
			groupBox2.Controls.Add(btn_Sua);
			groupBox2.Controls.Add(btn_Them);
			groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox2.Location = new Point(535, 13);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(264, 316);
			groupBox2.TabIndex = 6;
			groupBox2.TabStop = false;
			groupBox2.Text = "Chức năng";
			// 
			// btn_Reset
			// 
			btn_Reset.Location = new Point(89, 206);
			btn_Reset.Name = "btn_Reset";
			btn_Reset.Size = new Size(94, 29);
			btn_Reset.TabIndex = 12;
			btn_Reset.Text = "Reset";
			btn_Reset.UseVisualStyleBackColor = true;
			btn_Reset.Click += btn_Reset_Click;
			// 
			// btn_Xoa
			// 
			btn_Xoa.Location = new Point(89, 156);
			btn_Xoa.Name = "btn_Xoa";
			btn_Xoa.Size = new Size(94, 29);
			btn_Xoa.TabIndex = 11;
			btn_Xoa.Text = "Xóa";
			btn_Xoa.UseVisualStyleBackColor = true;
			btn_Xoa.Click += btn_Xoa_Click;
			// 
			// btn_Sua
			// 
			btn_Sua.Location = new Point(89, 102);
			btn_Sua.Name = "btn_Sua";
			btn_Sua.Size = new Size(94, 29);
			btn_Sua.TabIndex = 10;
			btn_Sua.Text = "Sửa";
			btn_Sua.UseVisualStyleBackColor = true;
			btn_Sua.Click += btn_Sua_Click;
			// 
			// btn_Them
			// 
			btn_Them.Location = new Point(89, 50);
			btn_Them.Name = "btn_Them";
			btn_Them.Size = new Size(94, 29);
			btn_Them.TabIndex = 9;
			btn_Them.Text = "Thêm";
			btn_Them.UseVisualStyleBackColor = true;
			btn_Them.Click += btn_Them_Click;
			// 
			// txt_TimKiem
			// 
			txt_TimKiem.Location = new Point(12, 342);
			txt_TimKiem.Name = "txt_TimKiem";
			txt_TimKiem.Size = new Size(300, 27);
			txt_TimKiem.TabIndex = 7;
			txt_TimKiem.Text = "Tìm kiếm...";
			txt_TimKiem.MouseClick += txt_TimKiem_MouseClick;
			txt_TimKiem.TextChanged += txt_TimKiem_TextChanged;
			txt_TimKiem.Leave += txt_TimKiem_Leave;
			// 
			// dgrid_KM
			// 
			dgrid_KM.BackgroundColor = Color.SeaShell;
			dgrid_KM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgrid_KM.Location = new Point(12, 375);
			dgrid_KM.Name = "dgrid_KM";
			dgrid_KM.RowHeadersWidth = 51;
			dgrid_KM.RowTemplate.Height = 29;
			dgrid_KM.Size = new Size(786, 155);
			dgrid_KM.TabIndex = 8;
			dgrid_KM.CellContentClick += dgrid_KM_CellContentClick;
			// 
			// FrmKhuyenMai
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 542);
			Controls.Add(dgrid_KM);
			Controls.Add(txt_TimKiem);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "FrmKhuyenMai";
			Text = "FrmKhuyenMai";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgrid_KM).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBox1;
		private DateTimePicker date2;
		private DateTimePicker date1;
		private TextBox txt_hinhthuc;
		private Label label6;
		private Label label4;
		private Label label5;
		private RadioButton rbtn_KHD;
		private RadioButton rbtn_HD;
		private TextBox txt_Ten;
		private TextBox txt_Ma;
		private Label label3;
		private Label label2;
		private Label label1;
		private GroupBox groupBox2;
		private Button btn_Reset;
		private Button btn_Xoa;
		private Button btn_Sua;
		private Button btn_Them;
		private TextBox txt_TimKiem;
		private DataGridView dgrid_KM;
	}
}