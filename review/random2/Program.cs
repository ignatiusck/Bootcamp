using System;
class Program
{
    public static void Main()
    {
        // calculator operasion = Operators.sum;
        // operasion += Operators.sub;

        // int result = operasion.Invoke(10, 5);
        // Console.WriteLine(result);

        // Operator.completedCal += Operators.sub;
        // Operator.completedCal += Operators.sum;

        // Operator.start();

        // Console.WriteLine($"{Operator.result}");

        int a = 7;
        int b = 7;
        string c = "7";
        string aa = "hello";
        string bb = "hello";
        string e = "1 1";
        Console.WriteLine(aa.Equals(bb));
        Console.WriteLine(aa == bb);
        Console.WriteLine(0 == null);
        Int32.TryParse(c, out int d);
        //int.Parse(e);

        var chan = ("chan", 91);

        Dictionary<string, string> dict = new();
        dict.TryAdd("1", "aa");

        Console.WriteLine($"Text");
        Operator.comp(() => "2" + "2");

        //Operat.name();\
    }

    public delegate int calculator(int a, int b);

    static public class Operator
    {
        public static event calculator completedCal;
        public static int result;
        public static string rest;

        public static void start()
        {
            Console.WriteLine($"rendering done.");

            Thread.Sleep(1000);

            result = completedCal.Invoke(10, 9);
        }

        public static void comp(Func<string> a)
        {
            rest = a();
            Console.WriteLine($"{rest}");

        }
    }

    static class Operators
    {
        public static int sum(int a, int b)
        {
            return a + b;
        }

        public static int sub(int a, int b)
        {
            return a - b;
        }
    }

    abstract class Class
    {
        public abstract void name();
    }

    abstract class Operatorss : Class, Inameyeh
    {
        public override void name()
        {
            throw new NotImplementedException();
        }

        public void names(int a)
        {
            throw new NotImplementedException();
        }
    }


    interface Inameyeh
    {
        void names(int a);
    }
}

class Operat
{
    public static void name()
    {
        throw new NotImplementedException();
    }
}