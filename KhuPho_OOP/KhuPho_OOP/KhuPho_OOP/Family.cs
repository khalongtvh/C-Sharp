using System;
using System.Collections.Generic;
using System.Text;

namespace KhuPho_OOP
{
    class Family
    {
        private string address;
        private List<Person> persons;

        public Family()
        {
            this.persons = new List<Person>();
        }

        public Family(string address, List<Person> persons)
        {
            Address = address;
            Persons = persons;
        }

        public void inputFamily()
        {
            Console.Write("Address: ");
            address = Console.ReadLine();
            Console.Write("Number people in family: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Person person = new Person();
                person.inputPerson();

                if (Town.check_idPersonInTown(person.ID) && check_idPersonInFamily(person.ID))
                {
                    Persons.Add(person);
                }
                else
                {
                    Console.WriteLine($"Id: {person.ID} is exist!\nEnter again");
                    i--;
                }
            }
        }

        public Boolean check_idPersonInFamily(string id)
        {
            foreach (var person in Persons)
            {
                if (person.ID.Equals(id))
                {
                    return false;
                }
            }
            return true;
        }

        public string Address { get => address; set => address = value; }

        public List<Person> Persons { get => persons; set => persons = value; }


        public void Display(string typeDisplay)
        {

            Console.WriteLine($"address: {address}");

            persons.ForEach(delegate (Person item)
                        {
                            if (typeDisplay.Equals("all"))
                            {
                                item.Display();

                            }
                            else
                            {
                                if (item.ID.Equals(typeDisplay))
                                {
                                    item.Display();
                                }
                            }
                        });
        }

    }
}
