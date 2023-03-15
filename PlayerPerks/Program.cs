using System;

namespace PlayerPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input WASD combination:");
            string wasd = Console.ReadLine();

            Perks PlayerPerks=Perks.None;
            
            foreach (char c in wasd)
            {
                if (c == Convert.ToChar("w"))
                    PlayerPerks ^= Perks.WaterBreathing;

                else if (c == Convert.ToChar("a"))
                    PlayerPerks ^= Perks.AutoHeal;

                else if (c == Convert.ToChar("s"))
                    PlayerPerks ^= Perks.Stealth;

                else if (c == Convert.ToChar("d"))
                    PlayerPerks ^= Perks.DoubleJump;

                else
                {
                    Console.WriteLine("Unknown perk!");
                    return;
                }
                
            }
            if (PlayerPerks==Perks.None)
                Console.WriteLine("No perks at all!");
            else    
                Console.WriteLine(PlayerPerks);

            if ((PlayerPerks&(Perks)12)==(Perks)12)
                Console.WriteLine("Silent jumper!");
            if ((PlayerPerks&Perks.AutoHeal)!=Perks.AutoHeal)
                Console.WriteLine("Not gonna make it!");
        }
    }
}
