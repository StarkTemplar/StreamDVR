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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rootForm));
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.taskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.streamUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.streamId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.streamView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.streamTranscode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NextRunTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastRunTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddTrigger = new System.Windows.Forms.Button();
            this.listViewTriggers = new System.Windows.Forms.ListView();
            this.triggerDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.triggerStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonTaskEdit = new System.Windows.Forms.Button();
            this.buttonTaskDelete = new System.Windows.Forms.Button();
            this.buttonTriggerDelete = new System.Windows.Forms.Button();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelWebsite = new System.Windows.Forms.Label();
            this.labelDonations = new System.Windows.Forms.Label();
            this.labelCredits = new System.Windows.Forms.Label();
            this.labelLicense = new System.Windows.Forms.Label();
            this.labelAuthor2 = new System.Windows.Forms.Label();
            this.richTextBoxWebsite = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDonations = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCredits = new System.Windows.Forms.RichTextBox();
            this.richTextBoxLicense = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.streamWake = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            this.groupBoxQuality.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.groupBoxExe.SuspendLayout();
            this.tabPageSchedule.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(886, 666);
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
            this.tabPageConfig.Size = new System.Drawing.Size(878, 638);
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
            this.groupBoxQuality.Size = new System.Drawing.Size(872, 261);
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
            this.groupBoxOutput.Size = new System.Drawing.Size(872, 158);
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
            this.groupBoxExe.Size = new System.Drawing.Size(872, 158);
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
            this.tabPageSchedule.Controls.Add(this.tableLayoutPanel1);
            this.tabPageSchedule.Location = new System.Drawing.Point(4, 24);
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSchedule.Size = new System.Drawing.Size(878, 638);
            this.tabPageSchedule.TabIndex = 1;
            this.tabPageSchedule.Text = "  Schedule  ";
            this.tabPageSchedule.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.listViewTasks, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddTrigger, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.listViewTriggers, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddTask, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonTaskEdit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonTaskDelete, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonTriggerDelete, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(872, 639);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // listViewTasks
            // 
            this.listViewTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskName,
            this.streamUrl,
            this.streamId,
            this.streamTranscode,
            this.streamView,
            this.streamWake,
            this.NextRunTime,
            this.LastRunTime});
            this.tableLayoutPanel1.SetColumnSpan(this.listViewTasks, 4);
            this.listViewTasks.FullRowSelect = true;
            this.listViewTasks.GridLines = true;
            this.listViewTasks.HideSelection = false;
            this.listViewTasks.Location = new System.Drawing.Point(3, 3);
            this.listViewTasks.MultiSelect = false;
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(909, 249);
            this.listViewTasks.TabIndex = 2;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            this.listViewTasks.SelectedIndexChanged += new System.EventHandler(this.listViewTasks_SelectedIndexChanged);
            // 
            // taskName
            // 
            this.taskName.Text = "Name";
            this.taskName.Width = 132;
            // 
            // streamUrl
            // 
            this.streamUrl.Text = "Stream URL";
            this.streamUrl.Width = 156;
            // 
            // streamId
            // 
            this.streamId.Text = "File Tag";
            // 
            // streamView
            // 
            this.streamView.Text = "Display";
            this.streamView.Width = 59;
            // 
            // streamTranscode
            // 
            this.streamTranscode.Text = "Transcode";
            this.streamTranscode.Width = 75;
            // 
            // NextRunTime
            // 
            this.NextRunTime.Text = "Next Run Time";
            this.NextRunTime.Width = 174;
            // 
            // LastRunTime
            // 
            this.LastRunTime.Text = "Last Run Time";
            this.LastRunTime.Width = 165;
            // 
            // buttonAddTrigger
            // 
            this.buttonAddTrigger.Location = new System.Drawing.Point(3, 576);
            this.buttonAddTrigger.Name = "buttonAddTrigger";
            this.buttonAddTrigger.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTrigger.TabIndex = 4;
            this.buttonAddTrigger.Text = "Add";
            this.buttonAddTrigger.UseVisualStyleBackColor = true;
            this.buttonAddTrigger.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // listViewTriggers
            // 
            this.listViewTriggers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTriggers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.triggerDate,
            this.triggerStatus});
            this.tableLayoutPanel1.SetColumnSpan(this.listViewTriggers, 4);
            this.listViewTriggers.GridLines = true;
            this.listViewTriggers.Location = new System.Drawing.Point(3, 321);
            this.listViewTriggers.MultiSelect = false;
            this.listViewTriggers.Name = "listViewTriggers";
            this.listViewTriggers.Size = new System.Drawing.Size(909, 249);
            this.listViewTriggers.TabIndex = 5;
            this.listViewTriggers.UseCompatibleStateImageBehavior = false;
            this.listViewTriggers.View = System.Windows.Forms.View.Details;
            // 
            // triggerDate
            // 
            this.triggerDate.Text = "Date";
            this.triggerDate.Width = 394;
            // 
            // triggerStatus
            // 
            this.triggerStatus.Text = "Status";
            this.triggerStatus.Width = 198;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(3, 258);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTask.TabIndex = 3;
            this.buttonAddTask.Text = "Add";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonTaskEdit
            // 
            this.buttonTaskEdit.Location = new System.Drawing.Point(93, 258);
            this.buttonTaskEdit.Name = "buttonTaskEdit";
            this.buttonTaskEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonTaskEdit.TabIndex = 8;
            this.buttonTaskEdit.Text = "Edit";
            this.buttonTaskEdit.UseVisualStyleBackColor = true;
            this.buttonTaskEdit.Click += new System.EventHandler(this.buttonTaskEdit_Click);
            // 
            // buttonTaskDelete
            // 
            this.buttonTaskDelete.Location = new System.Drawing.Point(183, 258);
            this.buttonTaskDelete.Name = "buttonTaskDelete";
            this.buttonTaskDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonTaskDelete.TabIndex = 9;
            this.buttonTaskDelete.Text = "Delete";
            this.buttonTaskDelete.UseVisualStyleBackColor = true;
            this.buttonTaskDelete.Click += new System.EventHandler(this.buttonTaskDelete_Click);
            // 
            // buttonTriggerDelete
            // 
            this.buttonTriggerDelete.Location = new System.Drawing.Point(93, 576);
            this.buttonTriggerDelete.Name = "buttonTriggerDelete";
            this.buttonTriggerDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonTriggerDelete.TabIndex = 7;
            this.buttonTriggerDelete.Text = "Delete";
            this.buttonTriggerDelete.UseVisualStyleBackColor = true;
            this.buttonTriggerDelete.Click += new System.EventHandler(this.buttonTriggerDelete_Click);
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.tableLayoutPanel2);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 24);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Size = new System.Drawing.Size(878, 638);
            this.tabPageAbout.TabIndex = 2;
            this.tabPageAbout.Text = "  About  ";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelVersion, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelAuthor, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelWebsite, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelDonations, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelCredits, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelLicense, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelAuthor2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.richTextBoxWebsite, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.richTextBoxDonations, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.richTextBoxCredits, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.richTextBoxLicense, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(878, 638);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(25, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(25, 15, 25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(185, 0);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.labelVersion.Size = new System.Drawing.Size(442, 40);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "StreamDVR v";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.Location = new System.Drawing.Point(15, 153);
            this.labelAuthor.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(162, 17);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Author:";
            // 
            // labelWebsite
            // 
            this.labelWebsite.AutoSize = true;
            this.labelWebsite.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWebsite.Location = new System.Drawing.Point(15, 203);
            this.labelWebsite.Margin = new System.Windows.Forms.Padding(15, 3, 3, 0);
            this.labelWebsite.Name = "labelWebsite";
            this.labelWebsite.Size = new System.Drawing.Size(162, 17);
            this.labelWebsite.TabIndex = 4;
            this.labelWebsite.Text = "Website:";
            // 
            // labelDonations
            // 
            this.labelDonations.AutoSize = true;
            this.labelDonations.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDonations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonations.Location = new System.Drawing.Point(15, 253);
            this.labelDonations.Margin = new System.Windows.Forms.Padding(15, 3, 3, 0);
            this.labelDonations.Name = "labelDonations";
            this.labelDonations.Size = new System.Drawing.Size(162, 17);
            this.labelDonations.TabIndex = 5;
            this.labelDonations.Text = "Donations:";
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredits.Location = new System.Drawing.Point(15, 303);
            this.labelCredits.Margin = new System.Windows.Forms.Padding(15, 3, 3, 0);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(162, 17);
            this.labelCredits.TabIndex = 6;
            this.labelCredits.Text = "Credits:";
            // 
            // labelLicense
            // 
            this.labelLicense.AutoSize = true;
            this.labelLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicense.Location = new System.Drawing.Point(15, 403);
            this.labelLicense.Margin = new System.Windows.Forms.Padding(15, 3, 3, 0);
            this.labelLicense.Name = "labelLicense";
            this.labelLicense.Size = new System.Drawing.Size(162, 17);
            this.labelLicense.TabIndex = 7;
            this.labelLicense.Text = "License:";
            // 
            // labelAuthor2
            // 
            this.labelAuthor2.AutoSize = true;
            this.labelAuthor2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAuthor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor2.Location = new System.Drawing.Point(185, 153);
            this.labelAuthor2.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.labelAuthor2.Name = "labelAuthor2";
            this.labelAuthor2.Size = new System.Drawing.Size(442, 17);
            this.labelAuthor2.TabIndex = 8;
            this.labelAuthor2.Text = "StarkTemplar";
            // 
            // richTextBoxWebsite
            // 
            this.richTextBoxWebsite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxWebsite.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBoxWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxWebsite.Location = new System.Drawing.Point(185, 203);
            this.richTextBoxWebsite.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.richTextBoxWebsite.Name = "richTextBoxWebsite";
            this.richTextBoxWebsite.Size = new System.Drawing.Size(442, 44);
            this.richTextBoxWebsite.TabIndex = 9;
            this.richTextBoxWebsite.Text = "https://github.com/StarkTemplar/StreamDVR";
            this.richTextBoxWebsite.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxWebsite_LinkClicked);
            // 
            // richTextBoxDonations
            // 
            this.richTextBoxDonations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxDonations.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBoxDonations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDonations.Location = new System.Drawing.Point(185, 253);
            this.richTextBoxDonations.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.richTextBoxDonations.Name = "richTextBoxDonations";
            this.richTextBoxDonations.Size = new System.Drawing.Size(442, 44);
            this.richTextBoxDonations.TabIndex = 10;
            this.richTextBoxDonations.Text = "https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=streamdvr%40gmail%2" +
    "ecom&lc=US&item_name=StreamDVR&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donat" +
    "eCC_LG%2egif%3aNonHosted";
            this.richTextBoxDonations.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxDonations_LinkClicked);
            // 
            // richTextBoxCredits
            // 
            this.richTextBoxCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxCredits.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBoxCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCredits.Location = new System.Drawing.Point(183, 303);
            this.richTextBoxCredits.Name = "richTextBoxCredits";
            this.richTextBoxCredits.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxCredits.Size = new System.Drawing.Size(444, 94);
            this.richTextBoxCredits.TabIndex = 11;
            this.richTextBoxCredits.Text = resources.GetString("richTextBoxCredits.Text");
            this.richTextBoxCredits.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxCredits_LinkClicked);
            // 
            // richTextBoxLicense
            // 
            this.richTextBoxLicense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBoxLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLicense.Location = new System.Drawing.Point(185, 405);
            this.richTextBoxLicense.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.richTextBoxLicense.Name = "richTextBoxLicense";
            this.tableLayoutPanel2.SetRowSpan(this.richTextBoxLicense, 2);
            this.richTextBoxLicense.Size = new System.Drawing.Size(442, 172);
            this.richTextBoxLicense.TabIndex = 12;
            this.richTextBoxLicense.Text = resources.GetString("richTextBoxLicense.Text");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // streamWake
            // 
            this.streamWake.Text = "Wake";
            this.streamWake.Width = 52;
            // 
            // rootForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(886, 666);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rootForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPageAbout.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ColumnHeader taskName;
        private System.Windows.Forms.ColumnHeader NextRunTime;
        private System.Windows.Forms.ColumnHeader LastRunTime;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonAddTrigger;
        private System.Windows.Forms.ColumnHeader streamUrl;
        private System.Windows.Forms.ColumnHeader streamId;
        private System.Windows.Forms.ColumnHeader streamView;
        private System.Windows.Forms.ColumnHeader streamTranscode;
        private System.Windows.Forms.ListView listViewTriggers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ColumnHeader triggerDate;
        private System.Windows.Forms.ColumnHeader triggerStatus;
        private System.Windows.Forms.Button buttonTriggerDelete;
        private System.Windows.Forms.Button buttonTaskEdit;
        private System.Windows.Forms.Button buttonTaskDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelWebsite;
        private System.Windows.Forms.Label labelDonations;
        private System.Windows.Forms.Label labelCredits;
        private System.Windows.Forms.Label labelLicense;
        private System.Windows.Forms.Label labelAuthor2;
        private System.Windows.Forms.RichTextBox richTextBoxWebsite;
        private System.Windows.Forms.RichTextBox richTextBoxDonations;
        private System.Windows.Forms.RichTextBox richTextBoxCredits;
        private System.Windows.Forms.RichTextBox richTextBoxLicense;
        private System.Windows.Forms.ColumnHeader streamWake;
    }
}

