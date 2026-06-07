using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class Inferencia {
        public static void Executar() {
            var nome = "Leonardo"; 
            Console.WriteLine(nome);

            var idade = 32; 
            Console.WriteLine(idade);
            //var nunca pode ser iniciado vazio

            var preco = 4.99;
            Console.WriteLine(preco);
            // nome = 123; // erro de compilação, pois o tipo da variável nome é string e não pode ser atribuído um valor inteiro

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);
        }
    }
}
