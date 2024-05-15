using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_7.src
{
    public class Matrix : MatrixName
    {
        private int[][] data;

        public int rows = 0;
        public int columns = 0;

        // Ми копіюємо значення, не посилання у цьому конструкторі
        public Matrix(string name, int[][] data) : base(name)
        {
            rows = data.Length;
            columns = data[0].Length;

            this.data = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                this.data[i] = new int[columns];

                for (int j = 0; j < columns; j++)
                {
                    this.data[i][j] = data[i][j];
                }
            }
        }

        public Matrix(string name, int initElement, int rows, int columns) : base(name)
        {
            this.rows = rows;
            this.columns = columns;

            data = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                data[i] = new int[columns];

                for (int j = 0; j < columns; j++)
                {
                    data[i][j] = initElement;
                }
            }
        }

        public int this[int r, int c]
        {
            get => data[r][c];
        }


        public void PrintMatrix()
        {
            string format = "{0,4}";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++) 
                {
                    Console.Write(string.Format(format, data[i][j]));
                }

                Console.WriteLine();
            }
        }
    }
}
