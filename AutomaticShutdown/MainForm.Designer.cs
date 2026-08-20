namespace AutomaticShutdown;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            components?.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();

        lblStartTime = new Label();
        grpNormal = new GroupBox();
        lblNormalHint = new Label();
        lblCountdownTime = new Label();
        panelNormalLabels = new FlowLayoutPanel();
        lblHour = new Label();
        lblMinute = new Label();
        lblSecond = new Label();

        grpShutdown = new GroupBox();
        lblShutdownPrefix = new Label();
        lblShutdownTime = new Label();
        lblShutdownSuffix = new Label();

        flowDelayButtons = new FlowLayoutPanel();
        panelStatus = new Panel();
        lblStatus = new Label();
        btnSettings = new Button();
        trayIcon = new NotifyIcon(components);
        trayContextMenu = new ContextMenuStrip(components);
        trayMenuShow = new ToolStripMenuItem();
        trayMenuSettings = new ToolStripMenuItem();
        trayMenuAutoStart = new ToolStripMenuItem();
        trayMenuShowCountdown = new ToolStripMenuItem();
        trayMenuSeparator = new ToolStripSeparator();
        trayMenuExit = new ToolStripMenuItem();
        mainTimer = new System.Windows.Forms.Timer(components);

        SuspendLayout();

        // lblStartTime
        lblStartTime.Dock = DockStyle.Top;
        lblStartTime.Font = new Font("Microsoft YaHei UI", 9.5F);
        lblStartTime.TextAlign = ContentAlignment.MiddleCenter;
        lblStartTime.Text = "首次开机时间：----";
        lblStartTime.Height = 30;

        // grpNormal
        grpNormal.Dock = DockStyle.Top;
        grpNormal.Height = 160;
        grpNormal.Text = "正常工作阶段";
        grpNormal.Font = new Font("Microsoft YaHei UI", 9F);

        // lblNormalHint
        lblNormalHint.Text = "距离下班还有";
        lblNormalHint.Font = new Font("Microsoft YaHei UI", 10F);
        lblNormalHint.Dock = DockStyle.Top;
        lblNormalHint.Height = 28;
        lblNormalHint.TextAlign = ContentAlignment.MiddleCenter;

        // lblCountdownTime
        lblCountdownTime.Dock = DockStyle.Top;
        lblCountdownTime.Font = new Font("Consolas", 40F, FontStyle.Bold);
        lblCountdownTime.TextAlign = ContentAlignment.MiddleCenter;
        lblCountdownTime.Text = "00:00:00";
        lblCountdownTime.Height = 60;

        // panelNormalLabels
        panelNormalLabels.Dock = DockStyle.Top;
        panelNormalLabels.Height = 22;
        panelNormalLabels.FlowDirection = FlowDirection.LeftToRight;
        panelNormalLabels.AutoSize = false;
        panelNormalLabels.Padding = new Padding(0, 2, 0, 0);

        lblHour.Text = "时";
        lblHour.AutoSize = true;
        lblHour.Margin = new Padding(72, 0, 0, 0);
        lblHour.Font = new Font("Microsoft YaHei UI", 9F);

        lblMinute.Text = "分";
        lblMinute.AutoSize = true;
        lblMinute.Margin = new Padding(42, 0, 0, 0);
        lblMinute.Font = new Font("Microsoft YaHei UI", 9F);

        lblSecond.Text = "秒";
        lblSecond.AutoSize = true;
        lblSecond.Margin = new Padding(42, 0, 0, 0);
        lblSecond.Font = new Font("Microsoft YaHei UI", 9F);

        panelNormalLabels.Controls.Add(lblHour);
        panelNormalLabels.Controls.Add(lblMinute);
        panelNormalLabels.Controls.Add(lblSecond);

        grpNormal.Controls.Add(panelNormalLabels);
        grpNormal.Controls.Add(lblCountdownTime);
        grpNormal.Controls.Add(lblNormalHint);

        // grpShutdown
        grpShutdown.Dock = DockStyle.Top;
        grpShutdown.Height = 140;
        grpShutdown.Text = "关机倒计时阶段";
        grpShutdown.Font = new Font("Microsoft YaHei UI", 9F);
        grpShutdown.ForeColor = Color.Red;
        grpShutdown.Visible = false;

        // lblShutdownPrefix
        lblShutdownPrefix.Text = "电脑将在";
        lblShutdownPrefix.Font = new Font("Microsoft YaHei UI", 10F);
        lblShutdownPrefix.ForeColor = Color.Red;
        lblShutdownPrefix.Dock = DockStyle.Top;
        lblShutdownPrefix.Height = 28;
        lblShutdownPrefix.TextAlign = ContentAlignment.MiddleCenter;

        // lblShutdownTime
        lblShutdownTime.Dock = DockStyle.Top;
        lblShutdownTime.Font = new Font("Consolas", 40F, FontStyle.Bold);
        lblShutdownTime.ForeColor = Color.Red;
        lblShutdownTime.TextAlign = ContentAlignment.MiddleCenter;
        lblShutdownTime.Text = "01:59";
        lblShutdownTime.Height = 60;

        // lblShutdownSuffix
        lblShutdownSuffix.Text = "后自动关机";
        lblShutdownSuffix.Font = new Font("Microsoft YaHei UI", 10F);
        lblShutdownSuffix.ForeColor = Color.Red;
        lblShutdownSuffix.Dock = DockStyle.Top;
        lblShutdownSuffix.Height = 28;
        lblShutdownSuffix.TextAlign = ContentAlignment.MiddleCenter;

        grpShutdown.Controls.Add(lblShutdownSuffix);
        grpShutdown.Controls.Add(lblShutdownTime);
        grpShutdown.Controls.Add(lblShutdownPrefix);

        // flowDelayButtons
        flowDelayButtons.Dock = DockStyle.Top;
        flowDelayButtons.Height = 48;
        flowDelayButtons.FlowDirection = FlowDirection.LeftToRight;
        flowDelayButtons.Padding = new Padding(15, 8, 15, 8);
        flowDelayButtons.AutoSize = false;
        flowDelayButtons.WrapContents = false;

        // panelStatus
        panelStatus.Dock = DockStyle.Bottom;
        panelStatus.Height = 32;
        panelStatus.Padding = new Padding(10, 0, 10, 0);

        // lblStatus
        lblStatus.Text = "● 状态：正常工作中";
        lblStatus.Font = new Font("Microsoft YaHei UI", 9F);
        lblStatus.ForeColor = Color.Green;
        lblStatus.Dock = DockStyle.Fill;
        lblStatus.TextAlign = ContentAlignment.MiddleLeft;

        // btnSettings
        btnSettings.Text = "⚙";
        btnSettings.Font = new Font("Segoe UI", 14F);
        btnSettings.FlatStyle = FlatStyle.Flat;
        btnSettings.FlatAppearance.BorderSize = 0;
        btnSettings.Dock = DockStyle.Right;
        btnSettings.Width = 35;
        btnSettings.Cursor = Cursors.Hand;
        btnSettings.Click += BtnSettings_Click;

        panelStatus.Controls.Add(lblStatus);
        panelStatus.Controls.Add(btnSettings);

        // trayContextMenu
        trayContextMenu.Items.AddRange(new ToolStripItem[]
        {
            trayMenuShow,
            trayMenuSettings,
            trayMenuAutoStart,
            trayMenuShowCountdown,
            trayMenuSeparator,
            trayMenuExit
        });

        // trayMenuShow
        trayMenuShow.Text = "显示主窗口";
        trayMenuShow.Click += TrayMenuShow_Click;

        // trayMenuSettings
        trayMenuSettings.Text = "设置";
        trayMenuSettings.Click += TrayMenuSettings_Click;

        // trayMenuAutoStart
        trayMenuAutoStart.Text = "开机自启";
        trayMenuAutoStart.Click += TrayMenuAutoStart_Click;

        // trayMenuShowCountdown
        trayMenuShowCountdown.Text = "在任务栏显示倒计时";
        trayMenuShowCountdown.Click += TrayMenuShowCountdown_Click;

        // trayMenuSeparator
        trayMenuSeparator.Text = "-";

        // trayMenuExit
        trayMenuExit.Text = "退出程序";
        trayMenuExit.Click += TrayMenuExit_Click;

        // trayIcon
        trayIcon.Text = "下班倒计时";
        trayIcon.ContextMenuStrip = trayContextMenu;
        trayIcon.DoubleClick += TrayIcon_DoubleClick;
        trayIcon.Icon = CreateTrayIcon();
        trayIcon.Visible = true;

        // mainTimer
        mainTimer.Interval = 1000;
        mainTimer.Tick += MainTimer_Tick;

        // MainForm
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(420, 370);
        Controls.Add(panelStatus);
        Controls.Add(flowDelayButtons);
        Controls.Add(grpShutdown);
        Controls.Add(grpNormal);
        Controls.Add(lblStartTime);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Text = "下班倒计时";
        StartPosition = FormStartPosition.CenterScreen;
        ShowInTaskbar = true;
        FormClosing += MainForm_FormClosing;
        Load += MainForm_Load;

        ResumeLayout(false);
    }

    private static Icon CreateTrayIcon()
    {
        var bmp = new Bitmap(16, 16);
        using var g = Graphics.FromImage(bmp);
        g.Clear(Color.Transparent);
        using var brush = new SolidBrush(Color.FromArgb(0, 120, 215));
        g.FillEllipse(brush, 1, 1, 14, 14);
        using var font = new Font("Consolas", 9F, FontStyle.Bold);
        using var white = new SolidBrush(Color.White);
        g.DrawString("⏰", font, white, -1, -1);
        return Icon.FromHandle(bmp.GetHicon());
    }

    #endregion

    private Label lblStartTime;
    private GroupBox grpNormal;
    private Label lblNormalHint;
    private Label lblCountdownTime;
    private FlowLayoutPanel panelNormalLabels;
    private Label lblHour;
    private Label lblMinute;
    private Label lblSecond;
    private GroupBox grpShutdown;
    private Label lblShutdownPrefix;
    private Label lblShutdownTime;
    private Label lblShutdownSuffix;
    private FlowLayoutPanel flowDelayButtons;
    private Panel panelStatus;
    private Label lblStatus;
    private Button btnSettings;
    private NotifyIcon trayIcon;
    private ContextMenuStrip trayContextMenu;
    private ToolStripMenuItem trayMenuShow;
    private ToolStripMenuItem trayMenuSettings;
    private ToolStripMenuItem trayMenuAutoStart;
    private ToolStripMenuItem trayMenuShowCountdown;
    private ToolStripSeparator trayMenuSeparator;
    private ToolStripMenuItem trayMenuExit;
    private System.Windows.Forms.Timer mainTimer;
}
