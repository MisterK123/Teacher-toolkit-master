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

namespace Teacher_toolkit_G_drive_version
{
    public partial class StudentPicker : Form
    {
        public StudentPicker()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter a students name to add.", "Error");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();


            if (listBox1.Items.Count > 0)
            {
                int studentVal = rnd.Next(0, listBox1.Items.Count);
                textBox2.Text = listBox1.Items[studentVal].ToString();
                if (checkBox1.Checked == true)
                {

                    listBox1.Items.RemoveAt(studentVal);

                }

            }
            else
            {
                MessageBox.Show("Please add students to the list.", "Error");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void quitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void reloadStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void importClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void importClassToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
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

        private void reloadStudentListToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(193, 211, 254);
            label1.BackColor = Color.FromArgb(193, 211, 254);
            button1.BackColor = Color.FromArgb(215, 227, 252);
            button2.BackColor = Color.FromArgb(215, 227, 252);
            checkBox1.BackColor = Color.FromArgb(215, 227, 252);
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(159, 160, 255);
            label1.BackColor = Color.FromArgb(159, 160, 255);
            button1.BackColor = Color.FromArgb(203, 178, 254);
            button2.BackColor = Color.FromArgb(203, 178, 254);
            checkBox1.BackColor = Color.FromArgb(203, 178, 254);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 150, 199);
            label1.BackColor = Color.FromArgb(0, 150, 199);
            button1.BackColor = Color.FromArgb(72, 202, 228);
            button2.BackColor = Color.FromArgb(72, 202, 228);
            checkBox1.BackColor = Color.FromArgb(72, 202, 228);

        }

        private void StudentPicker_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
