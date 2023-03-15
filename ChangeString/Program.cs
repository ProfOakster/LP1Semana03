using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter phrase:");
            string message=Console.ReadLine();

            Console.WriteLine("Enter character to remove:");
            char remove=char.Parse(Console.ReadLine());

            string result = "";
            foreach (char c in message)
            {
                if (c != remove)
                {
                    result += c;
                }
            }
            Console.WriteLine(result);
        }
    }
}
