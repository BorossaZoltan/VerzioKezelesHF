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
            int hanySzamLegyen;
            Console.Write("Adja meg hány számot szeretne megadni!");
            hanySzamLegyen = int.Parse(Console.ReadLine());
            int[] bekertSzamok = new int[hanySzamLegyen];
            for (int i = 0; i < bekertSzamok.Length; i++)
            {
                Console.Write("{0}. szám: ", i + 1);
                bekertSzamok[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A bekért számok átlaga: " + bekertSzamok.Average());
            Console.Write("Legnagyobb érték: "+bekertSzamok.Max()+"\n Minimum érték: "+ bekertSzamok.Min());
            Console.ReadKey();
        }
    }
}
