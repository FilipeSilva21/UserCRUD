using System;
using System.Collections.Generic;
using System.Linq;
using UserCRUD.models;

namespace UserCRUD.services;

public class UserService
{
    public List<User> Users = new();
    
    public void AddUser(string name, string email, int age)
    {
        try
        {
            Users.Add(new User(name, age, email));
            Console.WriteLine("Usuário cadastrado com sucesso!");
        }
        
        catch (Exception runTimeException)
        {
            Console.WriteLine("Erro ao cadastrar o usuario");
            throw;
        }
    }

    public void GetAllUsers()
    {
        try
        {
            if (Users.Count == 0)
            {
                Console.WriteLine("Sem usuários cadastrados.");
                return;
            }
            Console.WriteLine("Lista de usuários cadastrados:");
            Console.WriteLine("----------------------------");

            foreach (var user in Users)
            {
                Console.WriteLine(user);
            }
        }
        
        catch (Exception runTimeException)
        {
            Console.WriteLine("Erro ao listar os usuarios");
            throw;
        }
    }

    public void SearchUser(string name)
    {
        try
        {
            var foundUsers = Users.Where(u => u.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

            if (foundUsers.Count == 0)
            {
                Console.WriteLine("Usuário não encontrado.");
                return;
            }

            string wordUsers = foundUsers.Count == 1 ? " usuário" : " usuários";
            
            string wordFound = foundUsers.Count == 1 ? " encontrado: " : " encontrados: ";
            
            Console.WriteLine(foundUsers.Count + wordUsers + wordFound);

            foreach (var user in foundUsers)
            {
                Console.WriteLine(user);
            }

            Console.WriteLine();
        }

        catch (Exception runTimeException)
        {
            Console.WriteLine("Erro ao procurar o usuario");
            throw;
        }
    }
}