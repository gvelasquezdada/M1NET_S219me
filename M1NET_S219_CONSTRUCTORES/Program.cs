using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S219_CONSTRUCTORES
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante est = new Estudiante();
            Estudiante est2 = new Estudiante("Julio", "Perez", 7.8f); // Para el constructor
            est.nombre = "Gilberto";
            est.apellido = "Velasquez";
            est.cum = 8.5f;
            Estudiante est3 = new Estudiante // Para poder ver todos los atributos publicos de la clase.
            {
                nombre = "maria",
                apellido = "Lopez",
                cum = 8.5f

            };
            Console.WriteLine(est.nombre + " " + est.apellido);
            Console.WriteLine(est.cum);
            Console.WriteLine(est.cuotaMensual);

            Console.WriteLine(est2.nombre + " " + est2.apellido);
            Console.WriteLine(est2.cum);
            Console.WriteLine(est2.cuotaMensual);

            Console.ReadLine();
        }
    }
}
