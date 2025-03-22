namespace UserCRUD.models;

public class User
{
    public string Name { get; set; }
    
    public int Age { get; set; }

    public string Email { get; set; }

    public User(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }
    
    public override string ToString()
    {
        return $"Nome: {Name}, Email: {Email}, Idade: {Age}";
    }
}