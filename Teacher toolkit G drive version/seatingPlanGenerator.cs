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
using System.Runtime.InteropServices;

namespace Teacher_toolkit_G_drive_version
{
    public partial class seatingPlanGenerator : Form
    {
        public seatingPlanGenerator()
        {
            InitializeComponent();
        }
        public static string colourScheme;
        int pointer = 0;
        int numOfSeats = 0;
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
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }

                        listBox1.Items.Add(line);

                    }

                }

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void randomise()
        {
            listBox2.Items.Clear();
            Random rnd = new Random();
            pointer = 0;
            while (listBox1.Items.Count != listBox2.Items.Count)
            {
                int rnum = rnd.Next(0, listBox1.Items.Count);
                if (listBox2.Items.Contains(listBox1.Items[rnum]))
                {
                    //Do nothing
                }
                else
                {
                    listBox2.Items.Add(listBox1.Items[rnum]);
                }
            }
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                pointer++;

                listBox2.Items[i] = pointer + " - " + listBox2.Items[i];

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            randomise();
        }

        private void seatingPlanGenerator_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            button1.BackColor = Color.FromArgb(215, 227, 252); 
            this.StartPosition = FormStartPosition.CenterScreen;

            if (Form1.colourScheme == "Purple")
            {
                this.BackColor = Color.FromArgb(159, 160, 255);
                label1.BackColor = Color.FromArgb(159, 160, 255);
                button1.BackColor = Color.FromArgb(203, 178, 254);
                button2.BackColor = Color.FromArgb(203, 178, 254);

            }
            if (Form1.colourScheme == "Blue")
            {
                this.BackColor = Color.FromArgb(0, 150, 199);
                label1.BackColor = Color.FromArgb(0, 150, 199);
                button1.BackColor = Color.FromArgb(72, 202, 228);
                button2.BackColor = Color.FromArgb(72, 202, 228);

            }
            if (Form1.colourScheme == "Defualt")
            {
                this.BackColor = Color.FromArgb(193, 211, 254);
                label1.BackColor = Color.FromArgb(193, 211, 254);
                button1.BackColor = Color.FromArgb(215, 227, 252);
                button2.BackColor = Color.FromArgb(215, 227, 252);

            }
            if (Form1.colourScheme == "Black")
            {
                this.BackColor = Color.Black;
                label1.BackColor = Color.Black;
                label1.ForeColor = Color.White;
                button1.BackColor = Color.Black;
                
                button1.ForeColor = Color.White;
                button2.BackColor = Color.Black;
                button2.ForeColor = Color.White;

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void defualtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(193, 211, 254);
            label1.BackColor = Color.FromArgb(193, 211, 254);
            button1.BackColor = Color.FromArgb(215, 227, 252);
            label1.BackColor = Color.FromArgb(193, 211, 254);
            button1.BackColor = Color.FromArgb(215, 227, 252);
            label1.ForeColor = Color.Black;
            button1.ForeColor = Color.Black;

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(159, 160, 255);
            label1.BackColor = Color.FromArgb(159, 160, 255);
            button1.BackColor = Color.FromArgb(203, 178, 254);
            button1.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;


        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 150, 199);
            label1.BackColor = Color.FromArgb(0, 150, 199);
            button1.BackColor = Color.FromArgb(72, 202, 228);
            label1.BackColor = Color.FromArgb(0, 150, 199);
            button1.BackColor = Color.FromArgb(72, 202, 228);
            label1.ForeColor = Color.Black;
            button1.ForeColor = Color.Black;


        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                randomise();
            }   
        }

        private void seatingPlanGenerator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                randomise();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            randomise();
        }

        private void importClassListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }

                        listBox1.Items.Add(line);

                    }

                }

            }
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            button1.BackColor = Color.Black;

            button1.ForeColor = Color.White;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";

            }
            else
            {
                MessageBox.Show("Please enter a name to be added", "error");
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
