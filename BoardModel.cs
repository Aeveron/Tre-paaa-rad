
using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Tre_på_rad
{
    class BoardModel
    {
        public readonly Random _Random;
        public char[] Ruter { get; set; }
        //public char[] Row { get; set; }
        //public char[] Column { get; set; }

        public BoardModel()
        {
            Ruter = new char[9];
            for (int i = 0; i < Ruter.Length; i++)
            {
                Ruter[i] = ' ';
            }

        }
       
        public void SetCross(string position)
        {       
            //var rowArray = Row;           
            //var columnArray = Column;
            

            var p = position[0];
            var n = position[1];
            if ((p == 'a' || p == 'b' || p == 'c') && (n == '1' || n == '2' || n == '3'))
            {
               
                Console.WriteLine();
                Console.WriteLine("RIKTIG INPUT");
            }
            else Console.WriteLine("DU TOK FEIL");
        }

        public void SetRandomCircle()
        {

        }
    }
}
