using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamDVR
{
    public partial class Form2 : Form
    {
        private string _form2StreamUrl;
        private string _form2StreamTag;
        private bool _form2StreamTranscode;
        private bool _form2StreamMedia;
        private bool _form2StreamWake;


        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string url, string tag, bool transcode, bool media, bool wake)
        {
            InitializeComponent();
            textBoxStreamUrl.Text = url;
            textBoxStreamTag.Text = tag;
            if (transcode == true)
            {
                radioButtonTranscode1.Checked = true;
            }
            else
            {
                radioButtonTranscode1.Checked = false;
            }
            if (media == true)
            {
                radioButtonMediaplayer1.Checked = true;
            }
            else
            {
                radioButtonMediaplayer1.Checked = false;
            }
            if (wake == true)
            {
                radioButtonWake1.Checked = true;
            } else
            {
                radioButtonWake1.Checked = false;
            }
        }

        public Form2(string url, string tag, bool transcode, bool media, bool wake, bool locked)
        {
            InitializeComponent();
            textBoxStreamUrl.Text = url;
            textBoxStreamTag.Text = tag;
            if (transcode == true)
            {
                radioButtonTranscode1.Checked = true;
            }
            else
            {
                radioButtonTranscode1.Checked = false;
            }
            if (media == true)
            {
                radioButtonMediaplayer1.Checked = true;
            }
            else
            {
                radioButtonMediaplayer1.Checked = false;
            }
            if (wake == true)
            {
                radioButtonWake1.Checked = true;
            }
            else
            {
                radioButtonWake1.Checked = false;
            }
            if (locked == true)
            {
                textBoxStreamTag.ReadOnly = true;
            }
        }

        public string form2StreamUrl
        {
            get { return _form2StreamUrl; }
            set { _form2StreamUrl = value; }
        }

        public string form2StreamTag
        {
            get { return _form2StreamTag; }
            set { _form2StreamTag = value; }
        }

        public bool form2StreamTranscode
        {
            get { return _form2StreamTranscode; }
            set { _form2StreamTranscode = value; }
        }

        public bool form2StreamMedia
        {
            get { return _form2StreamMedia; }
            set { _form2StreamMedia = value; }
        }

        public bool form2StreamWake
        {
            get { return _form2StreamWake; }
            set { _form2StreamWake = value; }
        }

        private void radioButtonTranscode2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validateResult = validateForm();

            if (validateResult == true)
            {
                form2StreamUrl = textBoxStreamUrl.Text.Replace(" ", string.Empty);
                form2StreamTag = textBoxStreamTag.Text.Replace(" ", string.Empty);
                if (radioButtonTranscode1.Checked == true)
                {
                    form2StreamTranscode = true;
                } else
                {
                    form2StreamTranscode = false;
                }
                if (radioButtonMediaplayer1.Checked == true)
                {
                    form2StreamMedia = true;
                }
                else
                {
                    form2StreamMedia = false;
                }
                if (radioButtonWake1.Checked == true)
                {
                    form2StreamWake = true;
                } else
                {
                    form2StreamWake = false;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public bool validateForm()
        {
            if (String.IsNullOrEmpty(textBoxStreamUrl.Text) || String.IsNullOrEmpty(textBoxStreamTag.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Stream URL and Stream Tag must be populated", "Error", MessageBoxButtons.OK);
                return false;
            } else
            {
                return true;
            }
        }
    }
}
