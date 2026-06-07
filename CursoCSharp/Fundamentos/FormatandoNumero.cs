using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // 1 casa decimal
            Console.WriteLine(valor.ToString("C")); // moeda
            Console.WriteLine(valor.ToString("P")); // porcentagem
            Console.WriteLine(valor.ToString("#.##")); // 2 casas decimais, sem arredondar

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C", cultura));

            CultureInfo cultura2 = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura2));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D3")); // 3 dígitos, preenchendo com zeros à esquerda
        }
    }
}
