public class Publisher
{
    //public delegate void Container(object sender, EventArgs e);
    public EventHandler OnPublish;

    public void AddSubscribe(EventHandler subscriber)
    {
        OnPublish += subscriber;
        Console.WriteLine("New Subsriber added");
    }

    public void Run()
    {
        EventArgs e = new();
        OnPublish.Invoke(this, e);
    }
}
