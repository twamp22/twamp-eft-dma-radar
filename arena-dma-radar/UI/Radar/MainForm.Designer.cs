namespace arena_dma_radar.UI.Radar
{
    sealed partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            colorDialog1 = new ColorDialog();
            toolTip1 = new ToolTip(components);
            tabPage2 = new TabPage();
            flowLayoutPanel_Settings = new FlowLayoutPanel();
            flowLayoutPanel_RadarSettings = new FlowLayoutPanel();
            label2 = new Label();
            label8 = new Label();
            label1 = new Label();
            button_Restart = new Button();
            button_HotkeyManager = new Button();
            button_Radar_ColorPicker = new Button();
            button_BackupConfig = new Button();
            label_AimlineLength = new Label();
            trackBar_AimlineLength = new TrackBar();
            label_UIScale = new Label();
            trackBar_UIScale = new TrackBar();
            checkBox_MapSetup = new CheckBox();
            checkBox_Aimview = new CheckBox();
            checkBox_GrpConnect = new CheckBox();
            checkBox_HideNames = new CheckBox();
            flowLayoutPanel_MemWriteCheckbox = new FlowLayoutPanel();
            checkBox_EnableMemWrite = new CheckBox();
            flowLayoutPanel_MemWrites = new FlowLayoutPanel();
            label3 = new Label();
            checkBox_AdvancedMemWrites = new CheckBox();
            checkBox_AimBotEnabled = new CheckBox();
            checkBox_NoRecoilSway = new CheckBox();
            checkBox_Chams = new CheckBox();
            checkBox_NoVisor = new CheckBox();
            checkBox_NoWepMalf = new CheckBox();
            flowLayoutPanel_Aimbot = new FlowLayoutPanel();
            label13 = new Label();
            label6 = new Label();
            checkBox_SA_SafeLock = new CheckBox();
            checkBox_SA_AutoBone = new CheckBox();
            radioButton_AimTarget_FOV = new RadioButton();
            radioButton_AimTarget_CQB = new RadioButton();
            label_AimFOV = new Label();
            trackBar_AimFOV = new TrackBar();
            label10 = new Label();
            comboBox_AimbotTarget = new ComboBox();
            checkBox_AimRandomBone = new CheckBox();
            button_RandomBoneCfg = new Button();
            flowLayoutPanel_NoRecoil = new FlowLayoutPanel();
            label16 = new Label();
            label_Recoil = new Label();
            trackBar_NoRecoil = new TrackBar();
            label_Sway = new Label();
            trackBar_NoSway = new TrackBar();
            flowLayoutPanel_Chams = new FlowLayoutPanel();
            label17 = new Label();
            radioButton_Chams_Basic = new RadioButton();
            radioButton_Chams_Visible = new RadioButton();
            radioButton_Chams_Vischeck = new RadioButton();
            flowLayoutPanel_Vischeck = new FlowLayoutPanel();
            label14 = new Label();
            label15 = new Label();
            textBox_VischeckVisColor = new TextBox();
            button_VischeckVisColorPick = new Button();
            label33 = new Label();
            textBox_VischeckInvisColor = new TextBox();
            button_VischeckInvisColorPick = new Button();
            flowLayoutPanel_MonitorSettings = new FlowLayoutPanel();
            label11 = new Label();
            label_Width = new Label();
            textBox_ResWidth = new TextBox();
            label_Height = new Label();
            textBox_ResHeight = new TextBox();
            button_DetectRes = new Button();
            flowLayoutPanel_ESPSettings = new FlowLayoutPanel();
            label12 = new Label();
            label7 = new Label();
            button_StartESP = new Button();
            button_EspColorPicker = new Button();
            label_ESPFPSCap = new Label();
            textBox_EspFpsCap = new TextBox();
            checkBox_ESP_AutoFS = new CheckBox();
            comboBox_ESPAutoFS = new ComboBox();
            checkBox_ESP_Grenades = new CheckBox();
            checkBox_ESP_ShowMag = new CheckBox();
            checkBox_ESP_HighAlert = new CheckBox();
            checkBox_ESP_FireportAim = new CheckBox();
            checkBox_ESP_AimFov = new CheckBox();
            checkBox_ESP_AimLock = new CheckBox();
            checkBox_ESP_StatusText = new CheckBox();
            checkBox_ESP_FPS = new CheckBox();
            flowLayoutPanel_ESP_PlayerRender = new FlowLayoutPanel();
            label18 = new Label();
            radioButton_ESPRender_None = new RadioButton();
            radioButton_ESPRender_Bones = new RadioButton();
            checkBox_ESPRender_Labels = new CheckBox();
            checkBox_ESPRender_Weapons = new CheckBox();
            checkBox_ESPRender_Dist = new CheckBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label_EspFontScale = new Label();
            trackBar_EspFontScale = new TrackBar();
            label_EspLineScale = new Label();
            trackBar_EspLineScale = new TrackBar();
            tabPage1 = new TabPage();
            checkBox_MapFree = new CheckBox();
            groupBox_MapSetup = new GroupBox();
            button_MapSetupApply = new Button();
            textBox_mapScale = new TextBox();
            label5 = new Label();
            textBox_mapY = new TextBox();
            label4 = new Label();
            textBox_mapX = new TextBox();
            label_Pos = new Label();
            skglControl_Radar = new SKGLControl();
            tabControl1 = new TabControl();
            linkLabel_CheckForUpdates = new LinkLabel();
            tabPage2.SuspendLayout();
            flowLayoutPanel_Settings.SuspendLayout();
            flowLayoutPanel_RadarSettings.SuspendLayout();
            ((ISupportInitialize)trackBar_AimlineLength).BeginInit();
            ((ISupportInitialize)trackBar_UIScale).BeginInit();
            flowLayoutPanel_MemWriteCheckbox.SuspendLayout();
            flowLayoutPanel_MemWrites.SuspendLayout();
            flowLayoutPanel_Aimbot.SuspendLayout();
            ((ISupportInitialize)trackBar_AimFOV).BeginInit();
            flowLayoutPanel_NoRecoil.SuspendLayout();
            ((ISupportInitialize)trackBar_NoRecoil).BeginInit();
            ((ISupportInitialize)trackBar_NoSway).BeginInit();
            flowLayoutPanel_Chams.SuspendLayout();
            flowLayoutPanel_Vischeck.SuspendLayout();
            flowLayoutPanel_MonitorSettings.SuspendLayout();
            flowLayoutPanel_ESPSettings.SuspendLayout();
            flowLayoutPanel_ESP_PlayerRender.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((ISupportInitialize)trackBar_EspFontScale).BeginInit();
            ((ISupportInitialize)trackBar_EspLineScale).BeginInit();
            tabPage1.SuspendLayout();
            groupBox_MapSetup.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 20000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(flowLayoutPanel_Settings);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1256, 653);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_Settings
            // 
            flowLayoutPanel_Settings.AutoScroll = true;
            flowLayoutPanel_Settings.Controls.Add(flowLayoutPanel_RadarSettings);
            flowLayoutPanel_Settings.Controls.Add(flowLayoutPanel_MemWriteCheckbox);
            flowLayoutPanel_Settings.Controls.Add(flowLayoutPanel_MemWrites);
            flowLayoutPanel_Settings.Controls.Add(flowLayoutPanel_MonitorSettings);
            flowLayoutPanel_Settings.Controls.Add(flowLayoutPanel_ESPSettings);
            flowLayoutPanel_Settings.Dock = DockStyle.Fill;
            flowLayoutPanel_Settings.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel_Settings.Location = new Point(3, 3);
            flowLayoutPanel_Settings.Name = "flowLayoutPanel_Settings";
            flowLayoutPanel_Settings.Size = new Size(1250, 647);
            flowLayoutPanel_Settings.TabIndex = 10;
            flowLayoutPanel_Settings.WrapContents = false;
            // 
            // flowLayoutPanel_RadarSettings
            // 
            flowLayoutPanel_RadarSettings.AutoSize = true;
            flowLayoutPanel_RadarSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel_RadarSettings.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel_RadarSettings.Controls.Add(label2);
            flowLayoutPanel_RadarSettings.Controls.Add(label8);
            flowLayoutPanel_RadarSettings.Controls.Add(linkLabel_CheckForUpdates);
            flowLayoutPanel_RadarSettings.Controls.Add(label1);
            flowLayoutPanel_RadarSettings.Controls.Add(button_Restart);
            flowLayoutPanel_RadarSettings.Controls.Add(button_HotkeyManager);
            flowLayoutPanel_RadarSettings.Controls.Add(button_Radar_ColorPicker);
            flowLayoutPanel_RadarSettings.Controls.Add(button_BackupConfig);
            flowLayoutPanel_RadarSettings.Controls.Add(label_AimlineLength);
            flowLayoutPanel_RadarSettings.Controls.Add(trackBar_AimlineLength);
            flowLayoutPanel_RadarSettings.Controls.Add(label_UIScale);
            flowLayoutPanel_RadarSettings.Controls.Add(trackBar_UIScale);
            flowLayoutPanel_RadarSettings.Controls.Add(checkBox_MapSetup);
            flowLayoutPanel_RadarSettings.Controls.Add(checkBox_Aimview);
            flowLayoutPanel_RadarSettings.Controls.Add(checkBox_GrpConnect);
            flowLayoutPanel_RadarSettings.Controls.Add(checkBox_HideNames);
            flowLayoutPanel_RadarSettings.Dock = DockStyle.Top;
            flowLayoutPanel_Settings.SetFlowBreak(flowLayoutPanel_RadarSettings, true);
            flowLayoutPanel_RadarSettings.Location = new Point(3, 3);
            flowLayoutPanel_RadarSettings.Name = "flowLayoutPanel_RadarSettings";
            flowLayoutPanel_RadarSettings.Size = new Size(1186, 173);
            flowLayoutPanel_RadarSettings.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            flowLayoutPanel_RadarSettings.SetFlowBreak(label2, true);
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(179, 21);
            label2.TabIndex = 45;
            label2.Text = "Radar/General Settings";
            // 
            // label8
            // 
            label8.Location = new Point(3, 21);
            label8.Name = "label8";
            label8.Size = new Size(0, 0);
            label8.TabIndex = 46;
            label8.Text = "label8";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 45);
            label1.TabIndex = 16;
            label1.Text = "Zoom In: F1 / Mouse Whl Up\r\nZoom Out: F2 / Mouse Whl Dn\r\nToggle Fullscreen: F11";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Restart
            // 
            button_Restart.Font = new Font("Segoe UI", 9.75F);
            button_Restart.Location = new Point(180, 51);
            button_Restart.Name = "button_Restart";
            button_Restart.Size = new Size(107, 41);
            button_Restart.TabIndex = 18;
            button_Restart.Text = "Restart Radar";
            button_Restart.UseVisualStyleBackColor = true;
            button_Restart.Click += button_Restart_Click;
            // 
            // button_HotkeyManager
            // 
            button_HotkeyManager.Location = new Point(293, 51);
            button_HotkeyManager.Name = "button_HotkeyManager";
            button_HotkeyManager.Size = new Size(107, 41);
            button_HotkeyManager.TabIndex = 34;
            button_HotkeyManager.Text = "Hotkey Manager";
            button_HotkeyManager.UseVisualStyleBackColor = true;
            button_HotkeyManager.Click += button_HotkeyManager_Click;
            // 
            // button_Radar_ColorPicker
            // 
            button_Radar_ColorPicker.Location = new Point(406, 51);
            button_Radar_ColorPicker.Name = "button_Radar_ColorPicker";
            button_Radar_ColorPicker.Size = new Size(107, 41);
            button_Radar_ColorPicker.TabIndex = 21;
            button_Radar_ColorPicker.Text = "Color Picker";
            button_Radar_ColorPicker.UseVisualStyleBackColor = true;
            button_Radar_ColorPicker.Click += button_Radar_ColorPicker_Click;
            // 
            // button_BackupConfig
            // 
            flowLayoutPanel_RadarSettings.SetFlowBreak(button_BackupConfig, true);
            button_BackupConfig.Location = new Point(519, 51);
            button_BackupConfig.Name = "button_BackupConfig";
            button_BackupConfig.Size = new Size(107, 41);
            button_BackupConfig.TabIndex = 20;
            button_BackupConfig.Text = "Backup Config";
            button_BackupConfig.UseVisualStyleBackColor = true;
            button_BackupConfig.Click += button_BackupConfig_Click;
            // 
            // label_AimlineLength
            // 
            label_AimlineLength.Anchor = AnchorStyles.Right;
            label_AimlineLength.AutoSize = true;
            label_AimlineLength.Location = new Point(4, 113);
            label_AimlineLength.Margin = new Padding(4, 0, 4, 0);
            label_AimlineLength.Name = "label_AimlineLength";
            label_AimlineLength.Size = new Size(88, 15);
            label_AimlineLength.TabIndex = 13;
            label_AimlineLength.Text = "Aimline Length";
            label_AimlineLength.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBar_AimlineLength
            // 
            trackBar_AimlineLength.Anchor = AnchorStyles.Right;
            trackBar_AimlineLength.BackColor = SystemColors.Window;
            trackBar_AimlineLength.LargeChange = 50;
            trackBar_AimlineLength.Location = new Point(100, 98);
            trackBar_AimlineLength.Margin = new Padding(4, 3, 4, 3);
            trackBar_AimlineLength.Maximum = 1500;
            trackBar_AimlineLength.Minimum = 10;
            trackBar_AimlineLength.Name = "trackBar_AimlineLength";
            trackBar_AimlineLength.Size = new Size(92, 45);
            trackBar_AimlineLength.SmallChange = 5;
            trackBar_AimlineLength.TabIndex = 11;
            trackBar_AimlineLength.TickStyle = TickStyle.None;
            trackBar_AimlineLength.Value = 1500;
            // 
            // label_UIScale
            // 
            label_UIScale.Anchor = AnchorStyles.Right;
            label_UIScale.AutoSize = true;
            label_UIScale.Location = new Point(199, 113);
            label_UIScale.Name = "label_UIScale";
            label_UIScale.Size = new Size(72, 15);
            label_UIScale.TabIndex = 28;
            label_UIScale.Text = "UI Scale 1.00";
            label_UIScale.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBar_UIScale
            // 
            trackBar_UIScale.Anchor = AnchorStyles.Right;
            trackBar_UIScale.BackColor = SystemColors.Window;
            flowLayoutPanel_RadarSettings.SetFlowBreak(trackBar_UIScale, true);
            trackBar_UIScale.LargeChange = 10;
            trackBar_UIScale.Location = new Point(277, 98);
            trackBar_UIScale.Maximum = 200;
            trackBar_UIScale.Minimum = 50;
            trackBar_UIScale.Name = "trackBar_UIScale";
            trackBar_UIScale.Size = new Size(92, 45);
            trackBar_UIScale.TabIndex = 27;
            trackBar_UIScale.TickStyle = TickStyle.None;
            trackBar_UIScale.Value = 100;
            // 
            // checkBox_MapSetup
            // 
            checkBox_MapSetup.AutoSize = true;
            checkBox_MapSetup.Location = new Point(3, 149);
            checkBox_MapSetup.Name = "checkBox_MapSetup";
            checkBox_MapSetup.Size = new Size(153, 19);
            checkBox_MapSetup.TabIndex = 9;
            checkBox_MapSetup.Text = "Show Map Setup Helper";
            checkBox_MapSetup.UseVisualStyleBackColor = true;
            checkBox_MapSetup.CheckedChanged += checkBox_MapSetup_CheckedChanged;
            // 
            // checkBox_Aimview
            // 
            checkBox_Aimview.AutoSize = true;
            checkBox_Aimview.Location = new Point(162, 149);
            checkBox_Aimview.Name = "checkBox_Aimview";
            checkBox_Aimview.Size = new Size(86, 19);
            checkBox_Aimview.TabIndex = 19;
            checkBox_Aimview.Text = "ESP Widget";
            checkBox_Aimview.UseVisualStyleBackColor = true;
            checkBox_Aimview.CheckedChanged += checkBox_Aimview_CheckedChanged;
            // 
            // checkBox_GrpConnect
            // 
            checkBox_GrpConnect.AutoSize = true;
            checkBox_GrpConnect.Location = new Point(254, 149);
            checkBox_GrpConnect.Name = "checkBox_GrpConnect";
            checkBox_GrpConnect.Size = new Size(112, 19);
            checkBox_GrpConnect.TabIndex = 33;
            checkBox_GrpConnect.Text = "Connect Groups";
            checkBox_GrpConnect.UseVisualStyleBackColor = true;
            // 
            // checkBox_HideNames
            // 
            checkBox_HideNames.AutoSize = true;
            checkBox_HideNames.Location = new Point(372, 149);
            checkBox_HideNames.Name = "checkBox_HideNames";
            checkBox_HideNames.Size = new Size(91, 19);
            checkBox_HideNames.TabIndex = 26;
            checkBox_HideNames.Text = "Hide Names";
            checkBox_HideNames.UseVisualStyleBackColor = true;
            checkBox_HideNames.CheckedChanged += checkBox_HideNames_CheckedChanged;
            // 
            // flowLayoutPanel_MonitorSettings
            // 
            flowLayoutPanel_MonitorSettings.AutoSize = true;
            flowLayoutPanel_MonitorSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel_MonitorSettings.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel_MonitorSettings.Controls.Add(label11);
            flowLayoutPanel_MonitorSettings.Controls.Add(label_Width);
            flowLayoutPanel_MonitorSettings.Controls.Add(textBox_ResWidth);
            flowLayoutPanel_MonitorSettings.Controls.Add(label_Height);
            flowLayoutPanel_MonitorSettings.Controls.Add(textBox_ResHeight);
            flowLayoutPanel_MonitorSettings.Controls.Add(button_DetectRes);
            flowLayoutPanel_MonitorSettings.Dock = DockStyle.Top;
            flowLayoutPanel_Settings.SetFlowBreak(flowLayoutPanel_MonitorSettings, true);
            flowLayoutPanel_MonitorSettings.Location = new Point(3, 410);
            flowLayoutPanel_MonitorSettings.Name = "flowLayoutPanel_MonitorSettings";
            flowLayoutPanel_MonitorSettings.Size = new Size(1186, 70);
            flowLayoutPanel_MonitorSettings.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            flowLayoutPanel_MonitorSettings.SetFlowBreak(label11, true);
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(206, 21);
            label11.TabIndex = 46;
            label11.Text = "Monitor Info (ESP)";
            // 
            // label_Width
            // 
            label_Width.Anchor = AnchorStyles.Right;
            label_Width.AutoSize = true;
            label_Width.Location = new Point(3, 37);
            label_Width.Name = "label_Width";
            label_Width.Size = new Size(39, 15);
            label_Width.TabIndex = 2;
            label_Width.Text = "Width";
            // 
            // textBox_ResWidth
            // 
            textBox_ResWidth.Anchor = AnchorStyles.Right;
            textBox_ResWidth.Location = new Point(48, 33);
            textBox_ResWidth.MaxLength = 5;
            textBox_ResWidth.Name = "textBox_ResWidth";
            textBox_ResWidth.Size = new Size(51, 23);
            textBox_ResWidth.TabIndex = 0;
            textBox_ResWidth.Text = "1920";
            textBox_ResWidth.TextAlign = HorizontalAlignment.Center;
            textBox_ResWidth.TextChanged += textBox_ResWidth_TextChanged;
            // 
            // label_Height
            // 
            label_Height.Anchor = AnchorStyles.Right;
            label_Height.AutoSize = true;
            label_Height.Location = new Point(105, 37);
            label_Height.Name = "label_Height";
            label_Height.Size = new Size(43, 15);
            label_Height.TabIndex = 3;
            label_Height.Text = "Height";
            // 
            // textBox_ResHeight
            // 
            textBox_ResHeight.Anchor = AnchorStyles.Right;
            textBox_ResHeight.Location = new Point(154, 33);
            textBox_ResHeight.MaxLength = 5;
            textBox_ResHeight.Name = "textBox_ResHeight";
            textBox_ResHeight.Size = new Size(51, 23);
            textBox_ResHeight.TabIndex = 1;
            textBox_ResHeight.Text = "1080";
            textBox_ResHeight.TextAlign = HorizontalAlignment.Center;
            textBox_ResHeight.TextChanged += textBox_ResHeight_TextChanged;
            // 
            // button_DetectRes
            // 
            button_DetectRes.Location = new Point(211, 24);
            button_DetectRes.Name = "button_DetectRes";
            button_DetectRes.Size = new Size(107, 41);
            button_DetectRes.TabIndex = 4;
            button_DetectRes.Text = "Auto-Detect";
            button_DetectRes.UseVisualStyleBackColor = true;
            button_DetectRes.Click += button_DetectRes_Click;
            // 
            // flowLayoutPanel_ESPSettings
            // 
            flowLayoutPanel_ESPSettings.AutoSize = true;
            flowLayoutPanel_ESPSettings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel_ESPSettings.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel_ESPSettings.Controls.Add(label12);
            flowLayoutPanel_ESPSettings.Controls.Add(label7);
            flowLayoutPanel_ESPSettings.Controls.Add(button_StartESP);
            flowLayoutPanel_ESPSettings.Controls.Add(button_EspColorPicker);
            flowLayoutPanel_ESPSettings.Controls.Add(label_ESPFPSCap);
            flowLayoutPanel_ESPSettings.Controls.Add(textBox_EspFpsCap);
            flowLayoutPanel_ESPSettings.Controls.Add(checkBox_ESP_AutoFS);
            flowLayoutPanel_ESPSettings.Controls.Add(comboBox_ESPAutoFS);
            flowLayoutPanel_ESPSettings.Controls.Add(checkBox_ESP_Grenades);
            flowLayoutPanel_ESPSettings.Controls.Add(checkBox_ESP_ShowMag);
            flowLayoutPanel_ESPSettings.Controls.Add(checkBox_ESP_HighAlert);
            flowLayoutPanel_ESPSettings.Controls.Add(checkBox_ESP_FireportAim);
            flowLayoutPanel_ESPSettings.Controls.Add(checkBox_ESP_AimFov);
            flowLayoutPanel_ESPSettings.Controls.Add(checkBox_ESP_AimLock);
            flowLayoutPanel_ESPSettings.Controls.Add(checkBox_ESP_StatusText);
            flowLayoutPanel_ESPSettings.Controls.Add(checkBox_ESP_FPS);
            flowLayoutPanel_ESPSettings.Controls.Add(flowLayoutPanel_ESP_PlayerRender);
            flowLayoutPanel_ESPSettings.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel_ESPSettings.Dock = DockStyle.Top;
            flowLayoutPanel_Settings.SetFlowBreak(flowLayoutPanel_ESPSettings, true);
            flowLayoutPanel_ESPSettings.Location = new Point(3, 486);
            flowLayoutPanel_ESPSettings.Name = "flowLayoutPanel_ESPSettings";
            flowLayoutPanel_ESPSettings.Size = new Size(1186, 178);
            flowLayoutPanel_ESPSettings.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            flowLayoutPanel_ESPSettings.SetFlowBreak(label12, true);
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(79, 21);
            label12.TabIndex = 69;
            label12.Text = "Fuser ESP";
            // 
            // label7
            // 
            label7.Location = new Point(3, 21);
            label7.Name = "label7";
            label7.Size = new Size(0, 0);
            label7.TabIndex = 71;
            label7.Text = "label7";
            // 
            // button_StartESP
            // 
            button_StartESP.Anchor = AnchorStyles.Right;
            button_StartESP.Location = new Point(9, 24);
            button_StartESP.Name = "button_StartESP";
            button_StartESP.Size = new Size(107, 41);
            button_StartESP.TabIndex = 0;
            button_StartESP.Text = "Start ESP";
            button_StartESP.UseVisualStyleBackColor = true;
            button_StartESP.Click += button_StartESP_Click;
            // 
            // button_EspColorPicker
            // 
            button_EspColorPicker.Anchor = AnchorStyles.Right;
            button_EspColorPicker.Location = new Point(122, 24);
            button_EspColorPicker.Name = "button_EspColorPicker";
            button_EspColorPicker.Size = new Size(107, 41);
            button_EspColorPicker.TabIndex = 47;
            button_EspColorPicker.Text = "Color Picker";
            button_EspColorPicker.UseVisualStyleBackColor = true;
            button_EspColorPicker.Click += button_EspColorPicker_Click;
            // 
            // label_ESPFPSCap
            // 
            label_ESPFPSCap.Anchor = AnchorStyles.Right;
            label_ESPFPSCap.AutoSize = true;
            label_ESPFPSCap.Location = new Point(235, 37);
            label_ESPFPSCap.Name = "label_ESPFPSCap";
            label_ESPFPSCap.Size = new Size(50, 15);
            label_ESPFPSCap.TabIndex = 46;
            label_ESPFPSCap.Text = "FPS Cap";
            // 
            // textBox_EspFpsCap
            // 
            textBox_EspFpsCap.Anchor = AnchorStyles.Right;
            textBox_EspFpsCap.Location = new Point(291, 33);
            textBox_EspFpsCap.MaxLength = 4;
            textBox_EspFpsCap.Name = "textBox_EspFpsCap";
            textBox_EspFpsCap.Size = new Size(63, 23);
            textBox_EspFpsCap.TabIndex = 45;
            textBox_EspFpsCap.Text = "60";
            textBox_EspFpsCap.TextAlign = HorizontalAlignment.Center;
            textBox_EspFpsCap.TextChanged += textBox_EspFpsCap_TextChanged;
            // 
            // checkBox_ESP_AutoFS
            // 
            checkBox_ESP_AutoFS.Anchor = AnchorStyles.Right;
            checkBox_ESP_AutoFS.AutoSize = true;
            checkBox_ESP_AutoFS.Location = new Point(360, 35);
            checkBox_ESP_AutoFS.Name = "checkBox_ESP_AutoFS";
            checkBox_ESP_AutoFS.Size = new Size(108, 19);
            checkBox_ESP_AutoFS.TabIndex = 55;
            checkBox_ESP_AutoFS.Text = "Auto Fullscreen";
            checkBox_ESP_AutoFS.UseVisualStyleBackColor = true;
            checkBox_ESP_AutoFS.CheckedChanged += checkBox_ESP_AutoFS_CheckedChanged;
            // 
            // comboBox_ESPAutoFS
            // 
            comboBox_ESPAutoFS.Anchor = AnchorStyles.Right;
            comboBox_ESPAutoFS.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_ESPAutoFS.Enabled = false;
            flowLayoutPanel_ESPSettings.SetFlowBreak(comboBox_ESPAutoFS, true);
            comboBox_ESPAutoFS.FormattingEnabled = true;
            comboBox_ESPAutoFS.Location = new Point(474, 33);
            comboBox_ESPAutoFS.Name = "comboBox_ESPAutoFS";
            comboBox_ESPAutoFS.Size = new Size(121, 23);
            comboBox_ESPAutoFS.TabIndex = 56;
            comboBox_ESPAutoFS.SelectedIndexChanged += comboBox_ESPAutoFS_SelectedIndexChanged;
            // 
            // checkBox_ESP_Grenades
            // 
            checkBox_ESP_Grenades.AutoSize = true;
            checkBox_ESP_Grenades.Location = new Point(3, 71);
            checkBox_ESP_Grenades.Name = "checkBox_ESP_Grenades";
            checkBox_ESP_Grenades.Size = new Size(107, 19);
            checkBox_ESP_Grenades.TabIndex = 8;
            checkBox_ESP_Grenades.Text = "Show Grenades";
            checkBox_ESP_Grenades.UseVisualStyleBackColor = true;
            checkBox_ESP_Grenades.CheckedChanged += checkBox_ESP_Grenades_CheckedChanged;
            // 
            // checkBox_ESP_ShowMag
            // 
            checkBox_ESP_ShowMag.AutoSize = true;
            checkBox_ESP_ShowMag.Location = new Point(116, 71);
            checkBox_ESP_ShowMag.Name = "checkBox_ESP_ShowMag";
            checkBox_ESP_ShowMag.Size = new Size(109, 19);
            checkBox_ESP_ShowMag.TabIndex = 60;
            checkBox_ESP_ShowMag.Text = "Show Magazine";
            checkBox_ESP_ShowMag.UseVisualStyleBackColor = true;
            checkBox_ESP_ShowMag.CheckedChanged += checkBox_ESP_ShowMag_CheckedChanged;
            // 
            // checkBox_ESP_HighAlert
            // 
            checkBox_ESP_HighAlert.AutoSize = true;
            checkBox_ESP_HighAlert.Location = new Point(231, 71);
            checkBox_ESP_HighAlert.Name = "checkBox_ESP_HighAlert";
            checkBox_ESP_HighAlert.Size = new Size(80, 19);
            checkBox_ESP_HighAlert.TabIndex = 70;
            checkBox_ESP_HighAlert.Text = "High Alert";
            checkBox_ESP_HighAlert.UseVisualStyleBackColor = true;
            checkBox_ESP_HighAlert.CheckedChanged += checkBox_ESP_HighAlert_CheckedChanged;
            // 
            // checkBox_ESP_FireportAim
            // 
            checkBox_ESP_FireportAim.AutoSize = true;
            checkBox_ESP_FireportAim.Location = new Point(317, 71);
            checkBox_ESP_FireportAim.Name = "checkBox_ESP_FireportAim";
            checkBox_ESP_FireportAim.Size = new Size(124, 19);
            checkBox_ESP_FireportAim.TabIndex = 72;
            checkBox_ESP_FireportAim.Text = "Show Fireport Aim";
            checkBox_ESP_FireportAim.UseVisualStyleBackColor = true;
            checkBox_ESP_FireportAim.CheckedChanged += checkBox_ESP_FireportAim_CheckedChanged;
            // 
            // checkBox_ESP_StatusText
            // 
            checkBox_ESP_StatusText.AutoSize = true;
            checkBox_ESP_StatusText.Location = new Point(690, 71);
            checkBox_ESP_StatusText.Name = "checkBox_ESP_StatusText";
            checkBox_ESP_StatusText.Size = new Size(114, 19);
            checkBox_ESP_StatusText.TabIndex = 73;
            checkBox_ESP_StatusText.Text = "Show Status Text";
            checkBox_ESP_StatusText.UseVisualStyleBackColor = true;
            checkBox_ESP_StatusText.CheckedChanged += checkBox_ESP_StatusText_CheckedChanged;
            // 
            // checkBox_ESP_FPS
            // 
            checkBox_ESP_FPS.AutoSize = true;
            flowLayoutPanel_ESPSettings.SetFlowBreak(checkBox_ESP_FPS, true);
            checkBox_ESP_FPS.Location = new Point(810, 71);
            checkBox_ESP_FPS.Name = "checkBox_ESP_FPS";
            checkBox_ESP_FPS.Size = new Size(86, 19);
            checkBox_ESP_FPS.TabIndex = 5;
            checkBox_ESP_FPS.Text = "Display FPS";
            checkBox_ESP_FPS.UseVisualStyleBackColor = true;
            checkBox_ESP_FPS.CheckedChanged += checkBox_ESP_FPS_CheckedChanged;
            // 
            // flowLayoutPanel_ESP_PlayerRender
            // 
            flowLayoutPanel_ESP_PlayerRender.Anchor = AnchorStyles.Right;
            flowLayoutPanel_ESP_PlayerRender.AutoSize = true;
            flowLayoutPanel_ESP_PlayerRender.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel_ESP_PlayerRender.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel_ESP_PlayerRender.Controls.Add(label18);
            flowLayoutPanel_ESP_PlayerRender.Controls.Add(radioButton_ESPRender_None);
            flowLayoutPanel_ESP_PlayerRender.Controls.Add(radioButton_ESPRender_Bones);
            flowLayoutPanel_ESP_PlayerRender.Controls.Add(checkBox_ESPRender_Labels);
            flowLayoutPanel_ESP_PlayerRender.Controls.Add(checkBox_ESPRender_Weapons);
            flowLayoutPanel_ESP_PlayerRender.Controls.Add(checkBox_ESPRender_Dist);
            flowLayoutPanel_ESP_PlayerRender.Location = new Point(3, 96);
            flowLayoutPanel_ESP_PlayerRender.Name = "flowLayoutPanel_ESP_PlayerRender";
            flowLayoutPanel_ESP_PlayerRender.Size = new Size(200, 77);
            flowLayoutPanel_ESP_PlayerRender.TabIndex = 5;
            // 
            // label18
            // 
            label18.AutoSize = true;
            flowLayoutPanel_ESP_PlayerRender.SetFlowBreak(label18, true);
            label18.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(3, 0);
            label18.Name = "label18";
            label18.Size = new Size(113, 15);
            label18.TabIndex = 71;
            label18.Text = "Player Render Mode";
            // 
            // radioButton_ESPRender_None
            // 
            radioButton_ESPRender_None.AutoSize = true;
            radioButton_ESPRender_None.Location = new Point(3, 28);
            radioButton_ESPRender_None.Name = "radioButton_ESPRender_None";
            radioButton_ESPRender_None.Size = new Size(54, 19);
            radioButton_ESPRender_None.TabIndex = 63;
            radioButton_ESPRender_None.Text = "None";
            radioButton_ESPRender_None.UseVisualStyleBackColor = true;
            radioButton_ESPRender_None.CheckedChanged += radioButton_ESPRender_None_CheckedChanged;
            // 
            // radioButton_ESPRender_Bones
            // 
            radioButton_ESPRender_Bones.AutoSize = true;
            radioButton_ESPRender_Bones.Checked = true;
            flowLayoutPanel_ESP_PlayerRender.SetFlowBreak(radioButton_ESPRender_Bones, true);
            radioButton_ESPRender_Bones.Location = new Point(63, 28);
            radioButton_ESPRender_Bones.Name = "radioButton_ESPRender_Bones";
            radioButton_ESPRender_Bones.Size = new Size(57, 19);
            radioButton_ESPRender_Bones.TabIndex = 64;
            radioButton_ESPRender_Bones.TabStop = true;
            radioButton_ESPRender_Bones.Text = "Bones";
            radioButton_ESPRender_Bones.UseVisualStyleBackColor = true;
            radioButton_ESPRender_Bones.CheckedChanged += radioButton_ESPRender_Bones_CheckedChanged;
            // 
            // checkBox_ESPRender_Labels
            // 
            checkBox_ESPRender_Labels.AutoSize = true;
            checkBox_ESPRender_Labels.Location = new Point(3, 53);
            checkBox_ESPRender_Labels.Name = "checkBox_ESPRender_Labels";
            checkBox_ESPRender_Labels.Size = new Size(59, 19);
            checkBox_ESPRender_Labels.TabIndex = 68;
            checkBox_ESPRender_Labels.Text = "Labels";
            checkBox_ESPRender_Labels.UseVisualStyleBackColor = true;
            checkBox_ESPRender_Labels.CheckedChanged += checkBox_ESPRender_Labels_CheckedChanged;
            // 
            // checkBox_ESPRender_Weapons
            // 
            checkBox_ESPRender_Weapons.AutoSize = true;
            checkBox_ESPRender_Weapons.Location = new Point(68, 53);
            checkBox_ESPRender_Weapons.Name = "checkBox_ESPRender_Weapons";
            checkBox_ESPRender_Weapons.Size = new Size(75, 19);
            checkBox_ESPRender_Weapons.TabIndex = 69;
            checkBox_ESPRender_Weapons.Text = "Weapons";
            checkBox_ESPRender_Weapons.UseVisualStyleBackColor = true;
            checkBox_ESPRender_Weapons.CheckedChanged += checkBox_ESPRender_Weapons_CheckedChanged;
            // 
            // checkBox_ESPRender_Dist
            // 
            checkBox_ESPRender_Dist.AutoSize = true;
            checkBox_ESPRender_Dist.Location = new Point(149, 53);
            checkBox_ESPRender_Dist.Name = "checkBox_ESPRender_Dist";
            checkBox_ESPRender_Dist.Size = new Size(46, 19);
            checkBox_ESPRender_Dist.TabIndex = 70;
            checkBox_ESPRender_Dist.Text = "Dist";
            checkBox_ESPRender_Dist.UseVisualStyleBackColor = true;
            checkBox_ESPRender_Dist.CheckedChanged += checkBox_ESPRender_Dist_CheckedChanged;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Anchor = AnchorStyles.Right;
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.Controls.Add(label_EspFontScale);
            flowLayoutPanel4.Controls.Add(trackBar_EspFontScale);
            flowLayoutPanel4.Controls.Add(label_EspLineScale);
            flowLayoutPanel4.Controls.Add(trackBar_EspLineScale);
            flowLayoutPanel4.Location = new Point(209, 109);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(346, 51);
            flowLayoutPanel4.TabIndex = 4;
            // 
            // label_EspFontScale
            // 
            label_EspFontScale.Anchor = AnchorStyles.Right;
            label_EspFontScale.AutoSize = true;
            label_EspFontScale.Location = new Point(3, 18);
            label_EspFontScale.Name = "label_EspFontScale";
            label_EspFontScale.Size = new Size(85, 15);
            label_EspFontScale.TabIndex = 16;
            label_EspFontScale.Text = "Font Scale 1.00";
            // 
            // trackBar_EspFontScale
            // 
            trackBar_EspFontScale.Anchor = AnchorStyles.Right;
            trackBar_EspFontScale.BackColor = SystemColors.Window;
            trackBar_EspFontScale.Location = new Point(94, 3);
            trackBar_EspFontScale.Maximum = 200;
            trackBar_EspFontScale.Minimum = 50;
            trackBar_EspFontScale.Name = "trackBar_EspFontScale";
            trackBar_EspFontScale.Size = new Size(77, 45);
            trackBar_EspFontScale.TabIndex = 42;
            trackBar_EspFontScale.TickStyle = TickStyle.None;
            trackBar_EspFontScale.Value = 100;
            // 
            // label_EspLineScale
            // 
            label_EspLineScale.Anchor = AnchorStyles.Right;
            label_EspLineScale.AutoSize = true;
            label_EspLineScale.Location = new Point(177, 18);
            label_EspLineScale.Name = "label_EspLineScale";
            label_EspLineScale.Size = new Size(83, 15);
            label_EspLineScale.TabIndex = 43;
            label_EspLineScale.Text = "Line Scale 1.00";
            // 
            // trackBar_EspLineScale
            // 
            trackBar_EspLineScale.Anchor = AnchorStyles.Right;
            trackBar_EspLineScale.BackColor = SystemColors.Window;
            trackBar_EspLineScale.Location = new Point(266, 3);
            trackBar_EspLineScale.Maximum = 200;
            trackBar_EspLineScale.Minimum = 10;
            trackBar_EspLineScale.Name = "trackBar_EspLineScale";
            trackBar_EspLineScale.Size = new Size(77, 45);
            trackBar_EspLineScale.TabIndex = 44;
            trackBar_EspLineScale.TickStyle = TickStyle.None;
            trackBar_EspLineScale.Value = 100;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(checkBox_MapFree);
            tabPage1.Controls.Add(groupBox_MapSetup);
            tabPage1.Controls.Add(skglControl_Radar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1256, 653);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Radar";
            // 
            // checkBox_MapFree
            // 
            checkBox_MapFree.Appearance = Appearance.Button;
            checkBox_MapFree.AutoSize = true;
            checkBox_MapFree.Location = new Point(6, 6);
            checkBox_MapFree.Name = "checkBox_MapFree";
            checkBox_MapFree.Size = new Size(66, 25);
            checkBox_MapFree.TabIndex = 17;
            checkBox_MapFree.Text = "Map Free";
            checkBox_MapFree.UseVisualStyleBackColor = true;
            checkBox_MapFree.CheckedChanged += checkBox_MapFree_CheckedChanged;
            // 
            // groupBox_MapSetup
            // 
            groupBox_MapSetup.BackColor = Color.WhiteSmoke;
            groupBox_MapSetup.Controls.Add(button_MapSetupApply);
            groupBox_MapSetup.Controls.Add(textBox_mapScale);
            groupBox_MapSetup.Controls.Add(label5);
            groupBox_MapSetup.Controls.Add(textBox_mapY);
            groupBox_MapSetup.Controls.Add(label4);
            groupBox_MapSetup.Controls.Add(textBox_mapX);
            groupBox_MapSetup.Controls.Add(label_Pos);
            groupBox_MapSetup.Location = new Point(6, 36);
            groupBox_MapSetup.Name = "groupBox_MapSetup";
            groupBox_MapSetup.Size = new Size(327, 175);
            groupBox_MapSetup.TabIndex = 11;
            groupBox_MapSetup.TabStop = false;
            groupBox_MapSetup.Text = "Map Setup";
            groupBox_MapSetup.Visible = false;
            // 
            // button_MapSetupApply
            // 
            button_MapSetupApply.Location = new Point(6, 143);
            button_MapSetupApply.Name = "button_MapSetupApply";
            button_MapSetupApply.Size = new Size(75, 23);
            button_MapSetupApply.TabIndex = 16;
            button_MapSetupApply.Text = "Apply";
            button_MapSetupApply.UseVisualStyleBackColor = true;
            button_MapSetupApply.Click += button_MapSetupApply_Click;
            // 
            // textBox_mapScale
            // 
            textBox_mapScale.Location = new Point(46, 101);
            textBox_mapScale.Name = "textBox_mapScale";
            textBox_mapScale.Size = new Size(50, 23);
            textBox_mapScale.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 104);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 14;
            label5.Text = "Scale";
            // 
            // textBox_mapY
            // 
            textBox_mapY.Location = new Point(102, 67);
            textBox_mapY.Name = "textBox_mapY";
            textBox_mapY.Size = new Size(50, 23);
            textBox_mapY.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 70);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 12;
            label4.Text = "X,Y";
            // 
            // textBox_mapX
            // 
            textBox_mapX.Location = new Point(46, 67);
            textBox_mapX.Name = "textBox_mapX";
            textBox_mapX.Size = new Size(50, 23);
            textBox_mapX.TabIndex = 11;
            // 
            // label_Pos
            // 
            label_Pos.AutoSize = true;
            label_Pos.Location = new Point(7, 19);
            label_Pos.Margin = new Padding(4, 0, 4, 0);
            label_Pos.Name = "label_Pos";
            label_Pos.Size = new Size(43, 15);
            label_Pos.TabIndex = 10;
            label_Pos.Text = "coords";
            // 
            // skglControl_Radar
            // 
            skglControl_Radar.BackColor = Color.Black;
            skglControl_Radar.Dock = DockStyle.Fill;
            skglControl_Radar.Location = new Point(3, 3);
            skglControl_Radar.Margin = new Padding(4, 3, 4, 3);
            skglControl_Radar.Name = "skglControl_Radar";
            skglControl_Radar.Size = new Size(1250, 647);
            skglControl_Radar.TabIndex = 18;
            skglControl_Radar.VSync = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1264, 681);
            tabControl1.TabIndex = 8;
            // 
            // linkLabel_CheckForUpdates
            // 
            linkLabel_CheckForUpdates.AutoSize = true;
            flowLayoutPanel_RadarSettings.SetFlowBreak(linkLabel_CheckForUpdates, true);
            linkLabel_CheckForUpdates.Location = new Point(9, 27);
            linkLabel_CheckForUpdates.Margin = new Padding(3, 6, 3, 6);
            linkLabel_CheckForUpdates.Name = "linkLabel_CheckForUpdates";
            linkLabel_CheckForUpdates.Size = new Size(255, 15);
            linkLabel_CheckForUpdates.TabIndex = 47;
            linkLabel_CheckForUpdates.TabStop = true;
            linkLabel_CheckForUpdates.Text = "Check for updates at lone-eft.com/opensource";
            linkLabel_CheckForUpdates.LinkClicked += linkLabel_CheckForUpdates_LinkClicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Arena DMA Radar";
            tabPage2.ResumeLayout(false);
            flowLayoutPanel_Settings.ResumeLayout(false);
            flowLayoutPanel_Settings.PerformLayout();
            flowLayoutPanel_RadarSettings.ResumeLayout(false);
            flowLayoutPanel_RadarSettings.PerformLayout();
            ((ISupportInitialize)trackBar_AimlineLength).EndInit();
            ((ISupportInitialize)trackBar_UIScale).EndInit();
            flowLayoutPanel_MemWriteCheckbox.ResumeLayout(false);
            flowLayoutPanel_MemWriteCheckbox.PerformLayout();
            flowLayoutPanel_MemWrites.ResumeLayout(false);
            flowLayoutPanel_MemWrites.PerformLayout();
            flowLayoutPanel_Aimbot.ResumeLayout(false);
            flowLayoutPanel_Aimbot.PerformLayout();
            ((ISupportInitialize)trackBar_AimFOV).EndInit();
            flowLayoutPanel_NoRecoil.ResumeLayout(false);
            flowLayoutPanel_NoRecoil.PerformLayout();
            ((ISupportInitialize)trackBar_NoRecoil).EndInit();
            ((ISupportInitialize)trackBar_NoSway).EndInit();
            flowLayoutPanel_Chams.ResumeLayout(false);
            flowLayoutPanel_Chams.PerformLayout();
            flowLayoutPanel_Vischeck.ResumeLayout(false);
            flowLayoutPanel_Vischeck.PerformLayout();
            flowLayoutPanel_MonitorSettings.ResumeLayout(false);
            flowLayoutPanel_MonitorSettings.PerformLayout();
            flowLayoutPanel_ESPSettings.ResumeLayout(false);
            flowLayoutPanel_ESPSettings.PerformLayout();
            flowLayoutPanel_ESP_PlayerRender.ResumeLayout(false);
            flowLayoutPanel_ESP_PlayerRender.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((ISupportInitialize)trackBar_EspFontScale).EndInit();
            ((ISupportInitialize)trackBar_EspLineScale).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox_MapSetup.ResumeLayout(false);
            groupBox_MapSetup.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ColorDialog colorDialog1;
        private ToolTip toolTip1;
        private TabPage tabPage2;
        private FlowLayoutPanel flowLayoutPanel_Settings;
        private FlowLayoutPanel flowLayoutPanel_RadarSettings;
        private Label label2;
        private Label label1;
        private Button button_Restart;
        private Button button_HotkeyManager;
        private Button button_Radar_ColorPicker;
        private Button button_BackupConfig;
        private Label label_AimlineLength;
        private TrackBar trackBar_AimlineLength;
        private Label label_UIScale;
        private TrackBar trackBar_UIScale;
        private CheckBox checkBox_MapSetup;
        private CheckBox checkBox_Aimview;
        private CheckBox checkBox_GrpConnect;
        private CheckBox checkBox_HideNames;
        private CheckBox checkBox_EnableMemWrite;
        private FlowLayoutPanel flowLayoutPanel_MemWrites;
        private Label label3;
        private CheckBox checkBox_AimBotEnabled;
        private CheckBox checkBox_NoRecoilSway;
        private CheckBox checkBox_Chams;
        private CheckBox checkBox_NoVisor;
        private FlowLayoutPanel flowLayoutPanel_Aimbot;
        private Label label13;
        private CheckBox checkBox_SA_AutoBone;
        private CheckBox checkBox_SA_SafeLock;
        private RadioButton radioButton_AimTarget_FOV;
        private RadioButton radioButton_AimTarget_CQB;
        private Label label_AimFOV;
        private TrackBar trackBar_AimFOV;
        private Label label10;
        private ComboBox comboBox_AimbotTarget;
        private CheckBox checkBox_AimRandomBone;
        private Button button_RandomBoneCfg;
        private FlowLayoutPanel flowLayoutPanel_NoRecoil;
        private Label label16;
        private Label label_Recoil;
        private TrackBar trackBar_NoRecoil;
        private Label label_Sway;
        private TrackBar trackBar_NoSway;
        private FlowLayoutPanel flowLayoutPanel_Chams;
        private Label label17;
        private RadioButton radioButton_Chams_Basic;
        private RadioButton radioButton_Chams_Vischeck;
        private FlowLayoutPanel flowLayoutPanel_MonitorSettings;
        private Label label11;
        private Label label_Width;
        private TextBox textBox_ResWidth;
        private Label label_Height;
        private TextBox textBox_ResHeight;
        private Button button_DetectRes;
        private FlowLayoutPanel flowLayoutPanel_ESPSettings;
        private Label label12;
        private Button button_StartESP;
        private Button button_EspColorPicker;
        private Label label_ESPFPSCap;
        private TextBox textBox_EspFpsCap;
        private CheckBox checkBox_ESP_AutoFS;
        private ComboBox comboBox_ESPAutoFS;
        private CheckBox checkBox_ESP_ShowMag;
        private CheckBox checkBox_ESP_AimFov;
        private CheckBox checkBox_ESP_AimLock;
        private CheckBox checkBox_ESP_FPS;
        private FlowLayoutPanel flowLayoutPanel_ESP_PlayerRender;
        private Label label18;
        private RadioButton radioButton_ESPRender_None;
        private RadioButton radioButton_ESPRender_Bones;
        private CheckBox checkBox_ESPRender_Labels;
        private CheckBox checkBox_ESPRender_Weapons;
        private CheckBox checkBox_ESPRender_Dist;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label_EspFontScale;
        private TrackBar trackBar_EspFontScale;
        private TabPage tabPage1;
        private CheckBox checkBox_MapFree;
        private GroupBox groupBox_MapSetup;
        private Button button_MapSetupApply;
        private TextBox textBox_mapScale;
        private Label label5;
        private TextBox textBox_mapY;
        private Label label4;
        private TextBox textBox_mapX;
        private Label label_Pos;
        private SKGLControl skglControl_Radar;
        private TabControl tabControl1;
        private CheckBox checkBox_ESP_Grenades;
        private CheckBox checkBox_ESP_HighAlert;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckBox checkBox_ESP_FireportAim;
        private Label label_EspLineScale;
        private TrackBar trackBar_EspLineScale;
        private CheckBox checkBox_ESP_StatusText;
        private CheckBox checkBox_NoWepMalf;
        private CheckBox checkBox_AdvancedMemWrites;
        private FlowLayoutPanel flowLayoutPanel_Vischeck;
        private Label label14;
        private Label label15;
        private TextBox textBox_VischeckVisColor;
        private Button button_VischeckVisColorPick;
        private Label label33;
        private TextBox textBox_VischeckInvisColor;
        private Button button_VischeckInvisColorPick;
        private RadioButton radioButton_Chams_Visible;
        private FlowLayoutPanel flowLayoutPanel_MemWriteCheckbox;
        private LinkLabel linkLabel_CheckForUpdates;
    }
}

