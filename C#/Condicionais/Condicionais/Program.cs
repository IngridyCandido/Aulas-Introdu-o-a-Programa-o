using System.Runtime.Intrinsics.X86;

namespace Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cargo;
            double salario, aumento;
            Console.WriteLine("Qual o seu cargo (1-escriturario, 2-secretario, 3-caixa, 4-gerente, 5-diretor)? ");
            cargo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o seu salário atual ? R$");
            salario = Convert.ToDouble(Console.ReadLine());
            switch (cargo)
            {
                case 1:
                    aumento = (salario * 1.5);
                    Console.WriteLine("Seu aumento será de R$" + (aumento - salario) + " e seu novo salario será de R$" + aumento + ".");
                    break;
                case 2:
                    aumento = (salario * 1.35);
                    Console.WriteLine("Seu aumento será de R$" + (aumento - salario) + " e seu novo salario será de R$" + aumento + ".");
                    break;
                case 3:
                    aumento = (salario * 1.2);
                    Console.WriteLine("Seu aumento será de R$" + (aumento - salario) + " e seu novo salario será de R$" + aumento + ".");
                    break;
                case 4:
                    aumento = (salario * 1.1);
                    Console.WriteLine("Seu aumento será de R$" + (aumento - salario) + " e seu novo salario será de R$" + aumento + ".");
                    break;
                case 5:
                    Console.WriteLine("Você não receberá aumento. Seu salario continuará de R$" + salario + ".");
                    break;
                default:
                    Console.WriteLine("Esse cargo não existe na empresa.");
                    break;

            }
        }
    }
}
