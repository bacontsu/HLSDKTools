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
        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // set active color
            button2.BackColor = Color.FromArgb(120, 120, 120);
            button1.BackColor = Color.FromArgb(90, 90, 90);
            button3.BackColor = Color.FromArgb(90, 90, 90);
            button4.BackColor = Color.FromArgb(90, 90, 90);
            button5.BackColor = Color.FromArgb(90, 90, 90);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // set active color
            button3.BackColor = Color.FromArgb(120, 120, 120);
            button2.BackColor = Color.FromArgb(90, 90, 90);
            button1.BackColor = Color.FromArgb(90, 90, 90);
            button4.BackColor = Color.FromArgb(90, 90, 90);
            button5.BackColor = Color.FromArgb(90, 90, 90);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // set active color
            button4.BackColor = Color.FromArgb(120, 120, 120);
            button2.BackColor = Color.FromArgb(90, 90, 90);
            button3.BackColor = Color.FromArgb(90, 90, 90);
            button1.BackColor = Color.FromArgb(90, 90, 90);
            button5.BackColor = Color.FromArgb(90, 90, 90);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // set active color
            button5.BackColor = Color.FromArgb(120, 120, 120);
            button2.BackColor = Color.FromArgb(90, 90, 90);
            button3.BackColor = Color.FromArgb(90, 90, 90);
            button4.BackColor = Color.FromArgb(90, 90, 90);
            button1.BackColor = Color.FromArgb(90, 90, 90);
        }
    }
}
