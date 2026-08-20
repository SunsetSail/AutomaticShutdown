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

        lblCountdown = new Label();
        flowDelayButtons = new FlowLayoutPanel();
        trayIcon = new NotifyIcon(components);
        trayContextMenu = new ContextMenuStrip(components);
        trayMenuShow = new ToolStripMenuItem();
        trayMenuSettings = new ToolStripMenuItem();
        trayMenuAutoStart = new ToolStripMenuItem();
        trayMenuSeparator = new ToolStripSeparator();
        trayMenuExit = new ToolStripMenuItem();
        mainTimer = new System.Windows.Forms.Timer(components);

        SuspendLayout();

        // lblCountdown
        lblCountdown.Dock = DockStyle.Fill;
        lblCountdown.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold);
        lblCountdown.TextAlign = ContentAlignment.MiddleCenter;
        lblCountdown.Text = "准备中...";

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
            trayMenuSettings,
            trayMenuAutoStart,
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

        // trayMenuSeparator
        trayMenuSeparator.Text = "-";

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
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Text = "下班倒计时";
        StartPosition = FormStartPosition.CenterScreen;
        ShowInTaskbar = false;
        WindowState = FormWindowState.Minimized;
        FormClosing += MainForm_FormClosing;
        Load += MainForm_Load;

        ResumeLayout(false);
    }

    #endregion

    private Label lblCountdown;
    private FlowLayoutPanel flowDelayButtons;
    private NotifyIcon trayIcon;
    private ContextMenuStrip trayContextMenu;
    private ToolStripMenuItem trayMenuShow;
    private ToolStripMenuItem trayMenuSettings;
    private ToolStripMenuItem trayMenuAutoStart;
    private ToolStripSeparator trayMenuSeparator;
    private ToolStripMenuItem trayMenuExit;
    private System.Windows.Forms.Timer mainTimer;
}
