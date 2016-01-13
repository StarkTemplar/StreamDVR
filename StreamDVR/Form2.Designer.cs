namespace StreamDVR
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelStreamId = new System.Windows.Forms.Label();
            this.textBoxStreamTag = new System.Windows.Forms.TextBox();
            this.labelStreamUrl = new System.Windows.Forms.Label();
            this.textBoxStreamUrl = new System.Windows.Forms.TextBox();
            this.labelEncode = new System.Windows.Forms.Label();
            this.labelMediaplayer = new System.Windows.Forms.Label();
            this.radioButtonTranscode1 = new System.Windows.Forms.RadioButton();
            this.radioButtonTranscode2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonMediaplayer1 = new System.Windows.Forms.RadioButton();
            this.radioButtonMediaplayer2 = new System.Windows.Forms.RadioButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonWake1 = new System.Windows.Forms.RadioButton();
            this.radioButtonWake2 = new System.Windows.Forms.RadioButton();
            this.labelWake = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStreamId
            // 
            this.labelStreamId.AutoSize = true;
            this.labelStreamId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStreamId.Location = new System.Drawing.Point(19, 69);
            this.labelStreamId.Name = "labelStreamId";
            this.labelStreamId.Size = new System.Drawing.Size(71, 15);
            this.labelStreamId.TabIndex = 8;
            this.labelStreamId.Text = "Stream Tag";
            // 
            // textBoxStreamTag
            // 
            this.textBoxStreamTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStreamTag.Location = new System.Drawing.Point(142, 66);
            this.textBoxStreamTag.Name = "textBoxStreamTag";
            this.textBoxStreamTag.Size = new System.Drawing.Size(501, 21);
            this.textBoxStreamTag.TabIndex = 7;
            this.textBoxStreamTag.Text = "gsl";
            // 
            // labelStreamUrl
            // 
            this.labelStreamUrl.AutoSize = true;
            this.labelStreamUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStreamUrl.Location = new System.Drawing.Point(19, 33);
            this.labelStreamUrl.Name = "labelStreamUrl";
            this.labelStreamUrl.Size = new System.Drawing.Size(75, 15);
            this.labelStreamUrl.TabIndex = 6;
            this.labelStreamUrl.Text = "Stream URL";
            // 
            // textBoxStreamUrl
            // 
            this.textBoxStreamUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStreamUrl.Location = new System.Drawing.Point(142, 30);
            this.textBoxStreamUrl.Name = "textBoxStreamUrl";
            this.textBoxStreamUrl.Size = new System.Drawing.Size(501, 21);
            this.textBoxStreamUrl.TabIndex = 5;
            this.textBoxStreamUrl.Text = "http://afreeca.tv/36840697";
            // 
            // labelEncode
            // 
            this.labelEncode.AutoSize = true;
            this.labelEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncode.Location = new System.Drawing.Point(19, 111);
            this.labelEncode.Name = "labelEncode";
            this.labelEncode.Size = new System.Drawing.Size(329, 15);
            this.labelEncode.TabIndex = 9;
            this.labelEncode.Text = "Do you want to transcode this video when the stream ends?";
            // 
            // labelMediaplayer
            // 
            this.labelMediaplayer.AutoSize = true;
            this.labelMediaplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMediaplayer.Location = new System.Drawing.Point(19, 158);
            this.labelMediaplayer.Name = "labelMediaplayer";
            this.labelMediaplayer.Size = new System.Drawing.Size(417, 15);
            this.labelMediaplayer.TabIndex = 10;
            this.labelMediaplayer.Text = "Do you want your media player to show you the stream while it is recording?";
            // 
            // radioButtonTranscode1
            // 
            this.radioButtonTranscode1.AutoSize = true;
            this.radioButtonTranscode1.Location = new System.Drawing.Point(21, 16);
            this.radioButtonTranscode1.Name = "radioButtonTranscode1";
            this.radioButtonTranscode1.Size = new System.Drawing.Size(43, 17);
            this.radioButtonTranscode1.TabIndex = 11;
            this.radioButtonTranscode1.Text = "Yes";
            this.radioButtonTranscode1.UseVisualStyleBackColor = true;
            // 
            // radioButtonTranscode2
            // 
            this.radioButtonTranscode2.AutoSize = true;
            this.radioButtonTranscode2.Checked = true;
            this.radioButtonTranscode2.Location = new System.Drawing.Point(80, 16);
            this.radioButtonTranscode2.Name = "radioButtonTranscode2";
            this.radioButtonTranscode2.Size = new System.Drawing.Size(39, 17);
            this.radioButtonTranscode2.TabIndex = 12;
            this.radioButtonTranscode2.TabStop = true;
            this.radioButtonTranscode2.Text = "No";
            this.radioButtonTranscode2.UseVisualStyleBackColor = true;
            this.radioButtonTranscode2.CheckedChanged += new System.EventHandler(this.radioButtonTranscode2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonTranscode1);
            this.groupBox1.Controls.Add(this.radioButtonTranscode2);
            this.groupBox1.Location = new System.Drawing.Point(486, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(157, 41);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonMediaplayer1);
            this.groupBox2.Controls.Add(this.radioButtonMediaplayer2);
            this.groupBox2.Location = new System.Drawing.Point(486, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(157, 41);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonMediaplayer1
            // 
            this.radioButtonMediaplayer1.AutoSize = true;
            this.radioButtonMediaplayer1.Location = new System.Drawing.Point(21, 16);
            this.radioButtonMediaplayer1.Name = "radioButtonMediaplayer1";
            this.radioButtonMediaplayer1.Size = new System.Drawing.Size(43, 17);
            this.radioButtonMediaplayer1.TabIndex = 11;
            this.radioButtonMediaplayer1.Text = "Yes";
            this.radioButtonMediaplayer1.UseVisualStyleBackColor = true;
            // 
            // radioButtonMediaplayer2
            // 
            this.radioButtonMediaplayer2.AutoSize = true;
            this.radioButtonMediaplayer2.Checked = true;
            this.radioButtonMediaplayer2.Location = new System.Drawing.Point(80, 16);
            this.radioButtonMediaplayer2.Name = "radioButtonMediaplayer2";
            this.radioButtonMediaplayer2.Size = new System.Drawing.Size(39, 17);
            this.radioButtonMediaplayer2.TabIndex = 12;
            this.radioButtonMediaplayer2.TabStop = true;
            this.radioButtonMediaplayer2.Text = "No";
            this.radioButtonMediaplayer2.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(475, 252);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 17;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(568, 252);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonWake1);
            this.groupBox3.Controls.Add(this.radioButtonWake2);
            this.groupBox3.Location = new System.Drawing.Point(486, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox3.Size = new System.Drawing.Size(157, 41);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // radioButtonWake1
            // 
            this.radioButtonWake1.AutoSize = true;
            this.radioButtonWake1.Location = new System.Drawing.Point(21, 16);
            this.radioButtonWake1.Name = "radioButtonWake1";
            this.radioButtonWake1.Size = new System.Drawing.Size(43, 17);
            this.radioButtonWake1.TabIndex = 11;
            this.radioButtonWake1.Text = "Yes";
            this.radioButtonWake1.UseVisualStyleBackColor = true;
            // 
            // radioButtonWake2
            // 
            this.radioButtonWake2.AutoSize = true;
            this.radioButtonWake2.Checked = true;
            this.radioButtonWake2.Location = new System.Drawing.Point(80, 16);
            this.radioButtonWake2.Name = "radioButtonWake2";
            this.radioButtonWake2.Size = new System.Drawing.Size(39, 17);
            this.radioButtonWake2.TabIndex = 12;
            this.radioButtonWake2.TabStop = true;
            this.radioButtonWake2.Text = "No";
            this.radioButtonWake2.UseVisualStyleBackColor = true;
            // 
            // labelWake
            // 
            this.labelWake.AutoSize = true;
            this.labelWake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWake.Location = new System.Drawing.Point(19, 205);
            this.labelWake.Name = "labelWake";
            this.labelWake.Size = new System.Drawing.Size(301, 15);
            this.labelWake.TabIndex = 19;
            this.labelWake.Text = "Do you want your computer to wake for this recording?";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 321);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelWake);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelMediaplayer);
            this.Controls.Add(this.labelEncode);
            this.Controls.Add(this.labelStreamId);
            this.Controls.Add(this.textBoxStreamTag);
            this.Controls.Add(this.labelStreamUrl);
            this.Controls.Add(this.textBoxStreamUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Task Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStreamId;
        private System.Windows.Forms.TextBox textBoxStreamTag;
        private System.Windows.Forms.Label labelStreamUrl;
        private System.Windows.Forms.TextBox textBoxStreamUrl;
        private System.Windows.Forms.Label labelEncode;
        private System.Windows.Forms.Label labelMediaplayer;
        private System.Windows.Forms.RadioButton radioButtonTranscode1;
        private System.Windows.Forms.RadioButton radioButtonTranscode2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonMediaplayer1;
        private System.Windows.Forms.RadioButton radioButtonMediaplayer2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonWake1;
        private System.Windows.Forms.RadioButton radioButtonWake2;
        private System.Windows.Forms.Label labelWake;
    }
}