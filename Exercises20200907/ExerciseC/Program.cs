using System;
using System.Collections.Generic;
using System.Data;
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

            List<string> list = new List<string>(words);

            Console.WriteLine(words.Length);


            

            foreach (string word in list.ToList())
            {
                var target = word;
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

                //while (exists)
                //{
                //    int a = Array.IndexOf(words, target);
                //    if (a >= 0)
                //    {
                //        words = words.Where(w => w != words[a]).ToArray();
                //        exists = words.Contains(target);
                //        count += 1;
                //    }
                //    
                //    
                //}

                
                
                    
                
                wordCount[target] = count;

               
            }

            foreach(KeyValuePair<string, int> entry in wordCount)
            {
                Console.WriteLine(entry);
            }

            

           
        }
    }
}
