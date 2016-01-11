using System;
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

            tabControl1.Selecting += new TabControlCancelEventHandler(tabControl1_Selecting);
        }

        void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //check which tab is selected. if it is the schedule tab load the tasks and triggers
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPageSchedule"])
            {
                if (buttonConfigSave.BackColor == Color.Red)
                {
                    DialogResult dialogResult = MessageBox.Show("Would you like to save your changes?", "Unsaved changes", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //save ini file and return save button to normal color
                        writeIniFile();
                        changeSaveButtonColor(false);
                    } else
                    {
                        //read ini file and return save button to normal color
                        readIniFile();
                        changeSaveButtonColor(false);
                    }
                }
                loadTasks(null);
            }
        }

        private void buttonLivestreamer_Click(object sender, EventArgs e)
        {
            OpenFileDialog livestreamerDialog = new OpenFileDialog();
            livestreamerDialog.Filter = "Executables (livestreamer.exe)|livestreamer.exe";
            livestreamerDialog.FilterIndex = 1;
            livestreamerDialog.Multiselect = false;

            if (livestreamerDialog.ShowDialog() == DialogResult.OK)
            {
                livestreamerEXE = livestreamerDialog.FileName;
                textBoxLivestreamer.Text = livestreamerDialog.FileName;
                changeSaveButtonColor(true);
            }        
        }

        private void buttonHandbrake_Click(object sender, EventArgs e)
        {
            OpenFileDialog handbrakeDialog = new OpenFileDialog();
            handbrakeDialog.Filter = "Executables (handbrakecli.exe)|handbrakecli.exe";
            handbrakeDialog.FilterIndex = 1;
            handbrakeDialog.Multiselect = false;

            if (handbrakeDialog.ShowDialog() == DialogResult.OK)
            {
                handbrakeEXE = handbrakeDialog.FileName;
                textBoxHandbrake.Text = handbrakeDialog.FileName;
                changeSaveButtonColor(true);
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
                changeSaveButtonColor(true);
            }
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog logDialog = new FolderBrowserDialog();

            if (logDialog.ShowDialog() == DialogResult.OK)
            {
                logDir = logDialog.SelectedPath + "\\";
                textBoxLog.Text = logDialog.SelectedPath + "\\";
                changeSaveButtonColor(true);
            }
        }

        private void buttonLivestreamerOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog livestreamerOutputDialog = new FolderBrowserDialog();

            if (livestreamerOutputDialog.ShowDialog() == DialogResult.OK)
            {
                outputDir = livestreamerOutputDialog.SelectedPath + "\\";
                textBoxLivestreamerOutput.Text = livestreamerOutputDialog.SelectedPath + "\\";
                changeSaveButtonColor(true);
            }
        }

        private void buttonHandbrakeOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog handbrakeOutputDialog = new FolderBrowserDialog();

            if (handbrakeOutputDialog.ShowDialog() == DialogResult.OK)
            {
                handbrakeoutputDir = handbrakeOutputDialog.SelectedPath + "\\";
                textBoxHandbrakeOutput.Text = handbrakeOutputDialog.SelectedPath + "\\";
                changeSaveButtonColor(true);
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            moveListboxItem(-1);
            createQualityString();
            changeSaveButtonColor(true);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            moveListboxItem(1);
            createQualityString();
            changeSaveButtonColor(true);
        }

        private void radioButtonHandbrake1_CheckedChanged(object sender, EventArgs e)
        {
            //checks if the radio button is checked and sets the global variable handbrakePreset

            if (radioButtonHandbrake1.Checked == true)
            {
                handbrakePreset = radioButtonHandbrake1.Text;
                if (radioButtonHandbrake1.Focused == true)
                {
                    changeSaveButtonColor(true);
                }
            }
        }

        private void radioButtonHandbrake2_CheckedChanged(object sender, EventArgs e)
        {
            //checks if the radio button is checked and sets the global variable handbrakePreset

            if (radioButtonHandbrake2.Checked == true)
            {
                handbrakePreset = radioButtonHandbrake2.Text;
                if (radioButtonHandbrake2.Focused == true)
                {
                    changeSaveButtonColor(true);
                }
            }
        }

        private void radioButtonHandbrake3_CheckedChanged(object sender, EventArgs e)
        {
            //checks if the radio button is checked and sets the global variable handbrakePreset

            if (radioButtonHandbrake3.Checked == true)
            {
                handbrakePreset = textBoxHandbrakePreset.Text;
                if (radioButtonHandbrake3.Focused == true)
                {
                    changeSaveButtonColor(true);
                }
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
            changeSaveButtonColor(false);
        }

        private void buttonConfigDiscard_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to discard any changes and load settings from the StreamDVR.ini file?", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                readIniFile();
                changeSaveButtonColor(false);
            }
        }

        private void rootForm_Load(object sender, EventArgs e)
        {
            readIniFile();
            labelVersion.Text = "StreamDVR v" + Application.ProductVersion;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            loadTasks(null);
        }

        private void buttonTriggerDelete_Click(object sender, EventArgs e)
        {
            string selectedItemText;

            if (listViewTasks.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listViewTasks.SelectedItems)
                {
                    selectedItemText = selectedItem.Text;
                    openTriggerEditor(selectedItemText, listViewTriggers.SelectedItems[0].Text);
                    loadTriggers(selectedItemText);
                }
            }
        }

        private void buttonTaskEdit_Click(object sender, EventArgs e)
        {
            //edits selected task
            string selectedItemText;

            if (listViewTasks.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listViewTasks.SelectedItems)
                {
                    selectedItemText = selectedItem.Text;
                    editTask(selectedItem);
                    loadTasks(selectedItemText);
                }
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            Form2 settingsForm = new Form2();

            // Show the settings form
            settingsForm.ShowDialog();
            if (settingsForm.DialogResult != DialogResult.Cancel)
            {
                addTask(settingsForm.form2StreamUrl, settingsForm.form2StreamTag, settingsForm.form2StreamTranscode, settingsForm.form2StreamMedia, false);
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            string selectedItemText;

            if (listViewTasks.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listViewTasks.SelectedItems)
                {
                    selectedItemText = selectedItem.Text;
                    openTriggerEditor(selectedItemText, null);
                    loadTasks(selectedItemText);
                    //triggers will load because loadTasks will select the task which loads the triggers
                }
            }
        }

        private void listViewTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when listViewTasks is selected. load the triggers for that task into listViewTriggers

            string selectedItemText;

            if (listViewTasks.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listViewTasks.SelectedItems)
                {
                    selectedItemText = selectedItem.Text;
                    loadTriggers(selectedItemText);
                }
            }
        }

        private void buttonTaskDelete_Click(object sender, EventArgs e)
        {
            //deletes selected task
            string selectedItemText;

            if (listViewTasks.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listViewTasks.SelectedItems)
                {
                    selectedItemText = selectedItem.Text;
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this configured task? This will also delete all scheduled recordings for this task", "Are you sure?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        deleteTask(selectedItemText);
                        loadTasks(null);
                    }
                }
            }
        }

        private void richTextBoxWebsite_LinkClicked (object sender, System.Windows.Forms.LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void richTextBoxDonations_LinkClicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void richTextBoxCredits_LinkClicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        public void loadTasks(string selectedItemText)
        {
            //empty listview first
            listViewTasks.Items.Clear();

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
                enumFolderTasks(ts.RootFolder);
            }

            //select item if parameter was passed
            if (selectedItemText != null)
            {
                foreach (ListViewItem item in listViewTasks.Items)
                {
                    if (item.Text == selectedItemText)
                    {
                        listViewTasks.Select();
                        item.Focused = true;
                        item.Selected = true;
                    }
                }
            }
        }

        public void addTask(string url, string tag, bool transcode, bool media, bool edit)
        {
            //variable to check if this task is unique
            bool taskValid = true;

            //use tag as taskName
            string taskName = tag;

            //get directory that this application is executing in
            string currentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string batPath = "\"" + currentPath + "\\bat\\genericStream.bat" + "\"";

            //build arguments string
            string taskArguments = url + " " + tag;
            if (transcode)
            {
                taskArguments += " " + "Y";
            }
            else
            {
                taskArguments += " " + "N";
            }
            if (media)
            {
                taskArguments += " " + "Y";
            }
            else
            {
                taskArguments += " " + "N";
            }

            //create new task
            using (TaskService ts = new TaskService())
            {
                TaskDefinition taskDefinition = ts.NewTask();
                taskDefinition.Actions.Add(new ExecAction(batPath, taskArguments, null));
                taskDefinition.Principal.RunLevel = TaskRunLevel.Highest;

                //check if this taskName already exists in StreamDVR folder
                TaskFolder myFolder = ts.RootFolder.SubFolders["StreamDVR"];
                foreach (Microsoft.Win32.TaskScheduler.Task allTasks in myFolder.AllTasks)
                {
                    if (allTasks.Name == taskName)
                    {
                        taskValid = false;
                        if (edit == false)
                        {
                            //task already exists and edit flag is set to false
                            DialogResult dialogResult = MessageBox.Show("That tag already exists. Tag must be unique", "Error", MessageBoxButtons.OK);
                            // Create a new instance of the Form2 class
                            Form2 settingsForm = new Form2(url, tag, transcode, media);

                            // Show the settings form
                            settingsForm.ShowDialog();
                            if (settingsForm.DialogResult != DialogResult.Cancel)
                            {
                                addTask(settingsForm.form2StreamUrl, settingsForm.form2StreamTag, settingsForm.form2StreamTranscode, settingsForm.form2StreamMedia, false);
                            }
                        }
                        else
                        {
                            //task already exists and edit flag is set to true
                            allTasks.Definition.Actions.Clear();
                            allTasks.Definition.Actions.Add(new ExecAction(batPath, taskArguments, null));
                            allTasks.RegisterChanges();
                        }
                    }
                }

                if (taskValid == true)
                {
                    //task does not already exist. create

                    myFolder.RegisterTaskDefinition(taskName, taskDefinition);
                    //open trigger editor for new task
                    openTriggerEditor(taskName, null);
                    loadTasks(taskName);
                }
            }
        }

        public void editTask(ListViewItem selectedItem)
        {
            //gets data from selectedItem
            string url = selectedItem.SubItems[1].Text;
            string tag = selectedItem.SubItems[2].Text;
            bool transcode;
            bool media;

            if (selectedItem.SubItems[3].Text == "Y")
            {
                transcode = true;
            }
            else
            {
                transcode = false;
            }
            if (selectedItem.SubItems[4].Text == "Y")
            {
                media = true;
            }
            else
            {
                media = false;
            }

            // Create a new instance of the Form2 class
            Form2 settingsForm = new Form2(url, tag, transcode, media, true);

            // Show the settings form
            settingsForm.ShowDialog();
            if (settingsForm.DialogResult != DialogResult.Cancel)
            {
                addTask(settingsForm.form2StreamUrl, settingsForm.form2StreamTag, settingsForm.form2StreamTranscode, settingsForm.form2StreamMedia, true);
            }
        }

        public void deleteTask(string selectedItemText)
        {
            //receives seleteditem and deletes it

            //clear out listViewTriggers first
            listViewTriggers.Items.Clear();

            using (TaskService ts = new TaskService())
            {
                foreach (TaskFolder taskFolder in ts.RootFolder.SubFolders)
                {
                    if (taskFolder.Name == "StreamDVR")
                    {
                        foreach (Microsoft.Win32.TaskScheduler.Task task in taskFolder.Tasks)
                        {
                            if (selectedItemText == task.Name)
                            {
                                taskFolder.DeleteTask(task.Name);
                            }
                        }
                    }
                }
            }
        }

        public void enumFolderTasks(TaskFolder fld)
        {
            string nextruntime;
            string lastruntime;
            string streamUrl;
            string streamId;
            string streamView;
            string streamEncode;

            if (fld.Name == "StreamDVR")
            {
                foreach (Microsoft.Win32.TaskScheduler.Task task in fld.Tasks)
                {
                    nextruntime = Convert.ToString(task.NextRunTime);
                    lastruntime = Convert.ToString(task.LastRunTime);
                    string stream = task.Definition.Actions.ToString();

                    char[] delimiterChars = { ' ' };
                    try
                    {
                        string[] words = stream.Split(delimiterChars);
                        streamUrl = words[1];
                        streamId = words[2];
                        streamView = words[3];
                        streamEncode = words[4];
                    }
                    catch
                    {
                        //task must not have parameters we are looking for
                        streamUrl = "";
                        streamId = "";
                        streamView = "";
                        streamEncode = "";
                    }
                    //check to see if next run time or last run time are null. this is returned as 1/1/0001 12:00:00 AM
                    if (nextruntime == "1/1/0001 12:00:00 AM")
                    {
                        nextruntime = "";
                    }
                    if (lastruntime == "1/1/0001 12:00:00 AM")
                    {
                        lastruntime = "";
                    }
                    listViewTasks.Items.Add(new ListViewItem(new string[] { task.Name, streamUrl, streamId, streamView, streamEncode, nextruntime, lastruntime }));
                }
            }
            foreach (TaskFolder sfld in fld.SubFolders)
            { 
                enumFolderTasks(sfld);
            }
        }

        public void openTriggerEditor(string selectedItemText, string triggerToDelete)
        {
            //receives the text of the selected item and opens the task editor dialog
            using (TaskService ts = new TaskService())
            {
                foreach (TaskFolder taskFolder in ts.RootFolder.SubFolders)
                {
                    if (taskFolder.Name == "StreamDVR")
                    {
                        foreach (Microsoft.Win32.TaskScheduler.Task task in taskFolder.Tasks)
                        {
                            if (selectedItemText == task.Name)
                            {
                                if (triggerToDelete != null)
                                {
                                    int triggerIndex = 0;

                                    foreach (Trigger trigger in task.Definition.Triggers)
                                    {
                                        if (trigger.ToString() == triggerToDelete)
                                        {
                                            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this scheduled recording?", "Are you sure?", MessageBoxButtons.YesNo);
                                            if (dialogResult == DialogResult.Yes)
                                            {
                                                task.Definition.Triggers.RemoveAt(triggerIndex);
                                                task.RegisterChanges();
                                                break; //exit loop since we deleted trigger
                                            }
                                        }
                                        triggerIndex++;
                                    }
                                } else
                                {
                                    TriggerEditDialog triggerForm = new TriggerEditDialog();
                                    if (triggerForm.ShowDialog() == DialogResult.OK)
                                    {
                                        task.Definition.Triggers.Add(triggerForm.Trigger);
                                        task.RegisterChanges();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void loadTriggers(string selectedItemText)
        {
            //receives the text of the selected task and populates the listviewtriggers listview

            string triggerStartTime;
            string triggerStatus;

            //clear out listViewTriggers first
            listViewTriggers.Items.Clear();

            using (TaskService ts = new TaskService())
            {
                foreach (TaskFolder taskFolder in ts.RootFolder.SubFolders)
                {
                    if (taskFolder.Name == "StreamDVR")
                    {
                        foreach (Microsoft.Win32.TaskScheduler.Task task in taskFolder.Tasks)
                        {
                            if (selectedItemText == task.Name)
                            {
                                foreach (Trigger trigger in task.Definition.Triggers)
                                {
                                    triggerStartTime = trigger.ToString();
                                    if (trigger.Enabled == true)
                                    {
                                        triggerStatus = "Enabled";
                                    } else
                                    {
                                        triggerStatus = "Disabled";
                                    }

                                    listViewTriggers.Items.Add(new ListViewItem(new string[] { triggerStartTime, triggerStatus }));
                                }
                            }
                        }
                    }
                }
            }
        }

        public void moveListboxItem(int direction)
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
        
        public void changeSaveButtonColor(bool saveRequired)
        {
            if (saveRequired)
            {
                //turn button red because the user needs to save changes
                buttonConfigSave.BackColor = Color.Red;
                buttonConfigSave.ForeColor = Color.White;
            } else
            {
                //turn the button back to normal because save is complete
                buttonConfigSave.BackColor = Color.Transparent;
                buttonConfigSave.ForeColor = Color.Black;
            }
        }

        public void createQualityString()
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
            var MyIni = new IniFile("bat\\StreamDVR.ini");

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
            var MyIni = new IniFile("bat\\StreamDVR.ini");

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
