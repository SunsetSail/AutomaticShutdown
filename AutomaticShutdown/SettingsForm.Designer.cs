namespace AutomaticShutdown;

partial class SettingsForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        panelSidebar = new Panel();
        btnTabGeneral = new Button();
        btnTabDelay = new Button();
        btnTabAutoStart = new Button();
        btnTabAbout = new Button();

        panelContent = new Panel();

        panelGeneral = new Panel();
        lblWorkMinutes = new Label();
        numWorkMinutes = new NumericUpDown();
        lblWorkMinutesHint = new Label();
        lblShutdownCountdown = new Label();
        numShutdownCountdown = new NumericUpDown();
        lblShutdownHint = new Label();
        lblDelayOptionsLabel = new Label();
        txtDelayOptions = new TextBox();
        lblDelayHint = new Label();
        chkEnableTrayCountdown = new CheckBox();
        lblLogPath = new Label();
        txtLogPath = new TextBox();
        btnBrowse = new Button();

        panelDelay = new Panel();
        lblDelayTitle = new Label();
        lblDelayDesc = new Label();
        txtDelayOptionsPage = new TextBox();
        lblDelayPageHint = new Label();

        panelAutoStart = new Panel();
        lblAutoStartTitle = new Label();
        lblAutoStartDesc = new Label();
        chkAutoStart = new CheckBox();
        lblAutoStartStatus = new Label();

        panelAbout = new Panel();
        lblAboutTitle = new Label();
        lblAboutVersion = new Label();
        lblAboutDesc = new Label();

        panelButtons = new Panel();
        btnSave = new Button();
        btnCancel = new Button();
        btnReset = new Button();

        SuspendLayout();

        // panelSidebar
        panelSidebar.Dock = DockStyle.Left;
        panelSidebar.Width = 140;
        panelSidebar.BackColor = Color.FromArgb(245, 245, 245);

        // btnTabGeneral
        btnTabGeneral.Text = "⚙ 常规设置";
        btnTabGeneral.FlatStyle = FlatStyle.Flat;
        btnTabGeneral.FlatAppearance.BorderSize = 0;
        btnTabGeneral.Dock = DockStyle.Top;
        btnTabGeneral.Height = 42;
        btnTabGeneral.TextAlign = ContentAlignment.MiddleLeft;
        btnTabGeneral.Padding = new Padding(12, 0, 0, 0);
        btnTabGeneral.Font = new Font("Microsoft YaHei UI", 9.5F);
        btnTabGeneral.Cursor = Cursors.Hand;
        btnTabGeneral.Click += BtnTabGeneral_Click;

        // btnTabDelay
        btnTabDelay.Text = "🕐 延后选项";
        btnTabDelay.FlatStyle = FlatStyle.Flat;
        btnTabDelay.FlatAppearance.BorderSize = 0;
        btnTabDelay.Dock = DockStyle.Top;
        btnTabDelay.Height = 42;
        btnTabDelay.TextAlign = ContentAlignment.MiddleLeft;
        btnTabDelay.Padding = new Padding(12, 0, 0, 0);
        btnTabDelay.Font = new Font("Microsoft YaHei UI", 9.5F);
        btnTabDelay.Cursor = Cursors.Hand;
        btnTabDelay.Click += BtnTabDelay_Click;

        // btnTabAutoStart
        btnTabAutoStart.Text = "🚀 开机自启";
        btnTabAutoStart.FlatStyle = FlatStyle.Flat;
        btnTabAutoStart.FlatAppearance.BorderSize = 0;
        btnTabAutoStart.Dock = DockStyle.Top;
        btnTabAutoStart.Height = 42;
        btnTabAutoStart.TextAlign = ContentAlignment.MiddleLeft;
        btnTabAutoStart.Padding = new Padding(12, 0, 0, 0);
        btnTabAutoStart.Font = new Font("Microsoft YaHei UI", 9.5F);
        btnTabAutoStart.Cursor = Cursors.Hand;
        btnTabAutoStart.Click += BtnTabAutoStart_Click;

        // btnTabAbout
        btnTabAbout.Text = "ℹ 关于";
        btnTabAbout.FlatStyle = FlatStyle.Flat;
        btnTabAbout.FlatAppearance.BorderSize = 0;
        btnTabAbout.Dock = DockStyle.Top;
        btnTabAbout.Height = 42;
        btnTabAbout.TextAlign = ContentAlignment.MiddleLeft;
        btnTabAbout.Padding = new Padding(12, 0, 0, 0);
        btnTabAbout.Font = new Font("Microsoft YaHei UI", 9.5F);
        btnTabAbout.Cursor = Cursors.Hand;
        btnTabAbout.Click += BtnTabAbout_Click;

        panelSidebar.Controls.Add(btnTabAbout);
        panelSidebar.Controls.Add(btnTabAutoStart);
        panelSidebar.Controls.Add(btnTabDelay);
        panelSidebar.Controls.Add(btnTabGeneral);

        // panelContent
        panelContent.Dock = DockStyle.Fill;
        panelContent.Padding = new Padding(20);

        // === panelGeneral ===
        panelGeneral.Dock = DockStyle.Fill;

        lblWorkMinutes.Text = "工作时长（分钟）：";
        lblWorkMinutes.Location = new Point(0, 10);
        lblWorkMinutes.AutoSize = true;
        lblWorkMinutes.Font = new Font("Microsoft YaHei UI", 10F);

        numWorkMinutes.Location = new Point(160, 7);
        numWorkMinutes.Size = new Size(80, 27);
        numWorkMinutes.Minimum = 1;
        numWorkMinutes.Maximum = 1440;
        numWorkMinutes.Font = new Font("Microsoft YaHei UI", 10F);

        lblWorkMinutesHint.Text = "(9小时30分钟)";
        lblWorkMinutesHint.Location = new Point(248, 12);
        lblWorkMinutesHint.AutoSize = true;
        lblWorkMinutesHint.ForeColor = Color.Gray;
        lblWorkMinutesHint.Font = new Font("Microsoft YaHei UI", 9F);

        lblShutdownCountdown.Text = "关机倒计时（分钟）：";
        lblShutdownCountdown.Location = new Point(0, 55);
        lblShutdownCountdown.AutoSize = true;
        lblShutdownCountdown.Font = new Font("Microsoft YaHei UI", 10F);

        numShutdownCountdown.Location = new Point(160, 52);
        numShutdownCountdown.Size = new Size(80, 27);
        numShutdownCountdown.Minimum = 1;
        numShutdownCountdown.Maximum = 60;
        numShutdownCountdown.Font = new Font("Microsoft YaHei UI", 10F);

        lblShutdownHint.Text = "(分钟)";
        lblShutdownHint.Location = new Point(248, 57);
        lblShutdownHint.AutoSize = true;
        lblShutdownHint.ForeColor = Color.Gray;
        lblShutdownHint.Font = new Font("Microsoft YaHei UI", 9F);

        lblDelayOptionsLabel.Text = "延后选项（分钟）：";
        lblDelayOptionsLabel.Location = new Point(0, 100);
        lblDelayOptionsLabel.AutoSize = true;
        lblDelayOptionsLabel.Font = new Font("Microsoft YaHei UI", 10F);

        txtDelayOptions.Location = new Point(160, 97);
        txtDelayOptions.Size = new Size(150, 27);
        txtDelayOptions.Font = new Font("Microsoft YaHei UI", 10F);

        lblDelayHint.Text = "(逗号分隔)";
        lblDelayHint.Location = new Point(318, 102);
        lblDelayHint.AutoSize = true;
        lblDelayHint.ForeColor = Color.Gray;
        lblDelayHint.Font = new Font("Microsoft YaHei UI", 9F);

        chkEnableTrayCountdown.Text = "在任务栏显示下班倒计时";
        chkEnableTrayCountdown.Location = new Point(0, 145);
        chkEnableTrayCountdown.AutoSize = true;
        chkEnableTrayCountdown.Font = new Font("Microsoft YaHei UI", 10F);

        lblLogPath.Text = "开机时间记录文件：";
        lblLogPath.Location = new Point(0, 185);
        lblLogPath.AutoSize = true;
        lblLogPath.Font = new Font("Microsoft YaHei UI", 10F);

        txtLogPath.Location = new Point(160, 182);
        txtLogPath.Size = new Size(180, 27);
        txtLogPath.Font = new Font("Microsoft YaHei UI", 9.5F);

        btnBrowse.Text = "浏览...";
        btnBrowse.Location = new Point(348, 181);
        btnBrowse.Size = new Size(65, 29);
        btnBrowse.FlatStyle = FlatStyle.Flat;
        btnBrowse.Font = new Font("Microsoft YaHei UI", 8.5F);
        btnBrowse.Cursor = Cursors.Hand;
        btnBrowse.Click += BtnBrowse_Click;

        panelGeneral.Controls.Add(lblWorkMinutes);
        panelGeneral.Controls.Add(numWorkMinutes);
        panelGeneral.Controls.Add(lblWorkMinutesHint);
        panelGeneral.Controls.Add(lblShutdownCountdown);
        panelGeneral.Controls.Add(numShutdownCountdown);
        panelGeneral.Controls.Add(lblShutdownHint);
        panelGeneral.Controls.Add(lblDelayOptionsLabel);
        panelGeneral.Controls.Add(txtDelayOptions);
        panelGeneral.Controls.Add(lblDelayHint);
        panelGeneral.Controls.Add(chkEnableTrayCountdown);
        panelGeneral.Controls.Add(lblLogPath);
        panelGeneral.Controls.Add(txtLogPath);
        panelGeneral.Controls.Add(btnBrowse);

        // === panelDelay ===
        panelDelay.Dock = DockStyle.Fill;
        panelDelay.Visible = false;

        lblDelayTitle.Text = "延后选项";
        lblDelayTitle.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
        lblDelayTitle.Location = new Point(0, 5);
        lblDelayTitle.AutoSize = true;

        lblDelayDesc.Text = "设置延后关机的可选分钟数，用逗号分隔：";
        lblDelayDesc.Location = new Point(0, 40);
        lblDelayDesc.AutoSize = true;
        lblDelayDesc.Font = new Font("Microsoft YaHei UI", 9.5F);

        txtDelayOptionsPage.Location = new Point(0, 70);
        txtDelayOptionsPage.Size = new Size(280, 27);
        txtDelayOptionsPage.Font = new Font("Microsoft YaHei UI", 10F);

        lblDelayPageHint.Text = "例如：5,10,15,30";
        lblDelayPageHint.Location = new Point(0, 105);
        lblDelayPageHint.AutoSize = true;
        lblDelayPageHint.ForeColor = Color.Gray;

        panelDelay.Controls.Add(lblDelayTitle);
        panelDelay.Controls.Add(lblDelayDesc);
        panelDelay.Controls.Add(txtDelayOptionsPage);
        panelDelay.Controls.Add(lblDelayPageHint);

        // === panelAutoStart ===
        panelAutoStart.Dock = DockStyle.Fill;
        panelAutoStart.Visible = false;

        lblAutoStartTitle.Text = "开机自启";
        lblAutoStartTitle.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
        lblAutoStartTitle.Location = new Point(0, 5);
        lblAutoStartTitle.AutoSize = true;

        lblAutoStartDesc.Text = "设置是否在Windows启动时自动运行本程序";
        lblAutoStartDesc.Location = new Point(0, 40);
        lblAutoStartDesc.AutoSize = true;
        lblAutoStartDesc.Font = new Font("Microsoft YaHei UI", 9.5F);

        chkAutoStart.Text = "开机自动启动";
        chkAutoStart.Location = new Point(0, 75);
        chkAutoStart.AutoSize = true;
        chkAutoStart.Font = new Font("Microsoft YaHei UI", 10F);
        chkAutoStart.CheckedChanged += ChkAutoStart_CheckedChanged;

        lblAutoStartStatus.Text = "未启用";
        lblAutoStartStatus.Location = new Point(140, 78);
        lblAutoStartStatus.AutoSize = true;
        lblAutoStartStatus.ForeColor = Color.Gray;
        lblAutoStartStatus.Font = new Font("Microsoft YaHei UI", 9F);

        panelAutoStart.Controls.Add(lblAutoStartTitle);
        panelAutoStart.Controls.Add(lblAutoStartDesc);
        panelAutoStart.Controls.Add(chkAutoStart);
        panelAutoStart.Controls.Add(lblAutoStartStatus);

        // === panelAbout ===
        panelAbout.Dock = DockStyle.Fill;
        panelAbout.Visible = false;

        lblAboutTitle.Text = "关于";
        lblAboutTitle.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
        lblAboutTitle.Location = new Point(0, 5);
        lblAboutTitle.AutoSize = true;

        lblAboutVersion.Text = "电脑定时关机助手 v1.0";
        lblAboutVersion.Location = new Point(0, 40);
        lblAboutVersion.AutoSize = true;
        lblAboutVersion.Font = new Font("Microsoft YaHei UI", 10F);

        lblAboutDesc.Text = "自动记录每日首次开机时间，\n工作满指定时长后自动关机提醒。\n\n支持开机自启、延后关机、\n系统托盘最小化等功能。";
        lblAboutDesc.Location = new Point(0, 70);
        lblAboutDesc.AutoSize = true;
        lblAboutDesc.Font = new Font("Microsoft YaHei UI", 9.5F);
        lblAboutDesc.ForeColor = Color.Gray;

        panelAbout.Controls.Add(lblAboutTitle);
        panelAbout.Controls.Add(lblAboutVersion);
        panelAbout.Controls.Add(lblAboutDesc);

        // panelContent - add pages
        panelContent.Controls.Add(panelGeneral);
        panelContent.Controls.Add(panelDelay);
        panelContent.Controls.Add(panelAutoStart);
        panelContent.Controls.Add(panelAbout);

        // panelButtons
        panelButtons.Dock = DockStyle.Bottom;
        panelButtons.Height = 50;
        panelButtons.Padding = new Padding(20, 8, 20, 8);

        btnSave.Text = "保存";
        btnSave.Location = new Point(280, 8);
        btnSave.Size = new Size(80, 32);
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.BackColor = Color.FromArgb(0, 120, 215);
        btnSave.ForeColor = Color.White;
        btnSave.Font = new Font("Microsoft YaHei UI", 9.5F);
        btnSave.Cursor = Cursors.Hand;
        btnSave.Click += BtnSave_Click;

        btnCancel.Text = "取消";
        btnCancel.Location = new Point(370, 8);
        btnCancel.Size = new Size(80, 32);
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.Font = new Font("Microsoft YaHei UI", 9.5F);
        btnCancel.Cursor = Cursors.Hand;
        btnCancel.Click += BtnCancel_Click;

        btnReset.Text = "恢复默认";
        btnReset.Location = new Point(15, 8);
        btnReset.Size = new Size(80, 32);
        btnReset.FlatStyle = FlatStyle.Flat;
        btnReset.Font = new Font("Microsoft YaHei UI", 9.5F);
        btnReset.Cursor = Cursors.Hand;
        btnReset.Click += BtnReset_Click;

        panelButtons.Controls.Add(btnSave);
        panelButtons.Controls.Add(btnCancel);
        panelButtons.Controls.Add(btnReset);

        // SettingsForm
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(500, 340);
        Controls.Add(panelContent);
        Controls.Add(panelSidebar);
        Controls.Add(panelButtons);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Text = "设置";
        StartPosition = FormStartPosition.CenterParent;

        ResumeLayout(false);
    }

    #endregion

    private Panel panelSidebar;
    private Button btnTabGeneral;
    private Button btnTabDelay;
    private Button btnTabAutoStart;
    private Button btnTabAbout;
    private Panel panelContent;
    private Panel panelGeneral;
    private Label lblWorkMinutes;
    private NumericUpDown numWorkMinutes;
    private Label lblWorkMinutesHint;
    private Label lblShutdownCountdown;
    private NumericUpDown numShutdownCountdown;
    private Label lblShutdownHint;
    private Label lblDelayOptionsLabel;
    private TextBox txtDelayOptions;
    private Label lblDelayHint;
    private CheckBox chkEnableTrayCountdown;
    private Label lblLogPath;
    private TextBox txtLogPath;
    private Button btnBrowse;
    private Panel panelDelay;
    private Label lblDelayTitle;
    private Label lblDelayDesc;
    private TextBox txtDelayOptionsPage;
    private Label lblDelayPageHint;
    private Panel panelAutoStart;
    private Label lblAutoStartTitle;
    private Label lblAutoStartDesc;
    private CheckBox chkAutoStart;
    private Label lblAutoStartStatus;
    private Panel panelAbout;
    private Label lblAboutTitle;
    private Label lblAboutVersion;
    private Label lblAboutDesc;
    private Panel panelButtons;
    private Button btnSave;
    private Button btnCancel;
    private Button btnReset;
}
