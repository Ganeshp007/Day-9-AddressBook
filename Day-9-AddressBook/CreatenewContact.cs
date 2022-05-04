using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_AddressBook
{
    internal class CreatenewContact
    {
        //Init Local variables
        public String FirstName;
        public String LastName;
        public String Email_Id;
        public String PhoneNumber;
        public String Address;
        public String City;
        public String State;
        public String ZipCode;

        public CreatenewContact(String FirstName,String LastName,String Email_Id,String PhoneNumber,String Address,String City,String State,String ZipCode)
        { 
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email_Id = Email_Id;   
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;

        }
      

        public void GetDetails()
        {
            Console.Write("\nEnter First Name: ");
            FirstName = Console.ReadLine();

            Console.Write("\nEnter Last Name: ");
            LastName = Console.ReadLine();

            Console.Write("\nEnter Address : ");
            Address = Console.ReadLine();

            Console.Write("\nEnter City : ");
            City = Console.ReadLine();

            Console.Write("\nEnter State : ");
            State = Console.ReadLine();

            Console.Write("\nEnter ZipCode: ");
            ZipCode = Console.ReadLine();

            Console.Write("\nEnter Phone Number: ");
            PhoneNumber = Console.ReadLine();

            Console.Write("\nEnter Email_Id: ");
            Email_Id = Console.ReadLine();
        }
        public void  CreateDetails ()
        {
            
            List<string> PersonList = new List<string>();
            List<String> Listitem = new List<String> { "First Name", "Last Name", "Address", "City", "State", "Zip Code", "Email_Id"};
            //Adding Details Entered by user details to list
          
            PersonList.Add(FirstName);
            PersonList.Add(LastName);
            PersonList.Add(Address);
            PersonList.Add(City);
            PersonList.Add(State);
            PersonList.Add(ZipCode);
            PersonList.Add(Email_Id);
           
            for (int i=0;i<PersonList.Count;i++)
            {
                for(int j=i;j<=Listitem.Count;j++)
                {
                    Console.WriteLine((i+1)+". "+Listitem[j]+" : "+PersonList[i]+"\n");
                    break;
                }

              
            }
        }
    }
}
