using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
List<string> wordList = new List<string>() { "COMPUTER", "AMBUSHES", "MOUNTAIN", "SURPRISE", "OBTAINED", "FLAVOURS", "TERMINAL", "UNIVERSE", "WORKSHOP", "REPUBLIC" };
Random generator = new Random();
namespace Hangman_Lite__Part_8_Project_
{

    public partial class Form1 : Form
    {
        
        string word = "_ _ _ _ _ _ _ _";
        string secretWord = wordList[generator.Next(10)];

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(pictureBox2);
            pictureBox2.Location = new Point(131, 58);
            pictureBox2.BackColor = Color.Transparent;
            
            
        }
        

        private void btnA_Click(object sender, EventArgs e)
        {
                     
        }

        private void btnB_Click(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {

        }

        private void btnD_Click(object sender, EventArgs e)
        {

        }

        private void btnE_Click(object sender, EventArgs e)
        {

        }

        private void btnG_Click(object sender, EventArgs e)
        {

        }

        private void btnH_Click(object sender, EventArgs e)
        {

        }

        private void btnI_Click(object sender, EventArgs e)
        {

        }

        private void btnJ_Click(object sender, EventArgs e)
        {

        }

        private void btnK_Click(object sender, EventArgs e)
        {

        }

        private void btnL_Click(object sender, EventArgs e)
        {

        }

        private void btnM_Click(object sender, EventArgs e)
        {

        }

        private void btnN_Click(object sender, EventArgs e)
        {

        }

        private void btnO_Click(object sender, EventArgs e)
        {

        }

        private void btnP_Click(object sender, EventArgs e)
        {

        }

        private void btnQ_Click(object sender, EventArgs e)
        {

        }

        private void btnR_Click(object sender, EventArgs e)
        {

        }

        private void btnS_Click(object sender, EventArgs e)
        {

        }

        private void btnT_Click(object sender, EventArgs e)
        {

        }

        private void btnV_Click(object sender, EventArgs e)
        {

        }

        private void btnW_Click(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {

        }

        private void btnY_Click(object sender, EventArgs e)
        {

        }

        private void btnZ_Click(object sender, EventArgs e)
        {

        }
    }
}
