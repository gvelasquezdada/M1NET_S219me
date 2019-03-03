using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S219_AMBITOS1
{
    public class Program
    {
        public string variablePublic = "Variable Publica";
        private string variablePrivate = "Variable Privada";
        internal string variableInternal = "Variable Interna";
        protected string variableProtected = "Variable Protegida";
        internal protected string variableInternalProtected = "Variable Protegida Interna";

        
    }
    class pruebaAmbito
    {

        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine(p.variablePublic);
            Console.WriteLine(p.variableInternalProtected);
            Console.WriteLine(p.variableInternal);

        }
    }
    class pruebaAmbitoHerencia : Program
    {
        
        static void Main(string[] args)
        {
            pruebaAmbitoHerencia pra = new pruebaAmbitoHerencia();
            Console.WriteLine(pra.variableInternal);
            Console.WriteLine(pra.variableInternalProtected);
            Console.WriteLine(pra.variableProtected);
            Console.WriteLine(pra.variablePublic);
        }
    }
}
