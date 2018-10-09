using System;
using System.Collections.Generic;

namespace Tre_på_rad
{
    class BoardModel
    {
        private Random _random;
        public CellModel[] Ruter { get; set; }

        public BoardModel()
        {
            Ruter = new CellModel[9];
            for (int i = 0; i < Ruter.Length; i++)
            {
                Ruter[i] = new CellModel();
            }

            _random = new Random();
        }

        public void SetCross(string position)
        {
            var colChar = position[0];
            var rowChar = position[1];
            //var colIndex = 
            //    colChar == 'a' ? 0 : 
            //    colChar == 'b' ? 1 : 
            //    colChar == 'c' ? 2 : -1;
            var colIndex = colChar - 'a';
            var rowIndex = rowChar - '1';
            var cellIndex = colIndex + rowIndex * 3;
            Ruter[cellIndex].Mark(true);
        }

        //public void SetRandomCircleASDF(string position)
        //{
        //    var colChar = position[0];
        //    var rowChar = position[1];            
        //    var colIndex = colChar - 'a';
        //    var rowIndex = rowChar - '1';
        //    var cellIndex = colIndex + rowIndex * 3;

        //    Ruter[cellIndex].Mark(false);

        //    var randomCellIndex = _random.Next(cellIndex);

        //    if ()
        //    {
        //        Console.WriteLine('o');
        //    }

        //    Console.WriteLine(randomCellIndex);
        //}

        public bool SetRandomCircle()
        {
            var availableIndexes = new List<int>();
            for (int i = 0; i < Ruter.Length; i++)
            {
                if (Ruter[i].IsEmpty()) availableIndexes.Add(i);
            }

            if (availableIndexes.Count == 0) return false;
            var randomAvailableIndex = _random.Next(0, availableIndexes.Count);
            var index = availableIndexes[randomAvailableIndex];
            Ruter[index].Mark(false);
            return true;
        }
    }
}
