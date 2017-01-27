using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tio_bra_ovningar
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Yassin Oummadi & Anton Nordin 27 Januari 2017*/
            int summa = 0;
            for (int i = 0; i < 1000; i++)
            {
                if(i % 5 == 0 || i % 3 == 0)
                {
                    summa = summa + i;
                }
            }
            Console.WriteLine("Summan av alla tal under 1000 som är delbara med 3 och/eller 5 är: " + summa);
        }
    }
}
