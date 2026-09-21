using System;
using System.Drawing;
using System.Windows.Forms;

namespace BTChuong5_Section2
{
    public partial class FormMain : Form
    {
        private Label lblHeader = null!;
        private Label lblSubHeader = null!;
        private Button btnCau1 = null!;
        private Button btnCau2 = null!;
        private Button btnThoat = null!;
        private Label lblMoTaCau1 = null!;
        private Label lblMoTaCau2 = null!;

        public FormMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblHeader = new Label();
            this.lblSubHeader = new Label();
            this.btnCau1 = new Button();
            this.lblMoTaCau1 = new Label();
            this.btnCau2 = new Button();
            this.lblMoTaCau2 = new Label();
            this.btnThoat = new Button();
            this.SuspendLayout();

            // 
            // FormMain
            // 
            this.ClientSize = new Size(580, 420);
            this.Text = "Lập trình trực quan - Bài tập thực hành Chương 5 (Section 2)";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.BackColor = Color.FromArgb(246, 248, 251);

            // 
            // lblHeader
            // 
            this.lblHeader.Text = "BÀI TẬP THỰC HÀNH CHƯƠNG 5";
            this.lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblHeader.ForeColor = Color.FromArgb(20, 35, 60);
            this.lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            this.lblHeader.Location = new Point(20, 20);
            this.lblHeader.Size = new Size(540, 38);

            // 
            // lblSubHeader
            // 
            this.lblSubHeader.Text = "Section 2: Sự kiện Thiết bị Nhập liệu (Bàn phím & Chuột)";
            this.lblSubHeader.Font = new Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point);
            this.lblSubHeader.ForeColor = Color.FromArgb(80, 95, 115);
            this.lblSubHeader.TextAlign = ContentAlignment.MiddleCenter;
            this.lblSubHeader.Location = new Point(20, 58);
            this.lblSubHeader.Size = new Size(540, 28);

            // 
            // btnCau1
            // 
            this.btnCau1.Text = "1. Mở Câu 1: Form nhập liệu siêu thị";
            this.btnCau1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnCau1.BackColor = Color.FromArgb(13, 110, 253);
            this.btnCau1.ForeColor = Color.White;
            this.btnCau1.FlatStyle = FlatStyle.Flat;
            this.btnCau1.FlatAppearance.BorderSize = 0;
            this.btnCau1.Location = new Point(45, 105);
            this.btnCau1.Size = new Size(490, 45);
            this.btnCau1.Cursor = Cursors.Hand;
            this.btnCau1.Click += (s, e) => {
                FormBanHang frm = new FormBanHang();
                frm.ShowDialog(this);
            };

            // 
            // lblMoTaCau1
            // 
            this.lblMoTaCau1.Text = "Kiểm soát phím tắt (F2 thêm, F5 xóa trắng, ESC thoát) & lọc ký tự số KeyPress (txtSoLuong, txtDonGia), KeyPreview = true.";
            this.lblMoTaCau1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblMoTaCau1.ForeColor = Color.FromArgb(100, 110, 120);
            this.lblMoTaCau1.Location = new Point(50, 153);
            this.lblMoTaCau1.Size = new Size(480, 38);

            // 
            // btnCau2
            // 
            this.btnCau2.Text = "2. Mở Câu 2: Bảng vẽ mini";
            this.btnCau2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnCau2.BackColor = Color.FromArgb(25, 135, 84);
            this.btnCau2.ForeColor = Color.White;
            this.btnCau2.FlatStyle = FlatStyle.Flat;
            this.btnCau2.FlatAppearance.BorderSize = 0;
            this.btnCau2.Location = new Point(45, 205);
            this.btnCau2.Size = new Size(490, 45);
            this.btnCau2.Cursor = Cursors.Hand;
            this.btnCau2.Click += (s, e) => {
                FormBangVe frm = new FormBangVe();
                frm.ShowDialog(this);
            };

            // 
            // lblMoTaCau2
            // 
            this.lblMoTaCau2.Text = "Xử lý MouseDown, MouseMove, MouseUp để vẽ đường thẳng liên tục; MouseClick phải để xóa trắng; Label cập nhật tọa độ & trạng thái.";
            this.lblMoTaCau2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblMoTaCau2.ForeColor = Color.FromArgb(100, 110, 120);
            this.lblMoTaCau2.Location = new Point(50, 253);
            this.lblMoTaCau2.Size = new Size(480, 38);

            // 
            // btnThoat
            // 
            this.btnThoat.Text = "Thoát ứng dụng";
            this.btnThoat.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnThoat.BackColor = Color.FromArgb(220, 53, 69);
            this.btnThoat.ForeColor = Color.White;
            this.btnThoat.FlatStyle = FlatStyle.Flat;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Location = new Point(210, 320);
            this.btnThoat.Size = new Size(160, 38);
            this.btnThoat.Cursor = Cursors.Hand;
            this.btnThoat.Click += (s, e) => this.Close();

            // Add controls
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblSubHeader);
            this.Controls.Add(this.btnCau1);
            this.Controls.Add(this.lblMoTaCau1);
            this.Controls.Add(this.btnCau2);
            this.Controls.Add(this.lblMoTaCau2);
            this.Controls.Add(this.btnThoat);

            this.ResumeLayout(false);
        }
    }
}
