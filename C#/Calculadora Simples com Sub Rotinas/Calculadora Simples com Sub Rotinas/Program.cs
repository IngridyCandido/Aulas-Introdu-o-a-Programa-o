namespace Calculadora_Simples_com_Sub_Rotinas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double num1, num2, resultado;
            Console.WriteLine("Digite o primeiro número: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            do
            {
                Console.WriteLine("Menu de Opções");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        resultado = Soma(num1, num2);
                        Console.WriteLine($"Resultado da soma: {resultado}");
                        break;
                    case 2:
                        resultado = Subtracao(num1, num2);
                        Console.WriteLine($"Resultado da subtração: {resultado}");
                        break;
                    case 3:
                        resultado = Multiplicacao(num1, num2);
                        Console.WriteLine($"Resultado da multiplicação: {resultado}");
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Divisão por zero não é permitida.");
                        }
                        else
                        {
                            resultado = Divisao(num1, num2);
                            Console.WriteLine($"Resultado da divisão: {resultado}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Saindo do programa...");
                        break;
                }
            } while (opcao != 5);
        }
        static double Soma(double a, double b)
        {
            return a + b;
        }
        static double Subtracao(double a, double b)
        {
            return a - b;
        }
        static double Multiplicacao(double a, double b)
        {
            return a * b;
        }
        static double Divisao(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Divisão por zero não é permitida.");
            }
            return a / b;
        }
    }
}
