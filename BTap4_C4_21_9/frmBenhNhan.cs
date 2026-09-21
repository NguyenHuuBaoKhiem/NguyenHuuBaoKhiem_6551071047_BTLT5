namespace ClinicManagement;

public partial class frmBenhNhan : Form
{
    // Biến thành viên lưu danh sách bệnh nhân của riêng cửa sổ này, không dùng CSDL
    private List<string> dsBenhNhan = new List<string>();

    public frmBenhNhan()
    {
        InitializeComponent();
    }

    private void btnLuuTam_Click(object sender, EventArgs e)
    {
        string hoTen = txtHoTen.Text.Trim();
        if (string.IsNullOrWhiteSpace(hoTen))
        {
            MessageBox.Show(
                "Vui lòng nhập họ tên bệnh nhân!",
                "Cảnh báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            txtHoTen.Focus();
            return;
        }

        int tuoi = (int)numTuoi.Value;
        string trieuChung = string.IsNullOrWhiteSpace(txtTrieuChung.Text) ? "Không có" : txtTrieuChung.Text.Trim();

        string record = $"{hoTen} - {tuoi} tuổi - Triệu chứng: {trieuChung}";

        // Lưu vào danh sách nội bộ và hiển thị lên ListBox
        dsBenhNhan.Add(record);
        lstBenhNhan.Items.Add(record);

        // Đặt lại ô nhập
        txtHoTen.Clear();
        numTuoi.Value = 25;
        txtTrieuChung.Clear();
        txtHoTen.Focus();
    }
}
