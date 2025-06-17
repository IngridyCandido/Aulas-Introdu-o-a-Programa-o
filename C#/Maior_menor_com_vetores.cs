namespace Maior_menor_com_vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double [] x = new double x [15];
            double maiornumero = -99999999999; 
            double menornumero = 999999999999;
            for (int i = 0; i <x.Length; i++) 
            {
                Console.WhiteLine("Digite um número real: ");
                x[i] = Convert.ToDouble(Console.ReadLine());
                if (x[i] > maiornumero) 
                {
                    maiornumero = Convert.ToDouble(Console.ReadLine());
                }
                if (x[i] < menornumero)
                {
                    menornumero = Convert.ToDouble(Console.ReadLine());
                }     
            }
            for (x[i]=maiornumero)
            {
            Console.WhiteLine("O maior número do vetor é " + maiornumero + "e sua posição é " + i)
            }
            proximo
            for (x[i]=menornumero)
            {
            Console.WhiteLine("O menor número do vetor é " + menornumero + "e sua posição é " + i)
            }
            proximo
        }
    }
}
