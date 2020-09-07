using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening");
            char[] delimiterChars = { ' ', ',', ':' };

            string text = Console.ReadLine();

            string[] words = text.Split(delimiterChars);
            IDictionary<string, int> wordCount = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                bool exists = false;
                var target = words[i];
                int count = 0;
                wordCount[target] = count;

                words = words.Where(w => w != words[i]).ToArray();
                exists = words.Contains(target);

                
                while (exists)
                {
                    words = words.Where(w => w != words[i]).ToArray();
                    exists = words.Contains(target);
                    count += 1;
                }

                count += 1;
                wordCount[target] = count;

            }

            foreach(KeyValuePair<string, int> entry in wordCount)
            {
                Console.WriteLine(entry);
            }

           
        }
    }
}
