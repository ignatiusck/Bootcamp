class Program
{
    public static void Main()
    {
        Console.WriteLine("Perth".IsCapitalized());
        StringHelper.IsCapitalized("name");
        int age = 112;
        if (age.IsHigher())
        {
            Console.WriteLine("oke");
        }
        "name".First();

        object foo() => new { name = "bob", age = 6 };
        Console.WriteLine(foo);

    }
}
public static class StringHelper
{
    public static bool IsCapitalized(this string s)
    {
        if (string.IsNullOrEmpty(s)) return false;
        return char.IsUpper(s[0]);
    }

    public static bool IsHigher(this int c)
    {
        if (c < 10) return true;
        return false;
    }

    public static T First<T>(this IEnumerable<T> sequence)
    {
        foreach (T element in sequence)
            return element;
        throw new InvalidOperationException("No elements!");
    }

}

class Myclass
{
    public void getName()
    {

    }
}
