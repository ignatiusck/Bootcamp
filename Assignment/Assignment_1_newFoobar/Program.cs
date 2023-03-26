namespace Namespace
{
    public static class Program
    {
        public static void Main()
        {
            //input number
            Console.WriteLine("input a number : ");
            string? input = Console.ReadLine();
            int inNum = Convert.ToInt32(input);

            //add your setup
            SetUp.Add(3, "foo");
            SetUp.Add(5, "bar");
            SetUp.Add(7, "zoo"); //examle

            //get result
            Console.WriteLine("List : ");
            FoobarDelegate check = FooBar.fooBar;
            string result = SetUp.GetData(check, inNum);

            Console.WriteLine(result);
        }

        public delegate string FoobarDelegate(int num, string word, int inNum);
    }
}