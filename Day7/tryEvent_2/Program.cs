class Program
{
    public static void Main()
    {
        Subscriber subscriber = new();
        Publisher publisher = new();

        publisher.Add(subscriber.message);
        publisher.Add(subscriber.message_2);

        publisher.run();
    }
}
