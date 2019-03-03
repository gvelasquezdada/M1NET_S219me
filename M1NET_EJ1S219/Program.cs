using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_EJ1S219
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreAsalariado = "", nombreEventual = "", nombrePorServicio = "";
            double salarioAsalariado = 0d, salarioEventual = 0d;
            double renta = 0d, valHora = 0d;
            int numHora = 0;
            Console.WriteLine("Ingrese información de empleado asalariado ");
            Console.Write("Nombre: ");
            nombreAsalariado = Console.ReadLine();
            Console.Write("Digite salario ($): ");
            salarioAsalariado = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite Renta ($): ");
            renta = Convert.ToDouble(Console.ReadLine());
            EmpleadoAsalariado ea = new EmpleadoAsalariado(nombreAsalariado, salarioAsalariado, renta);
            Console.WriteLine(ea.nombre + " tiene un salario de: $" + ea.salario);
            Console.ReadLine();

            Console.WriteLine("************************************************************");
            Console.WriteLine("Ingrese información de empleado eventual ");
            Console.Write("Nombre: ");
            nombreEventual = Console.ReadLine();
            Console.Write("Digite salario ($): ");
            salarioEventual = Convert.ToDouble(Console.ReadLine());
            EmpleadoEventual ee = new EmpleadoEventual(nombreEventual, salarioEventual);
            Console.WriteLine(ee.nombre + " tiene un salario de: $" + ee.salario);
            Console.ReadLine();

            Console.WriteLine("************************************************************");
            Console.WriteLine("Ingrese información de empleado por servicio ");
            Console.Write("Nombre: ");
            nombrePorServicio = Console.ReadLine();
            Console.Write("Ingrese número de horas trabajadas: ");
            numHora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese valor de hora ($): ");
            valHora = Convert.ToDouble(Console.ReadLine());
            EmpleadoPorServicio eps = new EmpleadoPorServicio(nombrePorServicio, numHora, valHora);
            Console.WriteLine(eps.nombre + " tiene un salario de: $" + eps.salario);
            Console.Read();

        }
    }
}
