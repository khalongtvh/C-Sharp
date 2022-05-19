using System;
using System.Collections.Generic;
using System.Text;

namespace KhuPho_OOP
{
    class Person
    {
        //Với mỗi cá nhân, người ta quản lý các thông tin sau: Họ tên, Tuổi, Nghề nghiệp, số chứng minh nhân dân
        private string name;
        private int age;
        private string job;
        private string id;

        public Person()
        {
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Job { get => job; set => job = value; }
        public string ID { get => id; set => id = value; }

        public void inputPerson()
        {
            Console.Write("id : ");
            id = Console.ReadLine();
            Console.Write("name : ");
            name = Console.ReadLine();
            Console.Write("age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("job : ");
            job = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine($"id: {id} name : {name} age: {age} job: {job}");
        }

    }
}
