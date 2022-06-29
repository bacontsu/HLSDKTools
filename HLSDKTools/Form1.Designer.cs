namespace HLSDKTools
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabResize = new System.Windows.Forms.Panel();
            this.decTab = new System.Windows.Forms.Panel();
            this.displayModelBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.decOutBoxPath = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.decInBoxPath = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.decBoxPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.decOutputBox = new System.Windows.Forms.RichTextBox();
            this.decStartBtn = new System.Windows.Forms.Button();
            this.decBrowseFolderBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.decBrowseModelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.decButtonPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.tabPanel.SuspendLayout();
            this.tabResize.SuspendLayout();
            this.decTab.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Gray;
            this.closeBtn.Location = new System.Drawing.Point(756, -3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(47, 51);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 43);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(37, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(97, 19);
            this.title.TabIndex = 2;
            this.title.Text = "HLSDK Tools";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.FlatAppearance.BorderSize = 0;
            this.logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logo.Location = new System.Drawing.Point(8, 6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(30, 30);
            this.logo.TabIndex = 1;
            this.logo.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabPanel
            // 
            this.tabPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tabPanel.Controls.Add(this.button5);
            this.tabPanel.Controls.Add(this.button4);
            this.tabPanel.Controls.Add(this.button3);
            this.tabPanel.Controls.Add(this.button2);
            this.tabPanel.Controls.Add(this.button1);
            this.tabPanel.Location = new System.Drawing.Point(1, 0);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(179, 416);
            this.tabPanel.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 155);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(179, 37);
            this.button5.TabIndex = 4;
            this.button5.Text = "Map Compiler";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 116);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(179, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "Spritemaker";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 77);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(179, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Wadmaker";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 38);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(179, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "StudioMDL";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, -1);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(179, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Model Decompiler";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // tabResize
            // 
            this.tabResize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.tabResize.Controls.Add(this.tabPanel);
            this.tabResize.Location = new System.Drawing.Point(0, 43);
            this.tabResize.Name = "tabResize";
            this.tabResize.Size = new System.Drawing.Size(189, 416);
            this.tabResize.TabIndex = 5;
            this.tabResize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabResize_MouseDown);
            this.tabResize.MouseEnter += new System.EventHandler(this.tabResize_MouseEnter);
            this.tabResize.MouseLeave += new System.EventHandler(this.tabResize_MouseLeave);
            this.tabResize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tabResize_MouseUp);
            // 
            // decTab
            // 
            this.decTab.Controls.Add(this.displayModelBtn);
            this.decTab.Controls.Add(this.panel4);
            this.decTab.Controls.Add(this.panel3);
            this.decTab.Controls.Add(this.panel2);
            this.decTab.Controls.Add(this.label4);
            this.decTab.Controls.Add(this.decOutputBox);
            this.decTab.Controls.Add(this.decStartBtn);
            this.decTab.Controls.Add(this.decBrowseFolderBtn);
            this.decTab.Controls.Add(this.label3);
            this.decTab.Controls.Add(this.decBrowseModelBtn);
            this.decTab.Controls.Add(this.label2);
            this.decTab.Controls.Add(this.decButtonPath);
            this.decTab.Controls.Add(this.label1);
            this.decTab.Location = new System.Drawing.Point(195, 54);
            this.decTab.Name = "decTab";
            this.decTab.Size = new System.Drawing.Size(593, 384);
            this.decTab.TabIndex = 6;
            // 
            // displayModelBtn
            // 
            this.displayModelBtn.Location = new System.Drawing.Point(530, 89);
            this.displayModelBtn.Name = "displayModelBtn";
            this.displayModelBtn.Size = new System.Drawing.Size(41, 23);
            this.displayModelBtn.TabIndex = 14;
            this.displayModelBtn.Text = "View";
            this.displayModelBtn.UseVisualStyleBackColor = true;
            this.displayModelBtn.Click += new System.EventHandler(this.displayModelBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel4.Controls.Add(this.decOutBoxPath);
            this.panel4.Location = new System.Drawing.Point(179, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 23);
            this.panel4.TabIndex = 13;
            // 
            // decOutBoxPath
            // 
            this.decOutBoxPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.decOutBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.decOutBoxPath.ForeColor = System.Drawing.Color.White;
            this.decOutBoxPath.Location = new System.Drawing.Point(6, 5);
            this.decOutBoxPath.Name = "decOutBoxPath";
            this.decOutBoxPath.Size = new System.Drawing.Size(282, 13);
            this.decOutBoxPath.TabIndex = 0;
            this.decOutBoxPath.TextChanged += new System.EventHandler(this.decOutBoxPath_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.decInBoxPath);
            this.panel3.Location = new System.Drawing.Point(179, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 23);
            this.panel3.TabIndex = 13;
            // 
            // decInBoxPath
            // 
            this.decInBoxPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.decInBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.decInBoxPath.ForeColor = System.Drawing.Color.White;
            this.decInBoxPath.Location = new System.Drawing.Point(6, 5);
            this.decInBoxPath.Name = "decInBoxPath";
            this.decInBoxPath.Size = new System.Drawing.Size(282, 13);
            this.decInBoxPath.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.decBoxPath);
            this.panel2.Location = new System.Drawing.Point(179, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 23);
            this.panel2.TabIndex = 12;
            // 
            // decBoxPath
            // 
            this.decBoxPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.decBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.decBoxPath.ForeColor = System.Drawing.Color.White;
            this.decBoxPath.Location = new System.Drawing.Point(6, 5);
            this.decBoxPath.Name = "decBoxPath";
            this.decBoxPath.Size = new System.Drawing.Size(282, 13);
            this.decBoxPath.TabIndex = 0;
            this.decBoxPath.TextChanged += new System.EventHandler(this.decBoxPath_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Console Output:";
            // 
            // decOutputBox
            // 
            this.decOutputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.decOutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.decOutputBox.ForeColor = System.Drawing.Color.White;
            this.decOutputBox.Location = new System.Drawing.Point(25, 190);
            this.decOutputBox.Name = "decOutputBox";
            this.decOutputBox.Size = new System.Drawing.Size(528, 124);
            this.decOutputBox.TabIndex = 10;
            this.decOutputBox.Text = "";
            // 
            // decStartBtn
            // 
            this.decStartBtn.Location = new System.Drawing.Point(232, 326);
            this.decStartBtn.Name = "decStartBtn";
            this.decStartBtn.Size = new System.Drawing.Size(103, 31);
            this.decStartBtn.TabIndex = 9;
            this.decStartBtn.Text = "Decompile";
            this.decStartBtn.UseVisualStyleBackColor = true;
            this.decStartBtn.Click += new System.EventHandler(this.button8_Click);
            // 
            // decBrowseFolderBtn
            // 
            this.decBrowseFolderBtn.Location = new System.Drawing.Point(478, 117);
            this.decBrowseFolderBtn.Name = "decBrowseFolderBtn";
            this.decBrowseFolderBtn.Size = new System.Drawing.Size(93, 23);
            this.decBrowseFolderBtn.TabIndex = 8;
            this.decBrowseFolderBtn.Text = "Browse";
            this.decBrowseFolderBtn.UseVisualStyleBackColor = true;
            this.decBrowseFolderBtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Model Output Folder:";
            // 
            // decBrowseModelBtn
            // 
            this.decBrowseModelBtn.Location = new System.Drawing.Point(478, 89);
            this.decBrowseModelBtn.Name = "decBrowseModelBtn";
            this.decBrowseModelBtn.Size = new System.Drawing.Size(51, 23);
            this.decBrowseModelBtn.TabIndex = 5;
            this.decBrowseModelBtn.Text = "Browse";
            this.decBrowseModelBtn.UseVisualStyleBackColor = true;
            this.decBrowseModelBtn.Click += new System.EventHandler(this.decBrowseModelBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model Input File:";
            // 
            // decButtonPath
            // 
            this.decButtonPath.Location = new System.Drawing.Point(478, 47);
            this.decButtonPath.Name = "decButtonPath";
            this.decButtonPath.Size = new System.Drawing.Size(93, 23);
            this.decButtonPath.TabIndex = 2;
            this.decButtonPath.Text = "Browse";
            this.decButtonPath.UseVisualStyleBackColor = true;
            this.decButtonPath.Click += new System.EventHandler(this.decButtonPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Executable Path:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decTab);
            this.Controls.Add(this.tabResize);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPanel.ResumeLayout(false);
            this.tabResize.ResumeLayout(false);
            this.decTab.ResumeLayout(false);
            this.decTab.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button logo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel tabPanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel tabResize;
        private System.Windows.Forms.Panel decTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox decBoxPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button decButtonPath;
        private System.Windows.Forms.Button decBrowseFolderBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button decBrowseModelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decStartBtn;
        private System.Windows.Forms.RichTextBox decOutputBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox decOutBoxPath;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox decInBoxPath;
        private System.Windows.Forms.Button displayModelBtn;
    }
}

