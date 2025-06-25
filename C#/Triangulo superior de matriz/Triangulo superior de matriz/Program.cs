namespace Triangulo_superior_de_matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[3,3];
            char opcao;
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                        Console.WriteLine("Digite um número para 1 linha " + i + " um para coluna " + j + ":");
                        x[i,j] = Convert.ToInt32(Console.ReadLine());

                }

            }

            Console.WriteLine("Menu de Opções: \n a – triângulo superior \n b – triângulo inferior \n c – diagonal principal \n Digite uma opção:");
            opcao = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < x.GetLength(0); i++)
            {
                switch (opcao)
                {
                    case 'a':
                        for (int j = i; j < x.GetLength(1); j++)
                        {
                            Console.WriteLine("O triângulo superior da matriz é composto por: " + x[i, j]);
                        }
                        break;
                    case 'b':
                        for (int j = 0 ; j <= i; j++)
                        {
                            Console.WriteLine("O triângulo inferior da matriz é composto por: " + x[i, j]);
                        }
                            break; 
                    case 'c':
                         for (int j = i ; j == i; j++)
                         {
                            Console.WriteLine("A diagonal principal da matriz é composto por: " + x[i, j]);
                         }
                         break;
                }

            }
        }
    }
}
