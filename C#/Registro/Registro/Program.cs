namespace Registro
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
            //Declaração de variavel do tipo Pessoa
            //Pessoa pessoa1;

            //pessoa1.nome = "Carlos";
            //pessoa1.altura = 1.78;
            //pessoa1.dataNascimento = new DateTime(1978, 3, 30);

            Pessoa[] pessoas = new Pessoa[3];
            for (int i = 0; i < pessoas.Length; i++)
            {
                Console.WriteLine("Digite o nome: ");
                pessoas[i].nome = Console.ReadLine();

                Console.WriteLine("Digite a altura: ");
                pessoas[i].altura=Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o dia da data de nascimento: ");
                int dia = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o mês da data de nascimento: ");
                int mes = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o ano da data de nascimento: ");
                int ano = Convert.ToInt32(Console.ReadLine());

                pessoas[i].dataNascimento= new DateTime (ano, mes, dia);

            }
            for (int i = 0;i < pessoas.Length;i++)
            {
                Console.WriteLine("Nome: " + pessoas[i].nome + "\n" + "Altura: " + pessoas[i].altura +"cm"+ "\n" + "Data de nascimento: {0:d}" , pessoas[i].dataNascimento);
            }
        }
    }
}
