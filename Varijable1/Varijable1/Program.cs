using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varijable1
{
    class Program
    {
        static void Main(string[] args)
        {
            float ProsjekOcjena = 0;
            for (int Ocjena = 1, i = 1; Ocjena != 0; i++)
            {
                Console.Write("Upisite ocjenu:");
                Ocjena = Convert.ToInt32(Console.ReadLine());
                if (Ocjena <= 5 && Ocjena >= 0)
                {
                    if (Ocjena == 0)
                    {
                        Console.Write("Prosjek ocjena:" + ProsjekOcjena / (i-1));
                    }
                    else ProsjekOcjena += Ocjena;
                }
                else
                {
                    Console.WriteLine("Krivi unos!");
                    i--;
                }
            }
            Console.ReadKey();
        }
    }
}
