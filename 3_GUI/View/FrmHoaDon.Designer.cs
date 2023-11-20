namespace _3_GUI.View
{
	partial class FrmHoaDon
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDon));
			groupBox1 = new GroupBox();
			btn_Xoa = new RJControls.RJButton();
			btn_TimKiem = new RJControls.RJButton();
			tb_timkiem = new TextBox();
			dtg_hd = new DataGridView();
			groupBox2 = new GroupBox();
			dtg_hdct = new DataGridView();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dtg_hd).BeginInit();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dtg_hdct).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btn_Xoa);
			groupBox1.Controls.Add(btn_TimKiem);
			groupBox1.Controls.Add(tb_timkiem);
			groupBox1.Controls.Add(dtg_hd);
			groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox1.Location = new Point(12, 12);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1117, 303);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			groupBox1.Text = "Hóa đơn";
			// 
			// btn_Xoa
			// 
			btn_Xoa.BackColor = Color.MediumSeaGreen;
			btn_Xoa.FlatAppearance.BorderSize = 0;
			btn_Xoa.FlatStyle = FlatStyle.Flat;
			btn_Xoa.ForeColor = Color.White;
			btn_Xoa.Image = (Image)resources.GetObject("btn_Xoa.Image");
			btn_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
			btn_Xoa.Location = new Point(435, 32);
			btn_Xoa.Name = "btn_Xoa";
			btn_Xoa.Size = new Size(150, 37);
			btn_Xoa.TabIndex = 3;
			btn_Xoa.Text = "Xóa";
			btn_Xoa.UseVisualStyleBackColor = false;
			btn_Xoa.Click += btn_Xoa_Click;
			// 
			// btn_TimKiem
			// 
			btn_TimKiem.BackColor = Color.MediumSeaGreen;
			btn_TimKiem.FlatAppearance.BorderSize = 0;
			btn_TimKiem.FlatStyle = FlatStyle.Flat;
			btn_TimKiem.ForeColor = Color.White;
			btn_TimKiem.Image = (Image)resources.GetObject("btn_TimKiem.Image");
			btn_TimKiem.ImageAlign = ContentAlignment.MiddleLeft;
			btn_TimKiem.Location = new Point(279, 33);
			btn_TimKiem.Name = "btn_TimKiem";
			btn_TimKiem.Size = new Size(150, 37);
			btn_TimKiem.TabIndex = 2;
			btn_TimKiem.Text = "Tìm kiếm";
			btn_TimKiem.UseVisualStyleBackColor = false;
			btn_TimKiem.Click += btn_TimKiem_Click;
			// 
			// tb_timkiem
			// 
			tb_timkiem.Location = new Point(0, 36);
			tb_timkiem.Name = "tb_timkiem";
			tb_timkiem.Size = new Size(273, 34);
			tb_timkiem.TabIndex = 1;
			// 
			// dtg_hd
			// 
			dtg_hd.BackgroundColor = Color.SeaShell;
			dtg_hd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtg_hd.Location = new Point(0, 80);
			dtg_hd.Name = "dtg_hd";
			dtg_hd.RowHeadersWidth = 51;
			dtg_hd.RowTemplate.Height = 29;
			dtg_hd.Size = new Size(1103, 217);
			dtg_hd.TabIndex = 0;
			dtg_hd.CellClick += dtg_hd_CellClick;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(dtg_hdct);
			groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox2.Location = new Point(12, 321);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(1117, 306);
			groupBox2.TabIndex = 4;
			groupBox2.TabStop = false;
			groupBox2.Text = "Hóa đơn chi tiết";
			// 
			// dtg_hdct
			// 
			dtg_hdct.BackgroundColor = Color.SeaShell;
			dtg_hdct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtg_hdct.Location = new Point(7, 35);
			dtg_hdct.Name = "dtg_hdct";
			dtg_hdct.RowHeadersWidth = 51;
			dtg_hdct.RowTemplate.Height = 29;
			dtg_hdct.Size = new Size(1096, 220);
			dtg_hdct.TabIndex = 0;
			// 
			// FrmHoaDon
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1177, 621);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "FrmHoaDon";
			Text = "FrmHoaDon";
			Load += FrmHoaDon_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dtg_hd).EndInit();
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dtg_hdct).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private RJControls.RJButton btn_Xoa;
		private RJControls.RJButton btn_TimKiem;
		private TextBox tb_timkiem;
		private DataGridView dtg_hd;
		private GroupBox groupBox2;
		private DataGridView dtg_hdct;
	}
}