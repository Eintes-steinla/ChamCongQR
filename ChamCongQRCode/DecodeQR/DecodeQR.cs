using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.Windows.Compatibility;

namespace ChamCongQRCode
{
    public partial class DecodeQR : Form
    {
        public DecodeQR()
        {
            InitializeComponent();
        }

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private void frmChamCong_Load(object sender, EventArgs e)
        {
            // Bắt đầu chạy đồng hồ hiển thị thời gian
            timerClock.Start();
            lblCurrentTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            // Tìm tất cả các thiết bị camera có kết nối với máy tính
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // Kiểm tra xem có camera nào không
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("Không tìm thấy camera! Vui lòng kiểm tra lại thiết bị.", "Lỗi Camera", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Bắt đầu sử dụng camera đầu tiên trong danh sách
            StartCamera(0); timerScanQR.Interval = 1000;

            // Bắt đầu timer để quét mã QR
            timerScanQR.Start();
        }

        private void StartCamera(int deviceIndex)
        {
            // Tạo đối tượng video source từ camera được chọn
            videoSource = new VideoCaptureDevice(videoDevices[deviceIndex].MonikerString);
            // Gán sự kiện NewFrame để xử lý mỗi khi có khung hình mới
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            // Bắt đầu nhận tín hiệu từ camera
            videoSource.Start();
        }

        // Sự kiện được gọi mỗi khi camera có một khung hình mới
        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            this.Invoke((MethodInvoker)delegate
            {
                if (pictureBoxCamera.Image != null)
                {
                    pictureBoxCamera.Image.Dispose();
                }
                pictureBoxCamera.Image = frame;
            });
        }

        // Sự kiện Tick của Timer quét mã QR, xảy ra mỗi 500ms
        private void timerScanQR_Tick(object sender, EventArgs e)
        {
            if (pictureBoxCamera.Image != null)
            {
                // Tạo bản sao bitmap và dispose đúng cách
                using (var bitmap = new Bitmap(pictureBoxCamera.Image))
                {
                    // BarcodeReader (từ ZXing.Windows.Compatibility) sẽ nhận Bitmap trực tiếp
                    var reader = new BarcodeReader
                    {
                        AutoRotate = true,
                        Options = new ZXing.Common.DecodingOptions
                        {
                            TryHarder = true,
                            PossibleFormats = new[] { BarcodeFormat.QR_CODE }
                        }
                    };

                    var result = reader.Decode(bitmap);
                    if (result != null)
                    {
                        timerScanQR.Stop();
                        string employeeId = result.Text;
                        ProcessAttendance(employeeId);
                        System.Threading.Tasks.Task.Delay(3000).ContinueWith(t =>
                        {
                            this.Invoke((MethodInvoker)delegate {
                                ResetInfo();
                                timerScanQR.Start();
                            });
                        });
                    }
                }
            }
        }
        // Hàm xử lý logic chấm công chính
        string query;
        private void ProcessAttendance(string employeeId)
        {
            using (SqlConnection connection = DatabaseHelper.GetConnection())
            {
                try
                {
                    connection.Open();
                    string hoTen = "";

                    // 1. Lấy thông tin nhân viên từ database
                    query = "SELECT HoTen FROM CongNhan WHERE MaCN = @MaCN";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaCN", employeeId);
                        var result = cmd.ExecuteScalar(); // ExecuteScalar hiệu quả hơn khi chỉ lấy 1 giá trị

                        if (result != null)
                        {
                            hoTen = result.ToString();
                        }
                        else
                        {
                            lblStatus.Text = $"Không tìm thấy nhân viên với mã: {employeeId}";
                            lblStatus.ForeColor = Color.Red;
                            return;
                        }
                    }

                    DateTime now = DateTime.Now;

                    query = "INSERT INTO ChamCong (MaCN, ThoiGian) VALUES (@MaCN, @ThoiGian)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaCN", employeeId);
                        cmd.Parameters.AddWithValue("@ThoiGian", now);
                        cmd.ExecuteNonQuery(); // Thực thi lệnh insert
                    }

                    // 3. Tính tổng số ngày công đã làm trong tháng hiện tại
                    query = @"SELECT COUNT(DISTINCT CAST(ThoiGian AS DATE))
                                          FROM ChamCong
                                          WHERE MaCN = @MaCN AND MONTH(ThoiGian) = @Thang AND YEAR(ThoiGian) = @Nam";
                    int soNgayCong = 0;
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaCN", employeeId);
                        cmd.Parameters.AddWithValue("@Thang", now.Month);
                        cmd.Parameters.AddWithValue("@Nam", now.Year);
                        soNgayCong = (int)cmd.ExecuteScalar();
                    }

                    // 4. Hiển thị thông tin đã xử lý lên giao diện
                    this.Invoke((MethodInvoker)delegate
                    {
                        lblMaCN.Text = employeeId;
                        lblHoTen.Text = hoTen;
                        lblGioQuet.Text = now.ToString("HH:mm:ss dd/MM/yyyy");
                        lblNgayCong.Text = soNgayCong.ToString();
                        lblStatus.Text = "Chấm công thành công!";
                        lblStatus.ForeColor = Color.Green;
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối hoặc xử lý database: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Invoke((MethodInvoker)delegate
                    {
                        lblStatus.Text = "Đã xảy ra lỗi!";
                        lblStatus.ForeColor = Color.Red;
                    });
                }
            }
        }

        // Hàm xóa thông tin trên giao diện để chuẩn bị cho lần quét tiếp theo
        private void ResetInfo()
        {
            lblMaCN.Text = "---";
            lblHoTen.Text = "---";
            lblGioQuet.Text = "---";
            lblNgayCong.Text = "---";
            lblStatus.Text = "Công nhân đưa mã QR vào camera để quét chấm công";
            lblStatus.ForeColor = Color.Black;
        }

        // Sự kiện Tick của Timer đồng hồ
        private void timerClock_Tick(object sender, EventArgs e)
        {
            // Cập nhật thời gian hiển thị mỗi giây
            lblCurrentTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // Sự kiện khi Form đang được đóng lại
        private void frmChamCong_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Dừng camera và giải phóng tài nguyên
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop(); // Gửi tín hiệu dừng
                videoSource.WaitForStop();  // Đợi cho đến khi camera dừng hoàn toàn
                videoSource.NewFrame -= new NewFrameEventHandler(videoSource_NewFrame);
            }
        }

    }
}
