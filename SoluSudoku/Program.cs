using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoluSudoku
{
    class Table
    {
        
        public Table()
        {
            int[,] Values = new int[9, 9];
        }
        public int[,] Values { get; set; }

        private string PrintTable()
        {
            string result = "Hola";
            Console.Write(this.Values.Rank);
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    Values[i, j] = 0;
                }
            }
            return result;
        }
        public override string ToString()
        {
            return this.PrintTable();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Table tablero = new Table();
            Console.Clear();
            Console.Write(tablero);
        }

    }
}
