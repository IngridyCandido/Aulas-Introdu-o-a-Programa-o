namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sint1, sint2, doença;
            Console.WriteLine("Oi! Soube que está doente, qual o seu sintoma principal?");
            sint1 = Console.ReadLine();
            Console.WriteLine("Sinto muito, qual seu segundo sintoma principal?");
            sint2 = Console.ReadLine();
            switch (doença)
            {
                case 'febre + tosse':
                    Console.WriteLine("Sua doença provavelmente é: Gripe, resfriado, covid-19 ou dengue.");
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
