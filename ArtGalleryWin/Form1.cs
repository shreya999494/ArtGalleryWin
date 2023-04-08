using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGalleryWin
{
    public partial class Form1 : Form
    {
        Double count = 0;
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Username and Password is required");
            }
            else if(textBox1.Text == "CGS" && textBox2.Text == "admin")
            {
                
                        CGSArt cgsArt = new CGSArt();
                        cgsArt.Visible = true;
                        cgsArt.Activate();
                    

            }
            else 
            {
                count = count + 1;
                double maxcount = 3;
                double remain;
                remain = maxcount - count;
                MessageBox.Show("Wrong Username Or Password" + "\t"+remain +""+"tries left");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                if(count==maxcount)
                {
                    MessageBox.Show("Max try exceeded");
                    Application.Exit();
                }


            }
            
                
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
