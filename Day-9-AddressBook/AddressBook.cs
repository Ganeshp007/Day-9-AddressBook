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

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Address : ");
            person.Addresses = Console.ReadLine();

            Console.Write("Enter City : ");
            person.City = Console.ReadLine();

            Console.Write("Enter State : ");
            person.State = Console.ReadLine();

            Console.Write("Enter ZipCode: ");
            person.PinCode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNum = Console.ReadLine();

            Console.Write("Enter EmailId: ");
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
        public static void Modify()
        {
            if (People.Count != 0)
            {
                Console.WriteLine("Enter the First Name of contact to modify its Properties :");
                string Modified = Console.ReadLine();
                foreach (var person in People)
                {
                    if (person.FirstName.ToUpper() == Modified.ToUpper())
                    {
                        while (true)
                        {
                            Console.WriteLine("Choose Operation to Perform : ");
                            Console.WriteLine("1.Change First name ");
                            Console.WriteLine("2.Change Last name ");
                            Console.WriteLine("3.Change Address ");
                            Console.WriteLine("4.Change City");
                            Console.WriteLine("5.Change State ");
                            Console.WriteLine("6.Change Pincode ");
                            Console.WriteLine("7.Change Phone Number");
                            Console.WriteLine("8.Exit ");
                            int Check = Convert.ToInt32(Console.ReadLine());
                            switch (Check)
                            {
                                case 1:
                                    Console.WriteLine("Enter the New First Name: ");
                                    person.FirstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the New Last Name: ");
                                    person.LastName = Console.ReadLine();
                                    break;
                              
                                case 3:
                                    Console.WriteLine("Enter the New Address: ");
                                    person.Addresses = Console.ReadLine();
                                    break;

                                case 4:
                                    Console.WriteLine("Enter the New City: ");
                                    person.City = Console.ReadLine();
                                    break;

                                case 5:
                                    Console.WriteLine("Enter the New State: ");
                                    person.State = Console.ReadLine();
                                    break;

                                case 6:
                                    Console.WriteLine("Enter the New Pin Code: ");
                                    person.PinCode = Console.ReadLine();
                                    break;

                                case 7:
                                    Console.WriteLine("Enter the New Phone Number: ");
                                    person.PhoneNum = Console.ReadLine();
                                    break;

                                case 8:
                                    return;

                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine(">> There is No Such Contact with such First Name...");
                    }

                }


            }
        }

        public static void ListingPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine(">> Address Book is Empty...");
                Console.ReadKey();
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
