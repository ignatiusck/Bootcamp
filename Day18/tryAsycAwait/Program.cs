using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        int result = await AddTask(4, 5);
        Console.WriteLine($"{result}");
    }

    static async Task<int> AddTask(int x, int y)
    {
        await Task.Delay(1000);
        return x + y;
    }
}