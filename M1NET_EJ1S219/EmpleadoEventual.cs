using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_EJ1S219
{
    class EmpleadoEventual
    {
        public string nombre;
        public double salario;

        public EmpleadoEventual(string nombre, double salario)
        {
            this.nombre = nombre;
            this.salario = salario - (salario * 0.1d);
        }
    }
}
