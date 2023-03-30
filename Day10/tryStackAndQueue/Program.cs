using System.Collections;
class Program
{
    public static void Main()
    {
        Stack stack = new Stack();
        stack.Push("A");
        stack.Push(2);
        stack.Push("C");
        stack.Push(4);
        stack.Push("E");
        Console.Write("stack: ");
        foreach (var item in stack)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
        Console.WriteLine(stack.Peek());

        Console.WriteLine();
        Console.Write("queued: ");
        Queue queue = new Queue();
        queue.Enqueue("A");
        queue.Enqueue(2);
        queue.Enqueue("C");
        queue.Enqueue(4);
        queue.Enqueue("E");

        foreach (var item in queue)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
        Console.WriteLine(queue.Peek());

        Stack<string> stackStrings = new Stack<string>();
        stackStrings.Push("A");
        stackStrings.Push("B");
        stackStrings.Push("C");
        stackStrings.Push("D");
        stackStrings.Push("E");

        foreach (var item in stackStrings)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine();
    }
}