using Lab_7.src;

namespace Lab_7
{
    public class Program
    {
        private static string inputPath = "input.txt";
        private static string outputPath = "output.txt";
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(
                "All purpose matrix",
                ReadMatrixFromFile(inputPath)
            );

            matrix.PrintName();
            matrix.PrintMatrix();

            Solver solver = new Solver(matrix, outputPath);

            solver.Solve_N_Minus_2();
            solver.Solve_N_Minus_1();
            solver.Solve_N();
            solver.Solve_N_Plus_1();
            solver.Solve_N_Plus_2();
        }

        public static int[][] ReadMatrixFromFile(string path)
        {
            List<int[]> matrix = new List<int[]>();

            string[] lines = File.ReadAllLines(path);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] lineElements = lines[i].Split(' ');

                matrix.Add(new int[lineElements.Length]);

                for (int j = 0; j < lineElements.Length; j++)
                {
                    matrix[i][j] = int.Parse(lineElements[j]);
                }
            }

            return matrix.ToArray();
        }
    }
}
