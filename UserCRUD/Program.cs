using System;
using UserCRUD.services;

class Program
{
    static void Main()
    {
        UserService userService = new UserService(); // Injetando/importando o UserService
        
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
                case "1": // Caso seja selecionado para adicionar um novo usuário 
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

                case "2": // Caso seja selecionado para listar todos os usuários
                    userService.GetAllUsers();
                break;

                case "3": // Caso seja selecionado para buscar um usuário pelo nome
                    Console.Write("Digite o nome a ser buscado: ");
                    string searchName = Console.ReadLine() ?? "";
                    userService.SearchUser(searchName);
                break;

                case "0": // Caso seja selecionado para encerrar o programa
                    Console.WriteLine("Encerrando o programa...");
                return;

                default: // Caso não seja selecionada uma opção válida
                    Console.WriteLine("Opção inválida! Tente novamente");
                break;
            }
        }
    }
}