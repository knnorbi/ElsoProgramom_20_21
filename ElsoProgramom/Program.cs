using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoProgramom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Deklaráció
            int a;
            a = 5;
            Console.WriteLine(a);

            int b = 7;
            Console.WriteLine(b);

            int c = 3 * a + (a * b);
            Console.WriteLine(c);

            Console.WriteLine("Mikor születtél?");
            string beolvasott = Console.ReadLine();
            Console.WriteLine("Ezt írtad be: " + beolvasott);
            int beolvasottSzamkent = int.Parse(beolvasott);
            int eves = 2020 - beolvasottSzamkent;
            Console.WriteLine(eves + " éves vagy.");


            Console.ReadKey();
        }
    }
}
