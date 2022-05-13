using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();
            //your code goes here
            int num;
            int x = 0;

            for (num = 0; num <= words.Length - 1; num++)
            {
                if (words[num].Contains(letter))
                {
                    Console.WriteLine(words[num]);
                    x++;

                }

            }
            if (x == 0)
            {
                Console.WriteLine("No match");

            }

        }
    }
}
