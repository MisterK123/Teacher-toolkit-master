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
    public partial class seatingPlanGenerator : Form
    {
        public seatingPlanGenerator()
        {
            InitializeComponent();
        }
        int pointer = 0;
        int numOfSeats = 0;
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
            try
            {
                numOfSeats = int.Parse(textBox1.Text);
                if (numOfSeats > 2 && numOfSeats < 50)
                {
                    label2.Text = "Number of seats in class: " + numOfSeats;
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Please enter a resonable number", "potential error");
                }
                
            }
            catch
            {
                MessageBox.Show("please input an integer", "error");
            }
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Random rnd = new Random();
            pointer = 0;
            while (listBox1.Items.Count != listBox2.Items.Count)
            {
                int rnum = rnd.Next(0, listBox1.Items.Count);
                if (listBox2.Items.Contains(listBox1.Items[rnum]))
                {
                    Console.WriteLine(listBox1.Items[rnum]);
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
                
                
               
                //string temp = listBox1.Items.Count
            
            
            

        }

        private void seatingPlanGenerator_Load(object sender, EventArgs e)
        {

        }
    }
}
