using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    public class Mod
    {
        public static void mod(int numero)
        {
            if(numero % 2 == 0)
            {
                Console.WriteLine("Es número par");
            }
            else
            {
                Console.WriteLine("Es número impar");
            }
        }
    }
}
