using System.Globalization;
using System.Text;
class Program
{
    public static void Main(string[] args)
    {
        // try to uppercase
        string data = "Hello World";
        Console.WriteLine($"{data.ToLower()}");
        Console.WriteLine($"{data.ToUpper()}");

        //try split
        string[] parsed = data.Split();
        for (int i = 0; i < parsed.Length; i++)
        {
            Console.Write($"{parsed[i]}, ");
        }

        //string builder
        Console.WriteLine();
        StringBuilder strBuilder = new("namespace, namespace");
        strBuilder.Append(" hello world new");
        Console.WriteLine($"{strBuilder}");
        strBuilder.Clear();
        strBuilder.Append("hello world new2");
        Console.WriteLine($"{strBuilder}");

        //isControl?
        int D = 0x0005;
        char result = Convert.ToChar(D);
        Console.WriteLine($"{result}");

        //timespan
        TimeSpan time1 = TimeSpan.FromHours(1);
        Console.WriteLine($"{time1}");

        //datetime
        DateTime today = DateTime.Now;
        Console.WriteLine($"{today}");
        DateTime create = new(2022, 2, 28, 0, 9, 2);
        Console.WriteLine($"{create}");

        //format
        NumberFormatInfo f = new NumberFormatInfo();
        f.CurrencySymbol = "$$";
        Console.WriteLine(3.ToString("C", f)); // $$ 3.00
                                               // ------- //
        int value = 123456;
        string template = "The value is {0:E}.";
        string results = string.Format(new CultureInfo("en-US"), template, value);
        Console.WriteLine(results); //"The value is $123,456.00."

        //parse and try parse
        string number = "101";
        int num;
        int resultss;
        if (int.TryParse(number, out num))
        {
            resultss = num;
            Console.WriteLine($"{resultss}");
        }
        else
        {
            Console.WriteLine("failed to parse");
        }
        string number2 = (int.Parse(number)).ToString();
        Console.WriteLine($"without try {number2}");

        //convert result
        long numbers = 100;
        string numstring = numbers.ToString();
        Console.WriteLine(numstring);
        int numInt = Convert.ToInt32(numstring);
        Console.WriteLine(numInt);
    }
}
