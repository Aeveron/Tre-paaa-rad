
using System;
using System.Security.Cryptography.X509Certificates;

namespace Tre_på_rad
{
     class BoardView
    {
        
        public static void Show(char[] ruter)
        {
           
            Console.WriteLine("  a b c\r\n " +
                               "┌─────┐\r\n" +
                              "1|" + ruter[0] + " " + ruter[1] + " " + ruter[2] + "│\r\n" + 
                              "2│" + ruter[3] + " " + ruter[4] + " " + ruter[5] + "│\r\n" + 
                              "3│" + ruter[6] + " " + ruter[7] + " " + ruter[8] + "│\r\n" +
                              " └─────┘");
            
        }

        
        //public static char GetMoves(BoardModel board, int i)
        //{
        //    var ruteMoves = board.ruter[i];
        //    return ' ';

        //}
    }
}
