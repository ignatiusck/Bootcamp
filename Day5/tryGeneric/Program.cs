using System;
static class Program
{
    static void Main()
    {
        var yellow = new Lambo<string, int>("yellow", 100);

        //Change speed, with tuple
        (string name, int speedCal) = yellow.specDisplay("yellow", 500);
        Console.WriteLine($"{name} , {speedCal}");

        //Change name, with create new object
        var returnClass = new ReturnClass<string, int, Lambo<string, int>>();
        var red = returnClass.ChangeName(yellow, "red");
        Console.WriteLine($"{red.name} , {red.speedCal}");
    }

    public class Car<T1, T2>
    {
        public T1 name { get; set; }
        public T2 speedCal { get; set; }

        public Car(T1 name, T2 speedCal)
        {
            this.name = name;
            this.speedCal = speedCal;
        }
    }

    public class Lambo<T1, T2> : Car<T1, T2>
    {
        public Lambo(T1 name, T2 speedCal) : base(name, speedCal)
        {
            this.name = name;
            this.speedCal = speedCal;
        }

        public (T1, T2) specDisplay(T1 name, T2 speedCal)
        {
            return (name, speedCal);
        }
    }

    public class ReturnClass<T1, T2, T>
    {
        public Lambo<string, int>? ChangeName(T lambo, T1 name)
        {
            if (lambo is Lambo<string, int> car && name is string newName)
            {
                car.name = newName;
                return car;
            }
            Console.WriteLine($"input invalid.");
            return default;
        }
    }
}

