using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace HLSDKTools
{
    public partial class Form1 : Form
    {
        int button1Offset;
        int button2Offset;
        int button3Offset;
        int button4Offset;
        int button5Offset;

        int button1State;
        int button2State;
        int button3State;
        int button4State;
        int button5State;

        bool isResizing;
        bool enableResizing;

        // tabPanel
        int[] originCoord = new int[2];
        int[] currentCoord = new int[2];
        int[] originalSize = new int[2];
        int targetSize;

        // content
        int selectedTab;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        // ===================================================================================
        // Application Init function
        // ===================================================================================
        public Form1()
        {
            InitializeComponent();
            timer1.Start();

            // default values
            button1State = 30;
            button2State = 30;
            button3State = 30;
            button4State = 30;
            button5State = 30;

            button1Offset = button1State;
            button2Offset = button2State;
            button3Offset = button3State;
            button4Offset = button4State;
            button5Offset = button5State;

            originalSize = new int[] { 179, tabPanel.Top };

            Settings.InitSetting();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.ForeColor = Color.Red;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.ForeColor = Color.Gray;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // apply settings
            decBoxPath.Text = Settings.MDLDecPath;
            decOutBoxPath.Text = Settings.modelOutput;
            decInBoxPath.Text = Settings.modelInput;

            // show only selected panel
            switch (selectedTab)
            {
                case 0:
                    {
                        decTab.Show();
                        break;
                    }
                default:
                    {
                        decTab.Hide();
                        break;
                    }
            }

            // handle button1
            if (button1Offset > button1State) button1State++;
            else if (button1Offset < button1State) button1State--;

            // handle button2
            if (button2Offset > button2State) button2State++;
            else if (button2Offset < button2State) button2State--;

            // handle button3
            if (button3Offset > button3State) button3State++;
            else if (button3Offset < button3State) button3State--;

            // handle button4
            if (button4Offset > button4State) button4State++;
            else if (button4Offset < button4State) button4State--;

            // handle button5
            if (button5Offset > button5State) button5State++;
            else if (button5Offset < button5State) button5State--;

            // apply padding
            button1.Padding = new Padding(button1State, 0, 0, 0);
            button2.Padding = new Padding(button2State, 0, 0, 0);
            button3.Padding = new Padding(button3State, 0, 0, 0);
            button4.Padding = new Padding(button4State, 0, 0, 0);
            button5.Padding = new Padding(button5State, 0, 0, 0);

            // resizing cursor
            if(isResizing)
                Cursor.Current = Cursors.SizeWE;
            else Cursor.Current = Cursors.Default;

            // handle resizing code
            if(enableResizing)
            {
                // update coord
                currentCoord = new int[] { Cursor.Position.X, Cursor.Position.Y };

                // calculate difference
                int[] dist = new int[2];

                dist[0] = currentCoord[0] - originCoord[0];
                dist[1] = currentCoord[1] - originCoord[1];

                targetSize = originalSize[0] + dist[0];

                // some clamps
                if (targetSize < 179 && targetSize >= 0)
                {
                    tabPanel.Width = targetSize;
                    tabResize.Width = targetSize + 10;
                    decTab.Left = targetSize + 10 + 6;
                }
                else if (targetSize >= 179)
                {
                    tabPanel.Width = 179;
                    tabResize.Width = 189;
                    decTab.Left = 195;
                    targetSize = 179;
                }
                else if (targetSize <= 0)
                {
                    tabPanel.Width = 0;
                    tabResize.Width = 10;
                    decTab.Left = 16;
                    targetSize = 0;
                }

                //label1.Text = "current mouse coord" + currentCoord[0] + " original mouse coord" + originCoord[0] + " last tab size" + originalSize[0]; 

            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1Offset = 40;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1Offset = 30;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2Offset = 40;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2Offset = 30;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3Offset = 40;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3Offset = 30;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4Offset = 40;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4Offset = 30;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5Offset = 40;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5Offset = 30;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // set active color
            button1.BackColor = Color.FromArgb(120, 120, 120);
            button2.BackColor = Color.FromArgb(90, 90, 90);
            button3.BackColor = Color.FromArgb(90, 90, 90);
            button4.BackColor = Color.FromArgb(90, 90, 90);
            button5.BackColor = Color.FromArgb(90, 90, 90);

            selectedTab = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // set active color
            button2.BackColor = Color.FromArgb(120, 120, 120);
            button1.BackColor = Color.FromArgb(90, 90, 90);
            button3.BackColor = Color.FromArgb(90, 90, 90);
            button4.BackColor = Color.FromArgb(90, 90, 90);
            button5.BackColor = Color.FromArgb(90, 90, 90);

            selectedTab = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // set active color
            button3.BackColor = Color.FromArgb(120, 120, 120);
            button2.BackColor = Color.FromArgb(90, 90, 90);
            button1.BackColor = Color.FromArgb(90, 90, 90);
            button4.BackColor = Color.FromArgb(90, 90, 90);
            button5.BackColor = Color.FromArgb(90, 90, 90);

            selectedTab = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // set active color
            button4.BackColor = Color.FromArgb(120, 120, 120);
            button2.BackColor = Color.FromArgb(90, 90, 90);
            button3.BackColor = Color.FromArgb(90, 90, 90);
            button1.BackColor = Color.FromArgb(90, 90, 90);
            button5.BackColor = Color.FromArgb(90, 90, 90);

            selectedTab = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // set active color
            button5.BackColor = Color.FromArgb(120, 120, 120);
            button2.BackColor = Color.FromArgb(90, 90, 90);
            button3.BackColor = Color.FromArgb(90, 90, 90);
            button4.BackColor = Color.FromArgb(90, 90, 90);
            button1.BackColor = Color.FromArgb(90, 90, 90);

            selectedTab = 4;
        }

        private void tabResize_MouseEnter(object sender, EventArgs e)
        {
            //Cursor.Current = Cursors.SizeWE;
            isResizing = true;
        }

        private void tabResize_MouseLeave(object sender, EventArgs e)
        {
            //Cursor.Current = Cursors.Default;
            isResizing = false;
        }

        private void tabResize_MouseDown(object sender, MouseEventArgs e)
        {
            originCoord = new int[] { Cursor.Position.X, Cursor.Position.Y };
            //originalSize = new int[] { tabPanel.Left, tabPanel.Top };
            enableResizing = true;
        }

        private void tabResize_MouseUp(object sender, MouseEventArgs e)
        {
            originalSize[0] = targetSize;
            enableResizing = false;
        }

        private void decButtonPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"/bin/",
                Title = "Browse MDLDEC.exe Executeable",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "exe",
                Filter = "exe files (*.exe)|*.exe",
              
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Settings.MDLDecPath = openFileDialog1.FileName;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = Settings.MDLDecPath,
                    Arguments = '"' + Settings.modelInput + '"' + " " + '"' + Settings.modelOutput + '"',
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string standard_output;
                while ((standard_output = proc.StandardOutput.ReadLine()) != null)
                {
                    decOutputBox.Text += standard_output + '\n';
                }
            }
        }

        private void decBoxPath_TextChanged(object sender, EventArgs e)
        {
            Settings.SaveSetting();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = "D:/",
                Title = "Browse output folder",

                CheckFileExists = false,
                CheckPathExists = true,
                ValidateNames = false,

                FileName = "Folder Selection.",

            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Settings.modelOutput = openFileDialog1.FileName.Remove(openFileDialog1.FileName.Length - 17);
            }
        }

        private void displayModelBtn_Click(object sender, EventArgs e)
        {

            Process.Start(Settings.HLAMPath, '"' + Settings.modelInput + '"');
        }

        private void decBrowseModelBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = "D:/",
                Title = "Browse model (.mdl) file",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "mdl",
                Filter = "mdl files (*.mdl)|*.mdl",
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Settings.modelInput = openFileDialog1.FileName;
            }
        }

        private void decOutBoxPath_TextChanged(object sender, EventArgs e)
        {
            Settings.SaveSetting();
        }
    }
}
