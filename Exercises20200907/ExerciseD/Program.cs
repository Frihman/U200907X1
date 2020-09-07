using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening");
            char[] delimiterChars = { ' ', ',', ':', '?', '"' };

            string text = Console.ReadLine();

            char[] array = text.ToCharArray();
            IDictionary<char, int> wordCount = new Dictionary<char, int>();

            List<char> list = new List<char>(array);

            Console.WriteLine(array.Length);

            foreach (char ch in list.ToList())
            {
                var target = ch;
                int count = 0;

                if (wordCount.ContainsKey(target))
                {
                    count = wordCount[target];
                }

                list.RemoveAt(0);
                bool exists = list.Contains(target);

                if (count == 0)
                {
                    count += 1;
                }

                if (exists)
                {
                    count += 1;
                }

                wordCount[target] = count;


            }

            foreach (KeyValuePair<char, int> entry in wordCount)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
