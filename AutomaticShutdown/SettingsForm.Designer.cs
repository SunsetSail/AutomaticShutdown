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
        lblTitle = new Label();
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

        int yPos = 55;
        int controlX = 150;
        int lblX = 25;

        // lblTitle
        lblTitle.Dock = DockStyle.Top;
        lblTitle.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(220, 220, 220);
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        lblTitle.Text = "设置";
        lblTitle.Height = 50;
        lblTitle.BackColor = Color.FromArgb(35, 35, 35);

        // lblWorkHours
        lblWorkHours.Text = "工作时长";
        lblWorkHours.Location = new Point(lblX, yPos + 5);
        lblWorkHours.AutoSize = true;
        lblWorkHours.ForeColor = Color.FromArgb(200, 200, 200);
        lblWorkHours.Font = new Font("Microsoft YaHei UI", 10F);

        numWorkHours.Location = new Point(controlX, yPos);
        numWorkHours.Size = new Size(65, 27);
        numWorkHours.Minimum = 0;
        numWorkHours.Maximum = 24;
        numWorkHours.BackColor = Color.FromArgb(50, 50, 50);
        numWorkHours.ForeColor = Color.FromArgb(220, 220, 220);
        numWorkHours.BorderStyle = BorderStyle.FixedSingle;

        lblWorkMinutes.Text = "小时";
        lblWorkMinutes.Location = new Point(controlX + 70, yPos + 5);
        lblWorkMinutes.AutoSize = true;
        lblWorkMinutes.ForeColor = Color.FromArgb(180, 180, 180);

        numWorkMinutes.Location = new Point(controlX + 100, yPos);
        numWorkMinutes.Size = new Size(65, 27);
        numWorkMinutes.Minimum = 0;
        numWorkMinutes.Maximum = 59;
        numWorkMinutes.BackColor = Color.FromArgb(50, 50, 50);
        numWorkMinutes.ForeColor = Color.FromArgb(220, 220, 220);
        numWorkMinutes.BorderStyle = BorderStyle.FixedSingle;

        var lblMin1 = new Label();
        lblMin1.Text = "分钟";
        lblMin1.Location = new Point(controlX + 170, yPos + 5);
        lblMin1.AutoSize = true;
        lblMin1.ForeColor = Color.FromArgb(180, 180, 180);

        yPos += 45;

        // lblShutdownCountdown
        lblShutdownCountdown.Text = "关机倒计时";
        lblShutdownCountdown.Location = new Point(lblX, yPos + 5);
        lblShutdownCountdown.AutoSize = true;
        lblShutdownCountdown.ForeColor = Color.FromArgb(200, 200, 200);
        lblShutdownCountdown.Font = new Font("Microsoft YaHei UI", 10F);

        numShutdownCountdown.Location = new Point(controlX, yPos);
        numShutdownCountdown.Size = new Size(65, 27);
        numShutdownCountdown.Minimum = 1;
        numShutdownCountdown.Maximum = 60;
        numShutdownCountdown.BackColor = Color.FromArgb(50, 50, 50);
        numShutdownCountdown.ForeColor = Color.FromArgb(220, 220, 220);
        numShutdownCountdown.BorderStyle = BorderStyle.FixedSingle;

        var lblMin2 = new Label();
        lblMin2.Text = "分钟";
        lblMin2.Location = new Point(controlX + 70, yPos + 5);
        lblMin2.AutoSize = true;
        lblMin2.ForeColor = Color.FromArgb(180, 180, 180);

        yPos += 45;

        // lblDelayOptions
        lblDelayOptions.Text = "延后选项";
        lblDelayOptions.Location = new Point(lblX, yPos + 5);
        lblDelayOptions.AutoSize = true;
        lblDelayOptions.ForeColor = Color.FromArgb(200, 200, 200);
        lblDelayOptions.Font = new Font("Microsoft YaHei UI", 10F);

        txtDelayOptions.Location = new Point(controlX, yPos);
        txtDelayOptions.Size = new Size(250, 27);
        txtDelayOptions.BackColor = Color.FromArgb(50, 50, 50);
        txtDelayOptions.ForeColor = Color.FromArgb(220, 220, 220);
        txtDelayOptions.BorderStyle = BorderStyle.FixedSingle;
        txtDelayOptions.Font = new Font("Microsoft YaHei UI", 9.5F);

        yPos += 45;

        // lblLogPath
        lblLogPath.Text = "记录文件";
        lblLogPath.Location = new Point(lblX, yPos + 5);
        lblLogPath.AutoSize = true;
        lblLogPath.ForeColor = Color.FromArgb(200, 200, 200);
        lblLogPath.Font = new Font("Microsoft YaHei UI", 10F);

        txtLogPath.Location = new Point(controlX, yPos);
        txtLogPath.Size = new Size(250, 27);
        txtLogPath.BackColor = Color.FromArgb(50, 50, 50);
        txtLogPath.ForeColor = Color.FromArgb(220, 220, 220);
        txtLogPath.BorderStyle = BorderStyle.FixedSingle;
        txtLogPath.Font = new Font("Microsoft YaHei UI", 9.5F);

        yPos += 45;

        // chkEnableTrayCountdown
        chkEnableTrayCountdown.Text = "在任务栏显示倒计时";
        chkEnableTrayCountdown.Location = new Point(controlX, yPos);
        chkEnableTrayCountdown.AutoSize = true;
        chkEnableTrayCountdown.ForeColor = Color.FromArgb(200, 200, 200);
        chkEnableTrayCountdown.Font = new Font("Microsoft YaHei UI", 9.5F);

        yPos += 50;

        // btnSave
        btnSave.Text = "保存";
        btnSave.Location = new Point(220, yPos);
        btnSave.Size = new Size(90, 35);
        btnSave.FlatStyle = FlatStyle.Flat;
        btnSave.FlatAppearance.BorderColor = Color.FromArgb(0, 200, 150);
        btnSave.BackColor = Color.FromArgb(0, 200, 150);
        btnSave.ForeColor = Color.White;
        btnSave.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
        btnSave.Cursor = Cursors.Hand;
        btnSave.Click += btnSave_Click;

        // btnCancel
        btnCancel.Text = "取消";
        btnCancel.Location = new Point(320, yPos);
        btnCancel.Size = new Size(90, 35);
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
        btnCancel.BackColor = Color.FromArgb(50, 50, 50);
        btnCancel.ForeColor = Color.FromArgb(200, 200, 200);
        btnCancel.Font = new Font("Microsoft YaHei UI", 10F);
        btnCancel.Cursor = Cursors.Hand;
        btnCancel.Click += btnCancel_Click;

        // SettingsForm
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(430, yPos + 55);
        Controls.Add(lblTitle);
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
        BackColor = Color.FromArgb(30, 30, 30);

        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitle;
    private Label lblWorkHours;
    private NumericUpDown numWorkHours;
    private Label lblWorkMinutes;
    private NumericUpDown numWorkMinutes;
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
