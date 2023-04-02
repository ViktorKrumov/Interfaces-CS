using System;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson person = new Citizen("Peshko", 12, 1, "Nqkyde");
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

            IIdentifiable person2 = new Citizen("Peshko", 12, 1, "Nqkyde");
            Console.WriteLine(person2.Id);

            IBirthdate person3 = new Citizen("Peshko", 12, 1, "Nqkyde");
            Console.WriteLine(person3.Birthdate);

        }
    }
}
