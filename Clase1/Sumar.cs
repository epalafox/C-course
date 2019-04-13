using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    public class Sumar
    {
        private int a;
        private int b;
        public Sumar(int _a, int _b)
        {
            a = _a;
            b = _b;
        }
        /// <summary>
        /// Suma sin parametros
        /// </summary>
        public int Suma()
        {
            return a + b;
        }
        /// <summary>
        /// Suma con parametros
        /// </summary>
        /// <param name="_a">parametro 1</param>
        /// <param name="_b">parametro 2</param>
        public int Suma(int _a, int _b)
        {
            return _a + _b;
        }
    }
}
