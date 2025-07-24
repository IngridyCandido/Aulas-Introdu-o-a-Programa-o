using System.Text;

namespace Função_quadrática
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //função quadrática do tipo ax² + bx + c
            double a, b, c, delta, x1, x2;
            char opcao;
            // Recebe os coeficientes da função quadrática
            Console.WriteLine("Digite o coeficiente a da função quadrática (ax² + bx + c):");
            a = Convert.ToDouble(Console.ReadLine());
            // Verifica se o coeficiente a é zero
            if (a == 0)
            {
                Console.WriteLine("O coeficiente a não pode ser zero. A função não é quadrática.");
                return;
            }
            Console.WriteLine("Digite o coeficiente b da função quadrática (ax² + bx + c):");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o coeficiente c da função quadrática (ax² + bx + c):");
            c = Convert.ToDouble(Console.ReadLine());
            do
            {
                // Menu de opções
                Console.WriteLine("Menu de opções para a função f(x)=" + a + "x²+" + b + "x+" + c +":");
                Console.WriteLine("1. Calcular raízes da função quadrática ou zero da função");
                Console.WriteLine("2. Verificar concavidade da parábola");
                Console.WriteLine("3. Calcular vértice da parábola");
                Console.WriteLine("4. Verificar quando a função é positiva ou negativa");
                Console.WriteLine("5. Onde a função corta o eixo Y");
                Console.WriteLine("6. Sair");
                Console.WriteLine("Escolha uma opção:");

                opcao = Console.ReadKey().KeyChar;
                Console.WriteLine(); // Pula linha após a leitura da opção
            
                // Calcula o valor de delta
                delta = b * b - 4 * a * c;
                if (delta == 0)
                {
                    // Calcula a raiz única
                    x1 = -b / (2 * a);
                }
                else
                {
                    // Calcula as duas raízes reais
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                }
                switch (opcao)
                {
                    case '1':

                        // Exibe os possiveis zero da função
                        if (delta < 0)
                        {
                            Console.WriteLine("A equação não possui raízes reais, pois delta = " + delta + ".");
                        }
                        else if (delta == 0)
                        {
                            // Calcula a raiz única
                            x1 = -b / (2 * a);
                            Console.WriteLine($"Delta=0, por isso a equação possui uma raiz real: x = {x1}");
                        }
                        else
                        {
                            // Calcula as duas raízes reais
                            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                            Console.WriteLine($"Delta é igual a {delta}, por isso a equação possui duas raízes reais: x1 = {x1}, x2 = {x2}");
                        }
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey(); // Aguarda o usuário pressionar uma tecla antes de continuar
                        break;

                    case '2':
 
                        // Verifica se a concavidade é para cima ou para baixo
                        if (a > 0)
                        {
                            Console.WriteLine("A parábola é côncava para cima.");
                        }
                        else if (a < 0)
                        {
                            Console.WriteLine("A parábola é côncava para baixo.");
                        }
                        else
                        {
                            Console.WriteLine("A função não é quadrática (coeficiente a não pode ser zero).");
                        }
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey(); // Aguarda o usuário pressionar uma tecla antes de continuar
                        break;

                    case '3':
                    
                        // Calcula o vértice da parábola
                        double xV = -b / (2 * a);
                        double yV = -delta / (4 * a);
                        Console.WriteLine($"O vértice da parábola está em: ({xV}, {yV})");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey(); // Aguarda o usuário pressionar uma tecla antes de continuar
                        break;

                    case '4':
 
                        // Calcula quando a função é positiva ou negativa
                        if (a > 0)
                        {
                            if (delta < 0)
                            {
                                Console.WriteLine("A função é positiva para todos os valores de x.");
                            }
                            if (delta == 0)
                            {
                                Console.WriteLine($"A função é positiva para x < {x1} e x > {x1}. E neutra quando toca em {x1} pois f({x1})=0.");
                            }
                            else if (delta > 0)
                            {
                                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                                Console.WriteLine($"A função é positiva para x < {x2} e x > {x1} e negativa fora desse intervalo.");
                            }
                        }
                        else if (a < 0)
                        {
                            if (delta < 0)
                            {
                                Console.WriteLine("A função é negativa para todos os valores de x.");
                            }
                            if (delta == 0)
                            {
                                Console.WriteLine($"A função é negativa para x < {x1} e x > {x1}. E neutra quando toca em {x1} pois f({x1})=0.");
                            }
                            else if (delta > 0)
                            {
                                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                                Console.WriteLine($"A função é negativa para {x2} < x < {x1} e positiva fora desse intervalo.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("A função não é quadrática (coeficiente a não pode ser zero).");
                        }
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey(); // Aguarda o usuário pressionar uma tecla antes de continuar
                        break;

                    case '5':
                       
                        // Calcula onde a função corta o eixo Y
                        double yCorteY = c; // O ponto de corte com o eixo Y é sempre c
                        Console.WriteLine($"A função corta o eixo Y no ponto: (0, {yCorteY})");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey(); // Aguarda o usuário pressionar uma tecla antes de continuar
                        break;


                    case '6':
                        Console.WriteLine("Saindo do programa.");
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Encerrando o programa.");
                        return;

                }
            } while (opcao != 6) ;           
        }
    }
}
