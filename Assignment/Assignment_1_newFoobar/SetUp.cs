using SetContainer;
using System.Collections;
using static Namespace.Program;

public static class SetUp
{
    private static ArrayList container = new();
    private static string result = "";

    public static void Add(int num, string inString)
    {
        SetContainers model = new() { inNum = num, inString = inString };
        container.Add(model);
    }

    public static string GetData(FoobarDelegate check, int inNum)
    {
        for (int i = 0; i <= inNum; i++)
        {
            string inResult = $"{i}";
            int count = 0;
            foreach (SetContainers item in container)
            {
                SetContainers setup = (SetContainers)item;
                string ReturnString = check(setup.inNum, setup.inString, i);
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