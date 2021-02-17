using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string word = "(((((((((((((())))))";
            int bracketCount = 0;
            foreach(char h in word)
            {
                if(h.ToString() == "(")
                {
                    bracketCount += 1;
                } else if(h.ToString() == ")")
                {
                    bracketCount -= 1;
                }
            }

            if (bracketCount < 0)
            {
                Console.WriteLine("Error: need to return a positive integer");
            }
            else
            {
                Console.WriteLine("Bracket Count: " + bracketCount);
                
            }
        }
    }
}
