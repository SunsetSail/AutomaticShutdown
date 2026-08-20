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
        lblWorkDuration = new Label();
        lblWorkHours = new Label();
        lblWorkMinutes = new Label();
        numWorkHours = new NumericUpDown();
        numWorkMinutes = new NumericUpDown();
        lblShutdownCountdown = new Label();
        numShutdownCountdown = new NumericUpDown();
        lblDelayOptions = new Label();
        txtDelayOptions = new TextBox();
        lblLogPath = new Label();
        txtLogPath = new TextBox();
        chkEnableTrayCountdown = new CheckBox();
        btnSave = new Button();
        btnCancel = new Button();

        SuspendLayout();

        int yPos = 15;
        int controlX = 140;

        // lblWorkHours + numWorkHours + lblWorkMinutes + numWorkMinutes
        lblWorkHours.Text = "工作时长：";
        lblWorkHours.Location = new Point(15, yPos + 3);
        lblWorkHours.AutoSize = true;

        numWorkHours.Location = new Point(controlX, yPos);
        numWorkHours.Size = new Size(60, 23);
        numWorkHours.Minimum = 0;
        numWorkHours.Maximum = 24;

        lblWorkMinutes.Text = "小时";
        lblWorkMinutes.Location = new Point(controlX + 65, yPos + 3);
        lblWorkMinutes.AutoSize = true;

        numWorkMinutes.Location = new Point(controlX + 95, yPos);
        numWorkMinutes.Size = new Size(60, 23);
        numWorkMinutes.Minimum = 0;
        numWorkMinutes.Maximum = 59;

        lblWorkDuration.Text = "分钟";
        lblWorkDuration.Location = new Point(controlX + 160, yPos + 3);
        lblWorkDuration.AutoSize = true;

        yPos += 40;

        // lblShutdownCountdown + numShutdownCountdown
        lblShutdownCountdown.Text = "关机倒计时：";
        lblShutdownCountdown.Location = new Point(15, yPos + 3);
        lblShutdownCountdown.AutoSize = true;

        numShutdownCountdown.Location = new Point(controlX, yPos);
        numShutdownCountdown.Size = new Size(60, 23);
        numShutdownCountdown.Minimum = 1;
        numShutdownCountdown.Maximum = 60;

        var lblShutdownMin = new Label();
        lblShutdownMin.Text = "分钟";
        lblShutdownMin.Location = new Point(controlX + 65, yPos + 3);
        lblShutdownMin.AutoSize = true;

        yPos += 40;

        // lblDelayOptions + txtDelayOptions
        lblDelayOptions.Text = "延后选项：";
        lblDelayOptions.Location = new Point(15, yPos + 3);
        lblDelayOptions.AutoSize = true;

        txtDelayOptions.Location = new Point(controlX, yPos);
        txtDelayOptions.Size = new Size(230, 23);

        yPos += 40;

        // lblLogPath + txtLogPath
        lblLogPath.Text = "记录文件：";
        lblLogPath.Location = new Point(15, yPos + 3);
        lblLogPath.AutoSize = true;

        txtLogPath.Location = new Point(controlX, yPos);
        txtLogPath.Size = new Size(230, 23);

        yPos += 40;

        // chkEnableTrayCountdown
        chkEnableTrayCountdown.Text = "在任务栏显示倒计时";
        chkEnableTrayCountdown.Location = new Point(controlX, yPos);
        chkEnableTrayCountdown.AutoSize = true;

        yPos += 45;

        // btnSave
        btnSave.Text = "保存";
        btnSave.Location = new Point(200, yPos);
        btnSave.Size = new Size(75, 30);
        btnSave.Click += btnSave_Click;

        // btnCancel
        btnCancel.Text = "取消";
        btnCancel.Location = new Point(285, yPos);
        btnCancel.Size = new Size(75, 30);
        btnCancel.Click += btnCancel_Click;

        // SettingsForm
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(390, yPos + 50);
        Controls.Add(lblWorkHours);
        Controls.Add(numWorkHours);
        Controls.Add(lblWorkMinutes);
        Controls.Add(numWorkMinutes);
        Controls.Add(lblWorkDuration);
        Controls.Add(lblShutdownCountdown);
        Controls.Add(numShutdownCountdown);
        Controls.Add(lblShutdownMin);
        Controls.Add(lblDelayOptions);
        Controls.Add(txtDelayOptions);
        Controls.Add(lblLogPath);
        Controls.Add(txtLogPath);
        Controls.Add(chkEnableTrayCountdown);
        Controls.Add(btnSave);
        Controls.Add(btnCancel);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Text = "设置";
        StartPosition = FormStartPosition.CenterParent;

        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblWorkHours;
    private NumericUpDown numWorkHours;
    private Label lblWorkMinutes;
    private NumericUpDown numWorkMinutes;
    private Label lblWorkDuration;
    private Label lblShutdownCountdown;
    private NumericUpDown numShutdownCountdown;
    private Label lblDelayOptions;
    private TextBox txtDelayOptions;
    private Label lblLogPath;
    private TextBox txtLogPath;
    private CheckBox chkEnableTrayCountdown;
    private Button btnSave;
    private Button btnCancel;
}
