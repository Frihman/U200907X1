using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening");
            char[] delimiterChars = { ' ', ',', ':' };

            string text = Console.ReadLine();

            string[] words = text.Split(delimiterChars);

            foreach (var word in words)
            {
                Console.WriteLine(word + " (" + word.Length + ")");

            }
        }
    }
}
