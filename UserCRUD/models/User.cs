namespace UserCRUD.models;

public class User
{
    public string name { get; set; }
    
    public int age { get; set; }

    public string email { get; set; }

    public User(string name, int age, string email)
    {
        this.name = name;
        this.age = age;
        this.email = email;
    }
    
    public override string ToString()
    {
        return $"Nome: {name}, Email: {email}, Idade: {age}";
    }
}