using System.Diagnostics;

namespace AutomaticShutdown;

public partial class MainForm : Form
{
    private AppConfig _config = null!;
    private DateTime _startTime;
    private DateTime _shutdownDeadline;
    private bool _isShutdownCountdownActive;
    private readonly List<Button> _delayButtons = [];

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object? sender, EventArgs e)
    {
        _config = AppConfig.Load();
        _startTime = StartTimeRecorder.RecordOrGetStartTime(_config.LogPath);

        UpdateAutoStartMenu();
        CreateDelayButtons();
        UpdateTrayTooltip("准备中...");
        mainTimer.Start();

        WindowState = FormWindowState.Minimized;
        ShowInTaskbar = _config.EnableTrayCountdown;
    }

    private void CreateDelayButtons()
    {
        flowDelayButtons.Controls.Clear();
        _delayButtons.Clear();

        foreach (var minutes in _config.DelayOptions)
        {
            var btn = new Button
            {
                Text = $"延后{minutes}分钟",
                Size = new Size(100, 35),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft YaHei UI", 9F),
                Tag = minutes
            };
            btn.Click += DelayButton_Click;
            _delayButtons.Add(btn);
            flowDelayButtons.Controls.Add(btn);
        }
    }

    private void MainTimer_Tick(object? sender, EventArgs e)
    {
        var now = DateTime.Now;
        var elapsed = now - _startTime;
        var workDuration = TimeSpan.FromMinutes(_config.WorkDurationMinutes);

        if (!_isShutdownCountdownActive)
        {
            if (elapsed >= workDuration)
            {
                _isShutdownCountdownActive = true;
                _shutdownDeadline = now.AddMinutes(_config.ShutdownCountdownMinutes);
                ShowShutdownReminder();
            }
            else
            {
                var remaining = workDuration - elapsed;
                lblCountdown.Text = $"距离下班还有 {remaining:hh\\:mm\\:ss}";
                lblCountdown.ForeColor = SystemColors.ControlText;
                UpdateTrayTooltip($"下班倒计时：{remaining:hh\\:mm\\:ss}");
                Text = _config.EnableTrayCountdown ? $"下班倒计时 {remaining:hh\\:mm\\:ss}" : "下班倒计时";
            }
        }
        else
        {
            var remaining = _shutdownDeadline - now;
            if (remaining <= TimeSpan.Zero)
            {
                ExecuteShutdown();
                return;
            }

            lblCountdown.Text = $"电脑将在 {remaining:mm\\:ss} 后自动关机";
            lblCountdown.ForeColor = Color.Red;
            UpdateTrayTooltip($"⚠ 关机倒计时：{remaining:mm\\:ss}");
            Text = _config.EnableTrayCountdown
                ? $"⚠ 关机倒计时 {remaining:mm\\:ss}"
                : "下班倒计时";
        }
    }

    private void ShowShutdownReminder()
    {
        var workMinutes = _config.WorkDurationMinutes;
        var hours = workMinutes / 60;
        var workMin = workMinutes % 60;

        var dialog = new Form
        {
            Text = "下班提醒",
            Size = new Size(420, 220),
            StartPosition = FormStartPosition.CenterScreen,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            MaximizeBox = false,
            MinimizeBox = false,
            ShowInTaskbar = true,
            TopMost = true
        };

        var lblMessage = new Label
        {
            Text = $"您已工作满 {hours} 小时 {workMin} 分钟，电脑将在 {_config.ShutdownCountdownMinutes} 分钟后自动关机。",
            Dock = DockStyle.Top,
            Height = 80,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Microsoft YaHei UI", 10F)
        };

        var flowPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Bottom,
            Height = 60,
            FlowDirection = FlowDirection.LeftToRight,
            Padding = new Padding(10, 10, 10, 10),
            AutoSize = false
        };

        foreach (var minutes in _config.DelayOptions)
        {
            var btn = new Button
            {
                Text = $"延后{minutes}分钟",
                Size = new Size(90, 35),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft YaHei UI", 9F),
                Tag = minutes
            };
            btn.Click += (_, _) =>
            {
                ApplyDelay((int)btn.Tag!);
                dialog.Close();
            };
            flowPanel.Controls.Add(btn);
        }

        dialog.Controls.Add(lblMessage);
        dialog.Controls.Add(flowPanel);
        dialog.ShowDialog(this);
    }

    private void DelayButton_Click(object? sender, EventArgs e)
    {
        if (sender is Button btn && btn.Tag is int minutes)
        {
            ApplyDelay(minutes);
        }
    }

    private void ApplyDelay(int minutes)
    {
        _shutdownDeadline = DateTime.Now.AddMinutes(minutes);
        _isShutdownCountdownActive = true;
    }

    private void ExecuteShutdown()
    {
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "shutdown",
                Arguments = "/s /t 0",
                UseShellExecute = false,
                CreateNoWindow = true
            });
        }
        catch (Exception ex)
        {
            MessageBox.Show($"关机失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CancelScheduledShutdown()
    {
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "shutdown",
                Arguments = "/a",
                UseShellExecute = false,
                CreateNoWindow = true
            });
        }
        catch
        {
        }
    }

    private void UpdateTrayTooltip(string text)
    {
        if (text.Length > 63)
            text = text[..63];
        trayIcon.Text = text;
    }

    private void UpdateAutoStartMenu()
    {
        trayMenuAutoStart.Checked = AutoStartManager.IsAutoStartEnabled();
    }

    private void TrayIcon_DoubleClick(object? sender, EventArgs e)
    {
        ShowMainForm();
    }

    private void TrayMenuShow_Click(object? sender, EventArgs e)
    {
        ShowMainForm();
    }

    private void TrayMenuSettings_Click(object? sender, EventArgs e)
    {
        using var settingsForm = new SettingsForm(_config);
        if (settingsForm.ShowDialog(this) == DialogResult.OK)
        {
            _config = AppConfig.Load();
            CreateDelayButtons();
        }
    }

    private void TrayMenuAutoStart_Click(object? sender, EventArgs e)
    {
        var current = AutoStartManager.IsAutoStartEnabled();
        AutoStartManager.SetAutoStart(!current);
        UpdateAutoStartMenu();
    }

    private void TrayMenuExit_Click(object? sender, EventArgs e)
    {
        CancelScheduledShutdown();
        mainTimer.Stop();
        trayIcon.Visible = false;
        Application.Exit();
    }

    private void ShowMainForm()
    {
        Show();
        ShowInTaskbar = _config.EnableTrayCountdown;
        WindowState = FormWindowState.Normal;
        BringToFront();
    }

    private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (e.CloseReason == CloseReason.UserClosing)
        {
            e.Cancel = true;
            Hide();
            ShowInTaskbar = false;
            return;
        }

        CancelScheduledShutdown();
        mainTimer.Stop();
        trayIcon.Visible = false;
    }
}
