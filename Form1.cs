using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SankeAndLaderForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class MoveStatus
        {
            public string Text { get; set; }
            public int Number { get; set; }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btn_Roll_Click(object sender, EventArgs e)
        {
            int player1Pos = 0, player2Pos = 0;
            string player1Moves = txtPlyerDiceNo1.Text;
            string player2Moves = txtPlyerDiceNo2.Text;
            string Ply1Status = string.Empty;
            string Ply2Status = string.Empty;

            if (IsValidInput(player1Moves.ToCharArray()) && IsValidInput(player1Moves.ToCharArray()))
            {

                //snakes
                Dictionary<int, int> snakes = new Dictionary<int, int>
            {
                {32,10 },{36,6},{48,26},{63,18},{88,24},{95,56},{97,78}
            };

                // Ladders
                Dictionary<int, int> ladders = new Dictionary<int, int>
            {
                {1,38 },{4,14},{8,10},{28,76},{21,42},{50,68},{71,92},{80,99}
            };
                bool gameWon = false;

                Queue<int> p1Queue = new Queue<int>(Array.ConvertAll(player1Moves.ToCharArray(), c => c - '0'));
                Queue<int> p2Queue = new Queue<int>(Array.ConvertAll(player2Moves.ToCharArray(), c => c - '0'));


                while (!gameWon && (p1Queue.Count > 0 || p2Queue.Count > 0))
                {
                    MoveStatus objdata = new MoveStatus();

                    if (p1Queue.Count > 0)
                    {
                        int roll = p1Queue.Dequeue();
                        objdata = MovePlayer(player1Pos, roll, snakes, ladders);
                        player1Pos = objdata.Number;
                        //Console.WriteLine("Player 1: " + objdata.Text + $" is at position {player1Pos}");
                        Ply1Status = objdata.Text + $" Is at position {player1Pos}";
                        if (player1Pos >= 100)
                        {
                            Ply1Status = "Player wins!";
                            gameWon = true;
                            break;
                        }
                    }

                    if (p2Queue.Count > 0)
                    {
                        int roll = p2Queue.Dequeue();
                        objdata = MovePlayer(player2Pos, roll, snakes, ladders);
                        player2Pos = objdata.Number;
                        Ply2Status = objdata.Text + $" Is at position {player2Pos}";
                        if (player2Pos >= 100)
                        {
                            Ply2Status = "Player wins!";
                            gameWon = true;
                            break;
                        }
                    }
                }

                lblPlayer1.Text = Ply1Status;
                lblPlayer2.Text = Ply2Status;
            }

        }

        private void txtPlyerDiceNo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsValidInput(e.KeyChar.ToString().ToCharArray());
        }

        private void txtPlyerDiceNo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsValidInput(e.KeyChar.ToString().ToCharArray());

        }

         private bool IsValidInput(char[] EnterKey)
         {
            foreach (var KeyChar in EnterKey)
            { 

                if (!char.IsControl(KeyChar) && !char.IsDigit(KeyChar))
                {
                    MessageBox.Show("Only numbers (1-6) are allowed!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (!char.IsControl(KeyChar) && char.IsDigit(KeyChar))
                {
                    int value = Convert.ToInt16(KeyChar.ToString());
                    if (value < 1 || value > 6)
                    {
                        MessageBox.Show("Enter a number between 1 and 6!", "Invalid Dice Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

            }
            return true;
         }
        

        static MoveStatus MovePlayer(int position, int roll, Dictionary<int, int> snakes, Dictionary<int, int> ladders)
        {
            position += roll;
            string strMove = "";
            if (snakes.ContainsKey(position))
            {
                strMove = $" 🐍 Hit a snake at {position}, moving down to {snakes[position]} And";
                position = snakes[position];
            }
            else if (ladders.ContainsKey(position))
            {
                strMove = $"🚀 Hit a ladder at {position}, climbing up to {ladders[position]} And";
                position = ladders[position];
            }

            return new MoveStatus { Text = strMove, Number = position };
        }
    }
}

