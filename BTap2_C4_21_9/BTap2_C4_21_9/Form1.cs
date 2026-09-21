namespace BTap2_C4_21_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Configure ToolTip behavior
            // AutoPopDelay = 5000, InitialDelay = 500, ReshowDelay = 100, ShowAlways = true
            if (this.toolTip1 != null)
            {
                this.toolTip1.AutoPopDelay = 5000;
                this.toolTip1.InitialDelay = 500;
                this.toolTip1.ReshowDelay = 100;
                this.toolTip1.ShowAlways = true;
            }
        }

        private void btnDangKy_Click(object? sender, EventArgs e)
        {
            var hoTen = this.txtHoTen.Text.Trim();
            var sdt = this.txtSDT.Text.Trim();
            var email = this.txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Số điện thoại", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var goi = this.cboGoiTap.SelectedItem?.ToString() ?? string.Empty;
            var soBuoi = this.numSoBuoiTuan.Value;

            var msg = $"Họ tên: {hoTen}\nSĐT: {sdt}\nEmail: {email}\nGói tập: {goi}\nSố buổi/tuần: {soBuoi}";
            MessageBox.Show(msg, "Thông tin đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
