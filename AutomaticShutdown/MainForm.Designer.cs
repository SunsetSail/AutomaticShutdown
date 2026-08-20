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

        lblTitle = new Label();
        lblCountdown = new Label();
        lblStatus = new Label();
        flowDelayButtons = new FlowLayoutPanel();
        panelTop = new Panel();
        btnMenu = new Button();
        btnAutoStart = new Button();
        trayIcon = new NotifyIcon(components);
        trayContextMenu = new ContextMenuStrip(components);
        trayMenuShow = new ToolStripMenuItem();
        trayMenuAutoStart = new ToolStripMenuItem();
        trayMenuSeparator = new ToolStripSeparator();
        trayMenuExit = new ToolStripMenuItem();
        mainTimer = new System.Windows.Forms.Timer(components);

        SuspendLayout();

        // panelTop - top bar with menu and auto-start button
        panelTop.Dock = DockStyle.Top;
        panelTop.Height = 50;
        panelTop.BackColor = Color.FromArgb(30, 30, 30);
        panelTop.Padding = new Padding(10, 0, 10, 0);

        // btnMenu - settings menu button
        btnMenu.Text = "⚙";
        btnMenu.Font = new Font("Segoe UI", 16F);
        btnMenu.FlatStyle = FlatStyle.Flat;
        btnMenu.FlatAppearance.BorderSize = 0;
        btnMenu.ForeColor = Color.FromArgb(200, 200, 200);
        btnMenu.BackColor = Color.Transparent;
        btnMenu.Dock = DockStyle.Right;
        btnMenu.Width = 50;
        btnMenu.Cursor = Cursors.Hand;
        btnMenu.Click += BtnMenu_Click;

        // btnAutoStart - auto start toggle button
        btnAutoStart.Text = "开机自启：关";
        btnAutoStart.Font = new Font("Microsoft YaHei UI", 9F);
        btnAutoStart.FlatStyle = FlatStyle.Flat;
        btnAutoStart.FlatAppearance.BorderSize = 0;
        btnAutoStart.ForeColor = Color.FromArgb(160, 160, 160);
        btnAutoStart.BackColor = Color.Transparent;
        btnAutoStart.Dock = DockStyle.Left;
        btnAutoStart.Width = 120;
        btnAutoStart.Cursor = Cursors.Hand;
        btnAutoStart.Click += BtnAutoStart_Click;

        panelTop.Controls.Add(btnMenu);
        panelTop.Controls.Add(btnAutoStart);

        // lblTitle - app title
        lblTitle.Dock = DockStyle.Top;
        lblTitle.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(220, 220, 220);
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        lblTitle.Text = "下班倒计时";
        lblTitle.Height = 45;
        lblTitle.BackColor = Color.FromArgb(35, 35, 35);

        // lblCountdown - main countdown display
        lblCountdown.Dock = DockStyle.Fill;
        lblCountdown.Font = new Font("Consolas", 42F, FontStyle.Bold);
        lblCountdown.ForeColor = Color.FromArgb(0, 200, 150);
        lblCountdown.TextAlign = ContentAlignment.MiddleCenter;
        lblCountdown.Text = "00:00:00";
        lblCountdown.BackColor = Color.FromArgb(25, 25, 25);

        // lblStatus - status text below countdown
        lblStatus.Dock = DockStyle.Bottom;
        lblStatus.Font = new Font("Microsoft YaHei UI", 10F);
        lblStatus.ForeColor = Color.FromArgb(140, 140, 140);
        lblStatus.TextAlign = ContentAlignment.TopCenter;
        lblStatus.Text = "准备中...";
        lblStatus.Height = 35;
        lblStatus.BackColor = Color.FromArgb(25, 25, 25);

        // flowDelayButtons - delay buttons area
        flowDelayButtons.Dock = DockStyle.Bottom;
        flowDelayButtons.Height = 60;
        flowDelayButtons.FlowDirection = FlowDirection.LeftToRight;
        flowDelayButtons.Padding = new Padding(10, 10, 10, 10);
        flowDelayButtons.BackColor = Color.FromArgb(30, 30, 30);
        flowDelayButtons.WrapContents = false;
        flowDelayButtons.AutoSize = false;

        // trayContextMenu
        trayContextMenu.BackColor = Color.FromArgb(40, 40, 40);
        trayContextMenu.ForeColor = Color.FromArgb(220, 220, 220);
        trayContextMenu.Renderer = new DarkMenuRenderer();
        trayContextMenu.Items.AddRange(new ToolStripItem[]
        {
            trayMenuShow,
            trayMenuAutoStart,
            trayMenuSeparator,
            trayMenuExit
        });

        // trayMenuShow
        trayMenuShow.Text = "显示主窗口";
        trayMenuShow.ForeColor = Color.FromArgb(220, 220, 220);
        trayMenuShow.Click += TrayMenuShow_Click;

        // trayMenuAutoStart
        trayMenuAutoStart.Text = "开机自启";
        trayMenuAutoStart.ForeColor = Color.FromArgb(220, 220, 220);
        trayMenuAutoStart.Click += TrayMenuAutoStart_Click;

        // trayMenuSeparator
        trayMenuSeparator.Text = "-";

        // trayMenuExit
        trayMenuExit.Text = "退出";
        trayMenuExit.ForeColor = Color.FromArgb(220, 220, 220);
        trayMenuExit.Click += TrayMenuExit_Click;

        // trayIcon
        trayIcon.Text = "下班倒计时";
        trayIcon.ContextMenuStrip = trayContextMenu;
        trayIcon.DoubleClick += TrayIcon_DoubleClick;
        trayIcon.Visible = true;
        trayIcon.Icon = CreateTrayIcon();

        // mainTimer
        mainTimer.Interval = 1000;
        mainTimer.Tick += MainTimer_Tick;

        // MainForm
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(420, 350);
        Controls.Add(lblCountdown);
        Controls.Add(lblStatus);
        Controls.Add(flowDelayButtons);
        Controls.Add(lblTitle);
        Controls.Add(panelTop);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Text = "下班倒计时";
        StartPosition = FormStartPosition.CenterScreen;
        ShowInTaskbar = true;
        BackColor = Color.FromArgb(25, 25, 25);
        FormClosing += MainForm_FormClosing;
        Load += MainForm_Load;

        ResumeLayout(false);
    }

    private static Icon CreateTrayIcon()
    {
        var bitmap = new Bitmap(32, 32);
        using var g = Graphics.FromImage(bitmap);
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        g.Clear(Color.Transparent);

        using var brush = new SolidBrush(Color.FromArgb(0, 200, 150));
        g.FillEllipse(brush, 2, 2, 28, 28);

        using var whiteBrush = new SolidBrush(Color.White);
        using var font = new Font("Consolas", 14F, FontStyle.Bold);
        var textSize = g.MeasureString("⏰", font);
        g.DrawString("⏰", font, whiteBrush, (32 - textSize.Width) / 2, (32 - textSize.Height) / 2);

        return Icon.FromHandle(bitmap.GetHicon());
    }

    #endregion

    private Label lblTitle;
    private Label lblCountdown;
    private Label lblStatus;
    private FlowLayoutPanel flowDelayButtons;
    private Panel panelTop;
    private Button btnMenu;
    private Button btnAutoStart;
    private NotifyIcon trayIcon;
    private ContextMenuStrip trayContextMenu;
    private ToolStripMenuItem trayMenuShow;
    private ToolStripMenuItem trayMenuAutoStart;
    private ToolStripSeparator trayMenuSeparator;
    private ToolStripMenuItem trayMenuExit;
    private System.Windows.Forms.Timer mainTimer;
}

public class DarkMenuRenderer : ToolStripProfessionalRenderer
{
    protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
    {
        using var brush = new SolidBrush(Color.FromArgb(40, 40, 40));
        e.Graphics.FillRectangle(brush, e.AffectedBounds);
    }

    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
    {
        var rect = new Rectangle(Point.Empty, e.Item.Size);
        var color = e.Item.Selected ? Color.FromArgb(60, 60, 60) : Color.FromArgb(40, 40, 40);
        using var brush = new SolidBrush(color);
        e.Graphics.FillRectangle(brush, rect);
    }

    protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
    {
        e.TextColor = Color.FromArgb(220, 220, 220);
        base.OnRenderItemText(e);
    }

    protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
    {
        using var pen = new Pen(Color.FromArgb(60, 60, 60));
        e.Graphics.DrawRectangle(pen, 0, 0, e.AffectedBounds.Width - 1, e.AffectedBounds.Height - 1);
    }
}
