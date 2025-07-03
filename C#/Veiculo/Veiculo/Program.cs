using System.Runtime.CompilerServices;

namespace Veiculo
{
    internal class Program
    {
        struct Veiculo //Criando o registro Veiculos
        {
            public string placa;
            public string renavam;
            public int tipo;
            public int categoria;
            public int lugares;
            public string cor;
            public DateTime dataAdquirido;
            public string situação;
            public string nomeProprietario;
        }
        static void Main(string[] args)
        {
            //Declarando o vetor veiculos 
            Veiculo[] veiculos = new Veiculo[3];

            //Laço de repetição para adicionar informações aos vetores
            for (int i = 0; i < veiculos.Length; i++)
            {
                Console.WriteLine("Por favor, informe a placa do veiculo: ");
                veiculos[i].placa=Console.ReadLine();

                Console.WriteLine("Por favor, informe o renavam do veiculo: ");
                veiculos[i].renavam = Console.ReadLine();

                Console.WriteLine("Por favor, informe o tipo do veiculo: ");
                veiculos[i].tipo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Por favor, informe a categoria do veiculo: ");
                veiculos[i].categoria = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Por favor, informe quantos lugares o veiculo possui: ");
                veiculos[i].lugares = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Por favor, informe a cor do veiculo: ");
                veiculos[i].cor = Console.ReadLine();

                Console.WriteLine("Por favor, informe a a data que o veiculo foi adquirido no seguinte modelo dd/mm/aaaa: ");
                string[] dt = Console.ReadLine().Split('/'); //Fatia a string

                veiculos[i].dataAdquirido = new DateTime(Convert.ToInt32(dt[2]), Convert.ToInt32(dt[1]), Convert.ToInt32(dt[0]));

                Console.WriteLine("Por favor, informe a situação do veiculo: ");
                veiculos[i].situação = Console.ReadLine();

                Console.WriteLine("Por favor, informe o nome do proprietario do veiculo: ");
                veiculos[i].nomeProprietario = Console.ReadLine();
            }

            //Impressão do vetor veiculos:
            for (int i = 0; i < veiculos.Length; i++)
            {
                Console.WriteLine("O veiculo informado de placa " + veiculos[i].placa + " pertence a " + veiculos[i].nomeProprietario + ". Seu renavam é " +
                    veiculos[i].renavam + " seu tipo é " + veiculos[i].tipo + ", ele está na categoria " + veiculos[i].categoria + ", possui " + veiculos[i].lugares
                    + "lugares, sua cor é " + veiculos[i].cor + ", encontra-se na situação " + veiculos[i].situação + "e foi adquirido na data: {0:d} ", veiculos[i].dataAdquirido);
            }
        }
    }
}
