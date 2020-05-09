using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar() {
            double valor = 15.175;
            int inteiro = 354;

            Console.WriteLine(valor.ToString("F6"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine((valor).ToString("P"));
            Console.WriteLine((valor).ToString("#.##"));
            Console.WriteLine((inteiro).ToString("D10"));
        }
    }
}
