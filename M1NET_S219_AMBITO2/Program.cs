using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using programA1 = M1NET_S219_AMBITOS1.Program;

namespace M1NET_S219_AMBITO2
{
    class Program
    {
        static void Main(string[] args)
        {
            programA1 pA1 = new programA1();
            Console.WriteLine(pA1.variablePublic);
        }
    }

    class ejemploAmbito2 : programA1
    {
        static void Main(string[] args)
        {
            ejemploAmbito2 pra1 = new ejemploAmbito2();
            Console.WriteLine(pra1.variablePublic);
            Console.WriteLine(pra1.variableProtected);
            Console.WriteLine(pra1.variableInternalProtected);
        }
    }
        
}
