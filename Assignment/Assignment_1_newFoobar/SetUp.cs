using static Namespace.Program;

public static class SetUp
{
    private static Dictionary<int, string> container = new Dictionary<int, string>();
    private static string result = "";

    public static void Add(int num, string inString)
    {
        container.Add(num, inString);
    }

    public static void Remove(int num, string inString)
    {
        container.Remove(num, out inString);
    }

    public static string GetData(FoobarDelegate check, int inNum)
    {
        result = "";
        for (int i = 0; i <= inNum; i++)
        {
            string inResult = $"{i}";
            int count = 0;
            foreach (KeyValuePair<int, string> item in container)
            {
                string ReturnString = check(item.Key, item.Value, i);
                if (i == 0)
                {
                    inResult = "0";
                }
                else if (count > 0 && ReturnString != "none")
                {
                    inResult += ReturnString;
                }
                else if (ReturnString != "none")
                {
                    inResult = ReturnString;
                    count++;
                }
            }
            result += $"{inResult}, ";
        }
        return result;
    }
}