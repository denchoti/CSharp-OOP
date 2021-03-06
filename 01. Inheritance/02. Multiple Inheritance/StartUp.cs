using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Puppy doggie = new Puppy();
            doggie.Eat();
            doggie.Bark();
            doggie.Weep();
        }
    }
}
