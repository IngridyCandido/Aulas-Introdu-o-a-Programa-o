namespace Funções_de_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "Estou na escola hoje.";
            string palavraChave = "escola";
            string palavra;
            string trecho = frase.Substring(0, 5); // Exemplo de uso do Substring

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("Digite uma palavra: ");
            palavra = Console.ReadLine();

            // Verifica se a frase é nula ou vazia
            if (frase == null || frase.Length == 0)
            {
                Console.WriteLine("A frase não pode ser vazia.");
                return;
            }

            // Exibe a frase digitada e o número de caracteres
            Console.WriteLine("A frase digitada foi: '" + frase + "' e ela possui " + frase.Length + " caracteres.");

            // Verifica se a frase contém a palavra-chave e substitui por outra palavra.
            if (frase.Contains (palavraChave))
            {
                frase= frase.Replace(palavraChave, palavra);
                Console.WriteLine(frase);
            }

            Console.WriteLine(trecho);

            frase = frase.ToLower(); // Converte a frase para minúsculas

            frase = frase.ToUpper(); // Converte a frase para maiúsculas

            frase = frase.Remove(0, 5); // Remove os primeiros 5 caracteres da frase
            Console.WriteLine(frase);

            Console.WriteLine ("A frase possui " + frase.Count(char.IsLetter) + " letras.");
            // Exibe o número de letras na frase
            Console.WriteLine(frase[13]); // Exibe o caractere na posição 13 da frase
            Console.WriteLine(frase.IndexOf("hoje")); // Exibe o índice da palavra "hoje" na frase
            Console.WriteLine(frase.LastIndexOf("hoje")); // Exibe o último índice da palavra "hoje" na frase
            
            if(frase.Equals("ESTOU NA ESCOLA HOJE."))
            {
                Console.WriteLine("A frase é igual a 'ESTOU NA ESCOLA HOJE.'");
            }
            else
            {
                Console.WriteLine("A frase é diferente de 'ESTOU NA ESCOLA HOJE.'");
            }
        }
    }
}
