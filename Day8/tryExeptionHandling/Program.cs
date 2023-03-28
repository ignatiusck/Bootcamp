class Program
{
    public static void Main()
    {
        try
        {
            try
            {
                int a = 0;
                int b = 10;
                int c = b / a;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception Caught!");
            }

        }
        // catch (InvalidOperationException)
        // {
        //     //e = new("Exception");
        //     //Console.WriteLine(e.Message);
        // }
        catch (Exception e)
        {
            Console.WriteLine(e.Data.ToString());
        }
        finally
        {
            Console.WriteLine("finally");
        }
    }
}
