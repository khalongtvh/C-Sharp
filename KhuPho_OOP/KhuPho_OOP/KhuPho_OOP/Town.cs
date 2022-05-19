using System;
using System.Collections.Generic;
using System.Text;

namespace KhuPho_OOP
{
    class Town
    {
        private static List<Family> families= new List<Family>();

        public Town()
        {
        }

        public List<Family> Families { get => families; set => families = value; }

        public static Boolean check_idPersonInTown(string id)
        {
            foreach (var family in families)
            {
                foreach (var person in family.Persons)
                {
                    if (person.ID.Equals(id))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void addFamily(Family family)
        {
            Families.Add(family);
        }
        

        public void Display()
        {
            Console.WriteLine("so ho gia dinh " + families.Count);
            families.ForEach(delegate (Family item)
            {
                item.Display();
            });
        }
    }
}
