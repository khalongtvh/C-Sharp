using System;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.AnimalSound();
            cat.Eat();
            cat.run();

            Bird b = new Bird();
            b.AnimalSound();
            b.Eat();
            b.fly();
        }
    }
}
