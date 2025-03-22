using System;
using UserCRUD.services;

class Program
{
    static void Main()
    {
        UserService userService = new UserService();
        
        while (true)
        {
            Console.WriteLine("----- Menu -----");
            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Listar usuários");
            Console.WriteLine("3 - Buscar usuário pelo nome");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            Console.WriteLine();

            string choice = Console.ReadLine() ?? "";
            
            switch (choice)
            {
                case "1":
                    Console.Write("Insira o Nome: ");
                    string name = Console.ReadLine() ?? "";
                    Console.Write("Insira o Email: ");
                    string email = Console.ReadLine() ?? "";
                    Console.Write("Insira a Idade: ");
                    if (!int.TryParse(Console.ReadLine(), out int age))
                    {
                        Console.WriteLine("Idade inválida! Tente novamente.");
                        break;
                    }
                    
                    userService.AddUser(name, email, age);
                    break;

                case "2":
                    userService.GetAllUsers();
                    break;

                case "3":
                    Console.Write("Digite o nome a ser buscado: ");
                    string searchName = Console.ReadLine() ?? "";
                    userService.SearchUser(searchName);
                    break;

                case "0":
                    Console.WriteLine("Encerrando o programa...");
                    return;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente");
                    break;
            }
        }
    }
}