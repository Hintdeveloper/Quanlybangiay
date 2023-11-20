namespace _3_GUI.View
{
    partial class FrmSanPham
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
            dgrid_SP = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_SP).BeginInit();
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
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(670, 290);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm";
            // 
            // rbtn_KHD
            // 
            rbtn_KHD.AutoSize = true;
            rbtn_KHD.Location = new Point(311, 159);
            rbtn_KHD.Margin = new Padding(4);
            rbtn_KHD.Name = "rbtn_KHD";
            rbtn_KHD.Size = new Size(208, 34);
            rbtn_KHD.TabIndex = 8;
            rbtn_KHD.TabStop = true;
            rbtn_KHD.Text = "Không hoạt động";
            rbtn_KHD.UseVisualStyleBackColor = true;
            // 
            // rbtn_HD
            // 
            rbtn_HD.AutoSize = true;
            rbtn_HD.Location = new Point(142, 159);
            rbtn_HD.Margin = new Padding(4);
            rbtn_HD.Name = "rbtn_HD";
            rbtn_HD.Size = new Size(142, 34);
            rbtn_HD.TabIndex = 7;
            rbtn_HD.TabStop = true;
            rbtn_HD.Text = "Hoạt động";
            rbtn_HD.UseVisualStyleBackColor = true;
            // 
            // txt_GhiChu
            // 
            txt_GhiChu.Location = new Point(121, 215);
            txt_GhiChu.Margin = new Padding(4);
            txt_GhiChu.Name = "txt_GhiChu";
            txt_GhiChu.Size = new Size(319, 66);
            txt_GhiChu.TabIndex = 6;
            txt_GhiChu.Text = "";
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(99, 99);
            txt_Ten.Margin = new Padding(4);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(342, 35);
            txt_Ten.TabIndex = 5;
            txt_Ten.TextChanged += txt_Ten_TextChanged;
            // 
            // txt_Ma
            // 
            txt_Ma.Location = new Point(100, 38);
            txt_Ma.Margin = new Padding(4);
            txt_Ma.Name = "txt_Ma";
            txt_Ma.Size = new Size(340, 35);
            txt_Ma.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 215);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 30);
            label4.TabIndex = 3;
            label4.Text = "Ghi chú:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 159);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 30);
            label3.TabIndex = 2;
            label3.Text = "Trạng thái:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 30);
            label2.TabIndex = 1;
            label2.Text = "Mã:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 105);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 30);
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
            groupBox2.Location = new Point(691, 13);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(330, 290);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(109, 211);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(112, 34);
            btn_Reset.TabIndex = 3;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(109, 155);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(112, 34);
            btn_Xoa.TabIndex = 2;
            btn_Xoa.Text = "Xoá";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(109, 99);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(112, 34);
            btn_Sua.TabIndex = 1;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(109, 47);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(112, 34);
            btn_Them.TabIndex = 0;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(13, 311);
            txt_TimKiem.Margin = new Padding(4);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(374, 31);
            txt_TimKiem.TabIndex = 7;
            txt_TimKiem.Text = "Tìm kiếm...";
            txt_TimKiem.MouseClick += txt_TimKiem_MouseClick;
            txt_TimKiem.TextChanged += txt_TimKiem_TextChanged;
            txt_TimKiem.Leave += txt_TimKiem_Leave;
            // 
            // dgrid_SP
            // 
            dgrid_SP.BackgroundColor = Color.SeaShell;
            dgrid_SP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrid_SP.Location = new Point(15, 350);
            dgrid_SP.Margin = new Padding(4);
            dgrid_SP.Name = "dgrid_SP";
            dgrid_SP.RowHeadersWidth = 51;
            dgrid_SP.RowTemplate.Height = 29;
            dgrid_SP.Size = new Size(1006, 194);
            dgrid_SP.TabIndex = 8;
            dgrid_SP.CellClick += dgrid_SP_CellClick;
            // 
            // FrmSanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 563);
            Controls.Add(dgrid_SP);
            Controls.Add(txt_TimKiem);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmSanPham";
            Text = "FrmSanPham";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrid_SP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public GroupBox groupBox1;
        public RadioButton rbtn_KHD;
        public RadioButton rbtn_HD;
        public RichTextBox txt_GhiChu;
        public TextBox txt_Ten;
        public TextBox txt_Ma;
        public Label label4;
        public Label label3;
        public Label label2;
        public Label label1;
        public GroupBox groupBox2;
        public Button btn_Reset;
        public Button btn_Xoa;
        public Button btn_Sua;
        public Button btn_Them;
        public TextBox txt_TimKiem;
        public DataGridView dgrid_SP;
    }
}