// See https://aka.ms/new-console-template for more information

using Day_9_AddressBook;

Console.WriteLine("---- Welcome To Address Book Application ----\n");

int choice=0;

while(choice!=6)
{

    Console.WriteLine("Choose the Operation:- \n1.Create Addressbook \n2.Add New Contact\n3.Modify Existing Contact\n4.Delete Existing Contact\n5.Display AddressBook Details\n6.Exit\n");
    Console.Write("Enter the choice :- ");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
        {
            case 1:
                Console.WriteLine("\n>>>> Enter the Details :- ");
                AddressBook.GetCustomer(); //calling method which takes input from user
                Console.WriteLine("\nContact Added Successfully...\n");
                break;

            case 2:
                Console.WriteLine("\n>>>> Enter the Details :- ");
                AddressBook.AddContact(); //calling method which takes input from user
                break;

            case 3:
                Console.WriteLine("\n>>>> Modify Contact Details :-\n");
                AddressBook.EditConatact();
                break;
            
            case 4:
                Console.WriteLine("\n>>>> Delete Contact :-\n");
                AddressBook.DeletePeople();
                break;

            case 5:
                Console.WriteLine("\n>>>> Address Book Details :-\n");
                AddressBook.ListingPeople();
                break;

        default:
            if (choice >= 5)
            {
                Console.WriteLine("\n>> Please Enter valid choice.....\n");
            }
            else
            {
                Console.WriteLine("\n------ Thank You ------");
            }
            
                break;     
        

        }

}

