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