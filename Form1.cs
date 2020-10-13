using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hangman_Lite__Part_8_Project_
{

    public partial class Form1 : Form
    {

        public List<string> wordList = new List<string>() {"COMPUTER", "AMBUSHES", "MAGNETIC", "SURPRISE", "OBTAINED", "FLAVOURS", "TERMINAL", "UNIVERSE", "WORKSHIP", "REPUBLIC" };
        Random generator = new Random();
        string secretWord;
        string word;
        int index;
        int panelOrder;
        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetGame();
        }

        public void ResetGame()
        {
            secretWord = wordList[generator.Next(10)];           
            word = "_ _ _ _ _ _ _ _";
            lblWord.Text = word;
            guessCounter.Text = "Guesses Left: 3";
            btnReplay.Visible = false;
            pnlMan1.Visible = true;
            pnlMan2.Visible = true;
            pnlMan3.Visible = true;
            panelOrder = 0;
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
            btnE.Visible = true;
            btnF.Visible = true;
            btnG.Visible = true;
            btnH.Visible = true;
            btnI.Visible = true;
            btnJ.Visible = true;
            btnK.Visible = true;
            btnL.Visible = true;
            btnM.Visible = true;
            btnN.Visible = true;
            btnO.Visible = true;
            btnP.Visible = true;
            btnQ.Visible = true;
            btnR.Visible = true;
            btnS.Visible = true;
            btnT.Visible = true;
            btnU.Visible = true;
            btnV.Visible = true;
            btnW.Visible = true;
            btnX.Visible = true;
            btnY.Visible = true;
            btnZ.Visible = true;
        }

        public void ReplaceLetter(string letter)
        {
            if (secretWord.Contains(letter))
            {
                index = secretWord.IndexOf(letter) * 2;
                word = word.Remove(index, 1);
                word = word.Insert(index, letter);
                index = secretWord.LastIndexOf(letter) * 2;
                word = word.Remove(index, 1);
                word = word.Insert(index, letter);
                lblWord.Text = word;
                if (!word.Contains("_"))
                {
                    guessCounter.Text = "You finished the word!";
                    btnReplay.Visible = true;
                }
                
            }

            else if (!secretWord.Contains(letter))
            {
                panelOrder += 1;

                if (panelOrder == 1)
                {
                    pnlMan1.Visible = false;
                    guessCounter.Text = "Guesses Left: 2";
                }
                else if (panelOrder == 2)
                {
                    pnlMan2.Visible = false;
                    guessCounter.Text = "Guesses Left: 1";
                }
                else if (panelOrder == 3)
                {
                    pnlMan3.Visible = false;
                    guessCounter.Text = "Game's Over, Click Try Again to Retry";
                    btnReplay.Visible = true;
                }
            }                      
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Visible = false;
            ReplaceLetter("A");               
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnB.Visible = false;
            ReplaceLetter("B");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.Visible = false;
            ReplaceLetter("C");
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.Visible = false;
            ReplaceLetter("D");
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            btnE.Visible = false;
            ReplaceLetter("E");
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            btnF.Visible = false;
            ReplaceLetter("F");
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            btnG.Visible = false;
            ReplaceLetter("G");
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            btnH.Visible = false;
            ReplaceLetter("H");
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            btnI.Visible = false;
            ReplaceLetter("I");
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            btnJ.Visible = false;
            ReplaceLetter("J");
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            btnK.Visible = false;
            ReplaceLetter("K");
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            btnL.Visible = false;
            ReplaceLetter("L");
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            btnM.Visible = false;
            ReplaceLetter("M");
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            btnN.Visible = false;
            ReplaceLetter("N");
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            btnO.Visible = false;
            ReplaceLetter("O");
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            btnP.Visible = false;
            ReplaceLetter("P");
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            btnQ.Visible = false;
            ReplaceLetter("Q");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            btnR.Visible = false;
            ReplaceLetter("R");
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            btnS.Visible = false;
            ReplaceLetter("S");
        }
       
        private void btnT_Click(object sender, EventArgs e)
        {
            btnT.Visible = false;
            ReplaceLetter("T");
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            btnU.Visible = false;
            ReplaceLetter("U");
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            btnV.Visible = false;
            ReplaceLetter("V");
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            btnW.Visible = false;
            ReplaceLetter("W");
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            btnX.Visible = false;
            ReplaceLetter("X");
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            btnY.Visible = false;
            ReplaceLetter("Y");
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            btnA.Visible = false;
            ReplaceLetter("Z");
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

    }
}
