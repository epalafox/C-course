using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    public class Fibonacci
    {
        public static int funcion(int numero)
        {
            if (numero == 0 || numero == 1)
                return numero;
            else
                return funcion(numero - 1) + funcion(numero - 2);
        }
    }
}
