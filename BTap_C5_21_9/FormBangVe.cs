using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BTChuong5_Section2
{
    public partial class FormBangVe : Form
    {
        private Panel pnlCanvas = null!;
        private Label lblViTri = null!;
        private Panel pnlBottomBar = null!;
        private Panel pnlTopBar = null!;
        private Label lblHuongDan = null!;
        private Button btnXoaBang = null!;
        private Label lblChonMau = null!;
        private Button btnMauDen = null!;
        private Button btnMauDo = null!;
        private Button btnMauXanhDuong = null!;
        private Button btnMauXanhLa = null!;

        // Biến phục vụ vẽ
        private bool isDrawing = false;
        private Point lastPoint = Point.Empty;
        private Bitmap? canvasBitmap;
        private Graphics? canvasGraphics;
        private Color penColor = Color.Black;
        private float penWidth = 3.0f;

        public FormBangVe()
        {
            InitializeComponent();
            InitCanvasBitmap();
        }

        private void InitializeComponent()
        {
            this.pnlTopBar = new Panel();
            this.lblHuongDan = new Label();
            this.lblChonMau = new Label();
            this.btnMauDen = new Button();
            this.btnMauDo = new Button();
            this.btnMauXanhDuong = new Button();
            this.btnMauXanhLa = new Button();
            this.btnXoaBang = new Button();

            this.pnlBottomBar = new Panel();
            this.lblViTri = new Label();

            this.pnlCanvas = new DoubleBufferedPanel();

            this.pnlTopBar.SuspendLayout();
            this.pnlBottomBar.SuspendLayout();
            this.SuspendLayout();

            // 
            // FormBangVe
            // 
            this.ClientSize = new Size(820, 580);
            this.Text = "Câu 2: Bảng vẽ mini – MouseDown, MouseMove, MouseUp & Click phải";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.BackColor = Color.FromArgb(240, 242, 245);

            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Dock = DockStyle.Top;
            this.pnlTopBar.Height = 55;
            this.pnlTopBar.BackColor = Color.FromArgb(232, 237, 245);
            this.pnlTopBar.Padding = new Padding(10, 8, 10, 8);

            // lblHuongDan
            this.lblHuongDan.Text = "Chuột trái + kéo: Vẽ  |  Chuột phải: Xóa trắng";
            this.lblHuongDan.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblHuongDan.ForeColor = Color.FromArgb(30, 50, 80);
            this.lblHuongDan.Location = new Point(12, 16);
            this.lblHuongDan.AutoSize = true;

            // lblChonMau
            this.lblChonMau.Text = "Màu vẽ:";
            this.lblChonMau.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblChonMau.Location = new Point(340, 16);
            this.lblChonMau.AutoSize = true;

            // Nút chọn màu Đen
            this.btnMauDen.Text = "";
            this.btnMauDen.BackColor = Color.Black;
            this.btnMauDen.FlatStyle = FlatStyle.Flat;
            this.btnMauDen.Location = new Point(400, 14);
            this.btnMauDen.Size = new Size(26, 26);
            this.btnMauDen.Cursor = Cursors.Hand;
            this.btnMauDen.Click += (s, e) => penColor = Color.Black;

            // Nút chọn màu Đỏ
            this.btnMauDo.Text = "";
            this.btnMauDo.BackColor = Color.FromArgb(220, 53, 69);
            this.btnMauDo.FlatStyle = FlatStyle.Flat;
            this.btnMauDo.Location = new Point(435, 14);
            this.btnMauDo.Size = new Size(26, 26);
            this.btnMauDo.Cursor = Cursors.Hand;
            this.btnMauDo.Click += (s, e) => penColor = Color.FromArgb(220, 53, 69);

            // Nút chọn màu Xanh dương
            this.btnMauXanhDuong.Text = "";
            this.btnMauXanhDuong.BackColor = Color.FromArgb(0, 122, 255);
            this.btnMauXanhDuong.FlatStyle = FlatStyle.Flat;
            this.btnMauXanhDuong.Location = new Point(470, 14);
            this.btnMauXanhDuong.Size = new Size(26, 26);
            this.btnMauXanhDuong.Cursor = Cursors.Hand;
            this.btnMauXanhDuong.Click += (s, e) => penColor = Color.FromArgb(0, 122, 255);

            // Nút chọn màu Xanh lá
            this.btnMauXanhLa.Text = "";
            this.btnMauXanhLa.BackColor = Color.FromArgb(40, 167, 69);
            this.btnMauXanhLa.FlatStyle = FlatStyle.Flat;
            this.btnMauXanhLa.Location = new Point(505, 14);
            this.btnMauXanhLa.Size = new Size(26, 26);
            this.btnMauXanhLa.Cursor = Cursors.Hand;
            this.btnMauXanhLa.Click += (s, e) => penColor = Color.FromArgb(40, 167, 69);

            // btnXoaBang
            this.btnXoaBang.Text = "Xóa bảng (Click phải)";
            this.btnXoaBang.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnXoaBang.BackColor = Color.FromArgb(108, 117, 125);
            this.btnXoaBang.ForeColor = Color.White;
            this.btnXoaBang.FlatStyle = FlatStyle.Flat;
            this.btnXoaBang.FlatAppearance.BorderSize = 0;
            this.btnXoaBang.Location = new Point(620, 11);
            this.btnXoaBang.Size = new Size(170, 32);
            this.btnXoaBang.Cursor = Cursors.Hand;
            this.btnXoaBang.Click += (s, e) => XoaTrangBangVe();

            this.pnlTopBar.Controls.Add(this.lblHuongDan);
            this.pnlTopBar.Controls.Add(this.lblChonMau);
            this.pnlTopBar.Controls.Add(this.btnMauDen);
            this.pnlTopBar.Controls.Add(this.btnMauDo);
            this.pnlTopBar.Controls.Add(this.btnMauXanhDuong);
            this.pnlTopBar.Controls.Add(this.btnMauXanhLa);
            this.pnlTopBar.Controls.Add(this.btnXoaBang);

            // 
            // pnlBottomBar & lblViTri
            // 
            this.pnlBottomBar.Dock = DockStyle.Bottom;
            this.pnlBottomBar.Height = 35;
            this.pnlBottomBar.BackColor = Color.FromArgb(235, 238, 242);
            this.pnlBottomBar.BorderStyle = BorderStyle.FixedSingle;

            // 1 & 3: Label lblViTri luôn hiện tọa độ chuột hiện tại và trạng thái
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Text = "Tọa độ: (X: 0, Y: 0) | Trạng thái: Sẵn sàng";
            this.lblViTri.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblViTri.ForeColor = Color.FromArgb(40, 50, 70);
            this.lblViTri.Location = new Point(10, 5);
            this.lblViTri.AutoSize = true;

            this.pnlBottomBar.Controls.Add(this.lblViTri);

            // 
            // pnlCanvas (Panel lớn, nền trắng)
            // 
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Dock = DockStyle.Fill;
            this.pnlCanvas.BackColor = Color.White;
            this.pnlCanvas.Cursor = Cursors.Cross;
            this.pnlCanvas.BorderStyle = BorderStyle.Fixed3D;

            // Đăng ký các sự kiện chuột theo đúng yêu cầu đề bài:
            // 2. MouseDown để đánh dấu bắt đầu
            this.pnlCanvas.MouseDown += PnlCanvas_MouseDown;
            // 2. MouseMove để vẽ khi đang giữ chuột
            // 3. Label lblViTri luôn hiện tọa độ X, Y của con trỏ chuột dù có vẽ hay không
            this.pnlCanvas.MouseMove += PnlCanvas_MouseMove;
            // 2. MouseUp để kết thúc nét
            this.pnlCanvas.MouseUp += PnlCanvas_MouseUp;
            // 4. Nhấn chuột phải (MouseClick với Button == Right) -> xóa trắng Panel (Invalidate)
            this.pnlCanvas.MouseClick += PnlCanvas_MouseClick;

            // Xử lý vẽ đệm tránh mất nét khi thu phóng hoặc chuyển cửa sổ
            this.pnlCanvas.Paint += PnlCanvas_Paint;
            this.pnlCanvas.Resize += PnlCanvas_Resize;

            // Add to Form
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.pnlBottomBar);
            this.Controls.Add(this.pnlTopBar);

            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlBottomBar.ResumeLayout(false);
            this.pnlBottomBar.PerformLayout();
            this.ResumeLayout(false);
        }

        private void InitCanvasBitmap()
        {
            int w = Math.Max(pnlCanvas.Width, 1920);
            int h = Math.Max(pnlCanvas.Height, 1080);

            Bitmap newBitmap = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                g.Clear(Color.White);
                if (canvasBitmap != null)
                {
                    g.DrawImage(canvasBitmap, Point.Empty);
                }
            }

            canvasBitmap?.Dispose();
            canvasGraphics?.Dispose();

            canvasBitmap = newBitmap;
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.SmoothingMode = SmoothingMode.AntiAlias;
        }

        private void PnlCanvas_Resize(object? sender, EventArgs e)
        {
            if (pnlCanvas.Width > (canvasBitmap?.Width ?? 0) || pnlCanvas.Height > (canvasBitmap?.Height ?? 0))
            {
                InitCanvasBitmap();
                pnlCanvas.Invalidate();
            }
        }

        private void PnlCanvas_Paint(object? sender, PaintEventArgs e)
        {
            if (canvasBitmap != null)
            {
                e.Graphics.DrawImage(canvasBitmap, Point.Empty);
            }
        }

        /// <summary>
        /// Yêu cầu 2: Khi giữ chuột trái và kéo -> dùng MouseDown để đánh dấu bắt đầu
        /// Yêu cầu 5: Hiển thị "Đang vẽ..." trên Label khi đang giữ chuột
        /// </summary>
        private void PnlCanvas_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
                CapNhatToaDoVaTrangThai(e.X, e.Y, true);
            }
        }

        /// <summary>
        /// Yêu cầu 2: MouseMove để vẽ khi đang giữ chuột (vẽ đường thẳng liên tục theo từng đoạn nhỏ)
        /// Yêu cầu 3: Label lblViTri luôn hiện tọa độ X, Y của con trỏ chuột dù có vẽ hay không
        /// </summary>
        private void PnlCanvas_MouseMove(object? sender, MouseEventArgs e)
        {
            // Yêu cầu 3 & 5: Cập nhật tọa độ X, Y và trạng thái liên tục dù có vẽ hay không
            CapNhatToaDoVaTrangThai(e.X, e.Y, isDrawing);

            // Yêu cầu 2: Vẽ đường thẳng từ điểm trước tới điểm hiện tại khi đang giữ chuột trái
            if (isDrawing && e.Button == MouseButtons.Left && canvasGraphics != null)
            {
                using (Pen pen = new Pen(penColor, penWidth))
                {
                    pen.StartCap = LineCap.Round;
                    pen.EndCap = LineCap.Round;
                    pen.LineJoin = LineJoin.Round;

                    // Vẽ lên Bitmap đệm
                    canvasGraphics.DrawLine(pen, lastPoint, e.Location);
                }

                // Cập nhật điểm nối tiếp cho đoạn nhỏ tiếp theo
                lastPoint = e.Location;

                // Yêu cầu vẽ lại canvas
                pnlCanvas.Invalidate();
            }
        }

        /// <summary>
        /// Yêu cầu 2: MouseUp để kết thúc nét
        /// Yêu cầu 5: Hiển thị "Sẵn sàng" khi nhả chuột
        /// </summary>
        private void PnlCanvas_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                CapNhatToaDoVaTrangThai(e.X, e.Y, false);
            }
        }

        /// <summary>
        /// Yêu cầu 4: Nhấn chuột phải (MouseClick với Button == Right) -> xóa trắng Panel (Invalidate)
        /// </summary>
        private void PnlCanvas_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                XoaTrangBangVe();
            }
        }

        /// <summary>
        /// Xóa trắng Panel và Invalidate lại
        /// </summary>
        private void XoaTrangBangVe()
        {
            if (canvasGraphics != null)
            {
                canvasGraphics.Clear(Color.White);
                pnlCanvas.Invalidate();
            }
        }

        /// <summary>
        /// Cập nhật Label lblViTri: hiển thị X, Y và trạng thái "Đang vẽ..." / "Sẵn sàng"
        /// </summary>
        private void CapNhatToaDoVaTrangThai(int x, int y, bool dangVe)
        {
            string trangThai = dangVe ? "Đang vẽ..." : "Sẵn sàng";
            lblViTri.Text = $"Tọa độ: (X: {x}, Y: {y}) | Trạng thái: {trangThai}";
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                canvasGraphics?.Dispose();
                canvasBitmap?.Dispose();
            }
            base.Dispose(disposing);
        }
    }

    /// <summary>
    /// Panel hỗ trợ DoubleBuffered để nét vẽ hiển thị mượt mà, không giật hình
    /// </summary>
    public class DoubleBufferedPanel : Panel
    {
        public DoubleBufferedPanel()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                           ControlStyles.UserPaint |
                           ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }
    }
}
