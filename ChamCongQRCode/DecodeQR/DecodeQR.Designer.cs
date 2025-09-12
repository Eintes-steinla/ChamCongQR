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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxCamera = new System.Windows.Forms.PictureBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNgayCong = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGioQuet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaCN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.timerScanQR = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxCamera
            // 
            this.pictureBoxCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCamera.Location = new System.Drawing.Point(12, 53);
            this.pictureBoxCamera.Name = "pictureBoxCamera";
            this.pictureBoxCamera.Size = new System.Drawing.Size(530, 484);
            this.pictureBoxCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCamera.TabIndex = 0;
            this.pictureBoxCamera.TabStop = false;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.ForeColor = System.Drawing.Color.Blue;
            this.lblCurrentTime.Location = new System.Drawing.Point(427, 9);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(345, 30);
            this.lblCurrentTime.TabIndex = 1;
            this.lblCurrentTime.Text = "dd/MM/yyyy HH:mm:ss";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNgayCong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblGioQuet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblMaCN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(590, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 255);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chấm công";
            // 
            // lblNgayCong
            // 
            this.lblNgayCong.AutoSize = true;
            this.lblNgayCong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayCong.Location = new System.Drawing.Point(159, 185);
            this.lblNgayCong.Name = "lblNgayCong";
            this.lblNgayCong.Size = new System.Drawing.Size(44, 32);
            this.lblNgayCong.TabIndex = 7;
            this.lblNgayCong.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số ngày công:";
            // 
            // lblGioQuet
            // 
            this.lblGioQuet.AutoSize = true;
            this.lblGioQuet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioQuet.Location = new System.Drawing.Point(159, 137);
            this.lblGioQuet.Name = "lblGioQuet";
            this.lblGioQuet.Size = new System.Drawing.Size(44, 32);
            this.lblGioQuet.TabIndex = 5;
            this.lblGioQuet.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giờ chấm công:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(159, 89);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(44, 32);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên:";
            // 
            // lblMaCN
            // 
            this.lblMaCN.AutoSize = true;
            this.lblMaCN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCN.Location = new System.Drawing.Point(159, 41);
            this.lblMaCN.Name = "lblMaCN";
            this.lblMaCN.Size = new System.Drawing.Size(44, 32);
            this.lblMaCN.TabIndex = 1;
            this.lblMaCN.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // timerScanQR
            // 
            this.timerScanQR.Interval = 500;
            this.timerScanQR.Tick += new System.EventHandler(this.timerScanQR_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "CHẤM CÔNG BẰNG QR CODE";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(583, 370);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(460, 90);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Cán bộ công nhân viên đưa mã QR vào camera để chấm công";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChamCongQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 569);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.pictureBoxCamera);
            this.Name = "ChamCongQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm chấm công";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChamCong_FormClosing);
            this.Load += new System.EventHandler(this.frmChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCamera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
    }
}

