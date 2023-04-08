using CGS;
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
    public partial class Form2 : Form
    {

        
        public Form2()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gallery gal = new Gallery();
            string artPieceID = textBox1.Text;
            double piecePrice= Convert.ToDouble(textBox2.Text);
            bool var = gal.SellPiece(artPieceID, piecePrice);
            if(var == true)
            { MessageBox.Show("The Artpiece was sold"); }
            else { MessageBox.Show("The Artpiece could not be sold"); }
            this.Close();
        }
    }
}
