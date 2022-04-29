using System;
using System.Text;

namespace SoluSudoku
{
    class Table
    {
        private int[,] values = new int[9, 9];
        public int[,] Values { get; set; }
        public Table()
        {
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    values[i,j] = 0;
                }
            }
            Values = values;
        }
        public void fillTable()
        {
            int value;
            int[] coord = new int[2];
            do
            {
                Console.WriteLine("Ingrese el valor");
                value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la fila");
                coord[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la columna");
                coord[1] = Convert.ToInt32(Console.ReadLine());
                values[coord[0], coord[1]] = value;
                Console.Clear();
                Console.WriteLine("¿Desea ingresar otro valor? S/N");
            } while (Console.ReadLine() == "s");

        }
        public string PrintTable()
        {
            var s = new StringBuilder();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    s.Append(this.values[i,j]).Append(' ');
                }
            s.AppendLine();
            }
            return s.ToString();
        }
        public override string ToString()
        {
            return this.PrintTable();
        }

    }
    class TablePossibilities
    {
        private int[,,] values = new int[9, 9, 10];
        public int[,,] Values { get; set; }

        public TablePossibilities(Table fixedTable)
        {
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    values[i,j,0] = fixedTable.Values[i,j];
                    for(int k = 1; k < 10; k++)
                    {
                        values[i,j,k] = k;
                    }
                }
            }
            Values = values;

        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            for(int i = 0; i < 10; i++)
            {
                s.Append(Values[0,0,i]);
            }
            return s.ToString();
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Table tablero = new Table();
            TablePossibilities pruebas = new TablePossibilities(tablero);
            //tablero.fillTable();
            Console.WriteLine(pruebas);
            Console.Write(tablero);
            Console.Read();
        }

    }
}