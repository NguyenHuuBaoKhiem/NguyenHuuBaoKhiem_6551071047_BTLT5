namespace ClinicManagement;

partial class frmLichHen
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
        btnDatLich = new Button();
        txtTenBenhNhan = new TextBox();
        lblTenBenhNhan = new Label();
        dtpNgayGioHen = new DateTimePicker();
        lblNgayGioHen = new Label();
        lblTieuDe = new Label();
        grpDanhSach = new GroupBox();
        lstLichHen = new ListBox();
        pnlInput.SuspendLayout();
        grpDanhSach.SuspendLayout();
        SuspendLayout();
        // 
        // pnlInput
        // 
        pnlInput.BackColor = Color.FromArgb(245, 255, 250);
        pnlInput.Controls.Add(btnDatLich);
        pnlInput.Controls.Add(txtTenBenhNhan);
        pnlInput.Controls.Add(lblTenBenhNhan);
        pnlInput.Controls.Add(dtpNgayGioHen);
        pnlInput.Controls.Add(lblNgayGioHen);
        pnlInput.Controls.Add(lblTieuDe);
        pnlInput.Dock = DockStyle.Top;
        pnlInput.Location = new Point(0, 0);
        pnlInput.Name = "pnlInput";
        pnlInput.Size = new Size(484, 160);
        pnlInput.TabIndex = 0;
        // 
        // btnDatLich
        // 
        btnDatLich.BackColor = Color.ForestGreen;
        btnDatLich.Cursor = Cursors.Hand;
        btnDatLich.FlatStyle = FlatStyle.Flat;
        btnDatLich.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnDatLich.ForeColor = Color.White;
        btnDatLich.Location = new Point(130, 115);
        btnDatLich.Name = "btnDatLich";
        btnDatLich.Size = new Size(130, 32);
        btnDatLich.TabIndex = 5;
        btnDatLich.Text = "Đặt lịch";
        btnDatLich.UseVisualStyleBackColor = false;
        btnDatLich.Click += btnDatLich_Click;
        // 
        // txtTenBenhNhan
        // 
        txtTenBenhNhan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtTenBenhNhan.Font = new Font("Segoe UI", 9.75F);
        txtTenBenhNhan.Location = new Point(130, 75);
        txtTenBenhNhan.Name = "txtTenBenhNhan";
        txtTenBenhNhan.PlaceholderText = "Nhập tên bệnh nhân hẹn khám...";
        txtTenBenhNhan.Size = new Size(335, 25);
        txtTenBenhNhan.TabIndex = 4;
        // 
        // lblTenBenhNhan
        // 
        lblTenBenhNhan.AutoSize = true;
        lblTenBenhNhan.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblTenBenhNhan.Location = new Point(16, 78);
        lblTenBenhNhan.Name = "lblTenBenhNhan";
        lblTenBenhNhan.Size = new Size(103, 17);
        lblTenBenhNhan.TabIndex = 3;
        lblTenBenhNhan.Text = "Tên bệnh nhân:";
        // 
        // dtpNgayGioHen
        // 
        dtpNgayGioHen.CustomFormat = "dd/MM/yyyy HH:mm";
        dtpNgayGioHen.Font = new Font("Segoe UI", 9.75F);
        dtpNgayGioHen.Format = DateTimePickerFormat.Custom;
        dtpNgayGioHen.Location = new Point(130, 38);
        dtpNgayGioHen.Name = "dtpNgayGioHen";
        dtpNgayGioHen.Size = new Size(200, 25);
        dtpNgayGioHen.TabIndex = 2;
        // 
        // lblNgayGioHen
        // 
        lblNgayGioHen.AutoSize = true;
        lblNgayGioHen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        lblNgayGioHen.Location = new Point(16, 42);
        lblNgayGioHen.Name = "lblNgayGioHen";
        lblNgayGioHen.Size = new Size(93, 17);
        lblNgayGioHen.TabIndex = 1;
        lblNgayGioHen.Text = "Thời gian hẹn:";
        // 
        // lblTieuDe
        // 
        lblTieuDe.AutoSize = true;
        lblTieuDe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        lblTieuDe.ForeColor = Color.DarkGreen;
        lblTieuDe.Location = new Point(12, 9);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new Size(198, 21);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "ĐẶT LỊCH HẸN KHÁM BỆNH";
        // 
        // grpDanhSach
        // 
        grpDanhSach.Controls.Add(lstLichHen);
        grpDanhSach.Dock = DockStyle.Fill;
        grpDanhSach.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
        grpDanhSach.Location = new Point(0, 160);
        grpDanhSach.Name = "grpDanhSach";
        grpDanhSach.Size = new Size(484, 211);
        grpDanhSach.TabIndex = 1;
        grpDanhSach.TabStop = false;
        grpDanhSach.Text = "Danh sách lịch hẹn trong phiên (Cửa sổ này)";
        // 
        // lstLichHen
        // 
        lstLichHen.Dock = DockStyle.Fill;
        lstLichHen.Font = new Font("Segoe UI", 9.75F);
        lstLichHen.FormattingEnabled = true;
        lstLichHen.ItemHeight = 17;
        lstLichHen.Location = new Point(3, 21);
        lstLichHen.Name = "lstLichHen";
        lstLichHen.Size = new Size(478, 187);
        lstLichHen.TabIndex = 0;
        // 
        // frmLichHen
        // 
        AcceptButton = btnDatLich;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(484, 371);
        Controls.Add(grpDanhSach);
        Controls.Add(pnlInput);
        Name = "frmLichHen";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Đặt lịch hẹn";
        pnlInput.ResumeLayout(false);
        pnlInput.PerformLayout();
        grpDanhSach.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel pnlInput;
    private Label lblTieuDe;
    private Label lblNgayGioHen;
    private DateTimePicker dtpNgayGioHen;
    private Label lblTenBenhNhan;
    private TextBox txtTenBenhNhan;
    private Button btnDatLich;
    private GroupBox grpDanhSach;
    private ListBox lstLichHen;
}
