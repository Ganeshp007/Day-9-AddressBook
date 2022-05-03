// See https://aka.ms/new-console-template for more information

using Day_9_AddressBook;

Console.WriteLine("---- Welcome To Address Book Application ----\n");

CreatenewContact obj = new CreatenewContact(); //creating obj of CreatenewContact class
Console.WriteLine(">>>> Enter the Details :- ");
obj.GetDetails(); //calling method which takes input from user
Console.WriteLine("\n-------------------------------------------");
Console.WriteLine("\n>>>> User Details :- \n");
obj.CreateDetails(); //calling this method to store data in List and display on console


