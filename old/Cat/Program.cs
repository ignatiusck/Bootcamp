class Program
{
    static void Main () 
    {
        Cats memong = new Cats("memong", 4);
        Cats memong2 = new Cats("memong 2", 7);

        Console.WriteLine(memong.name);
    }
}

 class Cats
{
    public string name;
    public int age;

    public Cats(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}