using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_EJ2S219
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A("Clase_A", 1);
            A b = new A("Clase_B", 2);
            A c = b;
            b = a;
            a = new A("ClaseC", 3);
            c = a;
            Console.WriteLine(c.atributoA1 + c.atributoA2);
            Console.WriteLine(b.atributoA1 + b.atributoA2);
            Console.ReadKey();
        }
    }
}
