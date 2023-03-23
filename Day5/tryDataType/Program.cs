static class Program
{
    static void Main()
    {
        dynamic data = 1;
        data = "nama";

        Console.WriteLine($"{Animals.bird}");

        foreach (Animals item in Enum.GetValues(typeof(Animals)))
        {
            Console.WriteLine($"{item}");
        }

        int enums = (int)Animals.bird;
        Console.WriteLine($"{enums}");

    }

    public enum Animals
    {
        Cat,
        dog,
        bird
    }
}