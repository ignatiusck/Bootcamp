class Publisher
{
    public delegate void container(object publisher);
    public event container eventContainer;
    //public event EventHandler eventContainer2;
    public string data;

    public void Add(container sub)
    {
        eventContainer += sub;
        Console.WriteLine("new subcriber added");
    }

    public void run()
    {
        data = "rice";
        eventContainer?.Invoke(this);
    }
}