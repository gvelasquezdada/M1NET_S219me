using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S219_ENCAPSULACION
{
    class Program
    {
        static void Main(string[] args)
        {
            automovil a = new automovil();
            a.marca = "Toyota";
            a.modelo = "Yaris";
            a.Capacidad = 4;
            // a.Anyo = 2019;

            Console.WriteLine(a.modelo);
            Console.WriteLine(a.Anyo);
        }
    }

    class automovil
    {
        public string marca;
        public string modelo;
        public int Capacidad { get; set; }
        private int anyo;


        public int Anyo
        {
            get { return 2019; }
           
        }


    }
}
