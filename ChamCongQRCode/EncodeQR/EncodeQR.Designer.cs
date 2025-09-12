using System.Windows.Forms;

namespace ChamCongQRCode
{
    partial class EncodeQR
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtMaCN;
        private Button btnGenerate;
        private Button btnSave;
        private PictureBox pictureBoxQR;
        private Label lblMaCN;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtMaCN = new TextBox();
            btnGenerate = new Button();
            btnSave = new Button();
            pictureBoxQR = new PictureBox();
            lblMaCN = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).BeginInit();
            SuspendLayout();
            // 
            // txtMaCN
            // 
            txtMaCN.Location = new Point(171, 20);
            txtMaCN.Name = "txtMaCN";
            txtMaCN.Size = new Size(300, 31);
            txtMaCN.TabIndex = 1;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(171, 397);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(100, 30);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Tạo QR";
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(371, 397);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu QR";
            btnSave.Click += btnSave_Click;
            // 
            // pictureBoxQR
            // 
            pictureBoxQR.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxQR.Location = new Point(171, 69);
            pictureBoxQR.Name = "pictureBoxQR";
            pictureBoxQR.Size = new Size(300, 300);
            pictureBoxQR.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxQR.TabIndex = 4;
            pictureBoxQR.TabStop = false;
            // 
            // lblMaCN
            // 
            lblMaCN.AutoSize = true;
            lblMaCN.Location = new Point(20, 20);
            lblMaCN.Name = "lblMaCN";
            lblMaCN.Size = new Size(130, 25);
            lblMaCN.TabIndex = 0;
            lblMaCN.Text = "Mã công nhân:";
            // 
            // EncodeQR
            // 
            ClientSize = new Size(646, 475);
            Controls.Add(lblMaCN);
            Controls.Add(txtMaCN);
            Controls.Add(btnGenerate);
            Controls.Add(btnSave);
            Controls.Add(pictureBoxQR);
            Name = "EncodeQR";
            Text = "Tạo QR Code cho nhân viên";
            ((System.ComponentModel.ISupportInitialize)pictureBoxQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
