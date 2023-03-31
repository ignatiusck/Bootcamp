class Program
{
    public delegate int calculate(int a, int b);
    public calculate add = (a, b) => a + b;
    public static void Main()
    {
        Program prog = new();
        int result = prog.add(2, 4);
        Console.WriteLine(result);

        Calculator cal = new("apple");

        cal.print(() => prog.add(2, 5));

        result = cal.sub(2, 4);
        Console.WriteLine(result);

        cal.Name = "";
        Console.WriteLine(cal.Name);
    }

    public class Calculator
    {
        public string name;
        public string Name
        {
            get => name + " oke";
            set
            {
                if (value != "oke")
                {
                    name = value;
                }
                else
                {
                    name = "Good";
                }
            }
        }

        public Calculator(string name)
        {
            this.name = name;
        }

        internal void print(Func<int> value)
        {
            Console.WriteLine(value.Invoke());
        }

        public calculate sub = (a, b) => a - b;
    }
}
