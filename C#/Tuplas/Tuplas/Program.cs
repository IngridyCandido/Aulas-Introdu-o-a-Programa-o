using System.Runtime.Intrinsics.X86;

namespace Tuplas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pessoa = ("João", 25, true);
            Console.WriteLine(pessoa.Item1);
            Console.WriteLine(pessoa.Item2);
            Console.WriteLine(pessoa.Item3);

            // (string, int, bool) pessoa = ("João", 25, true);
            // Console.WriteLine(pessoa.Item1); // João
            // Console.WriteLine(pessoa.Item2); // 25

            var pessoa2 = (Nome: "Ingridy", Idade: 24, Ativo: true);
            Console.WriteLine(pessoa2.Nome);
            Console.WriteLine(pessoa2.Idade);
            Console.WriteLine(pessoa2.Ativo);

            // (string Nome, int Idade, bool Ativo) pessoa3 = ("João", 25, true);
            // Console.WriteLine(pessoa3.Nome); // João
            // Console.WriteLine(pessoa3.Idade); // 25

            var pessoas = new (string Nome, int Idade, bool Ativo)[]
            {
                ("José", 19, false),
                ("Ellen", 23, true),
                ("Paulo", 26, false),
                ("Caio", 23, true)
            };
            //Console.WriteLine(pessoas[0].Nome);
            //Console.WriteLine(pessoas[1].Nome);
            for (int i = 0; i < pessoas.Length; i++)
            {
                Console.WriteLine(pessoas[i].Nome + "\n");
                Console.WriteLine(pessoas[i].Idade + "\n");
                Console.WriteLine(pessoas[i].Ativo + "\n");
            }

            /* Crie uma tupla nomeada que represente um produto com os campos: Nome, Preço e Estoque.Imprima os valores.*/

            var produto = new (string Nome, double Preço, double Estoque)[]
            {
                ("Arroz", 5.99, 45.0),
                ("Feijão", 7.99, 30.0),
                ("Carne", 35.99, 10.0)
            };
            for (int i = 0; i < produto.Length; i++)
            {
                Console.WriteLine(produto[i].Nome + "\n");
                Console.WriteLine(produto[i].Preço + "\n");
                Console.WriteLine(produto[i].Estoque + "\n");
            }
        }
    }
}
