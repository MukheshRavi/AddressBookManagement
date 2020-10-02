using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{ public interface Address { }
     class Pogram
    {
        static void Main(string[] args)
        {
            Contacts c = new Contacts();
            SchoolContacts s = new SchoolContacts();

            Console.WriteLine("Welcome to Address Book Management");
            Console.WriteLine("Enter the choice");
            string process;
            do
            {
                Console.WriteLine("1:Contacts  2:SchoolContacts");
                int i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:
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
                        break;

                    case 2:
                        Console.WriteLine("1: Enter contact details   2: edit contact details  3.Delete a contact");
                        int ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                s.enterDetails();
                                break;

                            case 2:
                                Console.WriteLine("enter the frstname to edit contact details ");
                                string name = Console.ReadLine();
                                s.editDetails(name);
                                break;

                            case 3:
                                Console.WriteLine("enter the frstname to delete contact details ");
                                string named = Console.ReadLine();
                                break;


                            default:
                                Console.WriteLine("Invalid option");
                                break;
                        }
                        break;

                }
                        List<Address> list = new List<Address>();
                        list.Add(c);
                list.Add(s);

                

                        Console.WriteLine("Do you want to continue  yes or No ");
                process = Console.ReadLine();


            }

            while (process == "yes");

        }
        }



    }
}
