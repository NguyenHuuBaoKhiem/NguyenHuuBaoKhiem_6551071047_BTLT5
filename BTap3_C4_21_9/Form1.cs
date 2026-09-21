namespace TodoList;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // Thêm một số công việc mẫu ban đầu
        lstCongViec.Items.Add("Ôn tập kiến thức WinForms C#");
        lstCongViec.Items.Add("Làm bài tập thực hành Chương 4");
        lstCongViec.Items.Add("Tập gym 45 phút vào buổi chiều");
        CapNhatSoLuong();
    }

    private void CapNhatSoLuong()
    {
        lblStatusTip.Text = $"Tổng số công việc: {lstCongViec.Items.Count}";
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
        string congViec = txtCongViecMoi.Text.Trim();
        if (!string.IsNullOrWhiteSpace(congViec))
        {
            lstCongViec.Items.Add(congViec);
            txtCongViecMoi.Clear();
            txtCongViecMoi.Focus();
            CapNhatSoLuong();
        }
        else
        {
            MessageBox.Show(
                "Vui lòng nhập nội dung công việc cần thêm!",
                "Nhắc nhở",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            txtCongViecMoi.Focus();
        }
    }

    private void lstCongViec_MouseDown(object sender, MouseEventArgs e)
    {
        // Khi nhấp chuột phải, tự động chọn dòng tại vị trí con trỏ chuột
        if (e.Button == MouseButtons.Right)
        {
            int index = lstCongViec.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                lstCongViec.SelectedIndex = index;
            }
        }
    }

    private void tsmiDanhDauHoanThanh_Click(object sender, EventArgs e)
    {
        if (lstCongViec.SelectedItem != null)
        {
            int index = lstCongViec.SelectedIndex;
            string currentText = lstCongViec.SelectedItem.ToString() ?? "";
            const string prefix = "[Hoàn thành] ";

            if (!currentText.StartsWith(prefix))
            {
                lstCongViec.Items[index] = prefix + currentText;
                lstCongViec.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show(
                    "Công việc này đã được đánh dấu hoàn thành trước đó!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
        else
        {
            MessageBox.Show(
                "Vui lòng chọn một công việc để đánh dấu hoàn thành!",
                "Nhắc nhở",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }

    private void tsmiXoaCongViec_Click(object sender, EventArgs e)
    {
        if (lstCongViec.SelectedItem != null && lstCongViec.SelectedIndex != -1)
        {
            lstCongViec.Items.RemoveAt(lstCongViec.SelectedIndex);
            CapNhatSoLuong();
        }
        else
        {
            MessageBox.Show(
                "Vui lòng chọn một công việc trước khi xóa!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }

    private void tsmiXoaTatCa_Click(object sender, EventArgs e)
    {
        if (lstCongViec.Items.Count == 0)
        {
            MessageBox.Show(
                "Danh sách hiện tại đang trống!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            return;
        }

        DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn xóa tất cả công việc trong danh sách?",
            "Xác nhận xóa tất cả",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result == DialogResult.Yes)
        {
            lstCongViec.Items.Clear();
            CapNhatSoLuong();
        }
    }
}
