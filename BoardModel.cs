using System;

namespace Tre_på_rad
{
    class BoardModel
    {
        public readonly Random _Random;
        public CellModel[] Ruter { get; set; }

        public BoardModel()
        {
            Ruter = new CellModel[9];
            for (int i = 0; i < Ruter.Length; i++)
            {
                Ruter[i] = new CellModel();
            }
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

        public void SetRandomCircle()
        {

        }
    }
}
