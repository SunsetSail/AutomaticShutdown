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

        lblStartTime.Text = $"首次开机时间：{_startTime:yyyy-MM-dd HH:mm:ss}";
        UpdateAutoStartMenu();
        UpdateShowCountdownMenu();
        CreateDelayButtons();
        UpdateTrayTooltip("准备中...");
        UpdateStatus("正常工作中");
        mainTimer.Start();
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
                Size = new Size(85, 32),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Microsoft YaHei UI", 9F),
                Tag = minutes
            };
            btn.Click += DelayButton_Click;
            _delayButtons.Add(btn);
            flowDelayButtons.Controls.Add(btn);
        }

        var btnCancel = new Button
        {
            Text = "取消关机",
            Size = new Size(85, 32),
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Microsoft YaHei UI", 9F),
            ForeColor = Color.Red
        };
        btnCancel.Click += BtnCancelShutdown_Click;
        flowDelayButtons.Controls.Add(btnCancel);
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
                grpNormal.Visible = false;
                grpShutdown.Visible = true;
                UpdateStatus("关机倒计时中");
                ShowShutdownReminder();
            }
            else
            {
                var remaining = workDuration - elapsed;
                lblCountdownTime.Text = remaining.ToString(@"hh\:mm\:ss");
                UpdateTrayTooltip($"下班倒计时：{remaining:hh\\:mm\\:ss}");
                UpdateStatusBarTitle(remaining, false);
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

            lblShutdownTime.Text = remaining.ToString(@"mm\:ss");
            UpdateTrayTooltip($"⚠ 关机倒计时：{remaining:mm\\:ss}");
            UpdateStatusBarTitle(remaining, true);
        }
    }

    private void UpdateStatusBarTitle(TimeSpan remaining, bool isShutdown)
    {
        if (_config.EnableTrayCountdown)
        {
            if (isShutdown)
                Text = $"⚠ 电脑将在 {remaining:mm\\:ss} 后自动关机";
            else
                Text = $"下班倒计时 - 距离下班还有 {remaining:hh\\:mm\\:ss}";
        }
        else
        {
            Text = "下班倒计时";
        }
    }

    private void ShowShutdownReminder()
    {
        var workMinutes = _config.WorkDurationMinutes;
        var hours = workMinutes / 60;
        var workMin = workMinutes % 60;

        using var dialog = new Form
        {
            Text = "下班提醒",
            Size = new Size(400, 310),
            StartPosition = FormStartPosition.CenterScreen,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            MaximizeBox = false,
            MinimizeBox = false,
            ShowInTaskbar = true,
            TopMost = true
        };

        var lblIcon = new Label
        {
            Text = "🔔",
            Font = new Font("Segoe UI Emoji", 36F),
            Dock = DockStyle.Top,
            Height = 65,
            TextAlign = ContentAlignment.MiddleCenter
        };

        var lblTitle = new Label
        {
            Text = "下班提醒",
            Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold),
            Dock = DockStyle.Top,
            Height = 35,
            TextAlign = ContentAlignment.MiddleCenter
        };

        var lblMessage = new Label
        {
            Text = $"您已工作满 {hours} 小时 {workMin} 分钟，\n电脑将在 {_config.ShutdownCountdownMinutes} 分钟后自动关机。\n\n您可以选择延后关机时间：",
            Font = new Font("Microsoft YaHei UI", 10F),
            Dock = DockStyle.Top,
            Height = 100,
            TextAlign = ContentAlignment.TopCenter
        };

        var flowPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Bottom,
            Height = 75,
            FlowDirection = FlowDirection.LeftToRight,
            Padding = new Padding(20, 10, 20, 10),
            WrapContents = true
        };

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
            btn.Click += (_, _) =>
            {
                ApplyDelay((int)btn.Tag!);
                dialog.Close();
            };
            flowPanel.Controls.Add(btn);
        }

        var btnCancel = new Button
        {
            Text = "取消关机",
            Size = new Size(100, 35),
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Microsoft YaHei UI", 9F),
            ForeColor = Color.Red
        };
        btnCancel.Click += (_, _) =>
        {
            CancelShutdownCountdown();
            dialog.Close();
        };
        flowPanel.Controls.Add(btnCancel);

        dialog.Controls.Add(lblIcon);
        dialog.Controls.Add(lblTitle);
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

    private void CancelShutdownCountdown()
    {
        _isShutdownCountdownActive = false;
        CancelScheduledShutdown();
        grpShutdown.Visible = false;
        grpNormal.Visible = true;
        UpdateStatus("正常工作中");
    }

    private void BtnCancelShutdown_Click(object? sender, EventArgs e)
    {
        CancelShutdownCountdown();
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

    private void UpdateStatus(string status)
    {
        lblStatus.Text = $"● 状态：{status}";
        lblStatus.ForeColor = status.Contains("关机") ? Color.Red : Color.Green;
    }

    private void UpdateAutoStartMenu()
    {
        trayMenuAutoStart.Checked = AutoStartManager.IsAutoStartEnabled();
    }

    private void UpdateShowCountdownMenu()
    {
        trayMenuShowCountdown.Checked = _config.EnableTrayCountdown;
    }

    private void BtnSettings_Click(object? sender, EventArgs e)
    {
        OpenSettings();
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
        OpenSettings();
    }

    private void TrayMenuAutoStart_Click(object? sender, EventArgs e)
    {
        var current = AutoStartManager.IsAutoStartEnabled();
        AutoStartManager.SetAutoStart(!current);
        UpdateAutoStartMenu();
    }

    private void TrayMenuShowCountdown_Click(object? sender, EventArgs e)
    {
        _config.EnableTrayCountdown = !_config.EnableTrayCountdown;
        _config.Save();
        UpdateShowCountdownMenu();
        UpdateStatusBarTitle(TimeSpan.Zero, false);
    }

    private void TrayMenuExit_Click(object? sender, EventArgs e)
    {
        CancelScheduledShutdown();
        mainTimer.Stop();
        trayIcon.Visible = false;
        Application.Exit();
    }

    private void OpenSettings()
    {
        using var settingsForm = new SettingsForm(_config);
        if (settingsForm.ShowDialog(this) == DialogResult.OK)
        {
            _config = AppConfig.Load();
            CreateDelayButtons();
            UpdateAutoStartMenu();
            UpdateShowCountdownMenu();
            UpdateStatus("正常工作中");
        }
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
