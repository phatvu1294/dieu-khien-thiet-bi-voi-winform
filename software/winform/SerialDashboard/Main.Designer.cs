namespace SerialDashboard
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtInputData = new System.Windows.Forms.TextBox();
            this.gbxSetting = new System.Windows.Forms.GroupBox();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblLabelStatus = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCOM = new System.Windows.Forms.Label();
            this.cbxCOM = new System.Windows.Forms.ComboBox();
            this.tmrMonitoring = new System.Windows.Forms.Timer(this.components);
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.lblRawInfo = new System.Windows.Forms.Label();
            this.gbxDeviceStatus = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picDevice8 = new System.Windows.Forms.PictureBox();
            this.picDevice7 = new System.Windows.Forms.PictureBox();
            this.picDevice6 = new System.Windows.Forms.PictureBox();
            this.picDevice5 = new System.Windows.Forms.PictureBox();
            this.picDevice4 = new System.Windows.Forms.PictureBox();
            this.picDevice3 = new System.Windows.Forms.PictureBox();
            this.picDevice2 = new System.Windows.Forms.PictureBox();
            this.picDevice1 = new System.Windows.Forms.PictureBox();
            this.gbxDeviceControl = new System.Windows.Forms.GroupBox();
            this.cbxSpanTime = new System.Windows.Forms.ComboBox();
            this.lblSpanTime = new System.Windows.Forms.Label();
            this.rbtTurnOffAll = new System.Windows.Forms.RadioButton();
            this.rbtTurnOnAll = new System.Windows.Forms.RadioButton();
            this.lblSelectMode = new System.Windows.Forms.Label();
            this.lblHourSet = new System.Windows.Forms.Label();
            this.cbxSelectMode = new System.Windows.Forms.ComboBox();
            this.chkDevice8 = new System.Windows.Forms.CheckBox();
            this.chkDevice7 = new System.Windows.Forms.CheckBox();
            this.chkDevice6 = new System.Windows.Forms.CheckBox();
            this.chkDevice5 = new System.Windows.Forms.CheckBox();
            this.chkDevice4 = new System.Windows.Forms.CheckBox();
            this.chkDevice3 = new System.Windows.Forms.CheckBox();
            this.chkDevice2 = new System.Windows.Forms.CheckBox();
            this.chkDevice1 = new System.Windows.Forms.CheckBox();
            this.cbxSecondSet = new System.Windows.Forms.ComboBox();
            this.cbxMinuteSet = new System.Windows.Forms.ComboBox();
            this.cbxHourSet = new System.Windows.Forms.ComboBox();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.lblDateNow = new System.Windows.Forms.Label();
            this.tmrCounter = new System.Windows.Forms.Timer(this.components);
            this.gbxSetting.SuspendLayout();
            this.gbxDeviceStatus.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice1)).BeginInit();
            this.gbxDeviceControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputData
            // 
            this.txtInputData.Location = new System.Drawing.Point(12, 246);
            this.txtInputData.Multiline = true;
            this.txtInputData.Name = "txtInputData";
            this.txtInputData.ReadOnly = true;
            this.txtInputData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInputData.Size = new System.Drawing.Size(178, 75);
            this.txtInputData.TabIndex = 0;
            // 
            // gbxSetting
            // 
            this.gbxSetting.Controls.Add(this.btnRefesh);
            this.gbxSetting.Controls.Add(this.lblStatus);
            this.gbxSetting.Controls.Add(this.lblLabelStatus);
            this.gbxSetting.Controls.Add(this.btnDisconnect);
            this.gbxSetting.Controls.Add(this.btnConnect);
            this.gbxSetting.Controls.Add(this.cbxBaudRate);
            this.gbxSetting.Controls.Add(this.label1);
            this.gbxSetting.Controls.Add(this.lblCOM);
            this.gbxSetting.Controls.Add(this.cbxCOM);
            this.gbxSetting.Location = new System.Drawing.Point(12, 12);
            this.gbxSetting.Name = "gbxSetting";
            this.gbxSetting.Size = new System.Drawing.Size(178, 206);
            this.gbxSetting.TabIndex = 1;
            this.gbxSetting.TabStop = false;
            this.gbxSetting.Text = "Cài đặt";
            // 
            // btnRefesh
            // 
            this.btnRefesh.Location = new System.Drawing.Point(118, 36);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(54, 23);
            this.btnRefesh.TabIndex = 8;
            this.btnRefesh.Text = "Làm mới";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(70, 184);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Chưa kết nối!";
            // 
            // lblLabelStatus
            // 
            this.lblLabelStatus.AutoSize = true;
            this.lblLabelStatus.Location = new System.Drawing.Point(3, 184);
            this.lblLabelStatus.Name = "lblLabelStatus";
            this.lblLabelStatus.Size = new System.Drawing.Size(58, 13);
            this.lblLabelStatus.TabIndex = 6;
            this.lblLabelStatus.Text = "Trạng thái:";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(6, 140);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(166, 23);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Ngắt kết nối";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 111);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(166, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(6, 84);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(166, 21);
            this.cbxBaudRate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tốc độ Baud:";
            // 
            // lblCOM
            // 
            this.lblCOM.AutoSize = true;
            this.lblCOM.Location = new System.Drawing.Point(6, 21);
            this.lblCOM.Name = "lblCOM";
            this.lblCOM.Size = new System.Drawing.Size(70, 13);
            this.lblCOM.TabIndex = 1;
            this.lblCOM.Text = "Cổng kết nối:";
            // 
            // cbxCOM
            // 
            this.cbxCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCOM.FormattingEnabled = true;
            this.cbxCOM.Location = new System.Drawing.Point(6, 37);
            this.cbxCOM.Name = "cbxCOM";
            this.cbxCOM.Size = new System.Drawing.Size(106, 21);
            this.cbxCOM.TabIndex = 0;
            // 
            // tmrMonitoring
            // 
            this.tmrMonitoring.Enabled = true;
            this.tmrMonitoring.Tick += new System.EventHandler(this.tmrMonitoring_Tick);
            // 
            // lblRawInfo
            // 
            this.lblRawInfo.AutoSize = true;
            this.lblRawInfo.Location = new System.Drawing.Point(12, 230);
            this.lblRawInfo.Name = "lblRawInfo";
            this.lblRawInfo.Size = new System.Drawing.Size(87, 13);
            this.lblRawInfo.TabIndex = 4;
            this.lblRawInfo.Text = "Dữ liệu phản hồi:";
            // 
            // gbxDeviceStatus
            // 
            this.gbxDeviceStatus.Controls.Add(this.tableLayoutPanel1);
            this.gbxDeviceStatus.Location = new System.Drawing.Point(202, 12);
            this.gbxDeviceStatus.Name = "gbxDeviceStatus";
            this.gbxDeviceStatus.Size = new System.Drawing.Size(268, 156);
            this.gbxDeviceStatus.TabIndex = 5;
            this.gbxDeviceStatus.TabStop = false;
            this.gbxDeviceStatus.Text = "Trạng thái thiết bị";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.picDevice8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.picDevice7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.picDevice6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.picDevice5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.picDevice4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.picDevice3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.picDevice2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.picDevice1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(262, 137);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // picDevice8
            // 
            this.picDevice8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDevice8.BackgroundImage")));
            this.picDevice8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDevice8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDevice8.Image = ((System.Drawing.Image)(resources.GetObject("picDevice8.Image")));
            this.picDevice8.InitialImage = ((System.Drawing.Image)(resources.GetObject("picDevice8.InitialImage")));
            this.picDevice8.Location = new System.Drawing.Point(198, 71);
            this.picDevice8.Name = "picDevice8";
            this.picDevice8.Size = new System.Drawing.Size(61, 63);
            this.picDevice8.TabIndex = 7;
            this.picDevice8.TabStop = false;
            // 
            // picDevice7
            // 
            this.picDevice7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDevice7.BackgroundImage")));
            this.picDevice7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDevice7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDevice7.Image = ((System.Drawing.Image)(resources.GetObject("picDevice7.Image")));
            this.picDevice7.InitialImage = ((System.Drawing.Image)(resources.GetObject("picDevice7.InitialImage")));
            this.picDevice7.Location = new System.Drawing.Point(133, 71);
            this.picDevice7.Name = "picDevice7";
            this.picDevice7.Size = new System.Drawing.Size(59, 63);
            this.picDevice7.TabIndex = 6;
            this.picDevice7.TabStop = false;
            // 
            // picDevice6
            // 
            this.picDevice6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDevice6.BackgroundImage")));
            this.picDevice6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDevice6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDevice6.Image = ((System.Drawing.Image)(resources.GetObject("picDevice6.Image")));
            this.picDevice6.InitialImage = ((System.Drawing.Image)(resources.GetObject("picDevice6.InitialImage")));
            this.picDevice6.Location = new System.Drawing.Point(68, 71);
            this.picDevice6.Name = "picDevice6";
            this.picDevice6.Size = new System.Drawing.Size(59, 63);
            this.picDevice6.TabIndex = 5;
            this.picDevice6.TabStop = false;
            // 
            // picDevice5
            // 
            this.picDevice5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDevice5.BackgroundImage")));
            this.picDevice5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDevice5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDevice5.Image = ((System.Drawing.Image)(resources.GetObject("picDevice5.Image")));
            this.picDevice5.InitialImage = ((System.Drawing.Image)(resources.GetObject("picDevice5.InitialImage")));
            this.picDevice5.Location = new System.Drawing.Point(3, 71);
            this.picDevice5.Name = "picDevice5";
            this.picDevice5.Size = new System.Drawing.Size(59, 63);
            this.picDevice5.TabIndex = 4;
            this.picDevice5.TabStop = false;
            // 
            // picDevice4
            // 
            this.picDevice4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDevice4.BackgroundImage")));
            this.picDevice4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDevice4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDevice4.Image = ((System.Drawing.Image)(resources.GetObject("picDevice4.Image")));
            this.picDevice4.InitialImage = ((System.Drawing.Image)(resources.GetObject("picDevice4.InitialImage")));
            this.picDevice4.Location = new System.Drawing.Point(198, 3);
            this.picDevice4.Name = "picDevice4";
            this.picDevice4.Size = new System.Drawing.Size(61, 62);
            this.picDevice4.TabIndex = 3;
            this.picDevice4.TabStop = false;
            // 
            // picDevice3
            // 
            this.picDevice3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDevice3.BackgroundImage")));
            this.picDevice3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDevice3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDevice3.Image = ((System.Drawing.Image)(resources.GetObject("picDevice3.Image")));
            this.picDevice3.InitialImage = ((System.Drawing.Image)(resources.GetObject("picDevice3.InitialImage")));
            this.picDevice3.Location = new System.Drawing.Point(133, 3);
            this.picDevice3.Name = "picDevice3";
            this.picDevice3.Size = new System.Drawing.Size(59, 62);
            this.picDevice3.TabIndex = 2;
            this.picDevice3.TabStop = false;
            // 
            // picDevice2
            // 
            this.picDevice2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDevice2.BackgroundImage")));
            this.picDevice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDevice2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDevice2.Image = ((System.Drawing.Image)(resources.GetObject("picDevice2.Image")));
            this.picDevice2.InitialImage = ((System.Drawing.Image)(resources.GetObject("picDevice2.InitialImage")));
            this.picDevice2.Location = new System.Drawing.Point(68, 3);
            this.picDevice2.Name = "picDevice2";
            this.picDevice2.Size = new System.Drawing.Size(59, 62);
            this.picDevice2.TabIndex = 1;
            this.picDevice2.TabStop = false;
            // 
            // picDevice1
            // 
            this.picDevice1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDevice1.BackgroundImage")));
            this.picDevice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDevice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDevice1.Image = global::SerialDashboard.Properties.Resources.off;
            this.picDevice1.InitialImage = ((System.Drawing.Image)(resources.GetObject("picDevice1.InitialImage")));
            this.picDevice1.Location = new System.Drawing.Point(3, 3);
            this.picDevice1.Name = "picDevice1";
            this.picDevice1.Size = new System.Drawing.Size(59, 62);
            this.picDevice1.TabIndex = 0;
            this.picDevice1.TabStop = false;
            // 
            // gbxDeviceControl
            // 
            this.gbxDeviceControl.Controls.Add(this.cbxSpanTime);
            this.gbxDeviceControl.Controls.Add(this.lblSpanTime);
            this.gbxDeviceControl.Controls.Add(this.rbtTurnOffAll);
            this.gbxDeviceControl.Controls.Add(this.rbtTurnOnAll);
            this.gbxDeviceControl.Controls.Add(this.lblSelectMode);
            this.gbxDeviceControl.Controls.Add(this.lblHourSet);
            this.gbxDeviceControl.Controls.Add(this.cbxSelectMode);
            this.gbxDeviceControl.Controls.Add(this.chkDevice8);
            this.gbxDeviceControl.Controls.Add(this.chkDevice7);
            this.gbxDeviceControl.Controls.Add(this.chkDevice6);
            this.gbxDeviceControl.Controls.Add(this.chkDevice5);
            this.gbxDeviceControl.Controls.Add(this.chkDevice4);
            this.gbxDeviceControl.Controls.Add(this.chkDevice3);
            this.gbxDeviceControl.Controls.Add(this.chkDevice2);
            this.gbxDeviceControl.Controls.Add(this.chkDevice1);
            this.gbxDeviceControl.Controls.Add(this.cbxSecondSet);
            this.gbxDeviceControl.Controls.Add(this.cbxMinuteSet);
            this.gbxDeviceControl.Controls.Add(this.cbxHourSet);
            this.gbxDeviceControl.Location = new System.Drawing.Point(202, 174);
            this.gbxDeviceControl.Name = "gbxDeviceControl";
            this.gbxDeviceControl.Size = new System.Drawing.Size(268, 221);
            this.gbxDeviceControl.TabIndex = 6;
            this.gbxDeviceControl.TabStop = false;
            this.gbxDeviceControl.Text = "Điều khiển thiết bị";
            // 
            // cbxSpanTime
            // 
            this.cbxSpanTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSpanTime.FormattingEnabled = true;
            this.cbxSpanTime.Items.AddRange(new object[] {
            "30 giây",
            "1 phút",
            "5 phút",
            "10 phút",
            "15 phút",
            "30 phút",
            "60 phút",
            "90 phút",
            "120 phút",
            "360 phút"});
            this.cbxSpanTime.Location = new System.Drawing.Point(176, 192);
            this.cbxSpanTime.Name = "cbxSpanTime";
            this.cbxSpanTime.Size = new System.Drawing.Size(82, 21);
            this.cbxSpanTime.TabIndex = 19;
            this.cbxSpanTime.SelectedIndexChanged += new System.EventHandler(this.cbxSpanTime_SelectedIndexChanged);
            // 
            // lblSpanTime
            // 
            this.lblSpanTime.AutoSize = true;
            this.lblSpanTime.Location = new System.Drawing.Point(173, 174);
            this.lblSpanTime.Name = "lblSpanTime";
            this.lblSpanTime.Size = new System.Drawing.Size(85, 13);
            this.lblSpanTime.TabIndex = 18;
            this.lblSpanTime.Text = "Tắt toàn bộ sau:";
            // 
            // rbtTurnOffAll
            // 
            this.rbtTurnOffAll.AutoSize = true;
            this.rbtTurnOffAll.Location = new System.Drawing.Point(132, 146);
            this.rbtTurnOffAll.Name = "rbtTurnOffAll";
            this.rbtTurnOffAll.Size = new System.Drawing.Size(59, 17);
            this.rbtTurnOffAll.TabIndex = 17;
            this.rbtTurnOffAll.TabStop = true;
            this.rbtTurnOffAll.Text = "Tắt hết";
            this.rbtTurnOffAll.UseVisualStyleBackColor = true;
            this.rbtTurnOffAll.Click += new System.EventHandler(this.rbtTurnOffAll_CheckedChanged);
            // 
            // rbtTurnOnAll
            // 
            this.rbtTurnOnAll.AutoSize = true;
            this.rbtTurnOnAll.Location = new System.Drawing.Point(6, 146);
            this.rbtTurnOnAll.Name = "rbtTurnOnAll";
            this.rbtTurnOnAll.Size = new System.Drawing.Size(59, 17);
            this.rbtTurnOnAll.TabIndex = 16;
            this.rbtTurnOnAll.TabStop = true;
            this.rbtTurnOnAll.Text = "Bật hết";
            this.rbtTurnOnAll.UseVisualStyleBackColor = true;
            this.rbtTurnOnAll.Click += new System.EventHandler(this.rbtTurnOnAll_CheckedChanged);
            // 
            // lblSelectMode
            // 
            this.lblSelectMode.AutoSize = true;
            this.lblSelectMode.Location = new System.Drawing.Point(6, 22);
            this.lblSelectMode.Name = "lblSelectMode";
            this.lblSelectMode.Size = new System.Drawing.Size(72, 13);
            this.lblSelectMode.TabIndex = 15;
            this.lblSelectMode.Text = "Chọn chế độ:";
            // 
            // lblHourSet
            // 
            this.lblHourSet.AutoSize = true;
            this.lblHourSet.Location = new System.Drawing.Point(3, 174);
            this.lblHourSet.Name = "lblHourSet";
            this.lblHourSet.Size = new System.Drawing.Size(146, 13);
            this.lblHourSet.TabIndex = 13;
            this.lblHourSet.Text = "Đặt trạng thái thiết bị vào lúc:";
            // 
            // cbxSelectMode
            // 
            this.cbxSelectMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelectMode.FormattingEnabled = true;
            this.cbxSelectMode.Items.AddRange(new object[] {
            "Bật tắt thiết bị thủ công",
            "Hẹn giờ bật tắt thiết bị"});
            this.cbxSelectMode.Location = new System.Drawing.Point(84, 19);
            this.cbxSelectMode.Name = "cbxSelectMode";
            this.cbxSelectMode.Size = new System.Drawing.Size(174, 21);
            this.cbxSelectMode.TabIndex = 12;
            this.cbxSelectMode.SelectedIndexChanged += new System.EventHandler(this.cbxSelectMode_SelectedIndexChanged);
            // 
            // chkDevice8
            // 
            this.chkDevice8.AutoSize = true;
            this.chkDevice8.Location = new System.Drawing.Point(132, 118);
            this.chkDevice8.Name = "chkDevice8";
            this.chkDevice8.Size = new System.Drawing.Size(70, 17);
            this.chkDevice8.TabIndex = 11;
            this.chkDevice8.Text = "Thiết bị 8";
            this.chkDevice8.UseVisualStyleBackColor = true;
            this.chkDevice8.Click += new System.EventHandler(this.chkDevice_Click);
            // 
            // chkDevice7
            // 
            this.chkDevice7.AutoSize = true;
            this.chkDevice7.Location = new System.Drawing.Point(132, 95);
            this.chkDevice7.Name = "chkDevice7";
            this.chkDevice7.Size = new System.Drawing.Size(70, 17);
            this.chkDevice7.TabIndex = 10;
            this.chkDevice7.Text = "Thiết bị 7";
            this.chkDevice7.UseVisualStyleBackColor = true;
            this.chkDevice7.Click += new System.EventHandler(this.chkDevice_Click);
            // 
            // chkDevice6
            // 
            this.chkDevice6.AutoSize = true;
            this.chkDevice6.Location = new System.Drawing.Point(132, 72);
            this.chkDevice6.Name = "chkDevice6";
            this.chkDevice6.Size = new System.Drawing.Size(70, 17);
            this.chkDevice6.TabIndex = 9;
            this.chkDevice6.Text = "Thiết bị 6";
            this.chkDevice6.UseVisualStyleBackColor = true;
            this.chkDevice6.Click += new System.EventHandler(this.chkDevice_Click);
            // 
            // chkDevice5
            // 
            this.chkDevice5.AutoSize = true;
            this.chkDevice5.Location = new System.Drawing.Point(132, 49);
            this.chkDevice5.Name = "chkDevice5";
            this.chkDevice5.Size = new System.Drawing.Size(70, 17);
            this.chkDevice5.TabIndex = 8;
            this.chkDevice5.Text = "Thiết bị 5";
            this.chkDevice5.UseVisualStyleBackColor = true;
            this.chkDevice5.Click += new System.EventHandler(this.chkDevice_Click);
            // 
            // chkDevice4
            // 
            this.chkDevice4.AutoSize = true;
            this.chkDevice4.Location = new System.Drawing.Point(6, 118);
            this.chkDevice4.Name = "chkDevice4";
            this.chkDevice4.Size = new System.Drawing.Size(70, 17);
            this.chkDevice4.TabIndex = 7;
            this.chkDevice4.Text = "Thiết bị 4";
            this.chkDevice4.UseVisualStyleBackColor = true;
            this.chkDevice4.Click += new System.EventHandler(this.chkDevice_Click);
            // 
            // chkDevice3
            // 
            this.chkDevice3.AutoSize = true;
            this.chkDevice3.Location = new System.Drawing.Point(6, 95);
            this.chkDevice3.Name = "chkDevice3";
            this.chkDevice3.Size = new System.Drawing.Size(70, 17);
            this.chkDevice3.TabIndex = 6;
            this.chkDevice3.Text = "Thiết bị 3";
            this.chkDevice3.UseVisualStyleBackColor = true;
            this.chkDevice3.Click += new System.EventHandler(this.chkDevice_Click);
            // 
            // chkDevice2
            // 
            this.chkDevice2.AutoSize = true;
            this.chkDevice2.Location = new System.Drawing.Point(6, 72);
            this.chkDevice2.Name = "chkDevice2";
            this.chkDevice2.Size = new System.Drawing.Size(70, 17);
            this.chkDevice2.TabIndex = 5;
            this.chkDevice2.Text = "Thiết bị 2";
            this.chkDevice2.UseVisualStyleBackColor = true;
            this.chkDevice2.Click += new System.EventHandler(this.chkDevice_Click);
            // 
            // chkDevice1
            // 
            this.chkDevice1.AutoSize = true;
            this.chkDevice1.Location = new System.Drawing.Point(6, 49);
            this.chkDevice1.Name = "chkDevice1";
            this.chkDevice1.Size = new System.Drawing.Size(70, 17);
            this.chkDevice1.TabIndex = 4;
            this.chkDevice1.Text = "Thiết bị 1";
            this.chkDevice1.UseVisualStyleBackColor = true;
            this.chkDevice1.Click += new System.EventHandler(this.chkDevice_Click);
            // 
            // cbxSecondSet
            // 
            this.cbxSecondSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSecondSet.FormattingEnabled = true;
            this.cbxSecondSet.Location = new System.Drawing.Point(108, 192);
            this.cbxSecondSet.Name = "cbxSecondSet";
            this.cbxSecondSet.Size = new System.Drawing.Size(45, 21);
            this.cbxSecondSet.TabIndex = 3;
            this.cbxSecondSet.SelectedIndexChanged += new System.EventHandler(this.cbxSecondSet_SelectedIndexChanged);
            // 
            // cbxMinuteSet
            // 
            this.cbxMinuteSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinuteSet.FormattingEnabled = true;
            this.cbxMinuteSet.Location = new System.Drawing.Point(57, 192);
            this.cbxMinuteSet.Name = "cbxMinuteSet";
            this.cbxMinuteSet.Size = new System.Drawing.Size(45, 21);
            this.cbxMinuteSet.TabIndex = 1;
            this.cbxMinuteSet.SelectedIndexChanged += new System.EventHandler(this.cbxMinuteSet_SelectedIndexChanged);
            // 
            // cbxHourSet
            // 
            this.cbxHourSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHourSet.FormattingEnabled = true;
            this.cbxHourSet.Location = new System.Drawing.Point(6, 192);
            this.cbxHourSet.Name = "cbxHourSet";
            this.cbxHourSet.Size = new System.Drawing.Size(45, 21);
            this.cbxHourSet.TabIndex = 0;
            this.cbxHourSet.SelectedIndexChanged += new System.EventHandler(this.cbxHourSet_SelectedIndexChanged);
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeNow.Location = new System.Drawing.Point(12, 335);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(178, 25);
            this.lblTimeNow.TabIndex = 7;
            this.lblTimeNow.Text = "01:00:00";
            this.lblTimeNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateNow
            // 
            this.lblDateNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNow.Location = new System.Drawing.Point(8, 366);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(182, 29);
            this.lblDateNow.TabIndex = 8;
            this.lblDateNow.Text = "29/12/2010";
            this.lblDateNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrCounter
            // 
            this.tmrCounter.Interval = 1000;
            this.tmrCounter.Tick += new System.EventHandler(this.tmrCounter_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 407);
            this.Controls.Add(this.lblDateNow);
            this.Controls.Add(this.lblTimeNow);
            this.Controls.Add(this.gbxDeviceControl);
            this.Controls.Add(this.gbxDeviceStatus);
            this.Controls.Add(this.lblRawInfo);
            this.Controls.Add(this.gbxSetting);
            this.Controls.Add(this.txtInputData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BẢNG ĐIỀU KHIỂN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbxSetting.ResumeLayout(false);
            this.gbxSetting.PerformLayout();
            this.gbxDeviceStatus.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDevice8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice1)).EndInit();
            this.gbxDeviceControl.ResumeLayout(false);
            this.gbxDeviceControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputData;
        private System.Windows.Forms.GroupBox gbxSetting;
        private System.Windows.Forms.ComboBox cbxCOM;
        private System.Windows.Forms.Label lblCOM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblLabelStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer tmrMonitoring;
        private System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Label lblRawInfo;
        private System.Windows.Forms.GroupBox gbxDeviceStatus;
        private System.Windows.Forms.GroupBox gbxDeviceControl;
        private System.Windows.Forms.ComboBox cbxSecondSet;
        private System.Windows.Forms.ComboBox cbxMinuteSet;
        private System.Windows.Forms.ComboBox cbxHourSet;
        private System.Windows.Forms.CheckBox chkDevice8;
        private System.Windows.Forms.CheckBox chkDevice7;
        private System.Windows.Forms.CheckBox chkDevice6;
        private System.Windows.Forms.CheckBox chkDevice5;
        private System.Windows.Forms.CheckBox chkDevice4;
        private System.Windows.Forms.CheckBox chkDevice3;
        private System.Windows.Forms.CheckBox chkDevice2;
        private System.Windows.Forms.CheckBox chkDevice1;
        private System.Windows.Forms.ComboBox cbxSelectMode;
        private System.Windows.Forms.Label lblHourSet;
        private System.Windows.Forms.Label lblTimeNow;
        private System.Windows.Forms.Label lblDateNow;
        private System.Windows.Forms.Label lblSelectMode;
        private System.Windows.Forms.RadioButton rbtTurnOffAll;
        private System.Windows.Forms.RadioButton rbtTurnOnAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picDevice1;
        private System.Windows.Forms.PictureBox picDevice8;
        private System.Windows.Forms.PictureBox picDevice7;
        private System.Windows.Forms.PictureBox picDevice6;
        private System.Windows.Forms.PictureBox picDevice5;
        private System.Windows.Forms.PictureBox picDevice4;
        private System.Windows.Forms.PictureBox picDevice3;
        private System.Windows.Forms.PictureBox picDevice2;
        private System.Windows.Forms.Label lblSpanTime;
        private System.Windows.Forms.ComboBox cbxSpanTime;
        private System.Windows.Forms.Timer tmrCounter;
    }
}

