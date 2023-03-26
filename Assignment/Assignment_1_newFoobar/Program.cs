namespace Namespace
{
    public static class Program
    {
        public static void Main()
        {
            //Input number
            Console.WriteLine("input a number : ");
            string? input = Console.ReadLine();
            int inNum = Convert.ToInt32(input);
            Console.WriteLine();

            //Add config setup
            SetUp.Add(3, "foo");
            SetUp.Add(5, "bar");
            SetUp.Add(7, "zoo"); //examle

            //Get result
            Console.WriteLine();
            Console.WriteLine("List : ");
            FoobarDelegate check = FooBar.fooBar;
            string result = SetUp.GetData(check, inNum);
            Console.WriteLine(result);

            //Remove config
            Console.WriteLine();
            SetUp.Remove(3, "foo");

            //Get Result
            Console.WriteLine("After Remove List : ");
            result = SetUp.GetData(check, inNum);
            Console.WriteLine(result);
        }

        public delegate string FoobarDelegate(int num, string word, int inNum);
    }
}