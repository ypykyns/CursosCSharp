using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar() {

            Console.Write("Primeiro Valor: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Segundo Valor: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Salário");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);


            int c = a + b;
            Console.WriteLine(c);
            Console.WriteLine(salario);
        }
    }
}
