using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S219_CONSTRUCTORES
{
    class A
    {
        string id;

    }
    class Instancias
    {
        static void Main(string[] args)
        {
            A objetoA = new A();
            A objetoB = new A();
            A objetoC = objetoA;
            objetoA = null;

            Console.WriteLine(objetoA);
            Console.WriteLine(objetoB);
            Console.WriteLine(objetoC);
            Console.ReadLine();

        }
    }
}
