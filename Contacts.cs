using System;
using System.Collections.Generic;

namespace AddressBookMain
{


    public class Contacts : Address
    {
        public string frstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string email;
        public string zip;
        public string phnNo;
        public List<Contacts> l = new List<Contacts>();
        public Dictionary<string, Contacts> addressBook = new Dictionary<string, Contacts>();
        //Contacts contacts = new Contacts();

        public Contacts()
        {

        }

        public Contacts(string frstName, string lastName, string address, string city, string state, string email, string zip, string phnNo)
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
        {
           Contacts contacts = new Contacts();
            for (int i = 0; i < l.Count; i++)
            {
                contacts = l[i];
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



            }
        }

        public void enterDetails()
        {
            Console.WriteLine("Enter the name of address book");
            string name = Console.ReadLine();

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


           l.Add(contacts);
            Console.WriteLine("New contact added");
            Console.WriteLine("Firstname:" + contacts.frstName + "\nLastname:" + contacts.lastName + "\naddress:" + contacts.address +
                "\ncity:" + contacts.city + "\nstate:" + contacts.state + "\nzip" + contacts.zip + "\nPhone Number:" + contacts.phnNo);
            addressBook.Add(name, contacts);
           

        }


        public void displayAddressBook()
        {  if (addressBook.Count == 0)
                    Console.WriteLine("There is no contact added to display");

            else {
                foreach (KeyValuePair<string, Contacts> a in addressBook)
                {
                    Console.WriteLine("Name of AddressBook: firstname, lastname, address, city, state, email, zip, phoneNumber");
                    Console.WriteLine(a.Key + ":" + a.Value.frstName + "," + a.Value.lastName + "," + a.Value.address + "," + a.Value.city + ","
                        + a.Value.state + "," + a.Value.email + "," + a.Value.zip + "," + a.Value.phnNo);

                }
            }
        }


        public void deleteContact(string named)
        {
           Contacts c = new Contacts();
            for (int i = 0; i < l.Count; i++)
            { c = l[i];
                if (c.frstName == named)
                { l.Remove(c);
                   
                    }
            }
        }

        

        
    }
}

