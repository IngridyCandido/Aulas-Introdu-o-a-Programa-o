using System.Security.AccessControl;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raiom, raioM, altura, pi, volume, qtlitros;
            pi = 3.1416;

            Console.WriteLine("Olá! Preciso da sua ajuda para calcular o volume da sua caixa de água.");
            Console.WriteLine("Por favor, me forneça a altura dela:");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual o tamanho do raio maior (em cm)?");
            raioM = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual o tamanho do raio menor (em cm)?");
            raiom = Convert.ToDouble(Console.ReadLine());

            volume = (1.0 / 3.0) * pi * altura *( Math.Pow(raiom,2) + Math.Pow(raioM,2) + raiom * raioM);
            qtlitros = volume * 1000;

            Console.WriteLine("O volume da sua caixa é de " + volume + "cm³. E ela suporta" + qtlitros + "l.");
        }
    }
}
