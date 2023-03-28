namespace Namespace
{
    static class Program
    {
        public static void Main()
        {
            myClass classA = new(10);
            myClass classB = new(2);
            myClass classC = new(3);
            myClass classD = new(4);
            string result = classA | classB;
            //myClass result = classA + classB + (classC * classD);
            Console.WriteLine($"Result: {result}");
        }

        class myClass
        {
            public int value;
            public myClass(int value)
            {
                this.value = value;
            }

            public static myClass operator +(myClass a, myClass b)
            {
                return new myClass(a.value + b.value);
            }

            public static myClass operator -(myClass a, myClass b)
            {
                return new myClass(a.value - b.value);
            }

            public static myClass operator *(myClass a, myClass b)
            {
                return new myClass(a.value * b.value);
            }

            ////================================================================

            public static string operator >=(myClass a, myClass b)
            {
                return (a.value >= b.value).ToString();
            }
            public static string operator <=(myClass a, myClass b)
            {
                return (a.value <= b.value).ToString();
            }
            // public static string operator ==(myClass a, myClass b)
            // {
            //     return (a.value == b.value).ToString();
            // }
            // public static string operator !=(myClass a, myClass b)
            // {
            //     return (a.value != b.value).ToString();
            // }
            public static string operator &(myClass a, myClass b)
            {
                return (a.value != b.value && a.value != b.value).ToString();
            }
            public static string operator |(myClass a, myClass b)
            {
                return (a.value != b.value && a.value != b.value).ToString();
            }
        }
    }
}