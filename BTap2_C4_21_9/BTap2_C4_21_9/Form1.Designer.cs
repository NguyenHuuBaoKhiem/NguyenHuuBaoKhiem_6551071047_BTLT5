namespace BTap2_C4_21_9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboGoiTap;
        private System.Windows.Forms.NumericUpDown numSoBuoiTuan;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.ToolTip toolTip1;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboGoiTap = new System.Windows.Forms.ComboBox();
            this.numSoBuoiTuan = new System.Windows.Forms.NumericUpDown();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            // 
            // Form
            // 
            this.SuspendLayout();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 280);
            this.Text = "Đăng ký hội viên FitLife";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(140, 20);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(250, 23);
            this.txtHoTen.TabIndex = 0;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(140, 55);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(250, 23);
            this.txtSDT.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(140, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(140, 125);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(250, 23);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // cboGoiTap
            // 
            this.cboGoiTap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGoiTap.FormattingEnabled = true;
            this.cboGoiTap.Items.AddRange(new object[] { "Basic", "VIP", "Premium" });
            this.cboGoiTap.Location = new System.Drawing.Point(140, 160);
            this.cboGoiTap.Name = "cboGoiTap";
            this.cboGoiTap.Size = new System.Drawing.Size(150, 23);
            this.cboGoiTap.TabIndex = 4;
            this.cboGoiTap.SelectedIndex = 0;
            // 
            // numSoBuoiTuan
            // 
            this.numSoBuoiTuan.Location = new System.Drawing.Point(140, 195);
            this.numSoBuoiTuan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoBuoiTuan.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            this.numSoBuoiTuan.Value = new decimal(new int[] { 3, 0, 0, 0 });
            this.numSoBuoiTuan.Name = "numSoBuoiTuan";
            this.numSoBuoiTuan.Size = new System.Drawing.Size(60, 23);
            this.numSoBuoiTuan.TabIndex = 5;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(140, 230);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(100, 30);
            this.btnDangKy.TabIndex = 6;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // ToolTip texts (set here so they appear in designer-equivalent)
            // 
            this.toolTip1.SetToolTip(this.txtHoTen, "Nhập họ tên đầy đủ");
            this.toolTip1.SetToolTip(this.txtSDT, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
            this.toolTip1.SetToolTip(this.txtEmail, "Email dùng để nhận thông báo lịch tập và khuyến mãi");
            this.toolTip1.SetToolTip(this.dtpNgaySinh, "Chọn ngày sinh");
            this.toolTip1.SetToolTip(this.cboGoiTap, "Gói VIP và Premium có kèm huấn luyện viên riêng");
            this.toolTip1.SetToolTip(this.numSoBuoiTuan, "Số buổi tập mỗi tuần (1-7)");

            // Labels (lightweight, added inline)
            var lblHoTen = new System.Windows.Forms.Label();
            lblHoTen.Location = new System.Drawing.Point(20, 22);
            lblHoTen.Size = new System.Drawing.Size(100, 20);
            lblHoTen.Text = "Họ tên:";
            var lblSDT = new System.Windows.Forms.Label();
            lblSDT.Location = new System.Drawing.Point(20, 57);
            lblSDT.Size = new System.Drawing.Size(100, 20);
            lblSDT.Text = "Số ĐT:";
            var lblEmail = new System.Windows.Forms.Label();
            lblEmail.Location = new System.Drawing.Point(20, 92);
            lblEmail.Size = new System.Drawing.Size(100, 20);
            lblEmail.Text = "Email:";
            var lblNgaySinh = new System.Windows.Forms.Label();
            lblNgaySinh.Location = new System.Drawing.Point(20, 127);
            lblNgaySinh.Size = new System.Drawing.Size(100, 20);
            lblNgaySinh.Text = "Ngày sinh:";
            var lblGoiTap = new System.Windows.Forms.Label();
            lblGoiTap.Location = new System.Drawing.Point(20, 162);
            lblGoiTap.Size = new System.Drawing.Size(100, 20);
            lblGoiTap.Text = "Gói tập:";
            var lblSoBuoi = new System.Windows.Forms.Label();
            lblSoBuoi.Location = new System.Drawing.Point(20, 197);
            lblSoBuoi.Size = new System.Drawing.Size(120, 20);
            lblSoBuoi.Text = "Số buổi/tuần:";

            // Add controls to form
            this.Controls.Add(lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(lblSDT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(lblNgaySinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(lblGoiTap);
            this.Controls.Add(this.cboGoiTap);
            this.Controls.Add(lblSoBuoi);
            this.Controls.Add(this.numSoBuoiTuan);
            this.Controls.Add(this.btnDangKy);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
