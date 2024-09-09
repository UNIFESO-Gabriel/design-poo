public abstract class Animal
{
    protected string nome;
    public abstract void Comer();

    public Animal(string name)
    {
        nome = name;
    }
}

public class Leao : Animal
{
    public Leao(string name) : base(name) { }

    public override void Comer()
    {
        Console.WriteLine($"{nome} come carne!");
    }
}

public class Rato : Animal
{
    public Rato(string name) : base(name) { }
    
    public override void Comer()
    {
        Console.WriteLine($"{nome} come de tudo!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Animal simba = new Rato("Mickey");
        simba.Comer();
    }
}
