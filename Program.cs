using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_i_iloczyn_liczb_pierwszych
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort i = 0, n, k, a;
            ulong iloczyn=1, suma=0;
            Console.WriteLine("Program oblicza sumę i iloczyn n liczb pierwszych naturalnych podzielnych przez k");
            Console.WriteLine("Podaj ilość powtórzeń:");
            n = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Podaj dzielnik:");
            k = Convert.ToUInt16(Console.ReadLine());
            a = k;
            while (i < n)
            {
                suma += a;
                checked
                {
                    iloczyn *= a;
                }
                a += k;
                i++;
                Console.WriteLine(a);
            }
            Console.WriteLine("Suma {0} liczb pierwszych podzielnych przez {1} wynosi {2}", n, k, suma);
            Console.WriteLine("Iloczyn {0} liczb pierwszych podzielnych przez {1} wynosi {2}", n, k, iloczyn);
            Console.ReadKey(true);

        }
    }
}
