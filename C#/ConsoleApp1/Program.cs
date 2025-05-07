namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {//inicio
         //string nome = "Ingridy";
         // Console.WriteLine(nome);
            int anonasc;
            int idade;
            Console.WriteLine("Digite o ano de seu nascimento:");
            anonasc = Convert.ToInt32(Console.ReadLine());
            idade = 2025 - anonasc;
            Console.WriteLine("Sua idade é " + idade);
        }//fim
    }
}
