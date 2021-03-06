using System;

namespace Zoo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var animal = new Animal("Buni");
            Console.WriteLine(animal.Name);
        }
    }
}
