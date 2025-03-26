using UserCRUD.models;

namespace UserCRUD.services;

public class UserService // Classe para definição dos métodos de criação, listagem  e busca de usuarios
{
    public List<User> Users = new(); // Declarando a lista a serem inseridos os usuários
    
    public void AddUser(string name, string email, int age) // Método de criação de um usuário
    {
        try
        {
            Users.Add(new User(name, age, email));
            Console.WriteLine("Usuário cadastrado com sucesso!");
        }
        
        catch (Exception) // Caso dê algum erro ao criar um usuário
        {
            Console.WriteLine("Erro ao cadastrar o usuario");
            throw;
        }
    }

    public void GetAllUsers() // Método de listagem de todos os usuários
    {
        try
        {
            if (Users.Count == 0)
            {
                Console.WriteLine("Sem usuários cadastrados."); // Caso a lista esteja vazia informa que não há usuários cadastrados
                return;
            }
            
            Console.WriteLine("Lista de usuários cadastrados:");
            Console.WriteLine("----------------------------");
                foreach (var user in Users) // For que percorre a lista inteira, ao passar para o próximo elemento imprime no console o objeto 
                    {
                        Console.WriteLine(user);
                    }
        }
        
        catch (Exception) // Caso dê algum erro na listagem de usuários
        {
            Console.WriteLine("Erro ao listar os usuarios");
            throw;
        }
    }

    public void SearchUser(string name) // Método de busca de usuários pelo nome
    {
        try
        {
            var foundUsers = Users.Where(u => u.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

            if (foundUsers.Count == 0)
            {
                Console.WriteLine("Usuário não encontrado."); // Caso não encontre nenhum usuário com o nome inserido
                return;
            }

            string wordUsers = foundUsers.Count == 1 ? " usuário" : " usuários"; // Verificando se há mais de um usuário encontrado para mostrar a palavra no singular ou no plural

            string wordFound = foundUsers.Count == 1 ? " encontrado: " : " encontrados: ";

            Console.WriteLine(foundUsers.Count + wordUsers + wordFound);

            foreach (var user in foundUsers)
            {
                Console.WriteLine(user);
            }

            Console.WriteLine();
        }

        catch (Exception) // Caso dê algum erro na busca de usarios
        {
            Console.WriteLine("Erro ao procurar o usuario");
            throw;
        }
    }
}