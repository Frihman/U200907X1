using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseE
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            List<string> words = new List<string>();

            while (running)
            {
                Console.WriteLine("Mata in ett ord. Skriv 'AVSLUTA' for att fullborda inmatningen");
                string input = Console.ReadLine();
                if (input == "AVSLUTA")
                {
                    running = false;
                    break;

                } else
                {
                    words.Add(input);
                }
                
            }

            foreach (string word in words)
            {
                Console.Write(word + " ");
            }

            Console.WriteLine("");
        }
    }
}
