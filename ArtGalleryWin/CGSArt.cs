using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGS;

namespace ArtGalleryWin
{
    public partial class CGSArt : Form
    {
        
        
       Gallery gal = new Gallery();
        
        public CGSArt()
        {
            InitializeComponent();
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexchanged;

        }
        //char status;

        /*private void SelectedTab(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab==tabPage1) { statusBar1.Panels[0].Text = "Artists"; }
        }*/
        private void tabControl1_SelectedIndexchanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    statusBar1.Text = "Curators";
                    // Do nothing here (let's suppose that TabPage index 0 is the address information which is already loaded.
                    break;
                case 1:
                    statusBar1.Text = "Artists";
                    // Let's suppose TabPage index 1 is the one for the transactions.
                    // Assuming you have put a DataGridView control so that the transactions can be listed.
                    // currentCustomer.Id can be obtained through the CurrencyManager of your BindingSource object used to data bind your data to your Windows form controls.
                    //dataGridview1.DataSource = GetTransactions(currentCustomer.Id);
                    break;
                case 2:
                    statusBar1.Text = "ArtPiece";
                    break;
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Artists";
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "Artists";
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = "ArtPieces";
        }
       
        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            string curatorID = textBox3.Text;
            string fName = textBox1.Text;
            string lName = textBox2.Text;
            Random rand = new Random();
            int commission = rand.Next(100, 500);
            gal.AddCurator(fName, lName, curatorID);
            MessageBox.Show("Curator Added");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Curator Saved");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = gal.ListCurators();
            
            ListViewItem item = new ListViewItem(str);
            item.SubItems.Add(str);
            lvdata.Items.Add(item);
            
         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string fName = textBox6.Text;
            string lName = textBox5.Text;
            string artistID = textBox4.Text;
            gal.AddArtist(fName, lName, artistID);
            MessageBox.Show("Artist Added");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str1 = gal.ListArtists();
            ListViewItem item1 = new ListViewItem(str1);
            item1.SubItems.Add(str1);
            lvdata.Items.Add(item1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            char status='D';
            string artPieceID = textBox8.Text;
            string pieceTitle = textBox9.Text;
            string pieceYear = textBox10.Text;
            double pieceValue = Convert.ToDouble(textBox11.Text);
            string artistID = textBox12.Text;
            string curatorID = textBox7.Text;
            if (radioButton1.Checked) { status = 'D'; }
            if (radioButton2.Checked) { status = 'S'; }
            gal.AddPiece(artPieceID, pieceTitle, pieceYear, pieceValue, artistID, curatorID , status);
            MessageBox.Show("Artpiece Added");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Visible = true;
            f2.Activate();
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //status = 'S';
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //status = 'D';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string str2 = gal.ListPieces();
            ListViewItem item2 = new ListViewItem(str2);
            item2.SubItems.Add(str2);
            lvdata.Items.Add(item2);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
