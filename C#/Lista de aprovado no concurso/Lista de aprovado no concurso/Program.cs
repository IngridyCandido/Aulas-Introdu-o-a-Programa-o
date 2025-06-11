namespace Lista_de_aprovado_no_concurso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] candidato = new string[6];
            double[] nota = new double[6];
            for (int i = 0; i < candidato.Length; i++)
            {
                Console.WriteLine("Qual o nome do candidado? ");
                candidato[i] = Console.ReadLine();
                Console.WriteLine("Qual a nota do candidado? ");
                nota[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Qual a posição de classificação você deseja ver? ");
            int posicao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O candidado na "+ posicao + "ª é " + candidato[posicao-1] + " com nota igual a " + nota[posicao-1]);
            
        }
    }
}
