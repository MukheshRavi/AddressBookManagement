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
        List<Contacts> l = new List<Contacts>();

        public Contacts()
        {

        }

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
        

        public void editDetails(string name)
        { Contacts contacts = new Contacts();
           contacts = l[1];
            if (contacts.frstName == name)
            {
                Console.WriteLine("enter the number of details you want to edit");

                Console.WriteLine(" 1:frstName  2:lastName  3:address  4:city  5:state  6:email 7:zip  8:PhoneNumber ");
                int num = Convert.ToInt32(Console.ReadLine()); //user enters the which detail should be updated
                Console.WriteLine("enter the new detail");
                string detail = Console.ReadLine();  //user enters the new detail

                switch (num)
                {
                    case 1:
                        contacts.frstName = detail;
                        break;

                    case 2:
                        contacts.lastName = detail;
                        break;
                    case 3:
                        contacts.address = detail;
                        break;
                    case 4:
                        contacts.city = detail;
                        break;
                    case 5:
                        contacts.state = detail;
                        break;
                    case 6:
                        contacts.email = detail;
                        break;
                    case 7:
                        contacts.zip = detail;
                        break;
                    case 8:
                        contacts.phnNo = detail;
                        break;
                }


            }
            else
                Console.WriteLine("there is no such user with entered first name");

            
        }

        public void enterDetails()
        {
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

            Contacts contacts = new Contacts(frstName, lastName, address, city, state, email, zip, phnNo);


            new Contacts().l.Add(contacts);
            Console.WriteLine("New contact added");
            Console.WriteLine("Firstname:" + contacts.frstName + "\nLastname:" + contacts.lastName + "\naddress:" + contacts.address +
                "\ncity:" + contacts.city + "\nstate:" + contacts.state + "\nzip" + contacts.zip + "\nPhone Number:" + contacts.phnNo);

        }

        public void deleteContact(string name)
        {
            Contacts contacts = new Contacts();
            if (contacts.frstName == name)
                l.Remove(contacts);

        }

        static void Main(string[] args)
        {
            Contacts c = new Contacts();
            Console.WriteLine("Welcome to Address Book Management");
            Console.WriteLine("Enter the choice");
            string process;
            do
            {
                Console.WriteLine("1: Enter contact details   2: edit contact details  3.Delete a contact");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        c.enterDetails();
                        break;

                    case 2:
                        Console.WriteLine("enter the frstname to edit contact details ");
                        string name = Console.ReadLine();
                        c.editDetails(name);
                        break;

                    case 3:
                        Console.WriteLine("enter the frstname to delete contact details ");
                        string named = Console.ReadLine();
                        break;


                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.WriteLine("Do you want to continue  yes or No ");
                 process = Console.ReadLine();


            }

            while (process == "yes");


            }

        }
    }

