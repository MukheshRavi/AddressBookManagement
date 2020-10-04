﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookMain
{ public interface Address { }
     class Pogram
    {
        static void Main(string[] args)
        {
            Contacts c = new Contacts();
            Dictionary<string, Contacts> addressBook = new Dictionary<string, Contacts>();

            Console.WriteLine("Welcome to Address Book Management");
            Console.WriteLine("Enter the choice");
            string process;
            do
            {
                Console.WriteLine("Enter the name of address book");
                string name =Console.ReadLine();

                
                Console.WriteLine("1: Enter contact details   2: edit contact details  3.Delete a contact 4.Display Contanct");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:                                //To enter contact details
                        c.enterDetails();
                    
                        addressBook.Add(name, c);
                        break;

                    case 2:                                    //To update a contact based on First name 
                        Console.WriteLine("enter the frstname to edit contact details ");
                        string frstname = Console.ReadLine();
                        c.editDetails(frstname);
                        break;

                    case 3:                                 //To delete a contact
                        Console.WriteLine("enter the frstname to delete contact details ");
                        string named = Console.ReadLine();
                        c.deleteContact(named);
                        break;

                    case 4:                                    //To display a contact
                        if (addressBook.Count == 0)
                            Console.WriteLine("There is no contact added to display");
                        new AddressBook().displayAddressBook(addressBook);
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                        List<Address> list = new List<Address>();
                        list.Add(c);
               

                

                        Console.WriteLine("Do you want to continue  yes or No ");
                process = Console.ReadLine();


            }

            while (process == "yes");

        }
        }



    }

