using System;

namespace KhuPho_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Town town = new Town();
            Console.Write("So luong ho gia dinh: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Family family = new Family();

                family.inputFamily();

                town.addFamily(family);
            }
            town.Display();
        }
    }
}
