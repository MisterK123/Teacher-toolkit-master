using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_toolkit_G_drive_version
{
    public partial class TimerForm : Form
    {
        float time = 0;
        public TimerForm()
        {
            InitializeComponent();
        }
        public void RemoveText(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter text here...")
            {
                textBox1.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                textBox1.Text = "Enter text here...";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightGray;


        }
        //textBox1.GotFocus += GotFocus.EventHandle(RemoveText);
        //textBox1.LostFocus += LostFocus.EventHandle(AddText);

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void startTimer()
        {
            try
            {
                button1.Enabled = false;
                time = float.Parse(textBox1.Text);
                progressBar1.Maximum = (int.Parse(textBox1.Text) * 10);
                progressBar1.Step = 1;
                timer1.Enabled = true;
                textBox1.BackColor = Color.White;

            }
            catch
            {
                MessageBox.Show("Please input a value of time in ONLY seconds in the text box.", "Error");

            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            startTimer();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Stop")
            {
                timer1.Enabled = false;
                textBox1.BackColor = Color.White;
                button2.Text = "Continue";
                //button1.Enabled = false;
            }
            else
            {
                button2.Text = "Stop";
                timer1.Enabled = true;
                textBox1.BackColor = Color.White;
                //button1.Enabled = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox1.Text = "";
            textBox1.Enabled = true;
            timer1.Enabled = false;
            textBox1.BackColor = Color.White;
            button2.Text = "Stop";
            progressBar1.Maximum = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time <= 0)
            {
                button1.Enabled = true;
                button2.Text = "Stop";
                textBox1.Enabled = true;
                textBox1.Text = "0.00";
                textBox1.BackColor = Color.Green;
                progressBar1.Maximum = 0;
                timer1.Enabled = false;
                
                


            }
            else
            {
                time = (float)(time - 0.1);
                float timeMins = 0;
                timeMins = (float)(time / 60);
                int intTimeMins = (int)(timeMins);

                textBox1.Text = intTimeMins.ToString() + ":" + (time - ((int)(timeMins) * 60)).ToString("0.0");
                textBox1.Enabled = false;
                textBox1.ForeColor = Color.Black;

                progressBar1.PerformStep();


            }





        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            /*
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            */
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(193, 211, 254);
            label1.BackColor = Color.FromArgb(193, 211, 254);
            button1.BackColor = Color.FromArgb(215, 227, 252);
            button2.BackColor = Color.FromArgb(215, 227, 252);
            button3.BackColor = Color.FromArgb(215, 227, 252);

        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            this.BackColor = Color.Black;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 150, 199);
            label1.BackColor = Color.FromArgb(0, 150, 199);
            button1.BackColor = Color.FromArgb(72, 202, 228);
            button2.BackColor = Color.FromArgb(72, 202, 228);
            button3.BackColor = Color.FromArgb(72, 202, 228);
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(159, 160, 255);
            label1.BackColor = Color.FromArgb(159, 160, 255);
            button1.BackColor = Color.FromArgb(203, 178, 254);
            button2.BackColor = Color.FromArgb(203, 178, 254);
            button3.BackColor = Color.FromArgb(203, 178, 254);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                startTimer();
            }
        }
    }
}
