using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar() {

            int inteiro = 10;
            double quebrado = inteiro;

            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);


            Console.Write("Digite o primeiro número => ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine(numero);



            Console.Write("Digite segundo número => ");            
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine(numero2);


        }
    }
}
