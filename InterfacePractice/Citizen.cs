using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{
    class Citizen : IPerson, IIdentifiable, IBirthdate
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int Id { get; set; }

        public string Birthdate { get; set; }

        public Citizen(string name, int age, int id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }
        //public override string ToString()
        //{
        //    StringBuilder str = new StringBuilder();
        //    str.Append(String.Format($"Name: {Name}, Age: {Age}, Id: {Id}, Birthdate: {Birthdate}"));
        //    return str.ToString();
        //}
    }
}
