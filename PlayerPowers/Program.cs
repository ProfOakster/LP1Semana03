using System;
namespace PlayerPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get player # from user and storing it in var n
            Console.WriteLine("Input nº of players:");
            int n = int.Parse(Console.ReadLine());

            //Array for each player's powers
            Powers [] CharsPower = new Powers[n];

            //Cycles through each player
            string input;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Select player {i+1}'s powers: [Y/N]");

                //Cycles through each power
                for (int p = 0; p < 3; p++)
                {
                    //Asks Y/N to each power
                    Console.WriteLine((Powers)(1 << p));
                    input = Console.ReadLine();

                    //If input is Y or y, adds that power to the player
                    if (input.ToLower()=="y")
                        CharsPower[i] ^= (Powers)(1 << p);
                }
            }

            //Cycles through each player
            for (int c = 0; c < n; c++)
            {
                //Prints each player's powers
                Console.WriteLine($"Player {c+1}'s powers:");
                Console.WriteLine(CharsPower[c]);
                //If player has Fly and SuperStrength, prints Flying radiation
                if ((CharsPower[c] & (Powers)5)==(Powers)5)
                {
                   Console.WriteLine("Flying radiation!"); 
                }

            }
        }
    }
}
