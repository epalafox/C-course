using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    public class Potencia
    {
        public static int Pow(int numero, int potencia)
        {
            if (potencia != 1)
                return numero * Pow(numero, potencia - 1);
            else
                return numero;
        }
    }
}
