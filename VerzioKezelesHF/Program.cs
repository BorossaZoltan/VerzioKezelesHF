using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bekertSzamok = new int[10];
            Console.WriteLine("Adjon meg 10 számot!");
            for (int i = 0; i < bekertSzamok.Length; i++)
            {
                Console.Write("{0}. szám: ", i + 1);
                bekertSzamok[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("A bekért számok átlaga: " + bekertSzamok.Average());
            Console.ReadKey();
        }
    }
}
