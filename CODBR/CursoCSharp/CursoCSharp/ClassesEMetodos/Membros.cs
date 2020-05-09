using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar() {

            Pessoa ciclano = new Pessoa();
            ciclano.Nome = "Zé";
            ciclano.Idade = 36;

            ciclano.ApresentarNoConsole();
        }
    }
}
