// See https://aka.ms/new-console-template for more information

using Day_9_AddressBook;

Console.WriteLine("---- Welcome To Address Book Application ----\n");

int choice=0;

while(choice!=5)
{

    Console.WriteLine("Choose the Operation:- \n1.Create Contact \n2.Add New Contact\n3.Modify Contact\n4.Display Address_Book\n5.Exit");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
        {
            case 1:
                Console.WriteLine(">>>> Enter the Details :- ");
                AddressBook.GetCustomer(); //calling method which takes input from user
                Console.WriteLine("\nContact Added Successfully...\n");
                break;

            case 2:
                Console.WriteLine(">>>> Enter the Details :- ");
                AddressBook.GetCustomer(); //calling method which takes input from user
                Console.WriteLine("\nConatact Added Successfully....\n");
                break;

            case 3:
                Console.WriteLine(">>>> Modify Contact Details :-\n");
                AddressBook.Modify();
                break;



            case 4:
                Console.WriteLine(">>>> Address Book Details :-\n");
                AddressBook.ListingPeople();
                break;




            default: 
                Console.WriteLine(">> Please Enter valid choice.....\n");
                break;     
        

        }

}

