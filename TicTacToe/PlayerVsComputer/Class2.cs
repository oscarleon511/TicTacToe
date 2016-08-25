using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlayerVsComputer
{
    public class Class2
    {
        string letter = string.Empty;
        string letterForComputer = string.Empty;
        int count = 0;
        //Give player the option to select "X" or "O"
        public void GetLetterToPlay()
        {
            Console.WriteLine("Which letter do you want to use in order to play TicTacToe?");
            string letterSelectedToPlay = Console.ReadLine();
            string lowerCase = letterSelectedToPlay.ToLower();
            if (lowerCase == "x" || lowerCase == "o")
            {

                letter = lowerCase;
                while (count < 9 && !CheckForWin(letter) && !CheckForWin(letterForComputer))
                {
                   
                    if (!PlayerOneMove() && CheckForWin(letter))
                    {
                        break;
                    }
                    else if (count == 5 && !CheckForWin(letter))
                    {
                        Console.WriteLine("There is a tie");
                        break;
                    }
                    if (SwapPlayer())
                    {
                        ComputerMove();
                    }


                }
            }
        }
        //player1 enters number from 1 to 9
        public bool PlayerOneMove()
        {
            bool comeback = true;

            Console.WriteLine("Please enter a number from 1 to 9");
            string numberEntered = Console.ReadLine();
            int number = 0;
            // condition2: Number cannot be an alpha character
            if(!int.TryParse(numberEntered, out number))
            {
                return PlayerOneMove();
            }
            // condition1:Number has to be from 1 to 9
            else if(number > 0 && number < 10 && isItSpotOpen(number))
            {
                                
                AssignNumberToAnArray(number, Player.One);
                count++;
                comeback = false;
                // when player one wins
                if (CheckForWin(letter))
                {
                    Console.WriteLine("Player has won the game");
                    return false;
                }
                
                
                
            }
            else
            {
                //if conditions above is not met, please show message
                Console.WriteLine("Please try again entering a number from 1 to 9");
                PlayerOneMove();
                comeback = true;
            }
            return comeback;

        }
        //Create an array that will contain the spots of the board 9 spots
        string[] board = new string [] {" ", " ", " ", " ", " ", " ", " ", " ", " "};
        // assigned number to matrix method
        public void AssignNumberToAnArray(int number,Player player)
        {
            
            //number entered by player is assigned to an array
            if(player == Player.One)
            {
                //Letter will always be assigned to player one
                board[number - 1] = letter ;
                Console.WriteLine("Player one has played letter -  {0} ", letter);
                Console.WriteLine("");
                
            }
                //LetterForComputer will always be assigned for computer
            else if(player == Player.Computer)
            {
               board[number - 1] = letterForComputer;
               Console.WriteLine("Computer has played letter -  {0}", letterForComputer);
               Console.WriteLine("");
               
            }

            DisplayBoard();
            
        }
        public void DisplayBoard()
        {
            Console.WriteLine("\n  [ {0} ] [ {1} ] [ {2} ]\n\n  [ {3} ] [ {4} ] [ {5} ]\n\n  [ {6} ] [ {7} ] [ {8} ]\n\n", board[0], board[1], board[2], board[3], board[4], board[5], board[6], board[7], board[8]);
        }
        public bool SwapPlayer()

        {
            bool changeplayer = false;
            if(letter == "x")
            {

                letterForComputer = "o";
                changeplayer = true;
            }
            else if (letter == "o")
            {
                letterForComputer = "x";
                changeplayer = true;
            }
            return changeplayer;
            
        }
        public void ComputerMove()
        {
            Random randomNum = new Random();  
       //Work on this when get home
            bool continueLookingForNumbers = true;
            do
            {
                int move = randomNum.Next(1, 9);
             bool itIsOpen = isItSpotOpen(move);
             if (itIsOpen)
             {
                 AssignNumberToAnArray(move, Player.Computer);
                 continueLookingForNumbers = false;
                 if (CheckForWin(letterForComputer))
                 {
                     Console.WriteLine("Computer has won the game");
                     break;

                 }
             }
             else
             {
                 continueLookingForNumbers = true;
             }
                

            } while (continueLookingForNumbers);

            
            
           
        }
        public bool isItSpotOpen(int spotToMove)
        {
            bool allowed;
            if (board[spotToMove - 1] == "x" || board[spotToMove - 1] == "o")
            {
                allowed = false;
            }
            else
            {
                allowed = true;
            }
            return allowed;
        }
        public bool CheckForWin( string moveDoneByPlayer)
        {
            bool winnerInGame = false; ;
            
           

            int[,] winners = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 }, { 1, 5, 9 }, { 3, 5, 7 } };
           

            for (int i = 0; i < winners.GetLength(0); i++)
            {
                
                    int a = winners[i, 0] -1;
                    int b = winners[i, 1] -1;
                    int c = winners[i, 2] -1;

                    if(moveDoneByPlayer == board[a] && moveDoneByPlayer == board[b] && moveDoneByPlayer== board[c])
                    {

                        winnerInGame = true;
                        
                    }
                    
                
            }
            return winnerInGame;
        }

        

         

       
     
        
       
        
        //check that spot where number assigned has not been taken yet
        //if it has been taken, ask player to enter number again
        //if not, let computer play
        //Computer enters a random number
        //condition1: number entered by computer cannot be the same as player one
        //condition2: play number that can be assigned to spot no taken
        //condition3: block any winning moves from player one

    }
}
