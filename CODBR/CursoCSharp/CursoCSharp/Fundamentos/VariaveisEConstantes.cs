using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar() {
            // área da circunferência
            double raio = 5.5;
            const double PI = 3.14;


            double area = PI * (Math.Pow(raio, 2));
            Console.WriteLine("Área é " + area);
        }
    }
}
