namespace ClinicManagement;

partial class frmBenhNhan
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        pnlInput = new Panel();
        btnLuuTam = new Button();
        txtTrieuChung = new TextBox();
        lblTrieuChung = new Label();
        numTuoi = new NumericUpDown();
        lblTuoi = new Label();
        txtHoTen = new TextBox();
        lblHoTen = new Label();
        lblTieuDe = new Label();
        grpDanhSach = new GroupBox();
        lstBenhNhan = new ListBox();
        pnlInput.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numTuoi).BeginInit();
        grpDanhSach.SuspendLayout();
        SuspendLayout();
        // 
        // pnlInput
        // 
        pnlInput.BackColor = Color.FromArgb(240, 248, 255);
        pnlInput.Controls.Add(btnLuuTam);
        pnlInput.Controls.Add(txtTrieuChung);
        pnlInput.Controls.Add(lblTrieuChung);
        pnlInput.Controls.Add(numTuoi);
        pnlInput.Controls.Add(lblTuoi);
        pnlInput.Controls.Add(txtHoTen);
        pnlInput.Controls.Add(lblHoTen);
        pnlInput.Controls.Add(lblTieuDe);
        pnlInput.Dock = DockStyle.Top;
        pnlInput.Location = new Point(0, 0);
        pnlInput.Name = "pnlInput";
        pnlInput.Size = new Size(484, 185);
        pnlInput.TabIndex = 0;
        // 
        // btnLuuTam
        // 
        btnLuuTam.BackColor = Color.Teal;
        btnLuuTam.Cursor = Cursors.Hand;
        btnLuuTam.FlatStyle = FlatStyle.Flat;
        btnLuuTam.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnLuuTam.ForeColor = Color.White;
        btnLuuTam.Location = new Point(120, 142);
        btnLuuTam.Name = "btnLuuTam";
        btnLuuTam.Size = new Size(130, 32);
        btnLuuTam.TabIndex = 7;
        btnLuuTam.Text = "Lưu tạm";
        btnLuuTam.UseVisualStyleBackColor = false;
        btnLuuTam.Click += btnLuuTam_Click;
        // 
        // txtTrieuChung
        // 
        txtTrieuChung.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtTrieuChung.Font = new Font("Segoe UI", 9.75F);
        txtTrieuChung.Location = new Point(120, 107);
        txtTrieuChung.Name = "txtTrieuChung";
        txtTrieuChung.PlaceholderText = "Mô tả triệu chứng (sốt, đau đầu, ho...)";
        txtTrieuChung.Size = new Size(345, 25);
        txtTrieuChung.TabIndex = 6;
        // 
        // lblTrieuChung
        // 
        lblTrieuChung.AutoSize = true;
        lblTrieuChung.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblTrieuChung.Location = new Point(16, 110);
        lblTrieuChung.Name = "lblTrieuChung";
        lblTrieuChung.Size = new Size(86, 17);
        lblTrieuChung.TabIndex = 5;
        lblTrieuChung.Text = "Triệu chứng:";
        // 
        // numTuoi
        // 
        numTuoi.Font = new Font("Segoe UI", 9.75F);
        numTuoi.Location = new Point(120, 72);
        numTuoi.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
        numTuoi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numTuoi.Name = "numTuoi";
        numTuoi.Size = new Size(80, 25);
        numTuoi.TabIndex = 4;
        numTuoi.Value = new decimal(new int[] { 25, 0, 0, 0 });
        // 
        // lblTuoi
        // 
        lblTuoi.AutoSize = true;
        lblTuoi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblTuoi.Location = new Point(16, 75);
        lblTuoi.Name = "lblTuoi";
        lblTuoi.Size = new Size(39, 17);
        lblTuoi.TabIndex = 3;
        lblTuoi.Text = "Tuổi:";
        // 
        // txtHoTen
        // 
        txtHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtHoTen.Font = new Font("Segoe UI", 9.75F);
        txtHoTen.Location = new Point(120, 37);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.PlaceholderText = "Nhập họ tên bệnh nhân...";
        txtHoTen.Size = new Size(345, 25);
        txtHoTen.TabIndex = 2;
        // 
        // lblHoTen
        // 
        lblHoTen.AutoSize = true;
        lblHoTen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblHoTen.Location = new Point(16, 40);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new Size(53, 17);
        lblHoTen.TabIndex = 1;
        lblHoTen.Text = "Họ tên:";
        // 
        // lblTieuDe
        // 
        lblTieuDe.AutoSize = true;
        lblTieuDe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTieuDe.ForeColor = Color.DarkCyan;
        lblTieuDe.Location = new Point(12, 9);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new Size(204, 21);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "NHẬP HỒ SƠ BỆNH NHÂN";
        // 
        // grpDanhSach
        // 
        grpDanhSach.Controls.Add(lstBenhNhan);
        grpDanhSach.Dock = DockStyle.Fill;
        grpDanhSach.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        grpDanhSach.Location = new Point(0, 185);
        grpDanhSach.Name = "grpDanhSach";
        grpDanhSach.Size = new Size(484, 186);
        grpDanhSach.TabIndex = 1;
        grpDanhSach.TabStop = false;
        grpDanhSach.Text = "Danh sách bệnh nhân trong phiên (Cửa sổ này)";
        // 
        // lstBenhNhan
        // 
        lstBenhNhan.Dock = DockStyle.Fill;
        lstBenhNhan.Font = new Font("Segoe UI", 9.75F);
        lstBenhNhan.FormattingEnabled = true;
        lstBenhNhan.ItemHeight = 17;
        lstBenhNhan.Location = new Point(3, 21);
        lstBenhNhan.Name = "lstBenhNhan";
        lstBenhNhan.Size = new Size(478, 162);
        lstBenhNhan.TabIndex = 0;
        // 
        // frmBenhNhan
        // 
        AcceptButton = btnLuuTam;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(484, 371);
        Controls.Add(grpDanhSach);
        Controls.Add(pnlInput);
        Name = "frmBenhNhan";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Thông tin bệnh nhân";
        pnlInput.ResumeLayout(false);
        pnlInput.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numTuoi).EndInit();
        grpDanhSach.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel pnlInput;
    private Label lblTieuDe;
    private Label lblHoTen;
    private TextBox txtHoTen;
    private Label lblTuoi;
    private NumericUpDown numTuoi;
    private Label lblTrieuChung;
    private TextBox txtTrieuChung;
    private Button btnLuuTam;
    private GroupBox grpDanhSach;
    private ListBox lstBenhNhan;
}
