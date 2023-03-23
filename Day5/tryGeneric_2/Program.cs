using System.Collections;
namespace Namespace
{
    static class Program
    {
        public static void Main()
        {
            Car? red = new();
            Console.WriteLine($"{red.name}, {red.speed}");

            red = EditCar.EditDataCar(red, "yellow");
            Console.WriteLine($"{red.name}, {red.speed}");

            int result = adding<int>(10, 5);
            Console.WriteLine(result);

        }

        public static T? adding<T>(T a, T b)
        {
            if (a is int aa && b is int bb)
            {
                return (T)(object)(aa + bb);
            }
            else
            {
                return default;
            }

        }

        internal class Car
        {
            internal string? name;
            internal int? speed;

            internal Car()
            {
                name = "none";
                speed = 0;
            }
        }

        internal class EditCar
        {
            internal string? name;
            internal int? speed;
            internal EditCar()
            {
                name = "none";
                speed = 0;
            }
            internal static Car? EditDataCar<KC, K1>(KC Cname, K1 Name)
            {
                if (Cname is Car newCname && Name is string newName)
                {
                    newCname.name = newName;
                    return newCname;
                }
                return null;
            }
        }
    }
}