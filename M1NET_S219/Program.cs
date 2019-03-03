using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S219
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            Console.WriteLine("Ingrese Nombre: ");
            empleado.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Apellido: ");
            empleado.apellido = Console.ReadLine();
            Console.WriteLine("Ingrese Sueldo: ");
            empleado.sueldo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Edad: ");
            empleado.edad = int.Parse(Console.ReadLine());
                                          
            empleado.imprimirEmpleado();
       
        }
    }
}
