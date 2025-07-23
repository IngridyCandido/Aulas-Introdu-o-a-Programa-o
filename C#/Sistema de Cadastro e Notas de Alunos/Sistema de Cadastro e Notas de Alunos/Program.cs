using System.Runtime.Serialization;

namespace Sistema_de_Cadastro_e_Notas_de_Alunos
{
    internal class Program
    {
        struct Aluno
        {
            public string Nome;
            public int Matricula;
            public double MediaFinal;
        }

        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine($"Digite o nome do aluno {i + 1}:");
                alunos[i].Nome = Console.ReadLine();

                Console.WriteLine($"Digite a matrícula do aluno {i + 1}:");
                alunos[i].Matricula = int.Parse(Console.ReadLine());
            }

            double[,] notas = new double[5,3];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Aluno: {alunos[i].Nome} (Matrícula: {alunos[i].Matricula})");
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Digite a nota {j+1} do aluno {i+1}:");
                    notas[i, j] = double.Parse(Console.ReadLine());

                }
            }
            for (int j = 0; j < alunos.Length; j++)
            {
                double soma = 0;
                for (int k = 0; k < 3; k++)
                {
                    soma += notas[j, k];
                }
                alunos[j].MediaFinal = soma / 3;
                Console.WriteLine($"A média final do aluno {alunos[j].Nome} é: {alunos[j].MediaFinal}");
            }
        }
    }
}
