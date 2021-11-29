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
    public partial class DiceForm : Form
    {
        public DiceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int lowerBound = int.Parse(textBox3.Text);
                int upperBound = int.Parse(textBox1.Text);

                Random newrandom = new Random();
                int randomNum = newrandom.Next(lowerBound, upperBound+1);
                textBox2.Text = randomNum.ToString();

            }
            catch
            {
                MessageBox.Show("Please enter an integer (whole number)");
            
            }
            

        }

        private void DiceForm_Load(object sender, EventArgs e)
        {

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
    }
}
