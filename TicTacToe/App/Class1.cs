using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Class1
    {
        int count = 0;
        
        public void GetDisplay()
        {
            Console.WriteLine("This is the board game");
            Console.WriteLine();
            Console.WriteLine("1 2 3 \n4 5 6 \n7 8 9");
            Console.WriteLine();
            while (count < 9)
            {
                
                //if (the game is win for either player then exit)

                //Get value from Player One
               if(MoveForPlayer1()==false)
               {
                   break;
               }
               //if(game is a tie) then exit
               else if(count == 9 && CheckForWin("X")== false)
               {
                   Console.WriteLine("This is a tie");
                   return;
               }

                
                
                //Get value from Player two
                 bool makemove = true;
                do
                {
                    
                    Console.WriteLine("Player two 'O', please enter a number from 1 to 9");
                    string inputTwo = Console.ReadLine();
                    int inputplayertwo = 0;
                    if (!int.TryParse(inputTwo, out inputplayertwo))
                    {
                        makemove = true;
                    }
                    //Is this number is a valid input, value between 1 and 9?
                    else if (inputplayertwo > 0 && inputplayertwo < 10)
                    {

                        if (CheckForTaken(inputplayertwo) == false)
                        {
                            AssignedLetterToSpotOnMatrix(inputplayertwo, Player.Two);
                            makemove = false;
                            count++;
                            if (CheckForWin("O"))
                            {
                                Console.WriteLine("Player two wins");
                                return;
                               
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please try again!!!");
                            makemove = true;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Please try again!!!");
                    }
                
                } while (makemove);
                
                
            }
            

        }
        //Global array with a size of nine
        string[] numbersentered = new string [] {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
        
        //Spot on the matrix and assigning value to either player one or player two
            public void AssignedLetterToSpotOnMatrix(int spotOnMatrix, Player player)
            {

                string symbol = string.Empty;
              
                if(player == Player.One)
                {
                    symbol = "X";
                }
                else if (player == Player.Two)
                {
                    symbol = "O";
                }
                numbersentered [spotOnMatrix - 1] = symbol;
                DisplayedMatrix();
            }
           
              
        public void DisplayedMatrix()
        {


            Console.Write("  --- --- ---\n | {0} | {1} | {2} |\n  --- --- ---\n | {3} | {4} | {5} |\n  --- --- ---\n | {6} | {7} | {8} |\n  --- --- ---\n", numbersentered[0], numbersentered[1], numbersentered[2], numbersentered[3], numbersentered[4], numbersentered[5], numbersentered[6], numbersentered[7], numbersentered[8]);
                
                       
            
            }
        public bool CheckForWin(string player)
        {
            bool didwin = false;
            int [,] winning = new int[,] {{1,2,3}, {4,5,6}, {7,8,9},{1,4,7}, {2,5,8},{3,6,9}, {1,5,9}, {7,5,3}};
            for (int i = 0; i < 8; i++)
            {
                int a = winning[i,0] - 1;
                int b = winning[i,1] - 1;
                int c = winning[i,2] - 1;

                if(player == numbersentered[a] && player== numbersentered[b] && player == numbersentered[c])
                {
                    didwin = true;
                    
                }
                
            }
            return didwin;
            
            
        }
        public bool CheckForTaken(int placeTaken)
        {
            bool taken = true;
            if(numbersentered[placeTaken -1] == "X" || numbersentered[placeTaken -1] == "O")
            {
                return taken;
            }
            else
            {
                taken = false;
            }
            return taken;
        }
       public bool MoveForPlayer1()
        {
            bool comeback = true;
            Console.WriteLine("Player one 'X', please enter a number from 1 to 9");
            
            string inputone = Console.ReadLine();
           int inputPlayerOne = 0;
           if (!int.TryParse(inputone, out inputPlayerOne))
           {
               return MoveForPlayer1();
           }
            //Is this number is a valid input, value between 1 and 9?
             else if (inputPlayerOne > 0 && inputPlayerOne < 10)
            {
                if (CheckForTaken(inputPlayerOne) == false)
                {
                    AssignedLetterToSpotOnMatrix(inputPlayerOne, Player.One);
                    count++;
                   // while(CheckForWin("X"))
                    //{
                        if (CheckForWin("X"))
                        {
                            Console.WriteLine("Player one wins");
                            comeback = false;
                           
                         }
                        //The line below is the same thing as the following
                    //if(CheckForWin("X"))
                    //{
                    //Console.WriteLine("Player one wins");
                    //comeback = false;
                    //}
                    //else
                    //{
                    //comeback = false;
                     //}
                            
                             
                   
                    
                }
                else
                {
                    Console.WriteLine("Please try again!!!");
                    MoveForPlayer1();
                    comeback = true;
                }

            }
            else
            {
                Console.WriteLine("Please try again!!!");
                MoveForPlayer1();
                comeback = true;

            }
           return comeback;
         
        }

           
              
                      
        }
        
              
          
    }

