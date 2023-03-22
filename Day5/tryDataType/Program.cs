static class Program
{
    static void Main()
    {
        dynamic data = 1;
        data = "nama";

        Console.WriteLine($"{Animals.bird}");
    }

    enum Animals
    {
        Cat,
        dog,
        bird
    }
}