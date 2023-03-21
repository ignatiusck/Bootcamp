class Program 
{
    public delegate int myDelegate(int a, int b);
    static void Main() {
        myDelegate adding = add;
        int output = adding(4, 15);

        Console.WriteLine(output);
    }

    public static myDelegate add = (a, b) => a + b;
}