using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticticfinal
{
    public partial class Form1 : Form
    {


        private int click = 0;
        private String value;

        public void clickUser()
        {
            if (click % 2 == 0)
            {
                value = "0";
                // MessageBox.Show("User1's turn");
               


            }
            else
            {
                value = "1";
                //   MessageBox.Show("User2's turn");
                
            }
            
            click++;
          

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clickUser();
            button6.Text = value;
            button6.Enabled = false;
            Win();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickUser();
            button1.Text = value;
            button1.Enabled = false;
            Win();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clickUser();
            button2.Text = value;
            button2.Enabled = false;
            Win();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clickUser();
            button3.Text = value;
            button3.Enabled = false;
            Win();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clickUser();
            button4.Text = value;
            button4.Enabled = false;
            Win();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clickUser();
            button5.Text = value;
            button5.Enabled = false;
            Win();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clickUser();
            button7.Text = value;
            button7.Enabled = false;
            Win();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clickUser();
            button8.Text = value;
            button8.Enabled = false;
            Win();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clickUser();
            button9.Text = value;
            button9.Enabled = false;
            Win();

        }

        public void Win()
        {
            if (button1.Text == "0" && button2.Text == "0" && button3.Text == "0")
            {
                MessageBox.Show("User1 win");
                Application.Restart();
            }
            else if (button4.Text == "0" && button5.Text == "0" && button6.Text == "0")
            {
                MessageBox.Show("User1 win");
                Application.Restart();
            }
            else if (button7.Text == "0" && button8.Text == "0" && button9.Text == "0")
            {
                MessageBox.Show("User1 win");
                Application.Restart();
            }
            else if (button1.Text == "0" && button5.Text == "0" && button9.Text == "0")
            {
                MessageBox.Show("User1 win");
                Application.Restart();

            }
            else if (button3.Text == "0" && button5.Text == "0" && button7.Text == "0")
            {
                MessageBox.Show("User1 win");
                Application.Restart();
            }
            else if (button1.Text == "0" && button4.Text == "0" && button7.Text == "0")
            {
                MessageBox.Show("User1 win");
                Application.Restart();
            }
            else if (button2.Text == "0" && button8.Text == "0" && button5.Text == "0")
            {
                MessageBox.Show("User1 win");
                Application.Restart();
            }
            else if (button3.Text == "0" && button6.Text == "0" && button9.Text == "0")
            {
                MessageBox.Show("User1 win");
                Application.Restart();
            }

            if (button1.Text == "1" && button2.Text == "1" && button3.Text == "1")
            {
                MessageBox.Show("User2 win");
                Application.Restart();
            }
            else if (button4.Text == "1" && button5.Text == "1" && button6.Text == "1")
            {
                MessageBox.Show("User2 win");
                Application.Restart();
            } 

            else if (button7.Text == "1" && button8.Text == "1" && button9.Text == "1")
            {
                MessageBox.Show("User2 win");
                Application.Restart(); 



            }
            else if (button1.Text == "1" && button5.Text == "1" && button9.Text == "1")
            {
                MessageBox.Show("User2 win");
                Application.Restart();

            }
            else if (button3.Text == "1" && button5.Text == "1" && button7.Text == "1")
            {
                MessageBox.Show("User2 win");
                Application.Restart();

            }
            else if (button1.Text == "1" && button4.Text == "1" && button7.Text == "1")
            {
                MessageBox.Show("User2 win");
                Application.Restart();

            }
            else if (button2.Text == "1" && button8.Text == "1" && button5.Text == "1")
            {
                MessageBox.Show("User2 win");
                Application.Restart();

            }
            else if (button3.Text == "1" && button6.Text == "1" && button9.Text == "1")
            {
                MessageBox.Show("User2 win");
                Application.Restart();


            }
            if (click == 9) {
                    MessageBox.Show("Draw!!!!");
                Application.Restart();

            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

