namespace Maior_menor_com_vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] x = new double [15];
            double maiornumero = -99999999999;
            double menornumero = 999999999999;
            int imaior = 0;
            int imenor = 0;

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("Digite um número real: ");
                x[i] = Convert.ToDouble(Console.ReadLine());
                if (x[i] > maiornumero)
                {
                    maiornumero = x[i];
                    imaior = i;
                }
                if (x[i] < menornumero)
                {
                    menornumero = x[i];
                    imenor = i;
                }
            }
            Console.WriteLine("O maior número do vetor é " + maiornumero + " e sua posição é " + imaior + ".");
            Console.WriteLine("O menor número do vetor é " + menornumero + " e sua posição é " + imenor + ".");
        }
    }
}
