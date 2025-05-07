using System.Security.AccessControl;

namespace Form
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string RG;
            string CPF;
            string data;
            string númerocasa;
            string cep;
            string telefone;
            double renda;
            string nome;
            string rua;
            string bairro;
            string estado;
            string munícipio;
            

            Console.WriteLine("Olá, preciso que você preencha as seguintes informações:");
            Console.WriteLine("Qual seu nome completo?");
            nome = Console.ReadLine();
            Console.WriteLine("Qual seu RG?");
            RG = Console.ReadLine();
            Console.WriteLine("Qual seu CPF?");
            CPF = Console.ReadLine();
            Console.WriteLine("Qual sua data de nascimento?");
            data = Console.ReadLine();
            Console.WriteLine("Qual seu número de celular com DDD?");
            telefone = Console.ReadLine();
            Console.WriteLine("Qual seu cep?");
            cep = Console.ReadLine();
            Console.WriteLine("Qual seu estado?");
            estado = Console.ReadLine();
            Console.WriteLine("Qual seu munínipio?");
            munícipio = Console.ReadLine();
            Console.WriteLine("Qual o seu bairro?");
            bairro = Console.ReadLine();
            Console.WriteLine("Qual sua rua?");
            rua = Console.ReadLine();
            Console.WriteLine("Qual o número da sua casa?");
            númerocasa = Console.ReadLine();
            Console.WriteLine("Qual sua renda mensal?");
            renda = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Obrigada por preencher os dados. Você se chama " + nome + ", nasceu em " + data + ", portador do RG n° " + RG + " e CPF n° " + CPF + ". Seu celular com DDD é " + telefone + ". Tem uma renda mensal de R$" + renda + ". E mora no endereço: " + rua + ", "+ númerocasa + ", " + bairro + ", " + munícipio + ", " + estado + ", CEP: " + cep + ".");

        }
    }
}
