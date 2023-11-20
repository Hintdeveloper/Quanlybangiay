namespace _3_GUI.View
{
	partial class FrmQuenMatKhau
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
			txt_user = new TextBox();
			label4 = new Label();
			txt_gmail = new TextBox();
			label3 = new Label();
			txt_pass = new TextBox();
			label5 = new Label();
			txt_passnew = new TextBox();
			btn_XacNhan = new RJControls.RJButton();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(273, 20);
			label1.Name = "label1";
			label1.Size = new Size(184, 31);
			label1.TabIndex = 13;
			label1.Text = "ĐỔI MẬT KHẨU";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(181, 78);
			label2.Name = "label2";
			label2.Size = new Size(100, 25);
			label2.TabIndex = 14;
			label2.Text = "Username:";
			// 
			// txt_user
			// 
			txt_user.Location = new Point(352, 76);
			txt_user.Name = "txt_user";
			txt_user.Size = new Size(237, 27);
			txt_user.TabIndex = 19;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(187, 136);
			label4.Name = "label4";
			label4.Size = new Size(64, 25);
			label4.TabIndex = 20;
			label4.Text = "Gmail:";
			// 
			// txt_gmail
			// 
			txt_gmail.Location = new Point(352, 136);
			txt_gmail.Name = "txt_gmail";
			txt_gmail.Size = new Size(237, 27);
			txt_gmail.TabIndex = 21;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(187, 199);
			label3.Name = "label3";
			label3.Size = new Size(134, 25);
			label3.TabIndex = 22;
			label3.Text = "Password new:";
			// 
			// txt_pass
			// 
			txt_pass.Location = new Point(352, 200);
			txt_pass.Name = "txt_pass";
			txt_pass.Size = new Size(237, 27);
			txt_pass.TabIndex = 23;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(187, 261);
			label5.Name = "label5";
			label5.Size = new Size(163, 25);
			label5.TabIndex = 24;
			label5.Text = "Confirm password";
			// 
			// txt_passnew
			// 
			txt_passnew.Location = new Point(352, 262);
			txt_passnew.Name = "txt_passnew";
			txt_passnew.Size = new Size(237, 27);
			txt_passnew.TabIndex = 25;
			// 
			// btn_XacNhan
			// 
			btn_XacNhan.BackColor = Color.MediumSeaGreen;
			btn_XacNhan.FlatAppearance.BorderSize = 0;
			btn_XacNhan.FlatStyle = FlatStyle.Flat;
			btn_XacNhan.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			btn_XacNhan.ForeColor = Color.White;
			btn_XacNhan.Location = new Point(316, 317);
			btn_XacNhan.Name = "btn_XacNhan";
			btn_XacNhan.Size = new Size(184, 56);
			btn_XacNhan.TabIndex = 26;
			btn_XacNhan.Text = "Xác nhận";
			btn_XacNhan.UseVisualStyleBackColor = false;
			btn_XacNhan.Click += btn_XacNhan_Click;
			// 
			// FrmQuenMatKhau
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btn_XacNhan);
			Controls.Add(txt_passnew);
			Controls.Add(label5);
			Controls.Add(txt_pass);
			Controls.Add(label3);
			Controls.Add(txt_gmail);
			Controls.Add(label4);
			Controls.Add(txt_user);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "FrmQuenMatKhau";
			Text = "FrmQuenMatKhau";
			Load += FrmQuenMatKhau_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txt_user;
		private Label label4;
		private TextBox txt_gmail;
		private Label label3;
		private TextBox txt_pass;
		private Label label5;
		private TextBox txt_passnew;
		private RJControls.RJButton btn_XacNhan;
	}
}