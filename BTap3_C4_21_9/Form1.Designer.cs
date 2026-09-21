namespace TodoList;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
        pnlTop = new Panel();
        lblHuongDan = new Label();
        btnThem = new Button();
        txtCongViecMoi = new TextBox();
        lblTieuDe = new Label();
        lstCongViec = new ListBox();
        cmsCongViec = new ContextMenuStrip(components);
        tsmiDanhDauHoanThanh = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        tsmiXoaCongViec = new ToolStripMenuItem();
        tsmiXoaTatCa = new ToolStripMenuItem();
        statusStrip1 = new StatusStrip();
        lblStatusTip = new ToolStripStatusLabel();
        pnlTop.SuspendLayout();
        cmsCongViec.SuspendLayout();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // pnlTop
        // 
        pnlTop.BackColor = Color.AliceBlue;
        pnlTop.Controls.Add(lblHuongDan);
        pnlTop.Controls.Add(btnThem);
        pnlTop.Controls.Add(txtCongViecMoi);
        pnlTop.Controls.Add(lblTieuDe);
        pnlTop.Dock = DockStyle.Top;
        pnlTop.Location = new Point(0, 0);
        pnlTop.Name = "pnlTop";
        pnlTop.Size = new Size(584, 110);
        pnlTop.TabIndex = 0;
        // 
        // lblHuongDan
        // 
        lblHuongDan.AutoSize = true;
        lblHuongDan.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
        lblHuongDan.ForeColor = Color.DarkSlateGray;
        lblHuongDan.Location = new Point(20, 85);
        lblHuongDan.Name = "lblHuongDan";
        lblHuongDan.Size = new Size(310, 15);
        lblHuongDan.TabIndex = 3;
        lblHuongDan.Text = "* Nhấp chuột phải lên từng dòng để mở Menu ngữ cảnh";
        // 
        // btnThem
        // 
        btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnThem.BackColor = Color.RoyalBlue;
        btnThem.Cursor = Cursors.Hand;
        btnThem.FlatStyle = FlatStyle.Flat;
        btnThem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnThem.ForeColor = Color.White;
        btnThem.Location = new Point(460, 48);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(105, 30);
        btnThem.TabIndex = 2;
        btnThem.Text = "+ Thêm";
        btnThem.UseVisualStyleBackColor = false;
        btnThem.Click += btnThem_Click;
        // 
        // txtCongViecMoi
        // 
        txtCongViecMoi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtCongViecMoi.Font = new Font("Segoe UI", 11F);
        txtCongViecMoi.Location = new Point(20, 50);
        txtCongViecMoi.Name = "txtCongViecMoi";
        txtCongViecMoi.PlaceholderText = "Nhập nội dung công việc cần làm rồi bấm Thêm...";
        txtCongViecMoi.Size = new Size(430, 27);
        txtCongViecMoi.TabIndex = 1;
        // 
        // lblTieuDe
        // 
        lblTieuDe.AutoSize = true;
        lblTieuDe.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTieuDe.ForeColor = Color.Navy;
        lblTieuDe.Location = new Point(16, 14);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new Size(318, 25);
        lblTieuDe.TabIndex = 0;
        lblTieuDe.Text = "DANH SÁCH VIỆC CẦN LÀM (TO-DO)";
        // 
        // lstCongViec
        // 
        lstCongViec.ContextMenuStrip = cmsCongViec;
        lstCongViec.Dock = DockStyle.Fill;
        lstCongViec.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lstCongViec.FormattingEnabled = true;
        lstCongViec.ItemHeight = 20;
        lstCongViec.Location = new Point(0, 110);
        lstCongViec.Name = "lstCongViec";
        lstCongViec.Size = new Size(584, 301);
        lstCongViec.TabIndex = 1;
        lstCongViec.MouseDown += lstCongViec_MouseDown;
        // 
        // cmsCongViec
        // 
        cmsCongViec.Items.AddRange(new ToolStripItem[] { tsmiDanhDauHoanThanh, toolStripSeparator1, tsmiXoaCongViec, tsmiXoaTatCa });
        cmsCongViec.Name = "cmsCongViec";
        cmsCongViec.Size = new Size(187, 76);
        // 
        // tsmiDanhDauHoanThanh
        // 
        tsmiDanhDauHoanThanh.Name = "tsmiDanhDauHoanThanh";
        tsmiDanhDauHoanThanh.Size = new Size(186, 22);
        tsmiDanhDauHoanThanh.Text = "Đánh dấu hoàn thành";
        tsmiDanhDauHoanThanh.Click += tsmiDanhDauHoanThanh_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(183, 6);
        // 
        // tsmiXoaCongViec
        // 
        tsmiXoaCongViec.Name = "tsmiXoaCongViec";
        tsmiXoaCongViec.Size = new Size(186, 22);
        tsmiXoaCongViec.Text = "Xóa công việc này";
        tsmiXoaCongViec.Click += tsmiXoaCongViec_Click;
        // 
        // tsmiXoaTatCa
        // 
        tsmiXoaTatCa.Name = "tsmiXoaTatCa";
        tsmiXoaTatCa.Size = new Size(186, 22);
        tsmiXoaTatCa.Text = "Xóa tất cả";
        tsmiXoaTatCa.Click += tsmiXoaTatCa_Click;
        // 
        // statusStrip1
        // 
        statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusTip });
        statusStrip1.Location = new Point(0, 411);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(584, 22);
        statusStrip1.TabIndex = 2;
        statusStrip1.Text = "statusStrip1";
        // 
        // lblStatusTip
        // 
        lblStatusTip.ForeColor = Color.Gray;
        lblStatusTip.Name = "lblStatusTip";
        lblStatusTip.Size = new Size(149, 17);
        lblStatusTip.Text = "Tổng số công việc: 0";
        // 
        // Form1
        // 
        AcceptButton = btnThem;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(584, 433);
        Controls.Add(lstCongViec);
        Controls.Add(statusStrip1);
        Controls.Add(pnlTop);
        MinimumSize = new Size(480, 360);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Danh sách việc cần làm hằng ngày (Daily To-Do List)";
        Load += Form1_Load;
        pnlTop.ResumeLayout(false);
        pnlTop.PerformLayout();
        cmsCongViec.ResumeLayout(false);
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel pnlTop;
    private Label lblTieuDe;
    private TextBox txtCongViecMoi;
    private Button btnThem;
    private Label lblHuongDan;
    private ListBox lstCongViec;
    private ContextMenuStrip cmsCongViec;
    private ToolStripMenuItem tsmiDanhDauHoanThanh;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem tsmiXoaCongViec;
    private ToolStripMenuItem tsmiXoaTatCa;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel lblStatusTip;
}
