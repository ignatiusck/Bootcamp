class Subscriber
{
    public string data2;
    public void message(object sender)
    {
        data2 = ((Publisher)sender).data;
        Console.WriteLine($"data : {data2}");
    }

    public void message_2(object sender)
    {
        Console.WriteLine("Text2");
    }

    // public string message(string name)
    // {
    //     return name + " 1";
    // }

    // public string message_2(string name)
    // {
    //     return name + " 2";
    // }
}