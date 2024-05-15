using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7.src
{
    // Цей клас розв'язує проблеми (методи) для заданої матриці і пише результат у файл
    public class Solver
    {
        private Matrix matrix;
        private string resultsFilePath;

        public Solver(Matrix matrix, string resultsFilePath)
        {
            this.matrix = matrix;
            this.resultsFilePath = resultsFilePath;

            // Очищуємо файл для результатів для нового "солверу"
            File.WriteAllText(resultsFilePath, "");
        }

        private void SaveResultToFile(string result)
        {
            File.AppendAllText(this.resultsFilePath, result + '\n');
        }

        // Завдання #28 - К-ть негативних елементів нижче г/д матриці
        public void Solve_N_Minus_2()
        {
            if (matrix.rows != matrix.columns)
            {
                SaveResultToFile("Problem N - 2 error: Matrix isn't square");
                return;
            }

            int count = 0;

            // Починаємо одразу нижче г/д матриці
            for (int i = 1, j = 0; i < matrix.rows; i++)
            {
                // Поки за колонкою не дійшли до г/д...
                while (j < i)
                {
                    if (matrix[i, j] < 0)
                        count++;

                    j++;
                }

                j = 0;
            }

            SaveResultToFile("Problem N - 2 result: " + count);
        }

        // Завдання #29 - Сума позитивних елементів головної діагоналі матриці
        public void Solve_N_Minus_1()
        {
            if (matrix.rows != matrix.columns)
            {
                SaveResultToFile("Problem N - 1 error: Matrix isn't square");
                return;
            }

            int sum = 0;

            for (int i = 0; i < matrix.rows; i++)
            {
                if (matrix[i, i] > 0)
                    sum += matrix[i, i];
            }

            SaveResultToFile("Problem N - 1 result: " + sum);
        }

        // Завдання #30 - добуток від'ємних елементів головної діагоналі матриці
        public void Solve_N()
        {
            if (matrix.rows != matrix.columns) 
            {
                SaveResultToFile("Problem N error: Matrix isn't square");
                return;
            }

            int product = 1;

            for (int i = 0; i < matrix.rows; i++)
            {
                int element = matrix[i, i];

                if (element < 0)
                    product *= matrix[i, i];
            }

            SaveResultToFile("Problem N result: " +  product);
        }

        // Завдання #31 - максимальний елемент головної діагоналі матриці
        public void Solve_N_Plus_1()
        {
            if (matrix.rows != matrix.columns)
            {
                SaveResultToFile("Problem N + 1 error: Matrix isn't square");
                return;
            }

            int max = int.MinValue;

            for (int i = 0; i < matrix.rows; i++)
            {
                max = Math.Max(max, matrix[i, i]);
            }

            SaveResultToFile("Problem N + 1 result: " + max);
        }

        // Завдання #32 - мінімальний елемент головної діагоналі матриці
        public void Solve_N_Plus_2()
        {
            if (matrix.rows != matrix.columns)
            {
                SaveResultToFile("Problem N + 2 error: Matrix isn't square");
                return;
            }

            int min = int.MaxValue;

            for (int i = 0; i < matrix.rows; i++)
            {
                min = Math.Min(min, matrix[i, i]);
            }

            SaveResultToFile("Problem N + 2 result: " + min);
        }
    }
}
