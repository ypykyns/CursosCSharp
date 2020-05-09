using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Segundo Programa - Fundamentos", Class1.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Interpolacao de Strings - Fundamentos", InterpolacaoDeStrings.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},

                // Classe e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},



            });

            central.SelecionarEExecutar();
        }
    }
}