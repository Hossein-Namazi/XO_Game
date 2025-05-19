using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stone_Paper_Scissors
{
    public partial class Form1 : Form
    {
        int Count = 0;
        int CountWin = 0;
        int b1 = 0;int b2 = 0;int b3 = 0;int b4 = 0;int b5 = 0;int b6 = 0;int b7 = 0; int b8 = 0; int b9 = 0;
        string[,] Board =
        {
            {"1","2","3"},
            {"4","5","6"},
            {"7","8","9"}
        };
        void PlayerWin()
        {
            if (Count % 2 == 0)
            {
                MessageBox.Show("Player O Win");
            }
            else
            {
                MessageBox.Show("Player X Win");
            }
        }
        void Win()
        {
            ++Count;
            for (CountWin = 0; CountWin < 3; ++CountWin)
            {
                if (Board[0, CountWin] == Board[1, CountWin] & Board[1, CountWin] == Board[2, CountWin]
                    | Board[CountWin, 0] == Board[CountWin, 1] & Board[CountWin, 1] == Board[CountWin, 2])
                {
                    PlayerWin();
                    this.Close();
                }
            }
            if (Board[0, 0] == Board[1, 1] & Board[1, 1] == Board[2, 2]
                    | Board[0, 2] == Board[1, 1] & Board[1, 1] == Board[2, 0])
            {
                PlayerWin();
                this.Close();
            }
            if (Count >= 9)
            {
                b1 = 0; b2 = 0; b3 = 0; b4 = 0; b5 = 0; b6 = 0; b7 = 0; b8 = 0; b9 = 0;
            };
        }       
        public Form1()
        {
            InitializeComponent();           
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (b7 == 1 | Count >= 9 & Board[0, 2] == "X" & Count % 2 == 0 | Count >= 9 & Board[0, 2] == "O" & Count % 2 != 0)
            {
                return;
            }
            b7 = 1;
            if (Count % 2 == 0)
            {
                button7.Text = "X";
                button7.ForeColor = Color.Red;
                Board[0, 2] = "X";
            }
            else
            {
                button7.Text = "O";
                button7.ForeColor = Color.Blue;
                Board[0, 2] = "O";
            }
            if (Count < 10)
            {
                
            }
            Win();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (b8 == 1 | Count >= 9 & Board[1, 2] == "X" & Count % 2 == 0 | Count >= 9 & Board[1, 2] == "O" & Count % 2 != 0)
            {
                return;
            }
            b8 = 1;
            if (Count % 2 == 0)
            {
                button8.Text = "X";
                button8.ForeColor = Color.Red;
                Board[1, 2] = "X";
            }
            else
            {
                button8.Text = "O";
                button8.ForeColor = Color.Blue;
                Board[1, 2] = "O";
            }
            if (Count < 10)
            {
               
            }
            Win();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (b9 == 1 | Count >= 9 & Board[2, 2] == "X" & Count % 2 == 0 | Count >= 9 & Board[2, 2] == "O" & Count % 2 != 0)
            {
                return;
            }
            b9 = 1;
            if (Count % 2 == 0)
            {
                button9.Text = "X";
                button9.ForeColor = Color.Red;
                Board[2, 2] = "X";
            }
            else if (Count % 2 != 0)
            {
                button9.Text = "O";
                button9.ForeColor = Color.Blue;
                Board[2, 2] = "O";
            }
            if (Count < 10)
            {
              
            }
            Win();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (b4 == 1 | Count >= 9 & Board[0, 1] == "X" & Count % 2 == 0 | Count >= 9 & Board[0, 1] == "O" & Count % 2 != 0)
            {
                return;
            }
            b4 = 1;
            if (Count % 2 == 0)
            {
                button4.Text = "X";
                button4.ForeColor = Color.Red;
                Board[0, 1] = "X";
            }
            else if (Count % 2 != 0)
            {
                button4.Text = "O";
                button4.ForeColor = Color.Blue;
                Board[0, 1] = "O";
            }
            if (Count < 10)
            {
            
            }
            Win();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (b5 == 1 | Count >= 9 & Board[1, 1] == "X" & Count % 2 == 0 | Count >= 9 & Board[1, 1] == "O" & Count % 2 != 0)
            {
                return;
            }
            b5 = 1;
            if (Count % 2 == 0)
            {
                button5.Text = "X";
                button5.ForeColor = Color.Red;
                Board[1, 1] = "X";
            }
            else
            {
                button5.Text = "O";
                button5.ForeColor = Color.Blue;
                Board[1, 1] = "O";
            }
            if (Count < 10)
            {
           
            }
            Win();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (b6 == 1 | Count >= 9 & Board[2, 1] == "X" & Count % 2 == 0 | Count >= 9 & Board[2, 1] == "O" & Count % 2 != 0)
            {
                return;
            }
            b6 = 1;
            if (Count % 2 == 0)
            {
                button6.Text = "X";
                button6.ForeColor = Color.Red;
                Board[2, 1] = "X";
            }
            else
            {
                button6.Text = "O";
                button6.ForeColor = Color.Blue;
                Board[2, 1] = "O";
            }
            if (Count < 10)
            {
            
            }
            Win();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (b3 == 1 | Count >= 9 & Board[2, 0] == "X" & Count % 2 == 0 | Count >= 9 & Board[2, 0] == "O" & Count % 2 != 0)
            {
                return;
            }
            b3 = 1;
            if (Count % 2 == 0)
            {
                button3.Text = "X";
                button3.ForeColor = Color.Red;
                Board[2, 0] = "X";
            }
            else
            {
                button3.Text = "O";
                button3.ForeColor = Color.Blue;
                Board[2, 0] = "O";
            }
            if (Count < 10)
            {
      
            }
            Win();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (b2 == 1 | Count >= 9 & Board[1, 0] == "X" & Count % 2 == 0 | Count >= 9 & Board[1, 0] == "O" & Count % 2 != 0)
            {
                return;
            }
            b2 = 1;
            if (Count % 2 == 0)
            {
                button2.Text = "X";
                button2.ForeColor = Color.Red;
                Board[1, 0] = "X";
            }
            else
            {
                button2.Text = "O";
                button2.ForeColor = Color.Blue;
                Board[1, 0] = "O";
            }
            if (Count < 10)
            {
       
            }
            Win();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (b1 == 1 | Count >= 9 & Board[0, 0] == "X" & Count % 2 == 0 | Count >= 9 & Board[0, 0] == "O" & Count % 2 != 0)
            {
                return;
            }
            b1 = 1;
            if (Count % 2 == 0)
            {
                button1.Text = "X";
                button1.ForeColor = Color.Red;
                Board[0, 0] = "X";
            }
            else if (Count % 2 != 0)
            {
                button1.Text = "O";
                button1.ForeColor = Color.Blue;
                Board[0, 0] = "O";
            }
            if (Count < 10)
            {
      
            }            
            Win();
        }
    }
}