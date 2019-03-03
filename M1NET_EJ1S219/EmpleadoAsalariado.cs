using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_EJ1S219
{
    class EmpleadoAsalariado
    {
        public String nombre;
        public Double salario;
        public Double renta;

        public EmpleadoAsalariado(string nombre, double salario, double renta)
        {
            this.nombre = nombre;
            this.renta = renta;
            this.salario = salario - renta;

        }
    }
}
