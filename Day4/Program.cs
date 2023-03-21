using System;
class Program
{
    static void Main () {
        Shape circle = new Shape();

        string input = circle.circles("circle");
        Console.WriteLine(input);

        int x = 9;
        int y = 11;
        circle.tryRef(ref x);
        Console.WriteLine(x);

        int z = circle.tryIn(in x);
        Console.WriteLine(x);
        
        circle.tryOut(out y);
        Console.WriteLine(z);
    }

    class Shape
    {   
        public string shape {get; set;}

        public string circles (string shape) => shape;

        public void tryRef (ref int dir) {
           dir++;
        }

        public void tryOut (out int dirs) {
            dirs = 0;
            dirs++;
        }

        public int tryIn (in int dir) {
            return dir + 2;
        }
    }
}
