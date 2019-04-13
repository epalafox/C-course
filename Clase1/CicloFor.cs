using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    public class CicloFor
    {
        public static int[] Iniciar()
        {
            int[] a = new int[10];
            for(int i = 0; i < 10; i++)
            {
                a[i] = i + 1;
            }
            return a;
        }
    }
}
