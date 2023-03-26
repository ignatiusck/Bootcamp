public static class FooBar
{
    public static string fooBar(int num, string word, int inNum)
    {
        if (inNum % num == 0) return word;
        return "none";
    }
}
