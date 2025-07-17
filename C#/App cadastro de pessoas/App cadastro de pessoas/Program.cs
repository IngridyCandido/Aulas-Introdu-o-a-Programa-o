namespace App_cadastro_de_pessoas
{
    internal class Program
    {
        struct Usuarios
        {
            public string nome;
            public string cpf;
            public string eMail;
        }
        static void Main(string[] args)
        {
            char opcao;
            List <Usuarios> usuarioList = new List<Usuarios>();
            Usuarios usuario1 = new Usuarios();
            do
            {
                Console.WriteLine("MENU DE OPÇÕES" + "\n" + "1 - Cadastrar pessoa" + "\n" + "2 - Consultar pessoa pelo CPF" + "\n" + "3 - Excluir pessoa (por CPF)" + "\n" + "4 - Imprimir a lista de pessoas" + "\n" + "5 - Sair" + "\n" + "Digite sua opção:");
                opcao = Convert.ToChar(Console.ReadLine());

                switch (opcao)
                {
                    case '1':
                        Console.WriteLine("Digite o nome do usuário que deseja cadastrar:");
                        usuario1.nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do usuário que deseja cadastrar:");
                        usuario1.cpf = Console.ReadLine();
                        Console.WriteLine("Digite o E-mail do usuário que deseja cadastrar:");
                        usuario1.eMail = Console.ReadLine();
                        usuarioList.Add(usuario1);
                        Console.Clear();
                        break;
                    case '2':
                        Console.WriteLine("Digite o CPF da pessoa que deseja consultar:");
                        string cpfConsultar = Console.ReadLine();
                        Usuarios resultado = usuarioList.Find(p => p.cpf == cpfConsultar);
                        if (!resultado.Equals(default(Usuarios)))
                        {
                            Console.WriteLine("Nome: " + resultado.nome);
                            Console.WriteLine("CPF: " + resultado.cpf);
                            Console.WriteLine("E-mail: " + resultado.eMail);
                        }
                        Console.Clear();
                        break;
                    case '3':
                        Console.WriteLine("Digite o CPF da pessoa que deseja remover:");
                        string cpfRemover = Console.ReadLine();
                        Usuarios resultado2 = usuarioList.Find(p => p.cpf == cpfRemover);
                        if (!resultado2.Equals(default(Usuarios)))
                        {
                            usuarioList.Remove(resultado2);
                        }
                        Console.Clear();
                        break;
                    case '4':
                        foreach (var n in usuarioList)
                            {
                            Console.WriteLine("Nome: " + n.nome);
                            Console.WriteLine("CPF: " + n.cpf);
                            Console.WriteLine("E-mail: " + n.eMail);
                        }
                        Console.Clear();
                        break;
                    case '5':
                        Console.WriteLine("Saindo do programa...");
                        Console.Clear();
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 5) ;
        }
    }
}
