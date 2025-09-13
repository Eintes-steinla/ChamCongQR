namespace ChamCongQRCode
{
    partial class DecodeQR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxCamera;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNgayCong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGioQuet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaCN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Timer timerScanQR;
        private System.Windows.Forms.Label label2;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBoxCamera = new PictureBox();
            lblCurrentTime = new Label();
            groupBox1 = new GroupBox();
            lblNgayCong = new Label();
            label7 = new Label();
            lblGioQuet = new Label();
            label5 = new Label();
            lblHoTen = new Label();
            label3 = new Label();
            lblMaCN = new Label();
            label1 = new Label();
            timerClock = new System.Windows.Forms.Timer(components);
            timerScanQR = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxCamera
            // 
            pictureBoxCamera.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxCamera.Location = new Point(15, 83);
            pictureBoxCamera.Margin = new Padding(4, 5, 4, 5);
            pictureBoxCamera.Name = "pictureBoxCamera";
            pictureBoxCamera.Size = new Size(662, 755);
            pictureBoxCamera.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCamera.TabIndex = 0;
            pictureBoxCamera.TabStop = false;
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentTime.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentTime.ForeColor = Color.Blue;
            lblCurrentTime.Location = new Point(738, 16);
            lblCurrentTime.Margin = new Padding(4, 0, 4, 0);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(431, 47);
            lblCurrentTime.TabIndex = 1;
            lblCurrentTime.Text = "dd/MM/yyyy HH:mm:ss";
            lblCurrentTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblNgayCong);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblGioQuet);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblHoTen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblMaCN);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(738, 83);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(554, 398);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chấm công";
            // 
            // lblNgayCong
            // 
            lblNgayCong.AutoSize = true;
            lblNgayCong.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNgayCong.Location = new Point(199, 289);
            lblNgayCong.Margin = new Padding(4, 0, 4, 0);
            lblNgayCong.Name = "lblNgayCong";
            lblNgayCong.Size = new Size(53, 40);
            lblNgayCong.TabIndex = 7;
            lblNgayCong.Text = "---";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 294);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(165, 32);
            label7.TabIndex = 6;
            label7.Text = "Số ngày công:";
            // 
            // lblGioQuet
            // 
            lblGioQuet.AutoSize = true;
            lblGioQuet.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGioQuet.Location = new Point(199, 214);
            lblGioQuet.Margin = new Padding(4, 0, 4, 0);
            lblGioQuet.Name = "lblGioQuet";
            lblGioQuet.Size = new Size(53, 40);
            lblGioQuet.TabIndex = 5;
            lblGioQuet.Text = "---";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 219);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(180, 32);
            label5.TabIndex = 4;
            label5.Text = "Giờ chấm công:";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoTen.Location = new Point(199, 139);
            lblHoTen.Margin = new Padding(4, 0, 4, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(53, 40);
            lblHoTen.TabIndex = 3;
            lblHoTen.Text = "---";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 144);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 2;
            label3.Text = "Họ và tên:";
            // 
            // lblMaCN
            // 
            lblMaCN.AutoSize = true;
            lblMaCN.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaCN.Location = new Point(199, 64);
            lblMaCN.Margin = new Padding(4, 0, 4, 0);
            lblMaCN.Name = "lblMaCN";
            lblMaCN.Size = new Size(53, 40);
            lblMaCN.TabIndex = 1;
            lblMaCN.Text = "---";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên:";
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // timerScanQR
            // 
            timerScanQR.Interval = 500;
            timerScanQR.Tick += timerScanQR_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 14);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(519, 48);
            label2.TabIndex = 4;
            label2.Text = "CHẤM CÔNG BẰNG QR CODE";
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(729, 578);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(575, 141);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Cán bộ công nhân viên đưa mã QR vào camera để chấm công";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DecodeQR
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 889);
            Controls.Add(label2);
            Controls.Add(lblStatus);
            Controls.Add(groupBox1);
            Controls.Add(lblCurrentTime);
            Controls.Add(pictureBoxCamera);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DecodeQR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm chấm công";
            FormClosing += frmChamCong_FormClosing;
            Load += frmChamCong_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
    }
}

