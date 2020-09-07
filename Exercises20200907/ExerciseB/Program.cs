using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening");
            char[] delimiterChars = { ' ', ',', ':' };

            string text = Console.ReadLine();

            string[] words = text.Split(delimiterChars);

            Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

            foreach (var word in words.Reverse())
            {
                Console.WriteLine(word + " (" + word.Length + ")");
                Console.WriteLine("");
            }

            foreach (var word in words)
            {
                Console.WriteLine(word + " (" + word.Length + ")");

            }
        }
    }
}
