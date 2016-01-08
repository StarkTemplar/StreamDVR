﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32.TaskScheduler;

namespace StreamDVR
{
    public partial class rootForm : Form
    {
        //intialize global variables
        string livestreamerEXE;
        string handbrakeEXE;
        string mediaplayerEXE;
        string logDir;
        string outputDir;
        string handbrakeoutputDir;
        string quality;
        string handbrakePreset;

        public rootForm()
        {
            InitializeComponent();
        }

        private void buttonLivestreamer_Click(object sender, EventArgs e)
        {
            OpenFileDialog livestreamerDialog = new OpenFileDialog();
            livestreamerDialog.Filter = "Executables (*.exe)|*.exe";
            livestreamerDialog.FilterIndex = 1;
            livestreamerDialog.Multiselect = false;

            if (livestreamerDialog.ShowDialog() == DialogResult.OK)
            {
                livestreamerEXE = livestreamerDialog.FileName;
                textBoxLivestreamer.Text = livestreamerDialog.FileName;
            }        
        }

        private void buttonHandbrake_Click(object sender, EventArgs e)
        {
            OpenFileDialog handbrakeDialog = new OpenFileDialog();
            handbrakeDialog.Filter = "Executables (*cli.exe)|*cli.exe";
            handbrakeDialog.FilterIndex = 1;
            handbrakeDialog.Multiselect = false;

            if (handbrakeDialog.ShowDialog() == DialogResult.OK)
            {
                handbrakeEXE = handbrakeDialog.FileName;
                textBoxHandbrake.Text = handbrakeDialog.FileName;
            }
        }

        private void buttonMediaplayer_Click(object sender, EventArgs e)
        {
            OpenFileDialog mediaplayerDialog = new OpenFileDialog();
            mediaplayerDialog.Filter = "Executables (*.exe)|*.exe";
            mediaplayerDialog.FilterIndex = 1;
            mediaplayerDialog.Multiselect = false;

            if (mediaplayerDialog.ShowDialog() == DialogResult.OK)
            {
                mediaplayerEXE = mediaplayerDialog.FileName;
                textBoxMediaplayer.Text = mediaplayerDialog.FileName;
            }
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog logDialog = new FolderBrowserDialog();

            if (logDialog.ShowDialog() == DialogResult.OK)
            {
                logDir = logDialog.SelectedPath;
                textBoxLog.Text = logDialog.SelectedPath;
            }
        }

        private void buttonLivestreamerOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog livestreamerOutputDialog = new FolderBrowserDialog();

            if (livestreamerOutputDialog.ShowDialog() == DialogResult.OK)
            {
                outputDir = livestreamerOutputDialog.SelectedPath;
                textBoxLivestreamerOutput.Text = livestreamerOutputDialog.SelectedPath;
            }
        }

        private void buttonHandbrakeOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog handbrakeOutputDialog = new FolderBrowserDialog();

            if (handbrakeOutputDialog.ShowDialog() == DialogResult.OK)
            {
                handbrakeoutputDir = handbrakeOutputDialog.SelectedPath;
                textBoxHandbrakeOutput.Text = handbrakeOutputDialog.SelectedPath;
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            MoveListboxItem(-1);
            CreateQualityString();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            MoveListboxItem(1);
            CreateQualityString();
        }

        private void radioButtonHandbrake1_CheckedChanged(object sender, EventArgs e)
        {
            //checks if the radio button is checked and sets the global variable handbrakePreset

            if (radioButtonHandbrake1.Checked == true)
            {
                handbrakePreset = radioButtonHandbrake1.Text;
            }
        }

        private void radioButtonHandbrake2_CheckedChanged(object sender, EventArgs e)
        {
            //checks if the radio button is checked and sets the global variable handbrakePreset

            if (radioButtonHandbrake2.Checked == true)
            {
                handbrakePreset = radioButtonHandbrake2.Text;
            }
        }

        private void radioButtonHandbrake3_CheckedChanged(object sender, EventArgs e)
        {
            //checks if the radio button is checked and sets the global variable handbrakePreset

            if (radioButtonHandbrake3.Checked == true)
            {
                handbrakePreset = textBoxHandbrakePreset.Text;
            }
        }

        private void textBoxHandbrakePreset_TextChanged(object sender, EventArgs e)
        {
            //checks if the radio button is checked and sets the global variable handbrakePreset

            if (radioButtonHandbrake3.Checked == true)
            {
                handbrakePreset = textBoxHandbrakePreset.Text;
            }
        }

        private void buttonConfigSave_Click(object sender, EventArgs e)
        {
            writeIniFile();
        }

        private void buttonConfigDiscard_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to discard any changes and load settings from the StreamDVR.ini file", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                readIniFile();
            }
        }

        private void rootForm_Load(object sender, EventArgs e)
        {
            readIniFile();
        }

        public void MoveListboxItem(int direction)
        {
            // Moves the item in a list box 1 index higher or lower

            // Checking selected item
            if (listBoxLivestreamerQuality.SelectedItem == null || listBoxLivestreamerQuality.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex = listBoxLivestreamerQuality.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= listBoxLivestreamerQuality.Items.Count)
                return; // Index out of range - nothing to do

            object selected = listBoxLivestreamerQuality.SelectedItem;

            // Removing removable element
            listBoxLivestreamerQuality.Items.Remove(selected);
            // Insert it in new position
            listBoxLivestreamerQuality.Items.Insert(newIndex, selected);
            // Restore selection
            listBoxLivestreamerQuality.SetSelected(newIndex, true);
        }

        public void CreateQualityString()
        {
            //Creates the quality string and saves the value to the global variable quality

            quality = "";
            foreach (var item in listBoxLivestreamerQuality.Items)
            {
                quality += item.ToString() + ",";
            }
        }

        public void readIniFile()
        {
            var MyIni = new IniFile();

            //read ini file and assign to global variables
            livestreamerEXE = MyIni.Read("livestreamerEXE");
            handbrakeEXE = MyIni.Read("handbrakeEXE");
            mediaplayerEXE = MyIni.Read("mediaplayerEXE");
            logDir = MyIni.Read("logDir");
            outputDir = MyIni.Read("outputDir");
            handbrakeoutputDir = MyIni.Read("handbrakeoutputDir");
            quality = MyIni.Read("quality");
            handbrakePreset = MyIni.Read("handbrakePreset");

            //assign global variables to corresponding controls
            textBoxLivestreamer.Text = livestreamerEXE;
            textBoxHandbrake.Text = handbrakeEXE;
            textBoxMediaplayer.Text = mediaplayerEXE;
            textBoxLog.Text = logDir;
            textBoxLivestreamerOutput.Text = outputDir;
            textBoxHandbrakeOutput.Text = handbrakeoutputDir;

            //parse quality string and load collection
            char[] charsToTrim = { '\"' };
            string qualityResult = quality.Trim(charsToTrim);
            string[] qualityValues = qualityResult.Split(',');
            listBoxLivestreamerQuality.Items.Clear();

            foreach (string qualityString in qualityValues)
            {
                if (!String.IsNullOrEmpty(qualityString))
                    listBoxLivestreamerQuality.Items.Add(qualityString);
            }

            //parse handbrake quality string and select the correct radio button
            if (handbrakePreset == "AppleTV 3")
            {
                radioButtonHandbrake1.Checked = true;
                radioButtonHandbrake2.Checked = false;
                radioButtonHandbrake3.Checked = false;
                textBoxHandbrakePreset.Text = "";
            }
            else if (handbrakePreset == "Android")
            {
                radioButtonHandbrake1.Checked = false;
                radioButtonHandbrake2.Checked = true;
                radioButtonHandbrake3.Checked = false;
                textBoxHandbrakePreset.Text = "";
            }
            else
            {
                radioButtonHandbrake1.Checked = false;
                radioButtonHandbrake2.Checked = false;
                radioButtonHandbrake3.Checked = true;
                textBoxHandbrakePreset.Text = handbrakePreset;
            }
        }

        public void writeIniFile()
        {
            var MyIni = new IniFile();

            //write global variables to ini file
            MyIni.Write("livestreamerEXE", "\"" + livestreamerEXE + "\"");
            MyIni.Write("handbrakeEXE", "\"" + handbrakeEXE + "\"");
            MyIni.Write("mediaplayerEXE", "\"" + mediaplayerEXE + "\"");
            MyIni.Write("logDir", logDir);
            MyIni.Write("outputDir", outputDir);
            MyIni.Write("handbrakeoutputDir", handbrakeoutputDir);
            MyIni.Write("quality", "\"" + quality + "\"");
            MyIni.Write("handbrakePreset", "\"" + handbrakePreset + "\"");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            // Get the service on the local machine
            using (TaskService ts = new TaskService())
            {
                try
                {
                    ts.RootFolder.CreateFolder("StreamDVR");
                }
                catch
                {
                    //folder must already exist
                }
                EnumFolderTasks(ts.RootFolder);
            }
        }

        public void EnumFolderTasks(TaskFolder fld)
        {
            string nextruntime;
            string lastruntime;

            if (fld.Name == "StreamDVR")
            {
                foreach (Microsoft.Win32.TaskScheduler.Task task in fld.Tasks)
                {
                    nextruntime = Convert.ToString(task.NextRunTime);
                    lastruntime = Convert.ToString(task.LastRunTime);

                    //check to see if next run time or last run time are null. this is returned as 1/1/0001 12:00:00 AM
                    if (nextruntime == "1/1/0001 12:00:00 AM")
                    {
                        nextruntime = "";
                    }
                    if (lastruntime == "1/1/0001 12:00:00 AM")
                    {
                        lastruntime = "";
                    }
                    listViewTasks.Items.Add(new ListViewItem(new string[] { task.Name, nextruntime, lastruntime }));
                }
            }
            foreach (TaskFolder sfld in fld.SubFolders)
            { 
                EnumFolderTasks(sfld);
            }
        }
    }

    class IniFile   // revision 10
    {
        //Class for reading and writing to ini files
        //Found from user Danny Beckett at http://stackoverflow.com/questions/217902/reading-writing-an-ini-file

        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniFile(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}
