namespace Matriz_3x2x2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] x = new int[3, 2, 2];
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    for (int k = 0; k < x.GetLength(2); k++)
                    {
                        Console.WriteLine("Digite um número para 1 linha " + i + " um para coluna " + j + " e um para diagonal " + k + ":");
                        x[i, j, k] = Convert.ToInt32(Console.ReadLine()); 
                    }

                }

            }
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    for (int k = 0; k < x.GetLength(2); k++)
                    {
                        Console.WriteLine("x[" + i + "," + j + "," + k + "] vale " + x[i,j,k] + ".");
                    }

                }

            }
        }
    }
}
