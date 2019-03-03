using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_EJ3S219
{
    class Vivienda
    {
        private string familia;

        public string Familia
        {
            get { return familia; }
            set { familia = value; }
        }
        public string poligono { get; set; }
        public int numeroCasa { get; set; }
        public double pagoMensualCasa { get; set; }
        public double pagoVigilancia { get; set; }

        public void pagoTotal()
        {
            Console.WriteLine("Poligono: " + poligono);
            Console.WriteLine("Número casa: " + numeroCasa);
            Console.WriteLine("Pago total: $" + (pagoMensualCasa + pagoVigilancia));

        }
    }
}
