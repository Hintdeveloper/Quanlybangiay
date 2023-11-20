namespace _3_GUI.View
{
	partial class FrmKhachHang
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
			rd_khachquen = new RadioButton();
			rd_khachvanglai = new RadioButton();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			tb_point = new TextBox();
			tb_sdt = new TextBox();
			tb_hoten = new TextBox();
			groupBox2 = new GroupBox();
			btn_clear = new Button();
			btn_xoa = new Button();
			btn_sua = new Button();
			btn_them = new Button();
			txt_TimKiem = new TextBox();
			dtg_show = new DataGridView();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dtg_show).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(rd_khachquen);
			groupBox1.Controls.Add(rd_khachvanglai);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(tb_point);
			groupBox1.Controls.Add(tb_sdt);
			groupBox1.Controls.Add(tb_hoten);
			groupBox1.Location = new Point(12, 13);
			groupBox1.Margin = new Padding(3, 4, 3, 4);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(3, 4, 3, 4);
			groupBox1.Size = new Size(440, 285);
			groupBox1.TabIndex = 12;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin khách hàng";
			// 
			// rd_khachquen
			// 
			rd_khachquen.AutoSize = true;
			rd_khachquen.Location = new Point(291, 234);
			rd_khachquen.Margin = new Padding(3, 4, 3, 4);
			rd_khachquen.Name = "rd_khachquen";
			rd_khachquen.Size = new Size(107, 24);
			rd_khachquen.TabIndex = 9;
			rd_khachquen.TabStop = true;
			rd_khachquen.Text = "Khách quen";
			rd_khachquen.UseVisualStyleBackColor = true;
			// 
			// rd_khachvanglai
			// 
			rd_khachvanglai.AutoSize = true;
			rd_khachvanglai.Location = new Point(142, 234);
			rd_khachvanglai.Margin = new Padding(3, 4, 3, 4);
			rd_khachvanglai.Name = "rd_khachvanglai";
			rd_khachvanglai.Size = new Size(126, 24);
			rd_khachvanglai.TabIndex = 8;
			rd_khachvanglai.TabStop = true;
			rd_khachvanglai.Text = "Khách vãng lai";
			rd_khachvanglai.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(7, 239);
			label4.Name = "label4";
			label4.Size = new Size(75, 20);
			label4.TabIndex = 7;
			label4.Text = "Trạng thái";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(7, 122);
			label3.Name = "label3";
			label3.Size = new Size(97, 20);
			label3.TabIndex = 6;
			label3.Text = "Số điện thoại";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(7, 181);
			label2.Name = "label2";
			label2.Size = new Size(42, 20);
			label2.TabIndex = 5;
			label2.Text = "Point";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(7, 63);
			label1.Name = "label1";
			label1.Size = new Size(73, 20);
			label1.TabIndex = 4;
			label1.Text = "Họ và tên";
			// 
			// tb_point
			// 
			tb_point.Location = new Point(142, 168);
			tb_point.Margin = new Padding(3, 4, 3, 4);
			tb_point.Name = "tb_point";
			tb_point.Size = new Size(257, 27);
			tb_point.TabIndex = 2;
			// 
			// tb_sdt
			// 
			tb_sdt.Location = new Point(142, 109);
			tb_sdt.Margin = new Padding(3, 4, 3, 4);
			tb_sdt.Name = "tb_sdt";
			tb_sdt.Size = new Size(257, 27);
			tb_sdt.TabIndex = 1;
			// 
			// tb_hoten
			// 
			tb_hoten.Location = new Point(142, 51);
			tb_hoten.Margin = new Padding(3, 4, 3, 4);
			tb_hoten.Name = "tb_hoten";
			tb_hoten.Size = new Size(257, 27);
			tb_hoten.TabIndex = 0;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btn_clear);
			groupBox2.Controls.Add(btn_xoa);
			groupBox2.Controls.Add(btn_sua);
			groupBox2.Controls.Add(btn_them);
			groupBox2.Location = new Point(472, 13);
			groupBox2.Margin = new Padding(3, 4, 3, 4);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new Padding(3, 4, 3, 4);
			groupBox2.Size = new Size(229, 317);
			groupBox2.TabIndex = 15;
			groupBox2.TabStop = false;
			groupBox2.Text = "Chức năng";
			// 
			// btn_clear
			// 
			btn_clear.Location = new Point(36, 205);
			btn_clear.Name = "btn_clear";
			btn_clear.Size = new Size(152, 29);
			btn_clear.TabIndex = 21;
			btn_clear.Text = "Clear";
			btn_clear.UseVisualStyleBackColor = true;
			btn_clear.Click += btn_clear_Click;
			// 
			// btn_xoa
			// 
			btn_xoa.Location = new Point(36, 144);
			btn_xoa.Name = "btn_xoa";
			btn_xoa.Size = new Size(152, 29);
			btn_xoa.TabIndex = 20;
			btn_xoa.Text = "Xóa khách hàng";
			btn_xoa.UseVisualStyleBackColor = true;
			btn_xoa.Click += btn_xoa_Click;
			// 
			// btn_sua
			// 
			btn_sua.Location = new Point(36, 92);
			btn_sua.Name = "btn_sua";
			btn_sua.Size = new Size(152, 29);
			btn_sua.TabIndex = 19;
			btn_sua.Text = "Sửa khách hàng";
			btn_sua.UseVisualStyleBackColor = true;
			btn_sua.Click += btn_sua_Click;
			// 
			// btn_them
			// 
			btn_them.Location = new Point(36, 36);
			btn_them.Name = "btn_them";
			btn_them.Size = new Size(152, 29);
			btn_them.TabIndex = 18;
			btn_them.Text = "Thêm khách hàng";
			btn_them.UseVisualStyleBackColor = true;
			btn_them.Click += btn_them_Click;
			// 
			// txt_TimKiem
			// 
			txt_TimKiem.Location = new Point(12, 344);
			txt_TimKiem.Name = "txt_TimKiem";
			txt_TimKiem.Size = new Size(438, 27);
			txt_TimKiem.TabIndex = 16;
			txt_TimKiem.TextChanged += txt_TimKiem_TextChanged;
			// 
			// dtg_show
			// 
			dtg_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtg_show.Location = new Point(12, 385);
			dtg_show.Margin = new Padding(3, 4, 3, 4);
			dtg_show.Name = "dtg_show";
			dtg_show.RowHeadersWidth = 51;
			dtg_show.RowTemplate.Height = 25;
			dtg_show.Size = new Size(675, 163);
			dtg_show.TabIndex = 17;
			dtg_show.CellClick += dtg_show_CellClick;
			// 
			// FrmKhachHang
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 561);
			Controls.Add(dtg_show);
			Controls.Add(txt_TimKiem);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "FrmKhachHang";
			Text = "FrmKhachHang";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dtg_show).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBox1;
		private RadioButton rd_khachquen;
		private RadioButton rd_khachvanglai;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private TextBox tb_point;
		private TextBox tb_sdt;
		private TextBox tb_hoten;
		private GroupBox groupBox2;
		private Button btn_clear;
		private Button btn_xoa;
		private Button btn_sua;
		private Button btn_them;
		private TextBox txt_TimKiem;
		private DataGridView dtg_show;
	}
}