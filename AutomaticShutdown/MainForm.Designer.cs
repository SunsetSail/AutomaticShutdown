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

        menuStrip = new MenuStrip();
        menuSettings = new ToolStripMenuItem();
        menuExit = new ToolStripMenuItem();
        lblTitle = new Label();
        lblStartTime = new Label();
        dtpStartTime = new DateTimePicker();
        lblCountdown = new Label();
        flowDelayButtons = new FlowLayoutPanel();
        trayIcon = new NotifyIcon(components);
        trayContextMenu = new ContextMenuStrip(components);
        trayMenuShow = new ToolStripMenuItem();
        trayMenuExit = new ToolStripMenuItem();
        mainTimer = new System.Windows.Forms.Timer(components);

        SuspendLayout();

        // menuStrip
        menuStrip.Items.Add(menuSettings);
        menuStrip.Dock = DockStyle.Top;

        // menuSettings
        menuSettings.Text = "设置";
        menuSettings.Click += BtnMenuSettings_Click;

        // menuExit
        menuExit.Text = "退出";
        menuExit.Click += BtnMenuExit_Click;

        // lblTitle
        lblTitle.Dock = DockStyle.Top;
        lblTitle.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        lblTitle.Text = "下班倒计时";
        lblTitle.Height = 40;
        lblTitle.Padding = new Padding(0, 10, 0, 0);

        // lblStartTime
        lblStartTime.Text = "开机时间：";
        lblStartTime.Font = new Font("Microsoft YaHei UI", 10F);
        lblStartTime.AutoSize = true;
        lblStartTime.Anchor = AnchorStyles.Top;
        lblStartTime.TextAlign = ContentAlignment.MiddleLeft;

        // dtpStartTime
        dtpStartTime.Format = DateTimePickerFormat.Custom;
        dtpStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        dtpStartTime.Font = new Font("Microsoft YaHei UI", 10F);
        dtpStartTime.Width = 220;
        dtpStartTime.Anchor = AnchorStyles.Top;
        dtpStartTime.ValueChanged += DtpStartTime_ValueChanged;

        // lblCountdown
        lblCountdown.Dock = DockStyle.Fill;
        lblCountdown.Font = new Font("Consolas", 36F, FontStyle.Bold);
        lblCountdown.TextAlign = ContentAlignment.MiddleCenter;
        lblCountdown.Text = "00:00:00";

        // flowDelayButtons
        flowDelayButtons.Dock = DockStyle.Bottom;
        flowDelayButtons.Height = 50;
        flowDelayButtons.FlowDirection = FlowDirection.LeftToRight;
        flowDelayButtons.Padding = new Padding(10, 5, 10, 5);
        flowDelayButtons.AutoSize = false;

        // trayContextMenu
        trayContextMenu.Items.AddRange(new ToolStripItem[]
        {
            trayMenuShow,
            trayMenuExit
        });

        // trayMenuShow
        trayMenuShow.Text = "显示主窗口";
        trayMenuShow.Click += TrayMenuShow_Click;

        // trayMenuExit
        trayMenuExit.Text = "退出";
        trayMenuExit.Click += TrayMenuExit_Click;

        // trayIcon
        trayIcon.Text = "下班倒计时";
        trayIcon.ContextMenuStrip = trayContextMenu;
        trayIcon.DoubleClick += TrayIcon_DoubleClick;
        trayIcon.Visible = true;

        // mainTimer
        mainTimer.Interval = 1000;
        mainTimer.Tick += MainTimer_Tick;

        // MainForm
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(400, 300);
        Controls.Add(lblCountdown);
        Controls.Add(flowDelayButtons);
        Controls.Add(dtpStartTime);
        Controls.Add(lblStartTime);
        Controls.Add(lblTitle);
        Controls.Add(menuStrip);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Text = "下班倒计时";
        StartPosition = FormStartPosition.CenterScreen;
        ShowInTaskbar = true;
        FormClosing += MainForm_FormClosing;
        Load += MainForm_Load;

        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip;
    private ToolStripMenuItem menuSettings;
    private ToolStripMenuItem menuExit;
    private Label lblTitle;
    private Label lblStartTime;
    private DateTimePicker dtpStartTime;
    private Label lblCountdown;
    private FlowLayoutPanel flowDelayButtons;
    private NotifyIcon trayIcon;
    private ContextMenuStrip trayContextMenu;
    private ToolStripMenuItem trayMenuShow;
    private ToolStripMenuItem trayMenuExit;
    private System.Windows.Forms.Timer mainTimer;
}
