namespace ClinicManagement;

public partial class frmLichHen : Form
{
    // Biến thành viên lưu danh sách lịch hẹn của riêng cửa sổ này, không dùng CSDL
    private List<string> dsLichHen = new List<string>();

    public frmLichHen()
    {
        InitializeComponent();
    }

    private void btnDatLich_Click(object sender, EventArgs e)
    {
        string tenBenhNhan = txtTenBenhNhan.Text.Trim();
        if (string.IsNullOrWhiteSpace(tenBenhNhan))
        {
            MessageBox.Show(
                "Vui lòng nhập tên bệnh nhân đặt lịch!",
                "Cảnh báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            txtTenBenhNhan.Focus();
            return;
        }

        string thoiGian = dtpNgayGioHen.Value.ToString("dd/MM/yyyy HH:mm");
        string record = $"[Hẹn lúc {thoiGian}] Bệnh nhân: {tenBenhNhan}";

        // Lưu vào danh sách nội bộ và hiển thị lên ListBox
        dsLichHen.Add(record);
        lstLichHen.Items.Add(record);

        // Đặt lại ô nhập
        txtTenBenhNhan.Clear();
        txtTenBenhNhan.Focus();
    }
}
