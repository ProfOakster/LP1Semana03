using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter nº of lines:");
            int lines=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter nº of columns:");
            int columns=int.Parse(Console.ReadLine());

            float[,] matrix= new float [lines,columns];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter value for position [{i+1},{j+1}]:");
                    matrix[i, j] = float.Parse(Console.ReadLine());
                }
            }

            float line_sum = 0f;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    line_sum += matrix[i, j];
                }
                Console.WriteLine($"Sum of line nº{i+1} is {line_sum}");
                line_sum = 0f;
            }

            float column_sum = 0f;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    column_sum += matrix[i, j];
                }
                Console.WriteLine($"Sum of column nº{j + 1} is {column_sum}");
                column_sum = 0;
            }
        }   
    }
}
