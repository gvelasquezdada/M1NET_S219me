using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_EJ3S219
{
    class Program
    {
        static void Main(string[] args)
        {
            Vivienda casa = new Vivienda();
            Console.WriteLine("Ingrese datos de vivienda ");
            Console.Write("Familia: ");
            casa.Familia = Console.ReadLine();
            Console.Write("Poligono: ");
            casa.poligono = Console.ReadLine();
            Console.Write("Número de casa: ");
            casa.numeroCasa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pago Mensual ($): ");
            casa.pagoMensualCasa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Pago Vigilancia ($): ");
            casa.pagoVigilancia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Datos Familia " + casa.Familia + ":");
            casa.pagoTotal();
            Console.ReadKey();
        }
    }
}
