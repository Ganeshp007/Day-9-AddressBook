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
            Console.WriteLine("PinCode : " + person.PinCode);
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

        public static void EditConatact()
        {
            if (People.Count != 0)
            {

                Console.Write("Enter the contact Name to modify details :- ");
                string Modified = Console.ReadLine();
                foreach (var person in People)
                {
                    if (person.FirstName.ToUpper() == Modified.ToUpper())
                    {
                        while (true)
                        {
                            Console.WriteLine("Which details You want to Modify :- ");
                            Console.WriteLine("Enter 1 to Change First name ");
                            Console.WriteLine("Enter 2 to Change Last name ");
                            Console.WriteLine("Enter 3 to Change Address ");
                            Console.WriteLine("Enter 4 to Change City ");
                            Console.WriteLine("Enter 5 to Change State ");
                            Console.WriteLine("Enter 6 to Change Pincode ");
                            Console.WriteLine("Enter 7 to Change Phone Number ");
                            Console.WriteLine("Enter 8 to Exit ");
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
                                    Console.WriteLine("Enter the New Phone Number: ");
                                    person.PhoneNum = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the New Address: ");
                                    person.Addresses = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the New City: ");
                                    person.City = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter the New State: ");
                                    person.State = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter the New PinCode: ");
                                    person.PinCode = Console.ReadLine();
                                    break;
                                case 8:
                                    return;

                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("\n>> There is No Such Conatact with this Name..!!!\n");
                    }

                }

            }

            else
            {
                Console.WriteLine(">> You Dont have any contact in your AddressBook..!!!\n");
            }


        }


        public static void DeletePeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("\n>> Your Address Book is Empty...\n");
                return;
            }
            else
            {
                Console.Write("Enter the first name of contact you want to delete :- ");
                string Remove = Console.ReadLine();

                foreach (var person in People.ToList())
                {
                    if (person.FirstName.ToUpper() == Remove.ToUpper())
                    {
                        People.Remove(person);
                        Console.WriteLine("\n>> Contact deleted from AddressBook successfully....\n");
                    }
                    else
                    {
                        Console.WriteLine("\n>> Contact with this name is not present in AddressBook...");
                    }
                }
            }

        }



    }
}
