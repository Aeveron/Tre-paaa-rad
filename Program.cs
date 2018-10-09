
using System;
using System.Threading;

namespace Tre_på_rad
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardModel = new BoardModel();
            while (true)
            {
                
                BoardView.Show(boardModel.Ruter);
                Console.Write("Skriv inn hvor du vil sette kryss (f.eks. \"a2\"): ");
                var position = Console.ReadLine();
                boardModel.SetCross(position);
                Thread.Sleep(700);
                //boardModel.SetRandomCircle();
                var success = boardModel.SetRandomCircle();
                if (!success) return;
            }
        }
    }
}
