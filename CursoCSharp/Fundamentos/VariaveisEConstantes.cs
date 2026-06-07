using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {

            //tipo variavel = valor
            double raio = 4.5; // = atriubui valor a variável
            const double PI = 3.14; // const é uma constante, ou seja, não pode ser alterada depois de atribuída

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine("Área é " + area);


            //Tipos inteiros

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 45; // byte é um tipo de dado que armazena valores inteiros de 0 a 255
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // sbyte é um tipo de dado que armazena valores inteiros de -128 a 127

            short salario = short.MaxValue; // short é um tipo de dado que armazena valores inteiros de -32.768 a 32.767
            Console.WriteLine("Salário: " + salario);

            int menorValorInt = int.MinValue; // int é um tipo de dado que armazena valores inteiros de -2.147.483.648 a 2.147.483.647
            Console.WriteLine("Menor valor de int: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000; // uint é um tipo de dado que armazena valores inteiros de 0 a 4.294.967.295
            Console.WriteLine("População brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue; // long é um tipo de dado que armazena valores inteiros de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
            Console.WriteLine("Menor valor de long: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000; // ulong é um tipo de dado que armazena valores inteiros de 0 a 18.446.744.073.709.551.615
            Console.WriteLine("População mundial: " + populacaoMundial);

            //Tipos flutuantes

            float precoComputador = 1299.99f; // float é um tipo de dado que armazena valores de ponto flutuante de precisão simples
            Console.WriteLine("Preço do computador: " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // double é um tipo de dado que armazena valores de ponto flutuante de precisão dupla
            Console.WriteLine("Valor de mercado da Apple: " + valorDeMercadoDaApple);

            char letra = 'b'; // char é um tipo de dado que armazena um único caractere
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja bem vindo ao curso de C#"; // string é um tipo de dado que armazena uma sequência de caracteres
            Console.WriteLine("Texto: " + texto);
        }
    }
}
