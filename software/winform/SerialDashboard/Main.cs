using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using SerialDashboard.Properties;

namespace SerialDashboard
{
    public partial class frmMain : Form
    {
        int InputData = 0;
        delegate void SetComponentCallback(int data);

        int mode = 0;
        byte cmdSend = 0;
        int hour = 0, minute = 0, second = 0;
        int hourSet = 0, minuteSet = 0, secondSet = 0;
        double span = 0;

        public frmMain()
        {
            InitializeComponent();

            /* Thêm sự kiện khi Serial nhận được dữ liệu */
            serCOM.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
        }

        /* Sự kiện khi form được load */
        private void frmMain_Load(object sender, EventArgs e)
        {
            /* Nếu số lượng cổng Serial lớn hơn 0 thì lựa chọn giá trị đầu tiên */
            if (cbxCOM.Items.Count > 0) cbxCOM.SelectedIndex = 0;

            /* Lấy toàn bộ cổng Serial bỏ vào ComboBox */
            cbxCOM.DataSource = SafeSerialPort.GetPortNames();

            /* Mảng tốc độ baud và thêm các phần tử vào ComboBox tốc độ baud */
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            cbxBaudRate.Items.AddRange(BaudRate);

            /* Lựa chọn tốc độ mặc định 9600 (phần tử thứ 3 của mảng) */
            cbxBaudRate.SelectedIndex = 3;
            
            /* Chế độ bật tắt thủ công là mặc định */
            cbxSelectMode.SelectedIndex = 0;
            mode = cbxSelectMode.SelectedIndex;

            /* Giá trị thời gian tắt là giá trị đầu tiên (30 giây) */
            cbxSpanTime.SelectedIndex = 0;

            /* Thêm các giá trị giờ phút giây vào các ComboBox tương ứng */
            for (int i = 0; i < 24; i++)
            {
                cbxHourSet.Items.Add(i.ToString("00"));
            }
            for (int i = 0; i < 60; i++)
            {
                cbxMinuteSet.Items.Add(i.ToString("00"));
                cbxSecondSet.Items.Add(i.ToString("00"));
            }

            /* Chọn giá trị mặc định ComboBox giờ phút giây là phần tử đầu tiên */
            cbxHourSet.SelectedIndex = 0;
            cbxMinuteSet.SelectedIndex = 0;
            cbxSecondSet.SelectedIndex = 0;

            /* Tắt hết thiết bị được chọn */
            rbtTurnOffAll.Checked = true;

            /* Kiểm tra chế độ và đặt giá trị ban đầu */
            if (mode == 0)
            {
                cbxHourSet.Enabled = false;
                cbxMinuteSet.Enabled = false;
                cbxSecondSet.Enabled = false;
                cbxSpanTime.Enabled = false;
            }
            else if (mode == 1)
            {
                cbxHourSet.Enabled = true;
                cbxMinuteSet.Enabled = true;
                cbxSecondSet.Enabled = true;
                cbxSpanTime.Enabled = true;
            }
        }

        /* Sự kiện khi timer theo dõi Form được chạy */
        private void tmrMonitoring_Tick(object sender, EventArgs e)
        {
            /* Nếu cổng Serial chưa được mở thì */
            if (!serCOM.IsOpen)
            {
                lblStatus.Text = ("Chưa kết nối!");
                lblStatus.ForeColor = Color.Red;
                cbxCOM.Enabled = true;
                cbxBaudRate.Enabled = true;
                btnRefesh.Enabled = true;
                gbxDeviceControl.Enabled = false;
            }

            /* Nếu cổng Serial được mở thì */
            else if (serCOM.IsOpen)
            {
                lblStatus.Text = ("Đã kết nối!");
                lblStatus.ForeColor = Color.Green;
                cbxCOM.Enabled = false;
                cbxBaudRate.Enabled = false;
                btnRefesh.Enabled = false;
                gbxDeviceControl.Enabled = true;
            }

            /* Nếu số lượng cổng COM lớn hơn 0 thì */
            if (cbxCOM.Items.Count > 0)
            {
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = true;
            }
            else
            {
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = false;
            }

            /* Đọc thời gian hệ thống hiện tại */
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;

            /* Hiển thị thời gian và ngày của hệ thống */
            lblTimeNow.Text = hour.ToString("00") + ":" + minute.ToString("00") + ":" + second.ToString("00");
            lblDateNow.Text = DateTime.Now.ToString("dd/MM/yyyy");

            /* Nếu là chế độ hẹn giờ bật tắt thiết bị */
            if (mode == 1)
            {
                /* Nếu đến thời điểm đặt thì gửi lệnh và bật timer đếm thời gian để tắt */
                if (hourSet == hour && minuteSet == minute && secondSet == second)
                {
                    tmrCounter.Enabled = true;
                    setCommandSend();
                    if (serCOM.IsOpen)
                        serCOM.Write(new byte[] { cmdSend }, 0, 1);
                }
            }

        }

        /* Sự kiện khi Serial nhận được dữ liệu */
        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            if (serCOM.IsOpen)
            {
                // Đọc byte và gọi hàm hiển thị dữ liệu phản hồi, trạng thái các đèn
                InputData = serCOM.ReadByte();
                SetComponent(InputData);
            }
        }

        /* Hàm đặt các thành phần của Form theo dữ liệu nhận được */
        private void SetComponent(int data)
        {
            if (txtInputData.InvokeRequired || picDevice1.InvokeRequired || picDevice2.InvokeRequired ||
                picDevice3.InvokeRequired || picDevice4.InvokeRequired || picDevice5.InvokeRequired ||
                picDevice6.InvokeRequired || picDevice7.InvokeRequired || picDevice8.InvokeRequired)
            {
                SetComponentCallback d = new SetComponentCallback(SetComponent);
                Invoke(d, new object[] { data });
            }
            else
            {
                /* Hiển thi dữ liệu phản hồi */
                txtInputData.Text += "0x" + data.ToString("X2") + ", ";

                /* Tách lấy từng bit của byte và đặt hình ảnh bật tắt theo bit đó */
                int hexCode = data;
                if (((hexCode >> 0) & 1) == 1)
                    picDevice1.BackgroundImage = Resources.on;
                else
                    picDevice1.BackgroundImage = Resources.off;

                if (((hexCode >> 1) & 1) == 1)
                    picDevice2.BackgroundImage = Resources.on;
                else
                    picDevice2.BackgroundImage = Resources.off;

                if (((hexCode >> 2) & 1) == 1)
                    picDevice3.BackgroundImage = Resources.on;
                else
                    picDevice3.BackgroundImage = Resources.off;

                if (((hexCode >> 3) & 1) == 1)
                    picDevice4.BackgroundImage = Resources.on;
                else
                    picDevice4.BackgroundImage = Resources.off;

                if (((hexCode >> 4) & 1) == 1)
                    picDevice5.BackgroundImage = Resources.on;
                else
                    picDevice5.BackgroundImage = Resources.off;

                if (((hexCode >> 5) & 1) == 1)
                    picDevice6.BackgroundImage = Resources.on;
                else
                    picDevice6.BackgroundImage = Resources.off;

                if (((hexCode >> 6) & 1) == 1)
                    picDevice7.BackgroundImage = Resources.on;
                else
                    picDevice7.BackgroundImage = Resources.off;

                if (((hexCode >> 7) & 1) == 1)
                    picDevice8.BackgroundImage = Resources.on;
                else
                    picDevice8.BackgroundImage = Resources.off;
            }
        }

        /* Sự kiện khi nút kết nối được nhấn */
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serCOM.Dispose();
                serCOM.PortName = cbxCOM.Text;
                serCOM.BaudRate = Convert.ToInt32(cbxBaudRate.Text);
                serCOM.Open();
                cbxCOM.Enabled = false;
                cbxBaudRate.Enabled = false;
                btnRefesh.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Không thể mở cổng COM.\r\nXin vui lòng kiểm tra lại!", "Lỗi rồi -.-!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* Sự kiện khi nút ngắt kết nối được nhấn */
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            serCOM.Dispose();
            cbxCOM.Enabled = true;
            cbxBaudRate.Enabled = true;
            btnRefesh.Enabled = true;
            txtInputData.Clear();
        }

        /* Sự kiện khi Form đã được đóng */
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            tmrMonitoring.Dispose();
            tmrCounter.Dispose();
            serCOM.Dispose();
        }

        /* Sự kiện khi Form đang được đóng */
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrMonitoring.Dispose();
            tmrCounter.Dispose();
            serCOM.Dispose();
        }

        /* Sự kiện khi nút làm mới cổng Serial được nhấn */
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            cbxCOM.DataSource = SafeSerialPort.GetPortNames();
        }

        /* Nếu radioButton Bật toàn bộ được check chọn */
        private void rbtTurnOnAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTurnOnAll.Checked)
            {
                chkDevice1.Checked = true;
                chkDevice2.Checked = true;
                chkDevice3.Checked = true;
                chkDevice4.Checked = true;
                chkDevice5.Checked = true;
                chkDevice6.Checked = true;
                chkDevice7.Checked = true;
                chkDevice8.Checked = true;
                cmdSend = 0xFF;
                if (serCOM.IsOpen)
                {
                    if (mode == 0)
                        serCOM.Write(new byte[] { cmdSend }, 0, 1);
                }
            }
        }

        /* Nếu radioButton Tắt toàn bộ được check chọn */
        private void rbtTurnOffAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTurnOffAll.Checked)
            {
                chkDevice1.Checked = false;
                chkDevice2.Checked = false;
                chkDevice3.Checked = false;
                chkDevice4.Checked = false;
                chkDevice5.Checked = false;
                chkDevice6.Checked = false;
                chkDevice7.Checked = false;
                chkDevice8.Checked = false;
                cmdSend = 0x00;
                if (serCOM.IsOpen)
                {
                    if (mode == 0)
                        serCOM.Write(new byte[] { cmdSend }, 0, 1);
                }
            }
        }

        /* Sự kiện khi timer đếm thời gian để tắt hoạt động */
        private void tmrCounter_Tick(object sender, EventArgs e)
        {
            span -= 1;
            if (mode == 1)
            {
                if (span < 0)
                {
                    cmdSend = 0x00;
                    if (serCOM.IsOpen)
                    {
                        serCOM.Write(new byte[] { cmdSend }, 0, 1);
                    }
                    tmrCounter.Enabled = false;
                }
            }  
        }

        /* Sự kiện khi ComboBox chọn thời gian tắt được thay đổi giá trị */
        private void cbxSpanTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxSpanTime.SelectedIndex == 0)
            {
                string[] text = cbxSpanTime.Text.Split(new[] { " " }, StringSplitOptions.None);
                span = Double.Parse(text[0]);
            }
            else
            { 
                string[] text = cbxSpanTime.Text.Split(new[] { " " }, StringSplitOptions.None);
                span = Double.Parse(text[0]) * 60;
            }
        }

        /* Sự kiện khi ComboBox đặt giờ được thay đổi */
        private void cbxHourSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            hourSet = Int32.Parse(cbxHourSet.Text);
        }

        /* Sự kiện khi ComboBox đặt phút được thay đổi */
        private void cbxMinuteSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            minuteSet = Int32.Parse(cbxMinuteSet.Text);
        }

        /* Sự kiện khi ComboBox đặt giây được thay đổi */
        private void cbxSecondSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            secondSet = Int32.Parse(cbxSecondSet.Text);
        }

        /* Sự kiện khi ComboBox chọn chế độ được thay đổi */
        private void cbxSelectMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = cbxSelectMode.SelectedIndex;
            if (mode == 0)
            {
                cbxHourSet.Enabled = false;
                cbxMinuteSet.Enabled = false;
                cbxSecondSet.Enabled = false;
                cbxSpanTime.Enabled = false;
            }
            else if (mode == 1)
            {
                cbxHourSet.Enabled = true;
                cbxMinuteSet.Enabled = true;
                cbxSecondSet.Enabled = true;
                cbxSpanTime.Enabled = true;
            }

            tmrCounter.Enabled = false;
            chkDevice1.Checked = false;
            chkDevice2.Checked = false;
            chkDevice3.Checked = false;
            chkDevice4.Checked = false;
            chkDevice5.Checked = false;
            chkDevice6.Checked = false;
            chkDevice7.Checked = false;
            chkDevice8.Checked = false;
            rbtTurnOnAll.Checked = false;
            rbtTurnOffAll.Checked = true;

            setCommandSend();
            if (serCOM.IsOpen)
                serCOM.Write(new byte[] { cmdSend }, 0, 1);
        }

        /* Sự kiện khi check box thiết bị 1 đến 8 được thay đổi */
        private void chkDevice_Click(object sender, EventArgs e)
        {
            if (chkDevice1.Checked == true &&
            chkDevice2.Checked == true &&
            chkDevice3.Checked == true &&
            chkDevice4.Checked == true &&
            chkDevice5.Checked == true &&
            chkDevice6.Checked == true &&
            chkDevice7.Checked == true &&
            chkDevice8.Checked == true)
            {
                rbtTurnOnAll.Checked = true;
            }
            else
            {
                rbtTurnOnAll.Checked = false;
            }

            if (chkDevice1.Checked == false &&
            chkDevice2.Checked == false &&
            chkDevice3.Checked == false &&
            chkDevice4.Checked == false &&
            chkDevice5.Checked == false &&
            chkDevice6.Checked == false &&
            chkDevice7.Checked == false &&
            chkDevice8.Checked == false)
            {
                rbtTurnOffAll.Checked = true;
            }
            else
            {
                rbtTurnOffAll.Checked = false;
            }

            setCommandSend();

            if (mode == 0)
            {
                if (serCOM.IsOpen)
                    serCOM.Write(new byte[] { cmdSend }, 0, 1);
            }
        }

        /* Hàm đọc lệnh gửi đi theo các Checkbox thiết bị */
        private void setCommandSend()
        {
            cmdSend = 0;
            if (chkDevice1.Checked)
            {
                cmdSend += 1;
            }
            if (chkDevice2.Checked)
            {
                cmdSend += 2;
            }
            if (chkDevice3.Checked)
            {
                cmdSend += 4;
            }
            if (chkDevice4.Checked)
            {
                cmdSend += 8;
            }
            if (chkDevice5.Checked)
            {
                cmdSend += 16;
            }
            if (chkDevice6.Checked)
            {
                cmdSend += 32;
            }
            if (chkDevice7.Checked)
            {
                cmdSend += 64;
            }
            if (chkDevice8.Checked)
            {
                cmdSend += 128;
            }
        }
    }
}
