namespace ClinicManagement;

public partial class frmParent : Form
{
    private int countBenhNhan = 0;
    private int countLichHen = 0;

    public frmParent()
    {
        InitializeComponent();
    }

    private void mnuThongTinBenhNhan_Click(object sender, EventArgs e)
    {
        // Mỗi lần bấm luôn tạo một đối tượng frmBenhNhan HOÀN TOÀN MỚI
        countBenhNhan++;
        frmBenhNhan formBenhNhan = new frmBenhNhan();
        formBenhNhan.MdiParent = this;
        formBenhNhan.Text = $"Thông tin bệnh nhân #{countBenhNhan}";
        formBenhNhan.Show();
    }

    private void mnuDatLichHen_Click(object sender, EventArgs e)
    {
        // Mỗi lần bấm luôn tạo một đối tượng frmLichHen HOÀN TOÀN MỚI
        countLichHen++;
        frmLichHen formLichHen = new frmLichHen();
        formLichHen.MdiParent = this;
        formLichHen.Text = $"Đặt lịch hẹn #{countLichHen}";
        formLichHen.Show();
    }

    private void mnuCascade_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.Cascade);
    }

    private void mnuTileHorizontal_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void mnuTileVertical_Click(object sender, EventArgs e)
    {
        LayoutMdi(MdiLayout.TileVertical);
    }

    private void mnuDongTatCa_Click(object sender, EventArgs e)
    {
        foreach (Form child in MdiChildren)
        {
            child.Close();
        }
    }

    private void mnuThoat_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn thoát phần mềm quản lý phòng khám?",
            "Xác nhận thoát",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result == DialogResult.Yes)
        {
            Application.Exit();
        }
    }
}
