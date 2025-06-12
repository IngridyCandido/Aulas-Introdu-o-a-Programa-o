using System.Diagnostics;
using System.Net;
using System.Reflection;

namespace Menu_com_vetores
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] x = new double[10];
            double[] y = new double[10];
            double[] z = new double[10];
            char opcao;
            double num;

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Digite vetor1:");
                x[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite vetor2: ");
                y[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Menu de Opções: \n A – soma dos vetores. \n B – subtração dos vetores. \n C – multiplicação do vetor por um escalar. \n Digite uma opção:");
            opcao = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < x.Length; i++)
            {
                switch (opcao)
                {
                    case 'A':
                        z[i] = x[i] + y[i];
                        Console.WriteLine("A soma dos vetores " + x[i] + "+" + y[i] + "=" + z[i] + ".");
                        break;
                    case 'B':
                        z[i] = x[i] - y[i];
                        Console.WriteLine("A subtração dos vetores " + x[i] + "-" + y[i] + "=" + z[i] + ".");
                        break;
                    case 'C':
                        Console.WriteLine("Digite um número para multiplicar pelo vetor:");
                        num = Convert.ToDouble(Console.ReadLine());
                        z[i] = x[i] * num;
                        Console.WriteLine("A multiplicação do vetor pelo número escolhido é " + x[i] + "x" + num + "=" + z[i] + ".");
                        break;
                }
            }
        }
    }
}
