using System;

namespace Gestione
{
    public class DivisoriN
    {
        public static int LeggiN()
        {
            Console.Write("inserisci un numero intero: ");
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        public static void StampaDivN(int a)
        {
            int i = 1;
            int max = a / 2;

            while (i <= max)
            {
                if (a % i == 0)
                    Console.WriteLine(i);
                i++;
            }
            Console.WriteLine(a);
        }
    }
}
