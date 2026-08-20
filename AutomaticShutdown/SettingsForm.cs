namespace AutomaticShutdown;

public partial class SettingsForm : Form
{
    private readonly AppConfig _config;

    public SettingsForm(AppConfig config)
    {
        _config = config;
        InitializeComponent();
        LoadValues();
        SelectTab(0);
    }

    private void LoadValues()
    {
        numWorkMinutes.Value = _config.WorkDurationMinutes;
        numShutdownCountdown.Value = _config.ShutdownCountdownMinutes;
        txtDelayOptions.Text = string.Join(",", _config.DelayOptions);
        txtDelayOptionsPage.Text = string.Join(",", _config.DelayOptions);
        chkEnableTrayCountdown.Checked = _config.EnableTrayCountdown;
        chkAutoStart.Checked = AutoStartManager.IsAutoStartEnabled();
        UpdateAutoStartStatus();
    }

    private void SelectTab(int index)
    {
        btnTabGeneral.BackColor = index == 0 ? Color.FromArgb(0, 120, 215) : SystemColors.Control;
        btnTabGeneral.ForeColor = index == 0 ? Color.White : SystemColors.ControlText;
        btnTabDelay.BackColor = index == 1 ? Color.FromArgb(0, 120, 215) : SystemColors.Control;
        btnTabDelay.ForeColor = index == 1 ? Color.White : SystemColors.ControlText;
        btnTabAutoStart.BackColor = index == 2 ? Color.FromArgb(0, 120, 215) : SystemColors.Control;
        btnTabAutoStart.ForeColor = index == 2 ? Color.White : SystemColors.ControlText;
        btnTabAbout.BackColor = index == 3 ? Color.FromArgb(0, 120, 215) : SystemColors.Control;
        btnTabAbout.ForeColor = index == 3 ? Color.White : SystemColors.ControlText;

        panelGeneral.Visible = index == 0;
        panelDelay.Visible = index == 1;
        panelAutoStart.Visible = index == 2;
        panelAbout.Visible = index == 3;

        // Sync delay options between panels
        if (index == 1)
            txtDelayOptionsPage.Text = txtDelayOptions.Text;
        else if (index == 0)
            txtDelayOptions.Text = txtDelayOptionsPage.Text;
    }

    private void BtnTabGeneral_Click(object? sender, EventArgs e) => SelectTab(0);
    private void BtnTabDelay_Click(object? sender, EventArgs e) => SelectTab(1);
    private void BtnTabAutoStart_Click(object? sender, EventArgs e) => SelectTab(2);
    private void BtnTabAbout_Click(object? sender, EventArgs e) => SelectTab(3);

    private void BtnSave_Click(object? sender, EventArgs e)
    {
        _config.WorkDurationMinutes = (int)numWorkMinutes.Value;
        _config.ShutdownCountdownMinutes = (int)numShutdownCountdown.Value;
        _config.EnableTrayCountdown = chkEnableTrayCountdown.Checked;

        var delayText = panelDelay.Visible ? txtDelayOptionsPage.Text : txtDelayOptions.Text;

        try
        {
            _config.DelayOptions = delayText
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(s => int.Parse(s.Trim()))
                .Where(n => n > 0)
                .ToList();
        }
        catch
        {
            MessageBox.Show("延后选项格式错误，请输入以逗号分隔的数字。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _config.Save();
        AutoStartManager.SetAutoStart(chkAutoStart.Checked);
        DialogResult = DialogResult.OK;
        Close();
    }

    private void BtnCancel_Click(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }

    private void BtnReset_Click(object? sender, EventArgs e)
    {
        if (MessageBox.Show("确定恢复默认设置吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            var defaults = new AppConfig();
            defaults.Save();
            _config.WorkDurationMinutes = defaults.WorkDurationMinutes;
            _config.ShutdownCountdownMinutes = defaults.ShutdownCountdownMinutes;
            _config.DelayOptions = defaults.DelayOptions;
            _config.EnableTrayCountdown = defaults.EnableTrayCountdown;
            LoadValues();
            AutoStartManager.SetAutoStart(false);
            UpdateAutoStartStatus();
        }
    }

    private void ChkAutoStart_CheckedChanged(object? sender, EventArgs e)
    {
        UpdateAutoStartStatus();
    }

    private void UpdateAutoStartStatus()
    {
        lblAutoStartStatus.Text = chkAutoStart.Checked ? "已启用" : "未启用";
        lblAutoStartStatus.ForeColor = chkAutoStart.Checked ? Color.Green : Color.Gray;
    }
}
