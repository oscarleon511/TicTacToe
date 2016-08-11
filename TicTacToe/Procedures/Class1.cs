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
       public void GetDisplay()
        {
            Console.WriteLine("This is the board game");
            Console.WriteLine();
            Console.WriteLine("1 2 3 \n4 5 6 \n7 8 9");
            Console.WriteLine();
            Console.WriteLine("Player one 'X', please enter a number from 1 to 9");
            int inputplayerone = int.Parse(Console.ReadLine());
            Console.WriteLine("Player two 'O', please enter a number from 1 to 9");
            int inputplayertwo = int.Parse(Console.ReadLine());
        }
    }
}
