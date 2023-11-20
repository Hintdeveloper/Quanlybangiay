namespace _3_GUI.View
{
	partial class FrmThongTinHoaDon
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			lb_ma = new Label();
			label4 = new Label();
			lb_tennv = new Label();
			label5 = new Label();
			lb_tenkh = new Label();
			label6 = new Label();
			lb_thanhtien = new Label();
			btn_in = new RJControls.RJButton();
			dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(100, 22);
			label1.Name = "label1";
			label1.Size = new Size(279, 46);
			label1.TabIndex = 1;
			label1.Text = "Cửa Hàng HN";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(187, 79);
			label2.Name = "label2";
			label2.Size = new Size(132, 32);
			label2.TabIndex = 2;
			label2.Text = "Hóa Đơn";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(100, 133);
			label3.Name = "label3";
			label3.Size = new Size(108, 23);
			label3.TabIndex = 3;
			label3.Text = "Mã hóa đơn:";
			// 
			// lb_ma
			// 
			lb_ma.AutoSize = true;
			lb_ma.ForeColor = Color.Black;
			lb_ma.Location = new Point(336, 133);
			lb_ma.Name = "lb_ma";
			lb_ma.Size = new Size(72, 20);
			lb_ma.TabIndex = 7;
			lb_ma.Text = "Thông tin";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = Color.Black;
			label4.Location = new Point(100, 180);
			label4.Name = "label4";
			label4.Size = new Size(121, 23);
			label4.TabIndex = 8;
			label4.Text = "Tên nhân viên:";
			// 
			// lb_tennv
			// 
			lb_tennv.AutoSize = true;
			lb_tennv.ForeColor = Color.Black;
			lb_tennv.Location = new Point(336, 183);
			lb_tennv.Name = "lb_tennv";
			lb_tennv.Size = new Size(72, 20);
			lb_tennv.TabIndex = 9;
			lb_tennv.Text = "Thông tin";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			label5.ForeColor = Color.Black;
			label5.Location = new Point(100, 230);
			label5.Name = "label5";
			label5.Size = new Size(135, 23);
			label5.TabIndex = 10;
			label5.Text = "Tên khách hàng:";
			// 
			// lb_tenkh
			// 
			lb_tenkh.AutoSize = true;
			lb_tenkh.ForeColor = Color.Black;
			lb_tenkh.Location = new Point(336, 233);
			lb_tenkh.Name = "lb_tenkh";
			lb_tenkh.Size = new Size(72, 20);
			lb_tenkh.TabIndex = 11;
			lb_tenkh.Text = "Thông tin";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			label6.ForeColor = Color.Black;
			label6.Location = new Point(100, 274);
			label6.Name = "label6";
			label6.Size = new Size(96, 23);
			label6.TabIndex = 12;
			label6.Text = "Thành tiền:";
			// 
			// lb_thanhtien
			// 
			lb_thanhtien.AutoSize = true;
			lb_thanhtien.ForeColor = Color.Black;
			lb_thanhtien.Location = new Point(336, 277);
			lb_thanhtien.Name = "lb_thanhtien";
			lb_thanhtien.Size = new Size(72, 20);
			lb_thanhtien.TabIndex = 13;
			lb_thanhtien.Text = "Thông tin";
			// 
			// btn_in
			// 
			btn_in.BackColor = Color.MediumSeaGreen;
			btn_in.FlatAppearance.BorderSize = 0;
			btn_in.FlatStyle = FlatStyle.Flat;
			btn_in.ForeColor = Color.White;
			btn_in.Location = new Point(198, 312);
			btn_in.Margin = new Padding(3, 4, 3, 4);
			btn_in.Name = "btn_in";
			btn_in.Size = new Size(137, 40);
			btn_in.TabIndex = 14;
			btn_in.Text = "In Hóa Đơn";
			btn_in.UseVisualStyleBackColor = false;
			btn_in.Click += btn_in_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Bottom;
			dataGridView1.Location = new Point(0, 361);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(535, 164);
			dataGridView1.TabIndex = 15;
			// 
			// FrmThongTinHoaDon
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(535, 525);
			Controls.Add(dataGridView1);
			Controls.Add(btn_in);
			Controls.Add(lb_thanhtien);
			Controls.Add(label6);
			Controls.Add(lb_tenkh);
			Controls.Add(label5);
			Controls.Add(lb_tennv);
			Controls.Add(label4);
			Controls.Add(lb_ma);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "FrmThongTinHoaDon";
			Text = "FrmThongTinHoaDon";
			Load += FrmThongTinHoaDon_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label lb_ma;
		private Label label4;
		private Label lb_tennv;
		private Label label5;
		private Label lb_tenkh;
		private Label label6;
		private Label lb_thanhtien;
		private RJControls.RJButton btn_in;
		private DataGridView dataGridView1;
	}
}