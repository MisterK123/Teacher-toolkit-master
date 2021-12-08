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
    public partial class StopwatchForm : Form
    {
        public StopwatchForm()
        {
            InitializeComponent();
        }
        float time = 0;
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

        private void StopwatchForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Text = "stop";
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                button2.Text = "Continue";
            }
            else
            {
                timer1.Enabled = true;
                button2.Text = "Stop";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button2.Text = "Stop";
            time = 0;
            textBox1.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time += 0.1f;
            textBox1.Text = time.ToString("0.0");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void defualtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(193, 211, 254);
            label1.BackColor = Color.FromArgb(193, 211, 254);
            button1.BackColor = Color.FromArgb(215, 227, 252);
            button2.BackColor = Color.FromArgb(215, 227, 252);
            button3.BackColor = Color.FromArgb(215, 227, 252);
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.BackColor = Color.FromArgb(159, 160, 255);
            label1.BackColor = Color.FromArgb(159, 160, 255);
            button1.BackColor = Color.FromArgb(203, 178, 254);
            button2.BackColor = Color.FromArgb(203, 178, 254);
            button3.BackColor = Color.FromArgb(203, 178, 254);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 150, 199);
            label1.BackColor = Color.FromArgb(0, 150, 199);
            button1.BackColor = Color.FromArgb(72, 202, 228);
            button2.BackColor = Color.FromArgb(72, 202, 228);
            button3.BackColor = Color.FromArgb(72, 202, 228);
        }
    }
}
