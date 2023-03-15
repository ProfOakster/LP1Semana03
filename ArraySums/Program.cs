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
            Console.WriteLine(matrix);
        }
    }
}
