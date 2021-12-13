using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_toolkit_G_drive_version
{
    public partial class DiceForm : Form
    {
        int count = 0;
        public DiceForm()
        {
            InitializeComponent();
        }
        [DllImport("user32")]
        private static extern bool ReleaseCapture();

        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 161, 2, 0);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(label4.Text);

                Random newrandom = new Random();

                int randomNum = newrandom.Next(0, number + 1);
                label5.Text = randomNum.ToString("00");


            }
            catch
            {
                MessageBox.Show("Please enter an integer (whole number)");

            }


        }

        private void DiceForm_Load(object sender, EventArgs e)
        {
            label4.Text = "";
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            if (Form1.colourScheme == "Purple")
            {
                this.BackColor = Color.FromArgb(159, 160, 255);
                label1.BackColor = Color.FromArgb(159, 160, 255);
                button1.BackColor = Color.FromArgb(203, 178, 254);
                
            }
            if (Form1.colourScheme == "Blue")
            {
                this.BackColor = Color.FromArgb(0, 150, 199);
                label1.BackColor = Color.FromArgb(0, 150, 199);
                button1.BackColor = Color.FromArgb(72, 202, 228);
                
            }
            if (Form1.colourScheme == "Defualt")
            {
                this.BackColor = Color.FromArgb(193, 211, 254);
                label1.BackColor = Color.FromArgb(193, 211, 254);
                button1.BackColor = Color.FromArgb(215, 227, 252);
                
            }
            if (Form1.colourScheme == "Black")
            {
                this.BackColor = Color.Black;
                label1.BackColor = Color.Black;
                label1.ForeColor = Color.White;
                button1.BackColor = Color.Black;
                
                button1.ForeColor = Color.White;
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void defualtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            

            this.BackColor = Color.FromArgb(193, 211, 254);
            label1.BackColor = Color.FromArgb(193, 211, 254);
            
            button1.BackColor = Color.FromArgb(215, 227, 252);
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            

            this.BackColor = Color.FromArgb(159, 160, 255);
            label1.BackColor = Color.FromArgb(159, 160, 255);
            
            button1.BackColor = Color.FromArgb(203, 178, 254);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            

            this.BackColor = Color.FromArgb(0, 150, 199);
            label1.BackColor = Color.FromArgb(0, 150, 199);
            
            button1.BackColor = Color.FromArgb(72, 202, 228);
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            button1.BackColor = Color.Black;
            
            button1.ForeColor = Color.White;
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar1.Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if(count < 50)
            {
                
                label5.BackColor = Color.Green;
                timer1.Enabled = false;
            }
           

        }
    }
}
