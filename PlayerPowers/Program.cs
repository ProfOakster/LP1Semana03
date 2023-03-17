using System;
namespace PlayerPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input nº of players:");
            int n = int.Parse(Console.ReadLine());

            Powers [] CharsPower = new Powers[n];

            string input;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Select player {i+1}'s powers: [Y/N]");
                for (int p = 0; p < 3; p++)
                {
                    Console.WriteLine((Powers)(1 << p));
                    input = Console.ReadLine();
                    if (input.ToLower()=="y")
                    {
                        CharsPower[i] ^= (Powers)(1 << p);
                    };
                }
            }

            for (int c = 0; c < n; c++)
            {
                Console.WriteLine($"Player {c+1}'s powers:");
                Console.WriteLine(CharsPower[c]);
                if ((CharsPower[c] & (Powers)5)==(Powers)5)
                {
                   Console.WriteLine("Flying radiation!"); 
                }

            }
        }
    }
}
