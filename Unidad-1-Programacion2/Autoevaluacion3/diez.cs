

ISerializable[] items = [new User("Alice"), new Product(101)];

foreach (var item in items)
{
    item.Serialize(); // ejemplo
}

class User : ISerializable
{
    private string name;

    public User(string name)
    {
        this.name = name;
    }

    public string Serialize()
    {
        return $"User: {this.name}";
    }
}

class Product : ISerializable
{
    private double id;

    public Product(double id)
    {
        this.id = id;
    }

    public string Serialize()
    {
        return $"Product: {this.id}";
    }
}