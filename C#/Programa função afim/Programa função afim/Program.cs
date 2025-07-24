using System.Text;

namespace Programa_função_afim_e_quadratica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Função afim
            double x, a, b;
            char opcao;
            // Solicita os valores de a e b ao usuário
            Console.WriteLine("Digite o valor de a (coeficiente angular): ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de b (coeficiente linear): ");
            b = Convert.ToDouble(Console.ReadLine());

            do
            {
                // Solicita ao usuário o que ele deseja saber sobre a função Afim
                Console.WriteLine("Menu de opções, o que deseja saber sobre essa função afim f(x)=" + a + "x+" + b + ": \n 1 – A função é crescente ou decrescente? \n 2 – Qual o zero da função? \n 3 – Quando a função é positiva e negativa? \n 4 - Qual os pontos em que o gráfico da função corta o Eixo X e corta o Eixo Y? \n 5 - Sair do programa \n Digite uma opção:");
                opcao = Convert.ToChar(Console.ReadLine());
                // Verifica a opção escolhida pelo usuário
                switch (opcao)
                {
                    case '1':
                        // Verifica se a função é crescente ou decrescente
                        if (a > 0)
                        {
                            Console.WriteLine("A função é crescente.");
                        }
                        else if (a < 0)
                        {
                            Console.WriteLine("A função é decrescente.");
                        }
                        else
                        {
                            Console.WriteLine("A função é constante.");
                        }
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey(true); // Aguarda o usuário pressionar uma tecla antes de continuar
                        break;
                    case '2':
                        // Calcula o zero da função
                        if (a != 0)
                        {
                            x = -b / a;
                            Console.WriteLine($"O zero da função é: {x}");
                        }
                        else
                        {
                            Console.WriteLine("Não é possível calcular o zero da função, pois a = 0.");
                        }
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey(true); // Aguarda o usuário pressionar uma tecla antes de continuar
                        break;
                    case '3':
                        // Verifica quando a função é positiva e negativa
                        if (a > 0)
                        {
                            Console.WriteLine("A função é positiva para x > " + (-b / a) + " e negativa para x < " + (-b / a));
                        }
                        else if (a < 0)
                        {
                            Console.WriteLine("A função é negativa para x > " + (-b / a) + " e positiva para x < " + (-b / a));
                        }
                        else
                        {
                            Console.WriteLine("A função é constante e não muda de sinal.");
                        }
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey(true); // Aguarda o usuário pressionar uma tecla antes de continuar
                        break;
                    case '4':
                        // Exibe onde o gráfico corta os eixos X e Y
                        x = -b / a; // Zero da função
                        Console.WriteLine($"O gráfico da função corta o eixo Y no ponto (0, {b}). E corta o eixo X no ponto ({x}, 0)");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey(true); // Aguarda o usuário pressionar uma tecla antes de continuar
                        break;
                    case '5':
                        // Encerra o programa
                        Console.WriteLine("Saindo do programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != 5); 
        }
    }
}
