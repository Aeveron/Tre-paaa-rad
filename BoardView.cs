
using System;
using System.Security.Cryptography.X509Certificates;

namespace Tre_på_rad
{
     class BoardView
    {
        
        public static void Show(CellModel[] ruter)
        {

           
            Console.WriteLine("  a b c\r\n " +
                               "┌─────┐\r\n" +
                              "1|" + FindChar(ruter[0]) + " " + FindChar(ruter[1]) + " " + FindChar(ruter[2]) + "│\r\n" + 
                              "2│" + FindChar(ruter[3]) + " " + FindChar(ruter[4]) + " " + FindChar(ruter[5]) + "│\r\n" + 
                              "3│" + FindChar(ruter[6]) + " " + FindChar(ruter[7]) + " " + FindChar(ruter[8]) + "│\r\n" +
                              " └─────┘");            
        }

        private static char FindChar(CellModel cellModel)
        {
            if (cellModel.IsEmpty()) return ' ';
            return cellModel.IsPlayer1() ? 'x' : 'o';
        }


        //public static char GetMoves(BoardModel board, int i)
        //{
        //    var ruteMoves = board.ruter[i];
        //    return ' ';

        //}
    }
}
