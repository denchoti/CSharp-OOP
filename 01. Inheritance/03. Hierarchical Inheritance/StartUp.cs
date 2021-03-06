using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog doggie = new Dog();
            doggie.Eat();
            doggie.Bark();

            Cat kitty = new Cat();
            kitty.Eat();
            kitty.Meow();

        }
    }
}
