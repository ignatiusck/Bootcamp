using System;

class Program
{
    static void Main () {
        //check odd or event
        Console.WriteLine("input number : ");
        string numString = Console.ReadLine();
        int inNum = Convert.ToInt32(numString);
        string inString = "result";

        (int nums, string statuss) = check(inNum, inString);

        Console.WriteLine($"result : {nums} {statuss}");
    }

    static (int, string) check (int num, string status) {
        if(num % 2 == 0) {
            status = "even";
        } else {
            status = "odd";
        }
        return (num, status);
    }
}


// static class Program {
//     static void Main() {
//         int a = 5;
//         string b = "Hello";

//         (int c, string d) = MyMethod(a, b);
//         Console.WriteLine($"c={c}, d={d}");

//         (int, string) tuple= MyMethod(a,b);
//         Console.WriteLine($"tuple.Item1={tuple.Item1}, tuple.Item2={tuple.Item2}");
//     }

//     static (int,string) MyMethod(int a, string b) {
//         return (a, b);
//     }
// }

