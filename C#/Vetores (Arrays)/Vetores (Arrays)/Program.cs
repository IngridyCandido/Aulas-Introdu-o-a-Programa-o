namespace Vetores__Arrays_
{
    internal class Program
    {
        static void Main(string[] args)
        {//inicio
            int[] x = new int[9];
            //Lendo valores e preenchendo o vetor.
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Digite um número para a posição " + i + ":");
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Descobrindo valores pares já preenchidos no vetor e quais suas posições.
            for (int i = 0;i < 9; i++)
            {
                if (x[i] % 2 == 0) 
                { 
                    Console.WriteLine("O elemento na posição " + i + " é par e é igual a " + x[i]); 
                }
            }
            Console.ReadKey(); //pausa
        }//fim
    }
}
