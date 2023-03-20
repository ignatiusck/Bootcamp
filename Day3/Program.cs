class Program
{
    static void Main() {
        Cat memong = new Cat();

        memong.meow();
        Console.WriteLine(memong.foodCount<int>(2));
    }

    abstract class Animal
    {
        public string name;

        public Animal () {
            name = "none";
        }

        public virtual void meow() {
            Console.WriteLine("okeh");
        }

        public abstract DT foodCount<DT> (DT food);
    }

    class Cat : Animal
    {
        public override void meow () {
            Console.WriteLine("meow");
        }

        public override DT foodCount<DT> (DT food) {
            return food;
        }
    }
}