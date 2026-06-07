using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    internal class NotacaoPonto {
        public static void Executar() {
            var saudacao = "Olá".ToUpper().Insert(3, " World").Replace("World", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
            //navegacao segura, se o valor for nulo, ele nao tenta acessar a propriedade e retorna nulo
        }
    }
}
