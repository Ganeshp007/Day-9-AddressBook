using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_AddressBook
{
    internal class AddressBook
    {
        public static List<Person> People = new List<Person>();
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Addresses { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string PinCode { get; set; }
            public string PhoneNum { get; set; }
            public string Email_Id { get; set; }
        }
        public static void GetCustomer()
        {
            Person person = new Person();

            Console.Write("\nEnter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("\nEnter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("\nEnter Address : ");
            person.Addresses = Console.ReadLine();

            Console.Write("\nEnter City : ");
            person.City = Console.ReadLine();

            Console.Write("\nEnter State : ");
            person.State = Console.ReadLine();

            Console.Write("\nEnter ZipCode: ");
            person.PinCode = Console.ReadLine();

            Console.Write("\nEnter Phone Number: ");
            person.PhoneNum = Console.ReadLine();

            Console.Write("\nEnter EmailId: ");
            person.Email_Id = Console.ReadLine();

            People.Add(person);
        }
        public static void PrintCustomer(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Address : " + person.Addresses);
            Console.WriteLine("City : " + person.City);
            Console.WriteLine("State : " + person.State);
            Console.WriteLine("ZipCode : " + person.PinCode);
            Console.WriteLine("Phone Number: " + person.PhoneNum);
            Console.WriteLine("Email Id: " + person.Email_Id);
            Console.WriteLine("-------------------------------------------");
        }
        
        public static void AddContact()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("\n>> You have to create Address Book First...\n");
                return;
            }
            else
            {
                GetCustomer();
                Console.WriteLine("\nConatact Added Successfully....\n");
            }
        }
        public static void ListingPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("\n>> Your Address Book is Empty...\n");
                return;
            }
           
            foreach (var person in People)
            {
                PrintCustomer(person);
            }
            Console.WriteLine("\n>> Press Enter to continue...\n");
            Console.ReadKey();
        }


    }
}
