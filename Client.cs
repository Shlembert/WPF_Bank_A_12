public class Client
{
    public string Name { get; set; }
    public List<Account> Accounts { get; set; } = new List<Account>();

    public Client(string name)
    {
        Name = name;
    }

    // Пустой конструктор для сериализации
    public Client() { }

    public override string ToString()
    {
        return Name;
    }
}
