using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    public class CicloWhile
    {
        public void cicloWhile()
        {
            Console.WriteLine("Ingresa un número, 0 para terminar");
            var a = int.Parse(Console.ReadLine());
            var b = 0;
            while (a != 0)
            {
                b += a;
                Console.WriteLine("Ingresa un número, 0 para terminar");
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(b);
        }
        public void cicloDoWhile()
        {
            var b = 0;
            int a = 0;
            do
            {
                b += a;
                Console.WriteLine("Ingresa un número, 0 para terminar");
                a = int.Parse(Console.ReadLine());
            } while (a != 0);
            Console.WriteLine(b);
        }
    }
}
