namespace ClinicManagement;

partial class frmParent
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
        menuStrip1 = new MenuStrip();
        mnuNghiepVu = new ToolStripMenuItem();
        mnuThongTinBenhNhan = new ToolStripMenuItem();
        mnuDatLichHen = new ToolStripMenuItem();
        mnuCuaSo = new ToolStripMenuItem();
        mnuSapXep = new ToolStripMenuItem();
        mnuCascade = new ToolStripMenuItem();
        mnuTileHorizontal = new ToolStripMenuItem();
        mnuTileVertical = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        mnuDongTatCa = new ToolStripMenuItem();
        mnuThoat = new ToolStripMenuItem();
        statusStrip1 = new StatusStrip();
        lblStatus = new ToolStripStatusLabel();
        menuStrip1.SuspendLayout();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { mnuNghiepVu, mnuCuaSo, mnuSapXep, mnuThoat });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.MdiWindowListItem = mnuCuaSo;
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(884, 24);
        menuStrip1.TabIndex = 1;
        menuStrip1.Text = "menuStrip1";
        // 
        // mnuNghiepVu
        // 
        mnuNghiepVu.DropDownItems.AddRange(new ToolStripItem[] { mnuThongTinBenhNhan, mnuDatLichHen });
        mnuNghiepVu.Name = "mnuNghiepVu";
        mnuNghiepVu.Size = new Size(74, 20);
        mnuNghiepVu.Text = "&Nghiệp vụ";
        // 
        // mnuThongTinBenhNhan
        // 
        mnuThongTinBenhNhan.Name = "mnuThongTinBenhNhan";
        mnuThongTinBenhNhan.Size = new Size(185, 22);
        mnuThongTinBenhNhan.Text = "Thông tin &bệnh nhân";
        mnuThongTinBenhNhan.Click += mnuThongTinBenhNhan_Click;
        // 
        // mnuDatLichHen
        // 
        mnuDatLichHen.Name = "mnuDatLichHen";
        mnuDatLichHen.Size = new Size(185, 22);
        mnuDatLichHen.Text = "&Đặt lịch hẹn";
        mnuDatLichHen.Click += mnuDatLichHen_Click;
        // 
        // mnuCuaSo
        // 
        mnuCuaSo.Name = "mnuCuaSo";
        mnuCuaSo.Size = new Size(59, 20);
        mnuCuaSo.Text = "&Cửa sổ";
        // 
        // mnuSapXep
        // 
        mnuSapXep.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuTileHorizontal, mnuTileVertical, toolStripSeparator1, mnuDongTatCa });
        mnuSapXep.Name = "mnuSapXep";
        mnuSapXep.Size = new Size(60, 20);
        mnuSapXep.Text = "&Sắp xếp";
        // 
        // mnuCascade
        // 
        mnuCascade.Name = "mnuCascade";
        mnuCascade.Size = new Size(198, 22);
        mnuCascade.Text = "Xếp chồng (Cascade)";
        mnuCascade.Click += mnuCascade_Click;
        // 
        // mnuTileHorizontal
        // 
        mnuTileHorizontal.Name = "mnuTileHorizontal";
        mnuTileHorizontal.Size = new Size(198, 22);
        mnuTileHorizontal.Text = "Xếp ngang (Horizontal)";
        mnuTileHorizontal.Click += mnuTileHorizontal_Click;
        // 
        // mnuTileVertical
        // 
        mnuTileVertical.Name = "mnuTileVertical";
        mnuTileVertical.Size = new Size(198, 22);
        mnuTileVertical.Text = "Xếp dọc (Vertical)";
        mnuTileVertical.Click += mnuTileVertical_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(195, 6);
        // 
        // mnuDongTatCa
        // 
        mnuDongTatCa.Name = "mnuDongTatCa";
        mnuDongTatCa.Size = new Size(198, 22);
        mnuDongTatCa.Text = "Đóng tất cả cửa sổ con";
        mnuDongTatCa.Click += mnuDongTatCa_Click;
        // 
        // mnuThoat
        // 
        mnuThoat.Name = "mnuThoat";
        mnuThoat.Size = new Size(49, 20);
        mnuThoat.Text = "&Thoát";
        mnuThoat.Click += mnuThoat_Click;
        // 
        // statusStrip1
        // 
        statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
        statusStrip1.Location = new Point(0, 539);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(884, 22);
        statusStrip1.TabIndex = 2;
        statusStrip1.Text = "statusStrip1";
        // 
        // lblStatus
        // 
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(330, 17);
        lblStatus.Text = "Hệ thống quản lý phòng khám mini - MDI Clinic Management";
        // 
        // frmParent
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(884, 561);
        Controls.Add(statusStrip1);
        Controls.Add(menuStrip1);
        IsMdiContainer = true;
        MainMenuStrip = menuStrip1;
        Name = "frmParent";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Phần mềm quản lý phòng khám mini (MDI)";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem mnuNghiepVu;
    private ToolStripMenuItem mnuThongTinBenhNhan;
    private ToolStripMenuItem mnuDatLichHen;
    private ToolStripMenuItem mnuCuaSo;
    private ToolStripMenuItem mnuSapXep;
    private ToolStripMenuItem mnuCascade;
    private ToolStripMenuItem mnuTileHorizontal;
    private ToolStripMenuItem mnuTileVertical;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem mnuDongTatCa;
    private ToolStripMenuItem mnuThoat;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel lblStatus;
}
