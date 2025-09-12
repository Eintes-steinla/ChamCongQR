using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using QRCoder;

namespace ChamCongQRCode
{
    public partial class EncodeQR : Form
    {
        private Bitmap qrImage;

        public EncodeQR()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string maNV = txtMaCN.Text.Trim();
            string tenNV = txtTenCN.Text.Trim();

            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(tenNV))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã và tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Tạo QR code từ mã nhân viên
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(maNV, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCore = qrCode.GetGraphic(20);

            // 2. Thêm text vào ảnh QR
            int extraHeight = 60;
            qrImage = new Bitmap(qrCore.Width, qrCore.Height + extraHeight);

            using (Graphics g = Graphics.FromImage(qrImage))
            {
                g.Clear(Color.White);

                string textMa = $"Mã CN: {maNV}";
                string textTen = $"Tên CN: {tenNV}";

                using (Font font = new Font("Arial", 12, FontStyle.Bold))
                using (Brush brush = Brushes.Black)
                {
                    // Vẽ Mã CN (dòng 1)
                    SizeF sizeMa = g.MeasureString(textMa, font);
                    float xMa = (qrImage.Width - sizeMa.Width) / 2;
                    g.DrawString(textMa, font, brush, xMa, 5);

                    // Vẽ Tên CN (dòng 2, cách dòng 1 khoảng 20px)
                    SizeF sizeTen = g.MeasureString(textTen, font);
                    float xTen = (qrImage.Width - sizeTen.Width) / 2;
                    g.DrawString(textTen, font, brush, xTen, 30);
                }


                // Vẽ QR dưới phần chữ
                g.DrawImage(qrCore, new Rectangle(0, extraHeight, qrCore.Width, qrCore.Height));
            }

            pictureBoxQR.Image = qrImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (qrImage == null)
            {
                MessageBox.Show("Chưa có QR để lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            saveFileDialog.Title = "Lưu QR Code";
            saveFileDialog.FileName = $"QR_{txtMaCN.Text}.png";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                qrImage.Save(saveFileDialog.FileName, ImageFormat.Png);
                MessageBox.Show("Lưu QR Code thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
