class Program
{
    public static void Main()
    {
        Calculator cal = new();
        Notif notify = new();

        cal.Completed += notify.proccesCompletetd;

        // cal.add(10, 6);
        // cal.sub(10, 2);

        cal.MultiplyerProcces();
    }

    public delegate void myDelegate(int a, int b);

    public delegate void EventHandlerCal(object sender, EventArgs e);

    class Calculator
    {
        // public myDelegate add = (a, b) => Console.WriteLine($"{a + b}");
        // public myDelegate sub = (a, b) => Console.WriteLine($"{a - b}");
        public event EventHandlerCal Completed;
        public void MultiplyerProcces()
        {
            Console.WriteLine("multipliying completetd.");
            Completed(this, EventArgs.Empty);
        }
    }

    class Notif
    {
        public void proccesCompletetd(object sender, EventArgs e)
        {
            Console.WriteLine("oke completed.");
        }
    }

}