namespace Conversões
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intNota = 8;
            double dblNota = intNota;
            Console.WriteLine(dblNota);

            dblNota = 10.3456;
            intNota = (int)dblNota;
            Console.WriteLine(intNota);

            string strNome = "Maria";
            int intIdade = 22;
            double dblMedia = 8.23;
            bool boolMatriculado = true;

            Console.WriteLine(Convert.ToString(intIdade));
            Console.WriteLine(Convert.ToDouble(intIdade));
            Console.WriteLine(Convert.ToInt32(dblMedia));
            Console.WriteLine(Convert.ToString(boolMatriculado));

            Console.WriteLine(Convert.ToInt32(strNome)); //Não é possível mudar nome para número.
        }
    }
}
