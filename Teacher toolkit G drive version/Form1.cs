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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (comboBox1.Text == "Timer/Stopwatch")
            {
                Form2 secondForm = new Form2();
                secondForm.Show();
            
            }
            */

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void studentPickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            launchStudentPicker();
            string fileName = @"\\sutcfps2.sutc.internal\studentpersonal$\18harringtonk\Documents\Y10\IT\Mr. Parr IT\FavoriteFeatures.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("studentPicker");
            }

        }



        private void quitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            launchTimer();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void launchStudentPicker()
        {
            StudentPicker formPicker = new StudentPicker();
            formPicker.Show();
        }
        private void launchTimer()
        {
            TimerForm timerForm = new TimerForm();
            timerForm.Show();
        }
        private void launchStopwatch()
        {
            StopwatchForm stopwatchForm = new StopwatchForm();
            stopwatchForm.Show();
            
        }


        private void addStudentPicker()
        {
            if (button1.Text == "button1")
            {
                button1.Text = "Student picker";
                button1.Visible = true;
            }
            else if (button2.Text == "button2")
            {
                button2.Text = "Student picker";
                button2.Visible = true;
            }
            else if (button3.Text == "button3")
            {
                button3.Text = "Student picker";
                button3.Visible = true;
            }

        }

        private void studentPickerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addStudentPicker();

        }
        private void addTimer()
        {
            if (button1.Text == "button1")
            {
                button1.Text = "Timer";
                button1.Visible = true;
            }
            else if (button2.Text == "button2")
            {
                button2.Text = "Timer";
                button2.Visible = true;
            }
            else if (button3.Text == "button3")
            {
                button3.Text = "Timer";
                button3.Visible = true;
            }

        }

        private void timerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addTimer();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "Student picker")
            {
                launchStudentPicker();
            }
            if (button1.Text == "Timer")
            {
                launchTimer();
            }
            if (button1.Text == "Stopwatch")
            {
                launchStopwatch();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Student picker")
            {
                launchStudentPicker();
            }
            if (button2.Text == "Timer")
            {
                launchTimer();
            }
            if (button2.Text == "Stopwatch")
            {
                launchStopwatch();
            }
        }

        private void stopwatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            launchStopwatch();
            string fileName = @"\\sutcfps2.sutc.internal\studentpersonal$\18harringtonk\Documents\Y10\IT\Mr. Parr IT\FavoriteFeatures.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("stopwatch");
            }
        }

        private void stopwatchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "button1")
            {
                button1.Text = "Stopwatch";
                button1.Visible = true;
            }
            else if (button2.Text == "button2")
            {
                button2.Text = "Stopwatch";
                button2.Visible = true;
            }
            else if (button3.Text == "button3")
            {
                button3.Text = "Stopwatch";
                button3.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Student picker")
            {
                launchStudentPicker();
            }
            if (button3.Text == "Timer")
            {
                launchTimer();
            }
            if (button3.Text == "Stopwatch")
            {
                launchStopwatch();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.White;


            string fileName = @"\\sutcfps2.sutc.internal\studentpersonal$\18harringtonk\Documents\Y10\IT\Mr. Parr IT\FavoriteFeatures.txt";
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string temp = reader.ReadLine();
                    if (temp == "Timer")
                    {
                        addTimer();
                    }
                    if (temp == "studentPicker")
                    {
                        addStudentPicker();

                    }
                    string temp2 = reader.ReadLine();
                    if (temp2 == "Timer")
                    {
                        addTimer();
                    }
                    if (temp2 == "studentPicker")
                    {
                        addStudentPicker();

                    }

                }
            }
            catch (Exception exp)
            {
                //temp
            }

        }

        private void addFavoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void diceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiceForm diceForm = new DiceForm();
            diceForm.Show();
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(159, 160, 255);
            label1.BackColor = Color.FromArgb(159, 160, 255);
            button1.BackColor = Color.FromArgb(203, 178, 254);
            button2.BackColor = Color.FromArgb(203, 178, 254);
            button3.BackColor = Color.FromArgb(203, 178, 254);

        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(193, 211, 254);
            label1.BackColor = Color.FromArgb(193, 211, 254);
            button1.BackColor = Color.FromArgb(215, 227, 252);
            button2.BackColor = Color.FromArgb(215, 227, 252);
            button3.BackColor = Color.FromArgb(215, 227, 252);

        }

        private void timerToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            launchTimer();
        }

        private void diceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DiceForm diceForm = new DiceForm();
            diceForm.Show();
        }

        private void stopwatchToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            launchStopwatch();
        }

        private void studentPickerToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            launchStudentPicker();
        }

        private void timerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            addTimer();
        }

        private void seatingPlanGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seatingPlanGenerator seatingGenerator = new seatingPlanGenerator();
            seatingGenerator.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seatingPlanGenerator seatingGenerator = new seatingPlanGenerator();
            seatingGenerator.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            launchTimer();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DiceForm diceForm = new DiceForm();
            diceForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            launchStopwatch();
        }
    }

    
    
}
