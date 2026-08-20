namespace AutomaticShutdown;

public partial class SettingsForm : Form
{
    private readonly AppConfig _config;

    public SettingsForm(AppConfig config)
    {
        _config = config;
        InitializeComponent();
        LoadValues();
    }

    private void LoadValues()
    {
        numWorkHours.Value = _config.WorkDurationMinutes / 60;
        numWorkMinutes.Value = _config.WorkDurationMinutes % 60;
        numShutdownCountdown.Value = _config.ShutdownCountdownMinutes;
        txtDelayOptions.Text = string.Join(", ", _config.DelayOptions);
        txtLogPath.Text = _config.LogPath;
        chkEnableTrayCountdown.Checked = _config.EnableTrayCountdown;
    }

    private void btnSave_Click(object? sender, EventArgs e)
    {
        _config.WorkDurationMinutes = (int)(numWorkHours.Value * 60 + numWorkMinutes.Value);
        _config.ShutdownCountdownMinutes = (int)numShutdownCountdown.Value;
        _config.LogPath = txtLogPath.Text.Trim();
        _config.EnableTrayCountdown = chkEnableTrayCountdown.Checked;

        try
        {
            _config.DelayOptions = txtDelayOptions.Text
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
        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnCancel_Click(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
