namespace Calculadora_C#
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            char opcao;
            Console.WriteLine("Olá, vamos calcular? Escreva o primeiro número que desejar");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva o segundo número que deseja operar");
            num2 =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a operação númerica entre + (soma), - (diferença), * (multiplicação) e / (divisão) você quer executar?");
            opcao = Convert.ToChar(Console.ReadLine());

        switch (opcao)
        {
            case '+':
                Console.WriteLine("A soma dos seus números é: " + (num1 + num2) + ".");
                break;
            case '-':
                Console.WriteLine("A diferença dos seus números é: " + (num1 - num2) + ".");
                break;
            case '*':
                Console.WriteLine("A multiplicação dos seus números é: " + (num1 * num2) + ".");
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Não é posivel dividir por 0.");
                }
                else
                {
                    Console.WriteLine("A divisão dos seus números é: " + (num1 / num2) + ".");
                }
                break;
            default:
                Console.WriteLine("A operação escolhida não pode ser executada.");
                break;
                
            }
        }
    }
}
