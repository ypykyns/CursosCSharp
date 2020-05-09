using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class InterpolacaoDeStrings
    {
        public static void Executar() {
            string nome = "Luis";
            string sobrenome = "Sousa";
            double salario = 5000.01;

            Console.WriteLine("O funcionário {0} {1} recebe R${2} de salário.", 
                nome, sobrenome, salario);
        
        }
    }
}
