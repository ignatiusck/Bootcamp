using System;
static class Program
{
    static void Main()
    {
        var yellow = new Lambo() { name = "yellow", speedCal = 100 };

        yellow.specDisplay(yellow);

        (string name, int speedCal) = yellow.specDisplay<string, int>("yellow", 500);

        Console.WriteLine($"{name} , {speedCal}");

        Console.WriteLine("hello world");
    }

    public abstract class Car
    {
        public string name { get; set; }
        public int speedCal { get; set; }

        public Car()
        {
            name = "none";
            speedCal = 0;
        }

        public Car(string name, int speedCal)
        {
            this.name = name;
            this.speedCal = speedCal;
        }

        public abstract (T1, T2) specDisplay<T1, T2>(T1 name, T2 speedCal);
        public abstract void specDisplay(Lambo lambo);
    }

    public class Lambo : Car
    {
        public override (T1, T2) specDisplay<T1, T2>(T1 name, T2 speedCal)
        {
            return (name, speedCal);
        }

        public override void specDisplay(Lambo lambo)
        {
            Console.WriteLine($"{lambo.name}, {lambo.speedCal}");
        }
    }
}