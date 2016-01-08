namespace StreamDVR
{
    partial class rootForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.labelRequired = new System.Windows.Forms.Label();
            this.buttonConfigSave = new System.Windows.Forms.Button();
            this.buttonConfigDiscard = new System.Windows.Forms.Button();
            this.groupBoxQuality = new System.Windows.Forms.GroupBox();
            this.textBoxHandbrakePreset = new System.Windows.Forms.TextBox();
            this.radioButtonHandbrake3 = new System.Windows.Forms.RadioButton();
            this.radioButtonHandbrake2 = new System.Windows.Forms.RadioButton();
            this.radioButtonHandbrake1 = new System.Windows.Forms.RadioButton();
            this.labelHandbrakeQuality = new System.Windows.Forms.Label();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.labelLivestreamerQuality = new System.Windows.Forms.Label();
            this.listBoxLivestreamerQuality = new System.Windows.Forms.ListBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.buttonHandbrakeOutput = new System.Windows.Forms.Button();
            this.labelHandbrakeOutput = new System.Windows.Forms.Label();
            this.textBoxHandbrakeOutput = new System.Windows.Forms.TextBox();
            this.buttonLivestreamerOutput = new System.Windows.Forms.Button();
            this.labelLivestreamerOutput = new System.Windows.Forms.Label();
            this.textBoxLivestreamerOutput = new System.Windows.Forms.TextBox();
            this.buttonLog = new System.Windows.Forms.Button();
            this.labelLog = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.groupBoxExe = new System.Windows.Forms.GroupBox();
            this.buttonMediaplayer = new System.Windows.Forms.Button();
            this.labelMediaplayer = new System.Windows.Forms.Label();
            this.textBoxMediaplayer = new System.Windows.Forms.TextBox();
            this.buttonHandbrake = new System.Windows.Forms.Button();
            this.labelHandbrake = new System.Windows.Forms.Label();
            this.textBoxHandbrake = new System.Windows.Forms.TextBox();
            this.buttonLivestreamer = new System.Windows.Forms.Button();
            this.labelLivestreamer = new System.Windows.Forms.Label();
            this.textBoxLivestreamer = new System.Windows.Forms.TextBox();
            this.tabPageSchedule = new System.Windows.Forms.TabPage();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.taskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NextRunTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastRunTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLoad = new System.Windows.Forms.Button();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            this.groupBoxQuality.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.groupBoxExe.SuspendLayout();
            this.tabPageSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageConfig);
            this.tabControl1.Controls.Add(this.tabPageSchedule);
            this.tabControl1.Controls.Add(this.tabPageAbout);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 666);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Controls.Add(this.labelRequired);
            this.tabPageConfig.Controls.Add(this.buttonConfigSave);
            this.tabPageConfig.Controls.Add(this.buttonConfigDiscard);
            this.tabPageConfig.Controls.Add(this.groupBoxQuality);
            this.tabPageConfig.Controls.Add(this.groupBoxOutput);
            this.tabPageConfig.Controls.Add(this.groupBoxExe);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 24);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.tabPageConfig.Size = new System.Drawing.Size(921, 638);
            this.tabPageConfig.TabIndex = 0;
            this.tabPageConfig.Text = "  Config  ";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // labelRequired
            // 
            this.labelRequired.AutoSize = true;
            this.labelRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequired.Location = new System.Drawing.Point(18, 592);
            this.labelRequired.Name = "labelRequired";
            this.labelRequired.Size = new System.Drawing.Size(57, 13);
            this.labelRequired.TabIndex = 12;
            this.labelRequired.Text = "* Required";
            // 
            // buttonConfigSave
            // 
            this.buttonConfigSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigSave.Location = new System.Drawing.Point(567, 596);
            this.buttonConfigSave.Name = "buttonConfigSave";
            this.buttonConfigSave.Size = new System.Drawing.Size(75, 23);
            this.buttonConfigSave.TabIndex = 11;
            this.buttonConfigSave.Text = "Save";
            this.buttonConfigSave.UseVisualStyleBackColor = true;
            this.buttonConfigSave.Click += new System.EventHandler(this.buttonConfigSave_Click);
            // 
            // buttonConfigDiscard
            // 
            this.buttonConfigDiscard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfigDiscard.Location = new System.Drawing.Point(664, 596);
            this.buttonConfigDiscard.Name = "buttonConfigDiscard";
            this.buttonConfigDiscard.Size = new System.Drawing.Size(75, 23);
            this.buttonConfigDiscard.TabIndex = 10;
            this.buttonConfigDiscard.Text = "Discard";
            this.buttonConfigDiscard.UseVisualStyleBackColor = true;
            this.buttonConfigDiscard.Click += new System.EventHandler(this.buttonConfigDiscard_Click);
            // 
            // groupBoxQuality
            // 
            this.groupBoxQuality.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxQuality.Controls.Add(this.textBoxHandbrakePreset);
            this.groupBoxQuality.Controls.Add(this.radioButtonHandbrake3);
            this.groupBoxQuality.Controls.Add(this.radioButtonHandbrake2);
            this.groupBoxQuality.Controls.Add(this.radioButtonHandbrake1);
            this.groupBoxQuality.Controls.Add(this.labelHandbrakeQuality);
            this.groupBoxQuality.Controls.Add(this.buttonDown);
            this.groupBoxQuality.Controls.Add(this.buttonUp);
            this.groupBoxQuality.Controls.Add(this.labelLivestreamerQuality);
            this.groupBoxQuality.Controls.Add(this.listBoxLivestreamerQuality);
            this.groupBoxQuality.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxQuality.Location = new System.Drawing.Point(3, 328);
            this.groupBoxQuality.Name = "groupBoxQuality";
            this.groupBoxQuality.Padding = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.groupBoxQuality.Size = new System.Drawing.Size(915, 261);
            this.groupBoxQuality.TabIndex = 9;
            this.groupBoxQuality.TabStop = false;
            this.groupBoxQuality.Text = "Video Quality";
            // 
            // textBoxHandbrakePreset
            // 
            this.textBoxHandbrakePreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHandbrakePreset.Location = new System.Drawing.Point(158, 218);
            this.textBoxHandbrakePreset.Name = "textBoxHandbrakePreset";
            this.textBoxHandbrakePreset.Size = new System.Drawing.Size(100, 21);
            this.textBoxHandbrakePreset.TabIndex = 16;
            this.textBoxHandbrakePreset.TextChanged += new System.EventHandler(this.textBoxHandbrakePreset_TextChanged);
            // 
            // radioButtonHandbrake3
            // 
            this.radioButtonHandbrake3.AutoSize = true;
            this.radioButtonHandbrake3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHandbrake3.Location = new System.Drawing.Point(138, 222);
            this.radioButtonHandbrake3.Name = "radioButtonHandbrake3";
            this.radioButtonHandbrake3.Size = new System.Drawing.Size(14, 13);
            this.radioButtonHandbrake3.TabIndex = 15;
            this.radioButtonHandbrake3.TabStop = true;
            this.radioButtonHandbrake3.UseVisualStyleBackColor = true;
            this.radioButtonHandbrake3.CheckedChanged += new System.EventHandler(this.radioButtonHandbrake3_CheckedChanged);
            // 
            // radioButtonHandbrake2
            // 
            this.radioButtonHandbrake2.AutoSize = true;
            this.radioButtonHandbrake2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHandbrake2.Location = new System.Drawing.Point(138, 193);
            this.radioButtonHandbrake2.Name = "radioButtonHandbrake2";
            this.radioButtonHandbrake2.Size = new System.Drawing.Size(67, 19);
            this.radioButtonHandbrake2.TabIndex = 14;
            this.radioButtonHandbrake2.TabStop = true;
            this.radioButtonHandbrake2.Text = "Android";
            this.radioButtonHandbrake2.UseVisualStyleBackColor = true;
            this.radioButtonHandbrake2.CheckedChanged += new System.EventHandler(this.radioButtonHandbrake2_CheckedChanged);
            // 
            // radioButtonHandbrake1
            // 
            this.radioButtonHandbrake1.AutoSize = true;
            this.radioButtonHandbrake1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHandbrake1.Location = new System.Drawing.Point(138, 168);
            this.radioButtonHandbrake1.Name = "radioButtonHandbrake1";
            this.radioButtonHandbrake1.Size = new System.Drawing.Size(80, 19);
            this.radioButtonHandbrake1.TabIndex = 13;
            this.radioButtonHandbrake1.TabStop = true;
            this.radioButtonHandbrake1.Text = "AppleTV 3";
            this.radioButtonHandbrake1.UseVisualStyleBackColor = true;
            this.radioButtonHandbrake1.CheckedChanged += new System.EventHandler(this.radioButtonHandbrake1_CheckedChanged);
            // 
            // labelHandbrakeQuality
            // 
            this.labelHandbrakeQuality.AutoSize = true;
            this.labelHandbrakeQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHandbrakeQuality.Location = new System.Drawing.Point(15, 168);
            this.labelHandbrakeQuality.Name = "labelHandbrakeQuality";
            this.labelHandbrakeQuality.Size = new System.Drawing.Size(108, 15);
            this.labelHandbrakeQuality.TabIndex = 12;
            this.labelHandbrakeQuality.Text = "Handbrake Quality";
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(331, 89);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(53, 23);
            this.buttonDown.TabIndex = 11;
            this.buttonDown.Text = "down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(331, 50);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(53, 23);
            this.buttonUp.TabIndex = 10;
            this.buttonUp.Text = "up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // labelLivestreamerQuality
            // 
            this.labelLivestreamerQuality.AutoSize = true;
            this.labelLivestreamerQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLivestreamerQuality.Location = new System.Drawing.Point(15, 35);
            this.labelLivestreamerQuality.Name = "labelLivestreamerQuality";
            this.labelLivestreamerQuality.Size = new System.Drawing.Size(118, 15);
            this.labelLivestreamerQuality.TabIndex = 9;
            this.labelLivestreamerQuality.Text = "Livestreamer Quality";
            // 
            // listBoxLivestreamerQuality
            // 
            this.listBoxLivestreamerQuality.FormattingEnabled = true;
            this.listBoxLivestreamerQuality.ItemHeight = 16;
            this.listBoxLivestreamerQuality.Items.AddRange(new object[] {
            "Best",
            "High",
            "Medium",
            "Low",
            "Worst"});
            this.listBoxLivestreamerQuality.Location = new System.Drawing.Point(138, 35);
            this.listBoxLivestreamerQuality.Name = "listBoxLivestreamerQuality";
            this.listBoxLivestreamerQuality.Size = new System.Drawing.Size(186, 100);
            this.listBoxLivestreamerQuality.TabIndex = 0;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxOutput.Controls.Add(this.buttonHandbrakeOutput);
            this.groupBoxOutput.Controls.Add(this.labelHandbrakeOutput);
            this.groupBoxOutput.Controls.Add(this.textBoxHandbrakeOutput);
            this.groupBoxOutput.Controls.Add(this.buttonLivestreamerOutput);
            this.groupBoxOutput.Controls.Add(this.labelLivestreamerOutput);
            this.groupBoxOutput.Controls.Add(this.textBoxLivestreamerOutput);
            this.groupBoxOutput.Controls.Add(this.buttonLog);
            this.groupBoxOutput.Controls.Add(this.labelLog);
            this.groupBoxOutput.Controls.Add(this.textBoxLog);
            this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOutput.Location = new System.Drawing.Point(3, 170);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Padding = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.groupBoxOutput.Size = new System.Drawing.Size(915, 158);
            this.groupBoxOutput.TabIndex = 1;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Location of output files";
            // 
            // buttonHandbrakeOutput
            // 
            this.buttonHandbrakeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHandbrakeOutput.Location = new System.Drawing.Point(661, 104);
            this.buttonHandbrakeOutput.Name = "buttonHandbrakeOutput";
            this.buttonHandbrakeOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonHandbrakeOutput.TabIndex = 8;
            this.buttonHandbrakeOutput.Text = "Browse";
            this.buttonHandbrakeOutput.UseVisualStyleBackColor = true;
            this.buttonHandbrakeOutput.Click += new System.EventHandler(this.buttonHandbrakeOutput_Click);
            // 
            // labelHandbrakeOutput
            // 
            this.labelHandbrakeOutput.AutoSize = true;
            this.labelHandbrakeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHandbrakeOutput.Location = new System.Drawing.Point(15, 107);
            this.labelHandbrakeOutput.Name = "labelHandbrakeOutput";
            this.labelHandbrakeOutput.Size = new System.Drawing.Size(107, 15);
            this.labelHandbrakeOutput.TabIndex = 7;
            this.labelHandbrakeOutput.Text = "Handbrake Output";
            // 
            // textBoxHandbrakeOutput
            // 
            this.textBoxHandbrakeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHandbrakeOutput.Location = new System.Drawing.Point(138, 104);
            this.textBoxHandbrakeOutput.Name = "textBoxHandbrakeOutput";
            this.textBoxHandbrakeOutput.ReadOnly = true;
            this.textBoxHandbrakeOutput.Size = new System.Drawing.Size(501, 21);
            this.textBoxHandbrakeOutput.TabIndex = 6;
            // 
            // buttonLivestreamerOutput
            // 
            this.buttonLivestreamerOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLivestreamerOutput.Location = new System.Drawing.Point(661, 70);
            this.buttonLivestreamerOutput.Name = "buttonLivestreamerOutput";
            this.buttonLivestreamerOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonLivestreamerOutput.TabIndex = 5;
            this.buttonLivestreamerOutput.Text = "Browse";
            this.buttonLivestreamerOutput.UseVisualStyleBackColor = true;
            this.buttonLivestreamerOutput.Click += new System.EventHandler(this.buttonLivestreamerOutput_Click);
            // 
            // labelLivestreamerOutput
            // 
            this.labelLivestreamerOutput.AutoSize = true;
            this.labelLivestreamerOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLivestreamerOutput.Location = new System.Drawing.Point(15, 73);
            this.labelLivestreamerOutput.Name = "labelLivestreamerOutput";
            this.labelLivestreamerOutput.Size = new System.Drawing.Size(125, 15);
            this.labelLivestreamerOutput.TabIndex = 4;
            this.labelLivestreamerOutput.Text = "Livestreamer Output *";
            // 
            // textBoxLivestreamerOutput
            // 
            this.textBoxLivestreamerOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLivestreamerOutput.Location = new System.Drawing.Point(138, 70);
            this.textBoxLivestreamerOutput.Name = "textBoxLivestreamerOutput";
            this.textBoxLivestreamerOutput.ReadOnly = true;
            this.textBoxLivestreamerOutput.Size = new System.Drawing.Size(501, 21);
            this.textBoxLivestreamerOutput.TabIndex = 3;
            // 
            // buttonLog
            // 
            this.buttonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLog.Location = new System.Drawing.Point(661, 34);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(75, 23);
            this.buttonLog.TabIndex = 2;
            this.buttonLog.Text = "Browse";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLog.Location = new System.Drawing.Point(15, 37);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(55, 15);
            this.labelLog.TabIndex = 1;
            this.labelLog.Text = "Log file *";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLog.Location = new System.Drawing.Point(138, 34);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(501, 21);
            this.textBoxLog.TabIndex = 0;
            // 
            // groupBoxExe
            // 
            this.groupBoxExe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxExe.Controls.Add(this.buttonMediaplayer);
            this.groupBoxExe.Controls.Add(this.labelMediaplayer);
            this.groupBoxExe.Controls.Add(this.textBoxMediaplayer);
            this.groupBoxExe.Controls.Add(this.buttonHandbrake);
            this.groupBoxExe.Controls.Add(this.labelHandbrake);
            this.groupBoxExe.Controls.Add(this.textBoxHandbrake);
            this.groupBoxExe.Controls.Add(this.buttonLivestreamer);
            this.groupBoxExe.Controls.Add(this.labelLivestreamer);
            this.groupBoxExe.Controls.Add(this.textBoxLivestreamer);
            this.groupBoxExe.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxExe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExe.Location = new System.Drawing.Point(3, 12);
            this.groupBoxExe.Name = "groupBoxExe";
            this.groupBoxExe.Padding = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.groupBoxExe.Size = new System.Drawing.Size(915, 158);
            this.groupBoxExe.TabIndex = 0;
            this.groupBoxExe.TabStop = false;
            this.groupBoxExe.Text = "Location of supporting executables";
            // 
            // buttonMediaplayer
            // 
            this.buttonMediaplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMediaplayer.Location = new System.Drawing.Point(661, 104);
            this.buttonMediaplayer.Name = "buttonMediaplayer";
            this.buttonMediaplayer.Size = new System.Drawing.Size(75, 23);
            this.buttonMediaplayer.TabIndex = 8;
            this.buttonMediaplayer.Text = "Browse";
            this.buttonMediaplayer.UseVisualStyleBackColor = true;
            this.buttonMediaplayer.Click += new System.EventHandler(this.buttonMediaplayer_Click);
            // 
            // labelMediaplayer
            // 
            this.labelMediaplayer.AutoSize = true;
            this.labelMediaplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMediaplayer.Location = new System.Drawing.Point(15, 107);
            this.labelMediaplayer.Name = "labelMediaplayer";
            this.labelMediaplayer.Size = new System.Drawing.Size(79, 15);
            this.labelMediaplayer.TabIndex = 7;
            this.labelMediaplayer.Text = "Media Player";
            // 
            // textBoxMediaplayer
            // 
            this.textBoxMediaplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMediaplayer.Location = new System.Drawing.Point(138, 104);
            this.textBoxMediaplayer.Name = "textBoxMediaplayer";
            this.textBoxMediaplayer.ReadOnly = true;
            this.textBoxMediaplayer.Size = new System.Drawing.Size(501, 21);
            this.textBoxMediaplayer.TabIndex = 6;
            // 
            // buttonHandbrake
            // 
            this.buttonHandbrake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHandbrake.Location = new System.Drawing.Point(661, 70);
            this.buttonHandbrake.Name = "buttonHandbrake";
            this.buttonHandbrake.Size = new System.Drawing.Size(75, 23);
            this.buttonHandbrake.TabIndex = 5;
            this.buttonHandbrake.Text = "Browse";
            this.buttonHandbrake.UseVisualStyleBackColor = true;
            this.buttonHandbrake.Click += new System.EventHandler(this.buttonHandbrake_Click);
            // 
            // labelHandbrake
            // 
            this.labelHandbrake.AutoSize = true;
            this.labelHandbrake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHandbrake.Location = new System.Drawing.Point(15, 73);
            this.labelHandbrake.Name = "labelHandbrake";
            this.labelHandbrake.Size = new System.Drawing.Size(89, 15);
            this.labelHandbrake.TabIndex = 4;
            this.labelHandbrake.Text = "Handbrake CLI";
            // 
            // textBoxHandbrake
            // 
            this.textBoxHandbrake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHandbrake.Location = new System.Drawing.Point(138, 70);
            this.textBoxHandbrake.Name = "textBoxHandbrake";
            this.textBoxHandbrake.ReadOnly = true;
            this.textBoxHandbrake.Size = new System.Drawing.Size(501, 21);
            this.textBoxHandbrake.TabIndex = 3;
            // 
            // buttonLivestreamer
            // 
            this.buttonLivestreamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLivestreamer.Location = new System.Drawing.Point(661, 34);
            this.buttonLivestreamer.Name = "buttonLivestreamer";
            this.buttonLivestreamer.Size = new System.Drawing.Size(75, 23);
            this.buttonLivestreamer.TabIndex = 2;
            this.buttonLivestreamer.Text = "Browse";
            this.buttonLivestreamer.UseVisualStyleBackColor = true;
            this.buttonLivestreamer.Click += new System.EventHandler(this.buttonLivestreamer_Click);
            // 
            // labelLivestreamer
            // 
            this.labelLivestreamer.AutoSize = true;
            this.labelLivestreamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLivestreamer.Location = new System.Drawing.Point(15, 37);
            this.labelLivestreamer.Name = "labelLivestreamer";
            this.labelLivestreamer.Size = new System.Drawing.Size(86, 15);
            this.labelLivestreamer.TabIndex = 1;
            this.labelLivestreamer.Text = "Livestreamer *";
            // 
            // textBoxLivestreamer
            // 
            this.textBoxLivestreamer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLivestreamer.Location = new System.Drawing.Point(138, 34);
            this.textBoxLivestreamer.Name = "textBoxLivestreamer";
            this.textBoxLivestreamer.ReadOnly = true;
            this.textBoxLivestreamer.Size = new System.Drawing.Size(501, 21);
            this.textBoxLivestreamer.TabIndex = 0;
            // 
            // tabPageSchedule
            // 
            this.tabPageSchedule.Controls.Add(this.buttonModify);
            this.tabPageSchedule.Controls.Add(this.buttonCreate);
            this.tabPageSchedule.Controls.Add(this.listViewTasks);
            this.tabPageSchedule.Controls.Add(this.buttonLoad);
            this.tabPageSchedule.Location = new System.Drawing.Point(4, 24);
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSchedule.Size = new System.Drawing.Size(921, 638);
            this.tabPageSchedule.TabIndex = 1;
            this.tabPageSchedule.Text = "  Schedule  ";
            this.tabPageSchedule.UseVisualStyleBackColor = true;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(748, 607);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 4;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(657, 607);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // listViewTasks
            // 
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskName,
            this.NextRunTime,
            this.LastRunTime});
            this.listViewTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewTasks.GridLines = true;
            this.listViewTasks.Location = new System.Drawing.Point(3, 3);
            this.listViewTasks.MultiSelect = false;
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(915, 255);
            this.listViewTasks.TabIndex = 2;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            // 
            // taskName
            // 
            this.taskName.Text = "Name";
            this.taskName.Width = 187;
            // 
            // NextRunTime
            // 
            this.NextRunTime.Text = "Next Run Time";
            this.NextRunTime.Width = 194;
            // 
            // LastRunTime
            // 
            this.LastRunTime.Text = "Last Run Time";
            this.LastRunTime.Width = 165;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(838, 607);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Location = new System.Drawing.Point(4, 24);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(921, 638);
            this.tabPageAbout.TabIndex = 2;
            this.tabPageAbout.Text = "  About  ";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rootForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 666);
            this.Controls.Add(this.tabControl1);
            this.Name = "rootForm";
            this.Text = "StreamDVR";
            this.Load += new System.EventHandler(this.rootForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageConfig.ResumeLayout(false);
            this.tabPageConfig.PerformLayout();
            this.groupBoxQuality.ResumeLayout(false);
            this.groupBoxQuality.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.groupBoxExe.ResumeLayout(false);
            this.groupBoxExe.PerformLayout();
            this.tabPageSchedule.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.TabPage tabPageSchedule;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.GroupBox groupBoxExe;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonLivestreamer;
        private System.Windows.Forms.Label labelLivestreamer;
        private System.Windows.Forms.TextBox textBoxLivestreamer;
        private System.Windows.Forms.Button buttonHandbrake;
        private System.Windows.Forms.Label labelHandbrake;
        private System.Windows.Forms.TextBox textBoxHandbrake;
        private System.Windows.Forms.Button buttonMediaplayer;
        private System.Windows.Forms.Label labelMediaplayer;
        private System.Windows.Forms.TextBox textBoxMediaplayer;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Button buttonHandbrakeOutput;
        private System.Windows.Forms.Label labelHandbrakeOutput;
        private System.Windows.Forms.TextBox textBoxHandbrakeOutput;
        private System.Windows.Forms.Button buttonLivestreamerOutput;
        private System.Windows.Forms.Label labelLivestreamerOutput;
        private System.Windows.Forms.TextBox textBoxLivestreamerOutput;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.GroupBox groupBoxQuality;
        private System.Windows.Forms.ListBox listBoxLivestreamerQuality;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Label labelLivestreamerQuality;
        private System.Windows.Forms.RadioButton radioButtonHandbrake1;
        private System.Windows.Forms.Label labelHandbrakeQuality;
        private System.Windows.Forms.TextBox textBoxHandbrakePreset;
        private System.Windows.Forms.RadioButton radioButtonHandbrake3;
        private System.Windows.Forms.RadioButton radioButtonHandbrake2;
        private System.Windows.Forms.Label labelRequired;
        private System.Windows.Forms.Button buttonConfigSave;
        private System.Windows.Forms.Button buttonConfigDiscard;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ColumnHeader taskName;
        private System.Windows.Forms.ColumnHeader NextRunTime;
        private System.Windows.Forms.ColumnHeader LastRunTime;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonModify;
    }
}

