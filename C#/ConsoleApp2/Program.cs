namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Disciplina;
            double Nota1;
            double Nota2;
            double Media;

            Console.WriteLine("Digite o nome da disciplina a qual você deseja descobrir a média aqui:");
            Disciplina = Console.ReadLine();

            Console.WriteLine("Digite a sua 1ª nota da disciplina aqui:");
            Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a sua 2ª nota da disciplina aqui:");
            Nota2 = Convert.ToDouble(Console.ReadLine());

            Media = (2 * Nota1 + 3 * Nota2) / 5;
            Console.WriteLine("Sua média em " + Disciplina + " é: " + Media);
        }
    }
}
