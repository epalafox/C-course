using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {

            //var a = int.Parse(Console.ReadLine());
            //var b = int.Parse(Console.ReadLine());
            //Sumar sumar = new Sumar(a, b);
            //var c = sumar.Suma();
            //Console.WriteLine(c);
            //Console.ReadLine();
            /*
            var a = CicloFor.Iniciar();
            foreach(var x in a)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
            CicloWhile cicloWhile = new CicloWhile();
            cicloWhile.cicloDoWhile();
            Console.ReadLine();
            Cadenas cadenas = new Cadenas();
            cadenas.trabajarConCadenas();
            Console.ReadLine();*/
            /*Console.WriteLine("¿Cuántos números deseas ver?");
            var f = int.Parse(Console.ReadLine());
            for(int i = 0; i < f; i++)
            {
                Console.Write(Fibonacci.funcion(i) + ", ");
            }
            Console.WriteLine("Introduce el número");
            var numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la potencia");
            var potencia = int.Parse(Console.ReadLine());
            Console.WriteLine(Potencia.Pow(numero, potencia));*/
            Console.WriteLine("Introduce el número");
            var numero = int.Parse(Console.ReadLine());
            Mod.mod(numero);
            Console.ReadLine();
        }
    }
}
