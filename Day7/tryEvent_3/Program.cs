class Program
{
    public static void Main()
    {
        Subcriber subscriber = new();
        Publisher publisher = new();

        publisher.AddSubscribe(subscriber.message);

        publisher.Run();
    }
}