namespace Listas
{
    internal class Program
    {
        struct Pessoa
        {
            public string nome;
            public double altura;
            public DateTime dataNascimento;
        }
        static void Main(string[] args)
        {
            List <int> numeros = new List<int> {1,2,3,4,6}; // declarando lista e adicionando elementos
            numeros.Add (5); // adicionando elemento na lista
            numeros.Remove(2); // remove o elemento 2 da lista
            numeros.RemoveAt(2); // remove o elemento na posição 2 da lista
            //Console.WriteLine(numeros[0]); // 1
            //Console.WriteLine(numeros[3]); // 5

            foreach (int n in numeros) // iterando lista de inteiros
            {
                Console.WriteLine(n);
            }
            //Lista com tupla
            List<Tuple<string, double, double>> produtos = new List<Tuple<string, double, double>>(); 
            produtos.Add(new Tuple<string, double, double>("Arroz", 5.99, 45.0));
            produtos.Add(new Tuple<string, double, double>("Feijão", 7.99, 30.0));
            produtos.Add(new Tuple<string, double, double>("Carne", 35.99, 10.0));

            foreach (var n in produtos)
            {
                Console.WriteLine(n.Item1 + "\n");
                Console.WriteLine(n.Item2 + "\n");
                Console.WriteLine(n.Item3 + "\n");
            }
            //Lista com tupla do jeito do professor
            var produtos2 = new List<(string Nome, double Preco, double Estoque)>
            {
                ("Arroz", 5.99, 45.0),
                ("Feijão", 7.99, 30.0),
                ("Carne", 35.99, 10.0)
            };
            foreach (var n in produtos2)
            {
                Console.WriteLine(n.Nome + "\n");
                Console.WriteLine(n.Preco + "\n");
                Console.WriteLine(n.Estoque + "\n");
            }
            //Lista com registro do tipo pessoa
            List<Pessoa> pessoas = new List<Pessoa>();
            Pessoa pessoa1 = new Pessoa(); 
            
            Console.WriteLine("Digite o nome: ");
            pessoa1.nome = Console.ReadLine();

            Console.WriteLine("Digite a altura: ");
            pessoa1.altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o dia da data de nascimento: ");
            int dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o mês da data de nascimento: ");
            int mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o ano da data de nascimento: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            pessoa1.dataNascimento = new DateTime(ano, mes, dia);

            pessoas.Add(pessoa1);
            Console.WriteLine("Nome: " + pessoa1.nome + "\n" + "Altura: " + pessoa1.altura + "cm" + "\n" + "Data de nascimento: {0:d}", pessoa1.dataNascimento);
            
        }
    }
}
