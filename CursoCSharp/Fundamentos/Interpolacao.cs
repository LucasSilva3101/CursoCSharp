using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class Interpolacao {
        public static void Executar() {

            string nome = "Notebook Gamer";
            var marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");

            // Interpolação de string
            Console.WriteLine($"O {nome} custa {preco}.");

            // Interpolação com formatação
            Console.WriteLine($"O {nome} custa {preco:C2}."); // C2 formata o valor como moeda com 2 casas decimais

            // Interpolação com alinhamento
            Console.WriteLine($"|{"Produto",-20}|{"Preço",10}|");
            Console.WriteLine($"|{nome,-20}|{preco,10:C2}|");

            Console.WriteLine($" 1 + 1 = {1 + 1}!");
        }
    }
}
