public class Animal
{
    protected int Legs { get; set; }
    protected bool Mamal { get; set; }
    protected string Name { get; set; }

    public Animal()
    {
        Legs = 4;
        Mamal = false;
        Name = "Bug";
    }

    public Animal(int LegCount, bool Mam, string Name_Given)
    {
        Legs = LegCount;
        Mamal = Mam;
        Name = Name_Given;
    }

    public string GetName()
    {
        return this.Name;
    }
}

public class Human : Animal
{
    public Human(int LegCount, bool Mam, string Name_Given) : base(LegCount, Mam, Name_Given)
    {

    }

}
public class Example
{

    public static void Main()
    {
        Human A = new Human(2, true, "A");
        Class2 c = new Class2();
        c.PrintStuff();
        Console.WriteLine(A.GetName());
    }
}
