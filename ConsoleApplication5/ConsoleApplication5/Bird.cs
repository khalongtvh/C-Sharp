using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication5
{
    public class Bird : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Con chim kêu quạt quạt");
        }

        public override void Eat()
        {
            Console.WriteLine("Con chim ăn hạt");
        }

        public void fly()
        {
            Console.WriteLine("Con chim biết bay");
        }
    }
}
