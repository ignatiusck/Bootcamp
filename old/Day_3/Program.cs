using IAnimals;

class Program
{
    static void Main () {
        Console.WriteLine("Input the food!");
        string food = Console.ReadLine();

        Cat memong = new Cat("memong", 6, food);

        switch (food)
        {
            case "fish" :
                memong.eat(food);
                Console.WriteLine("Meow meouw.. :)");
                break;
            default:
                memong.eat(food);
                memong.meouw();
                break;
        }
        
    }

}
class Animal
{
    public string name;
    public int age;
    public string animal;

    public Animal() {
        this.name = "none";
        this.age = 0;
        this.animal = "mone";
    }
}

class Cat : Animal, IAnimals.IEat, IAnimals.ISound
{
    public Cat(string name, int age, string animal) {
        this.name = name;
        this.age = age;
        this.animal = animal;
    }

    public void eat(String food) {
        
        Console.WriteLine("let's eat " + food);
    }
    public int eatCount(int count) {
        return count;
    }

    public void meouw () {
        Console.WriteLine("Meow...");
    }
    public void bark () {
        Console.WriteLine("Hug hug...");
    }
}