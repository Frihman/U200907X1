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
            IDictionary<string, int> wordCount = new Dictionary<string, int>();

            List<string> list = new List<string>(array);

            Console.WriteLine(words.Length);

            foreach (string chara in list.ToList())
            {
                var target = chara;
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

            foreach (KeyValuePair<string, int> entry in wordCount)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
