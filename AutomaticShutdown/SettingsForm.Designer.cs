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
        lblWorkHours = new Label();
        lblWorkMinutes = new Label();
        numWorkHours = new NumericUpDown();
        numWorkMinutes = new NumericUpDown();
        lblShutdownCountdown = new Label();
        numShutdownCountdown = new NumericUpDown();
        lblDelayOptions = new Label();
        txtDelayOptions = new TextBox();
        chkEnableTrayCountdown = new CheckBox();
        chkAutoStart = new CheckBox();
        btnSave = new Button();
        btnCancel = new Button();

        SuspendLayout();

        int yPos = 20;
        int controlX = 130;
        int lblX = 20;

        // lblWorkHours
        lblWorkHours.Text = "工作时长：";
        lblWorkHours.Location = new Point(lblX, yPos + 4);
        lblWorkHours.AutoSize = true;
        lblWorkHours.Font = new Font("Microsoft YaHei UI", 10F);

        numWorkHours.Location = new Point(controlX, yPos);
        numWorkHours.Size = new Size(60, 27);
        numWorkHours.Minimum = 0;
        numWorkHours.Maximum = 24;

        lblWorkMinutes.Text = "小时";
        lblWorkMinutes.Location = new Point(controlX + 65, yPos + 4);
        lblWorkMinutes.AutoSize = true;

        numWorkMinutes.Location = new Point(controlX + 95, yPos);
        numWorkMinutes.Size = new Size(60, 27);
        numWorkMinutes.Minimum = 0;
        numWorkMinutes.Maximum = 59;

        var lblMin1 = new Label();
        lblMin1.Text = "分钟";
        lblMin1.Location = new Point(controlX + 160, yPos + 4);
        lblMin1.AutoSize = true;

        yPos += 40;

        // lblShutdownCountdown
        lblShutdownCountdown.Text = "关机倒计时：";
        lblShutdownCountdown.Location = new Point(lblX, yPos + 4);
        lblShutdownCountdown.AutoSize = true;
        lblShutdownCountdown.Font = new Font("Microsoft YaHei UI", 10F);

        numShutdownCountdown.Location = new Point(controlX, yPos);
        numShutdownCountdown.Size = new Size(60, 27);
        numShutdownCountdown.Minimum = 1;
        numShutdownCountdown.Maximum = 60;

        var lblMin2 = new Label();
        lblMin2.Text = "分钟";
        lblMin2.Location = new Point(controlX + 65, yPos + 4);
        lblMin2.AutoSize = true;

        yPos += 40;

        // lblDelayOptions
        lblDelayOptions.Text = "延后选项：";
        lblDelayOptions.Location = new Point(lblX, yPos + 4);
        lblDelayOptions.AutoSize = true;
        lblDelayOptions.Font = new Font("Microsoft YaHei UI", 10F);

        txtDelayOptions.Location = new Point(controlX, yPos);
        txtDelayOptions.Size = new Size(220, 27);
        txtDelayOptions.Font = new Font("Microsoft YaHei UI", 9.5F);

        yPos += 40;

        // chkEnableTrayCountdown
        chkEnableTrayCountdown.Text = "在任务栏显示倒计时";
        chkEnableTrayCountdown.Location = new Point(controlX, yPos);
        chkEnableTrayCountdown.AutoSize = true;
        chkEnableTrayCountdown.Font = new Font("Microsoft YaHei UI", 10F);

        yPos += 35;

        // chkAutoStart
        chkAutoStart.Text = "开机自动启动";
        chkAutoStart.Location = new Point(controlX, yPos);
        chkAutoStart.AutoSize = true;
        chkAutoStart.Font = new Font("Microsoft YaHei UI", 10F);

        yPos += 45;

        // btnSave
        btnSave.Text = "保存";
        btnSave.Location = new Point(180, yPos);
        btnSave.Size = new Size(80, 32);
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.Font = new Font("Microsoft YaHei UI", 10F);
        btnSave.Click += btnSave_Click;

        // btnCancel
        btnCancel.Text = "取消";
        btnCancel.Location = new Point(270, yPos);
        btnCancel.Size = new Size(80, 32);
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.Font = new Font("Microsoft YaHei UI", 10F);
        btnCancel.Click += btnCancel_Click;

        // SettingsForm
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(370, yPos + 50);
        Controls.Add(lblWorkHours);
        Controls.Add(numWorkHours);
        Controls.Add(lblWorkMinutes);
        Controls.Add(numWorkMinutes);
        Controls.Add(lblMin1);
        Controls.Add(lblShutdownCountdown);
        Controls.Add(numShutdownCountdown);
        Controls.Add(lblMin2);
        Controls.Add(lblDelayOptions);
        Controls.Add(txtDelayOptions);
        Controls.Add(chkEnableTrayCountdown);
        Controls.Add(chkAutoStart);
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
    private Label lblShutdownCountdown;
    private NumericUpDown numShutdownCountdown;
    private Label lblDelayOptions;
    private TextBox txtDelayOptions;
    private CheckBox chkEnableTrayCountdown;
    private CheckBox chkAutoStart;
    private Button btnSave;
    private Button btnCancel;
}
