using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTChuong5_Section2
{
    public partial class FormBanHang : Form
    {
        private Label lblTieuDe = null!;
        private Label lblMaSP = null!;
        private TextBox txtMaSP = null!;
        private Label lblSoLuong = null!;
        private TextBox txtSoLuong = null!;
        private Label lblDonGia = null!;
        private TextBox txtDonGia = null!;
        private Button btnThem = null!;
        private Button btnXoaTrang = null!;
        private Label lblDanhSach = null!;
        private ListBox lstKetQua = null!;
        private Label lblHuongDan = null!;

        public FormBanHang()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTieuDe = new Label();
            this.lblMaSP = new Label();
            this.txtMaSP = new TextBox();
            this.lblSoLuong = new Label();
            this.txtSoLuong = new TextBox();
            this.lblDonGia = new Label();
            this.txtDonGia = new TextBox();
            this.btnThem = new Button();
            this.btnXoaTrang = new Button();
            this.lblDanhSach = new Label();
            this.lstKetQua = new ListBox();
            this.lblHuongDan = new Label();
            this.SuspendLayout();

            // 
            // FormBanHang
            // 
            this.ClientSize = new Size(620, 520);
            this.Text = "Câu 1: Quản lý bán hàng siêu thị mini";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.BackColor = Color.FromArgb(245, 247, 250);

            // 6. Bật KeyPreview = true trên Form để bắt phím tắt hoạt động ngay cả khi TextBox đang focus
            this.KeyPreview = true;
            this.KeyDown += FormBanHang_KeyDown;

            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Text = "NHẬP LIỆU BÁN HÀNG SIÊU THỊ MINI";
            this.lblTieuDe.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTieuDe.ForeColor = Color.FromArgb(24, 43, 73);
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTieuDe.Location = new Point(20, 15);
            this.lblTieuDe.Size = new Size(580, 40);

            // 
            // lblMaSP
            // 
            this.lblMaSP.Text = "Mã sản phẩm:";
            this.lblMaSP.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblMaSP.Location = new Point(40, 75);
            this.lblMaSP.Size = new Size(130, 25);

            // 
            // txtMaSP
            // 
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Location = new Point(175, 72);
            this.txtMaSP.Size = new Size(405, 29);

            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Text = "Số lượng (chỉ số):";
            this.lblSoLuong.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblSoLuong.Location = new Point(40, 120);
            this.lblSoLuong.Size = new Size(130, 25);

            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Location = new Point(175, 117);
            this.txtSoLuong.Size = new Size(405, 29);
            // 2. txtSoLuong: chỉ cho phép nhập chữ số (0–9) và phím Backspace — dùng sự kiện KeyPress + e.Handled
            this.txtSoLuong.KeyPress += TxtSoLuongVaDonGia_KeyPress;

            // 
            // lblDonGia
            // 
            this.lblDonGia.Text = "Đơn giá (chỉ số):";
            this.lblDonGia.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblDonGia.Location = new Point(40, 165);
            this.lblDonGia.Size = new Size(130, 25);

            // 
            // txtDonGia
            // 
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Location = new Point(175, 162);
            this.txtDonGia.Size = new Size(405, 29);
            // 2. txtDonGia: chỉ cho phép nhập chữ số (0–9) và phím Backspace — dùng sự kiện KeyPress + e.Handled
            this.txtDonGia.KeyPress += TxtSoLuongVaDonGia_KeyPress;

            // 
            // btnThem
            // 
            this.btnThem.Name = "btnThem";
            this.btnThem.Text = "Thêm (F2)";
            this.btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnThem.BackColor = Color.FromArgb(0, 122, 255);
            this.btnThem.ForeColor = Color.White;
            this.btnThem.FlatStyle = FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Location = new Point(175, 207);
            this.btnThem.Size = new Size(195, 38);
            this.btnThem.Cursor = Cursors.Hand;
            this.btnThem.Click += BtnThem_Click;

            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Text = "Xóa trắng (F5)";
            this.btnXoaTrang.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnXoaTrang.BackColor = Color.FromArgb(108, 117, 125);
            this.btnXoaTrang.ForeColor = Color.White;
            this.btnXoaTrang.FlatStyle = FlatStyle.Flat;
            this.btnXoaTrang.FlatAppearance.BorderSize = 0;
            this.btnXoaTrang.Location = new Point(385, 207);
            this.btnXoaTrang.Size = new Size(195, 38);
            this.btnXoaTrang.Cursor = Cursors.Hand;
            this.btnXoaTrang.Click += BtnXoaTrang_Click;

            // 
            // lblDanhSach
            // 
            this.lblDanhSach.Text = "Danh sách sản phẩm đã nhập (MaSP | SoLuong | DonGia):";
            this.lblDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblDanhSach.Location = new Point(40, 260);
            this.lblDanhSach.Size = new Size(540, 25);

            // 
            // lstKetQua
            // 
            this.lstKetQua.Name = "lstKetQua";
            this.lstKetQua.Font = new Font("Consolas", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.lstKetQua.ItemHeight = 20;
            this.lstKetQua.Location = new Point(40, 290);
            this.lstKetQua.Size = new Size(540, 164);

            // 
            // lblHuongDan
            // 
            this.lblHuongDan.Text = "Phím tắt: [F2] Thêm vào danh sách  |  [F5] Xóa trắng các ô  |  [Escape] Thoát";
            this.lblHuongDan.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            this.lblHuongDan.ForeColor = Color.FromArgb(70, 80, 95);
            this.lblHuongDan.TextAlign = ContentAlignment.MiddleCenter;
            this.lblHuongDan.Location = new Point(20, 468);
            this.lblHuongDan.Size = new Size(580, 30);

            // Add Controls
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.lstKetQua);
            this.Controls.Add(this.lblHuongDan);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        /// <summary>
        /// Yêu cầu 2: txtSoLuong và txtDonGia: chỉ cho phép nhập chữ số (0–9) và phím Backspace — dùng sự kiện KeyPress + e.Handled.
        /// </summary>
        private void TxtSoLuongVaDonGia_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Cho phép phím số (0-9) và phím Backspace (mã ASCII 8)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Chặn ký tự không hợp lệ không cho xuất hiện trong TextBox
            }
        }

        /// <summary>
        /// Yêu cầu 3 & Kết quả mong đợi: Nhấn F2 hoặc bấm btnThem -> thêm dòng vào ListBox với định dạng: "MaSP | SoLuong | DonGia"
        /// </summary>
        private void BtnThem_Click(object? sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            string soLuong = txtSoLuong.Text.Trim();
            string donGia = txtDonGia.Text.Trim();

            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Vui lòng nhập Mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSP.Focus();
                return;
            }

            if (string.IsNullOrEmpty(soLuong))
            {
                MessageBox.Show("Vui lòng nhập Số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            if (string.IsNullOrEmpty(donGia))
            {
                MessageBox.Show("Vui lòng nhập Đơn giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            // Định dạng: "MaSP | SoLuong | DonGia"
            string dongMoi = $"{maSP} | {soLuong} | {donGia}";
            lstKetQua.Items.Add(dongMoi);

            // Xóa trắng và focus về txtMaSP để sẵn sàng nhập mặt hàng tiếp theo
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtMaSP.Focus();
        }

        /// <summary>
        /// Yêu cầu 4: Nhấn F5 hoặc bấm btnXoaTrang -> xóa trắng toàn bộ 3 TextBox và focus về txtMaSP.
        /// </summary>
        private void BtnXoaTrang_Click(object? sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtMaSP.Focus();
        }

        /// <summary>
        /// Yêu cầu 3, 4, 5: Bắt phím tắt F2, F5, Escape trên toàn form (KeyPreview = true)
        /// </summary>
        private void FormBanHang_KeyDown(object? sender, KeyEventArgs e)
        {
            // 3. Nhấn F2 từ bất kỳ đâu trên form -> kích hoạt btnThem
            if (e.KeyCode == Keys.F2)
            {
                btnThem.PerformClick();
                e.Handled = true;
            }
            // 4. Nhấn F5 -> xóa trắng toàn bộ 3 TextBox và focus về txtMaSP
            else if (e.KeyCode == Keys.F5)
            {
                btnXoaTrang.PerformClick();
                e.Handled = true;
            }
            // 5. Nhấn Escape -> hỏi xác nhận "Bạn có muốn thoát?" trước khi đóng form
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn thoát?",
                    "Xác nhận thoát",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }

                e.Handled = true;
            }
        }
    }
}
