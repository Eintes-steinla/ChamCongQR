using System;
using System.Drawing;
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
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo QR code từ mã nhân viên
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(maNV, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            qrImage = qrCode.GetGraphic(20);

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
                qrImage.Save(saveFileDialog.FileName);
                MessageBox.Show("Lưu QR Code thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
