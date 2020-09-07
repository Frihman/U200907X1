using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseG
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<char, string> leet = new Dictionary<char, string>();

            leet['a'] = "4";
            leet['b'] = "8";
            leet['c'] = "(";
            leet['d'] = "|)";
            leet['e'] = "3";
            leet['f'] = "|=";
            leet['g'] = "9";
            leet['h'] = "|-|";
            leet['i'] = "|";
            leet['j'] = "_|";
            leet['k'] = "|<";
            leet['l'] = "1";
            leet['m'] = "|'|'|";
            leet['n'] = "N";
            leet['o'] = "0";
            leet['p'] = "|D";
            leet['q'] = "(,)";
            leet['r'] = "|2";
            leet['s'] = "5";
            leet['t'] = "7";
            leet['u'] = "|_|";
            leet['v'] = "|/";
            leet['w'] = "W";
            leet['x'] = "><";
            leet['y'] = "j";
            leet['z'] = "2";
            leet[' '] = " ";

            Console.WriteLine("Skriv in en mening");
            string text = Console.ReadLine();

            char[] chars = text.ToCharArray();

            foreach (char ch in chars) {
                Console.Write(leet[ch]);
            }

            Console.WriteLine();
        }
    }
}
