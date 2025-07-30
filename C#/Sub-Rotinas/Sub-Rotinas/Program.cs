namespace Sub_Rotinas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sal, aum, novoSal;
            Imprimir("Digite o salário atual: ");
            sal =Convert.ToDouble(Console.ReadLine());
            aum = Calculo(sal);
            novoSal = sal + aum;
            Imprimir("O novo salário é: " + novoSal);
        }
        static double Calculo(double sal)
        {
            double perc, valor;
            Imprimir("Digite o percentual de aumento: ");
            perc = Convert.ToDouble(Console.ReadLine());
            valor = sal * perc / 100;
            return valor;
        }
        static void Imprimir (string texto)
        {
            Console.WriteLine(texto);
        }
    }
}
