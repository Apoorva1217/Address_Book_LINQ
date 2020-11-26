using System;

namespace AddressBookLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book using LINQ!");
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            addressBookRepo.CreateDataTable();
            bool check = true;
            while (check == true)
            {
                Console.WriteLine("\n---Welcome to Address Book LINQ!---");
                Console.WriteLine("***Enter Your Choice***");
                Console.WriteLine("1.Display Address Book");
                Console.WriteLine("2.Add Contact");
                Console.WriteLine("3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressBookRepo.Display();
                        break;
                    case 2:
                        Details details = new Details();
                        Console.WriteLine("Enter First Name:");
                        details.FirstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name:");
                        details.LastName = Console.ReadLine();
                        Console.WriteLine("Enter Address:");
                        details.Address = Console.ReadLine();
                        Console.WriteLine("Enter City:");
                        details.City = Console.ReadLine();
                        Console.WriteLine("Enter State:");
                        details.State = Console.ReadLine();
                        Console.WriteLine("Enter Zip code:");
                        details.ZipCode = Console.ReadLine();
                        Console.WriteLine("Enter Phone Number:");
                        details.PhoneNumber = Console.ReadLine();
                        Console.WriteLine("Enter Email ID:");
                        details.Email = Console.ReadLine();
                        addressBookRepo.InsertDataIntoAddressBook(details);
                        break;
                    case 3:
                        return;
                }
            }
        }
    }
}
