using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    public class Cadenas
    {
        public void trabajarConCadenas()
        {
            var hello = "Hola Mundo";
            char[] arreglo = hello.ToArray();
            Console.WriteLine(arreglo);
            string invertida = "";
            //foreach(var a in arreglo)
            //{
            //    invertida = a + invertida;
            //}
            for(int a = arreglo.Length; a > 0; a--)
            {
                invertida = invertida + arreglo[a - 1];
            }
            Console.WriteLine(invertida);
        }
    }
}
