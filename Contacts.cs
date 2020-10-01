using System;

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
        }
    }
}
