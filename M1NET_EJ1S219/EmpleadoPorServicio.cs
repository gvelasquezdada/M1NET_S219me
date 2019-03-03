using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_EJ1S219
{
    class EmpleadoPorServicio
    {
        public string nombre;
        public int numeroHoras;
        public double valorHora;
        public double salario;

        public EmpleadoPorServicio(string nombre, int numeroHoras,double valorHora)
        {
            this.nombre = nombre;
            this.numeroHoras = numeroHoras;
            this.valorHora = valorHora;
            this.salario = numeroHoras * valorHora;

        }
    }
}
