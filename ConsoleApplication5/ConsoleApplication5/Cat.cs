using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication5
{
    public class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine(" Mèo kêu mew mew. ");
        }
        public override void Eat()
        {
            Console.WriteLine(" Mèo ăn cơm.");
        }

        public void run()
        {
            Console.WriteLine("Mèo chạy 4 chân");
        }

    }
}
