using System;
using System.Collections.Generic;

namespace AddressBook
{
    class Contacts
    {
         public string frstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string email;
        public string zip;
        public string phnNo;

        public Contacts(string frstName, string lastName, string address, string city, string state, string email,string zip,string phnNo)
        {
            this.frstName = frstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.email = email;
            this.zip = zip;
            this.phnNo = phnNo;
            
        }
        


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Management");
            Console.WriteLine("Enter Contact Details");
            Console.WriteLine("Enter First Name");
            string frstName = Console.ReadLine();

            Console.WriteLine("Enter last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Address ");
            string address = Console.ReadLine();

            Console.WriteLine("Enter city Name");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state Name");
            string state = Console.ReadLine();

            Console.WriteLine("Enter email id");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Zip code");
            string zip = Console.ReadLine();

            Console.WriteLine("Enter Phone Number");
            string phnNo = Console.ReadLine();

            Contacts contacts = new Contacts(frstName,lastName,address,city,state,email,zip,phnNo);

            List<Contacts> l = new List<Contacts>();
            l.Add(contacts);

          

        }
    }
}
