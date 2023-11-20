namespace _3_GUI.View
{
	partial class FrmTimKiemTaiKhoan
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
			tb_gmail = new TextBox();
			btn_guima = new RJControls.RJButton();
			tb_ma = new TextBox();
			btn_xn = new RJControls.RJButton();
			SuspendLayout();
			// 
			// tb_gmail
			// 
			tb_gmail.Location = new Point(100, 48);
			tb_gmail.Margin = new Padding(3, 4, 3, 4);
			tb_gmail.Name = "tb_gmail";
			tb_gmail.PlaceholderText = "Nhập gmail đã đăng kí tài khoản";
			tb_gmail.Size = new Size(478, 27);
			tb_gmail.TabIndex = 5;
			tb_gmail.UseWaitCursor = true;
			// 
			// btn_guima
			// 
			btn_guima.BackColor = Color.MediumSeaGreen;
			btn_guima.FlatAppearance.BorderSize = 0;
			btn_guima.FlatStyle = FlatStyle.Flat;
			btn_guima.ForeColor = Color.White;
			btn_guima.Location = new Point(100, 110);
			btn_guima.Margin = new Padding(3, 4, 3, 4);
			btn_guima.Name = "btn_guima";
			btn_guima.Size = new Size(137, 40);
			btn_guima.TabIndex = 8;
			btn_guima.Text = "Gửi mã xác thực";
			btn_guima.UseVisualStyleBackColor = false;
			btn_guima.UseWaitCursor = true;
			btn_guima.Click += btn_guima_Click;
			// 
			// tb_ma
			// 
			tb_ma.Location = new Point(263, 117);
			tb_ma.Margin = new Padding(3, 4, 3, 4);
			tb_ma.Name = "tb_ma";
			tb_ma.Size = new Size(190, 27);
			tb_ma.TabIndex = 9;
			tb_ma.UseWaitCursor = true;
			// 
			// btn_xn
			// 
			btn_xn.BackColor = Color.MediumSeaGreen;
			btn_xn.FlatAppearance.BorderSize = 0;
			btn_xn.FlatStyle = FlatStyle.Flat;
			btn_xn.ForeColor = Color.White;
			btn_xn.Location = new Point(288, 200);
			btn_xn.Margin = new Padding(3, 4, 3, 4);
			btn_xn.Name = "btn_xn";
			btn_xn.Size = new Size(137, 40);
			btn_xn.TabIndex = 10;
			btn_xn.Text = "Xác nhận";
			btn_xn.UseVisualStyleBackColor = false;
			btn_xn.UseWaitCursor = true;
			btn_xn.Click += btn_xn_Click;
			// 
			// FrmTimKiemTaiKhoan
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btn_xn);
			Controls.Add(tb_ma);
			Controls.Add(btn_guima);
			Controls.Add(tb_gmail);
			Name = "FrmTimKiemTaiKhoan";
			Text = "FrmTimKiemTaiKhoan";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tb_gmail;
		private RJControls.RJButton btn_guima;
		private TextBox tb_ma;
		private RJControls.RJButton btn_xn;
	}
}