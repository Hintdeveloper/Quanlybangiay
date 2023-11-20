namespace _3_GUI.View
{
	partial class FrmLoai
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
			rbtn_KHD = new RadioButton();
			rbtn_HD = new RadioButton();
			txt_GhiChu = new RichTextBox();
			txt_Ten = new TextBox();
			txt_Ma = new TextBox();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			groupBox2 = new GroupBox();
			btn_Reset = new Button();
			btn_Xoa = new Button();
			btn_Sua = new Button();
			btn_Them = new Button();
			txt_TimKiem = new TextBox();
			dgrid_LoaiSanPham = new DataGridView();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgrid_LoaiSanPham).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(rbtn_KHD);
			groupBox1.Controls.Add(rbtn_HD);
			groupBox1.Controls.Add(txt_GhiChu);
			groupBox1.Controls.Add(txt_Ten);
			groupBox1.Controls.Add(txt_Ma);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox1.ForeColor = Color.Black;
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(536, 232);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			groupBox1.Text = "Loại sản phẩm";
			// 
			// rbtn_KHD
			// 
			rbtn_KHD.AutoSize = true;
			rbtn_KHD.Location = new Point(248, 126);
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
			rbtn_HD.Location = new Point(113, 126);
			rbtn_HD.Name = "rbtn_HD";
			rbtn_HD.Size = new Size(114, 27);
			rbtn_HD.TabIndex = 7;
			rbtn_HD.TabStop = true;
			rbtn_HD.Text = "Hoạt động";
			rbtn_HD.UseVisualStyleBackColor = true;
			// 
			// txt_GhiChu
			// 
			txt_GhiChu.Location = new Point(97, 172);
			txt_GhiChu.Name = "txt_GhiChu";
			txt_GhiChu.Size = new Size(256, 54);
			txt_GhiChu.TabIndex = 6;
			txt_GhiChu.Text = "";
			// 
			// txt_Ten
			// 
			txt_Ten.Location = new Point(79, 79);
			txt_Ten.Name = "txt_Ten";
			txt_Ten.Size = new Size(274, 30);
			txt_Ten.TabIndex = 5;
			txt_Ten.TextChanged += txt_Ten_TextChanged;
			// 
			// txt_Ma
			// 
			txt_Ma.Location = new Point(80, 30);
			txt_Ma.Name = "txt_Ma";
			txt_Ma.Size = new Size(273, 30);
			txt_Ma.TabIndex = 4;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 171);
			label4.Name = "label4";
			label4.Size = new Size(73, 23);
			label4.TabIndex = 3;
			label4.Text = "Ghi chú:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 126);
			label3.Name = "label3";
			label3.Size = new Size(91, 23);
			label3.TabIndex = 2;
			label3.Text = "Trạng thái:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 37);
			label2.Name = "label2";
			label2.Size = new Size(39, 23);
			label2.TabIndex = 1;
			label2.Text = "Mã:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 83);
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
			groupBox2.Location = new Point(563, 12);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(264, 232);
			groupBox2.TabIndex = 6;
			groupBox2.TabStop = false;
			groupBox2.Text = "Chức năng";
			// 
			// btn_Reset
			// 
			btn_Reset.Location = new Point(61, 168);
			btn_Reset.Name = "btn_Reset";
			btn_Reset.Size = new Size(94, 29);
			btn_Reset.TabIndex = 3;
			btn_Reset.Text = "Reset";
			btn_Reset.UseVisualStyleBackColor = true;
			btn_Reset.Click += btn_Reset_Click;
			// 
			// btn_Xoa
			// 
			btn_Xoa.Location = new Point(61, 120);
			btn_Xoa.Name = "btn_Xoa";
			btn_Xoa.Size = new Size(94, 29);
			btn_Xoa.TabIndex = 2;
			btn_Xoa.Text = "Xóa";
			btn_Xoa.UseVisualStyleBackColor = true;
			btn_Xoa.Click += btn_Xoa_Click;
			// 
			// btn_Sua
			// 
			btn_Sua.Location = new Point(61, 77);
			btn_Sua.Name = "btn_Sua";
			btn_Sua.Size = new Size(94, 29);
			btn_Sua.TabIndex = 1;
			btn_Sua.Text = "Sửa";
			btn_Sua.UseVisualStyleBackColor = true;
			btn_Sua.Click += btn_Sua_Click;
			// 
			// btn_Them
			// 
			btn_Them.Location = new Point(61, 29);
			btn_Them.Name = "btn_Them";
			btn_Them.Size = new Size(94, 29);
			btn_Them.TabIndex = 0;
			btn_Them.Text = "Thêm";
			btn_Them.UseVisualStyleBackColor = true;
			btn_Them.Click += btn_Them_Click;
			// 
			// txt_TimKiem
			// 
			txt_TimKiem.Location = new Point(12, 250);
			txt_TimKiem.Name = "txt_TimKiem";
			txt_TimKiem.Size = new Size(300, 27);
			txt_TimKiem.TabIndex = 7;
			txt_TimKiem.Text = "Tìm kiếm...";
			txt_TimKiem.MouseClick += txt_TimKiem_MouseClick;
			txt_TimKiem.TextChanged += txt_TimKiem_TextChanged;
			txt_TimKiem.Leave += txt_TimKiem_Leave;
			// 
			// dgrid_LoaiSanPham
			// 
			dgrid_LoaiSanPham.BackgroundColor = Color.SeaShell;
			dgrid_LoaiSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgrid_LoaiSanPham.Location = new Point(12, 283);
			dgrid_LoaiSanPham.Name = "dgrid_LoaiSanPham";
			dgrid_LoaiSanPham.RowHeadersWidth = 51;
			dgrid_LoaiSanPham.RowTemplate.Height = 29;
			dgrid_LoaiSanPham.Size = new Size(805, 155);
			dgrid_LoaiSanPham.TabIndex = 8;
			dgrid_LoaiSanPham.CellContentClick += dgrid_LoaiSanPham_CellContentClick;
			// 
			// FrmLoai
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dgrid_LoaiSanPham);
			Controls.Add(txt_TimKiem);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "FrmLoai";
			Text = "FrmLoai";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgrid_LoaiSanPham).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private GroupBox groupBox1;
		private RadioButton rbtn_KHD;
		private RadioButton rbtn_HD;
		private RichTextBox txt_GhiChu;
		private TextBox txt_Ten;
		private TextBox txt_Ma;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private GroupBox groupBox2;
		private Button btn_Reset;
		private Button btn_Xoa;
		private Button btn_Sua;
		private Button btn_Them;
		private TextBox txt_TimKiem;
		private DataGridView dgrid_LoaiSanPham;
	}
}