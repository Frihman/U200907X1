using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseF
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(1, 21);
            
            Console.WriteLine("Gissa numret mellan 1 och 21");

            bool running = true;
            
            while (running)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == number)
                {
                    Console.WriteLine("DU GISSADE RÄTT!!");
                    running = false;
                }
                else
                {
                    Console.WriteLine("Inte korrekt. Gissa igen");
                }
            }
            
        }
    }
}
