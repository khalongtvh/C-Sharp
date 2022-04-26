using System;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat_229 = new Cat();
            cat_229.AnimalSound();
            cat_229.Eat();
            cat_229.run();

            Bird b_229 = new Bird();
            b_229.AnimalSound();
            b_229.Eat();
            b_229.fly();
        }
    }
}
