using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S219
{
    class Empleado
    {
        public string nombre;
        public string apellido;
        public decimal sueldo;
        public int edad;

        public void imprimirEmpleado()
        {
            Console.WriteLine("Información del Empleado");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Sieldo: " + sueldo);
            Console.WriteLine("Edad: " + edad);
            

            Console.WriteLine("Ingrese Descuentos: ");
            decimal desc = decimal.Parse(Console.ReadLine());
            decimal sNeto = SalarioNeto(desc);
            Console.WriteLine("Decuentos: " + desc);

            if (sNeto < 500)
            {
                Console.WriteLine("aplica para Bono: " + (sNeto * 0.1m));
                Console.ReadLine();
            }
        }

        public decimal SalarioNeto(decimal descuentos)
        {
            return (sueldo - descuentos);
        }
    }
}
