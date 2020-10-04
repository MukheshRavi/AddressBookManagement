using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookMain
{
    class AddressBook
    {
        public string name;
        public Dictionary<string, Contacts> addressBook;


        public void displayAddressBook(Dictionary<string,Contacts> d)
        {
            foreach(KeyValuePair<string,Contacts> a in d)
            {
                Console.WriteLine("Name of AddressBook: firstname, lastname, address, city, state, email, zip, phoneNumber");
                Console.WriteLine(a.Key+":"+a.Value.frstName+","+a.Value.lastName + "," + a.Value.address + "," + a.Value.city + ","
                    + a.Value.state + "," + a.Value.email + "," + a.Value.zip + "," + a.Value.phnNo );

            }
        }
    }
}
