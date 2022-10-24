// Jared L. Abrams// CST-150// October 23, 2022// This is my own work

namespace _ABRAMS__CST_150_Activity_13__2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            // Reset Game
            resultsBox.Text = "";

            //Initialize the 2D array.
            int[,] myArray = new int[3, 3];

            // Random numbers generator to randomly assign values to a 2D array.
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    myArray[i,j] = random.Next(0,2);
                }
            }

            // Display Xs and Os on board. If the arrays value is a 1 then mark and X. Otherwise, mark O.
            // Button 1
            if (myArray[0, 0] == 1)
            {
                button1.Text = "X";
            }
            else
            {
                button1.Text = "O";
            }
            // Button 2
            if (myArray[0, 1] == 1)
            {
                button2.Text = "X";
            }
            else
            {
                button2.Text = "O";
            }
            // Button 3
            if (myArray[0, 2] == 1)
            {
                button3.Text = "X";
            }
            else
            {
                button3.Text = "O";
            }
            // Button 4
            if (myArray[1, 0] == 1)
            {
                button4.Text = "X";
            }
            else
            {
                button4.Text = "O";
            }
            // Button 5
            if (myArray[1, 1] == 1)
            {
                button5.Text = "X";
            }
            else
            {
                button5.Text = "O";
            }
            // Button 6
            if (myArray[1, 2] == 1)
            {
                button6.Text = "X";
            }
            else
            {
                button6.Text = "O";
            }
            // Button 7
            if (myArray[2, 0] == 1)
            {
                button7.Text = "X";
            }
            else
            {
                button7.Text = "O";
            }
            // Button 8
            if (myArray[2, 1] == 1)
            {
                button8.Text = "X";
            }
            else
            {
                button8.Text = "O";
            }
            // Button 9
            if (myArray[2, 2] == 1)
            {
                button9.Text = "X";
            }
            else
            {
                button9.Text = "O";
            }

            // Check game state.
            // Check for winner.

            // Check Rows
            // Row 1
            if (myArray[0,0] == myArray[0,1] && myArray[0,1] == myArray[0,2])
            {
                if (myArray[0,0] == 1)
                {
                    resultsBox.Text = "Player X wins";
                }
                else
                {
                    resultsBox.Text = "Player O wins";
                }
            }

            // Row 2
            if (myArray[1, 0] == myArray[1, 1] && myArray[1, 1] == myArray[1, 2])
            {
                if (myArray[1, 0] == 1)
                {
                    resultsBox.Text = "Player X wins";
                }
                else
                {
                    resultsBox.Text = "Player O wins";
                }
            }

            // Row 3
            if (myArray[2, 0] == myArray[2, 1] && myArray[2, 1] == myArray[2, 2])
            {
                if (myArray[2, 0] == 1)
                {
                    resultsBox.Text = "Player X wins";
                }
                else
                {
                    resultsBox.Text = "Player O wins";
                }
            }

            // Check Columns
            // Column 1
            if (myArray[0, 0] == myArray[1, 0] && myArray[1, 0] == myArray[2, 0])
            {
                if (myArray[0, 0] == 1)
                {
                    resultsBox.Text = "Player X wins";
                }
                else
                {
                    resultsBox.Text = "Player O wins";
                }
            }

            // Column 2
            if (myArray[0, 1] == myArray[1, 1] && myArray[1, 1] == myArray[2, 1])
            {
                if (myArray[0, 1] == 1)
                {
                    resultsBox.Text = "Player X wins";
                }
                else
                {
                    resultsBox.Text = "Player O wins";
                }
            }

            // Column 3
            if (myArray[0, 2] == myArray[1, 2] && myArray[1, 2] == myArray[2, 2])
            {
                if (myArray[0, 2] == 1)
                {
                    resultsBox.Text = "Player X wins";
                }
                else
                {
                    resultsBox.Text = "Player O wins";
                }
            }

            // Check Diagonals
            // Check Diagonal Left-To-Right
            if (myArray[0, 0] == myArray[1, 1] && myArray[1, 1] == myArray[2, 2])
            {
                if (myArray[0, 0] == 1)
                {
                    resultsBox.Text = "Player X wins";
                }
                else
                {
                    resultsBox.Text = "Player O wins";
                }
            }

            // Check Diagonal Right-To-Left
            if (myArray[0, 2] == myArray[1, 1] && myArray[1, 1] == myArray[2, 0])
            {
                if (myArray[0, 2] == 1)
                {
                    resultsBox.Text = "Player X wins";
                }
                else
                {
                    resultsBox.Text = "Player O wins";
                }
            }

            // If no winners are found then the game is a tie.
            if (resultsBox.Text == "")
            {
                resultsBox.Text = "Tied";
            }

            resultsBox.TextAlign = HorizontalAlignment.Center;

        }
    }
}