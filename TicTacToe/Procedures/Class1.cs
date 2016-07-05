using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe;

namespace Procedures
{
    public class Class1
    {
        //Creation of grid 3x3
        int[] row1 = new int[] { 1, 2, 3};
        int[] row2 = new int[] { 4, 5, 6};
        int[] row3 = new int[] { 7, 8, 9 };      
       
        //Creation of player 1
        public string Players(int player1, int player2)
        {
            int numberEnteredByPlayer1 = player1;
             

            while(player1 != player2)
            {
                if(player1 > 0 && player1 <= 3)
                {
                    return numberEnteredByPlayer1.ToString();
                }
                else if (player1 > 3 && player1 >= 6)
                {
                    return numberEnteredByPlayer1.ToString();
                }
                else if (player1 > 6 && player1 <= 9)
                {
                    return numberEnteredByPlayer1.ToString();
                }

               

            }
            return numberEnteredByPlayer1.ToString();
            



        }
        //Creation of player 2
        public void Player2(int number)
        {
            const string secondplayer = "X";

            while (number <= grid.Length)
            {
                if(number 

                {

                }
            }

        }

        public void WinninMoves()
        {
            int[] winningmove1 = new int[] { 1, 2, 3 };
            int[] winningmove2 = new int[] { 4, 5, 6 };
            int[] winningmove3 = new int[] { 7, 8, 9 };
            int[] winningmove4 = new int[] { 1, 4, 7 };
            int[] winningmove5 = new int[] { 2, 5, 8 };
            int[] winningmove6 = new int[] { 3, 6, 9 };
            int[] winningmove7 = new int[] { 1, 5, 9 };
            int[] winningmove8 = new int[] { 7, 5, 3 };
                      

        }

    }
}
