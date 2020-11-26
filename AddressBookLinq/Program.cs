using System;

namespace AddressBookLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book using LINQ!");
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            Details details = new Details();
            addressBookRepo.CreateDataTable();
            bool check = true;
            while (check == true)
            {
                Console.WriteLine("\n---Welcome to Address Book LINQ!---");
                Console.WriteLine("***Enter Your Choice***");
                Console.WriteLine("1.Display Address Book");
                Console.WriteLine("2.Add Contact");
                Console.WriteLine("3.Edit Existing Contact");
                Console.WriteLine("4.Delete Contact");
                Console.WriteLine("5.Retrieve Person By City");
                Console.WriteLine("6.Retrieve Person By State");
                Console.WriteLine("7.Count Person By City");
                Console.WriteLine("8.Count Person By State");
                Console.WriteLine("9.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressBookRepo.Display();
                        break;
                    case 2:
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
                        addressBookRepo.EditContact(details);
                        break;
                    case 4:
                        Console.WriteLine("Enter First Name:");
                        string FirstName = Console.ReadLine();
                        addressBookRepo.DeleteContact(FirstName);
                        break;
                    case 5:
                        Console.WriteLine("Enter City:");
                        string City = Console.ReadLine();
                        addressBookRepo.RetrievePersonBelongingToCity(City);
                        break;
                    case 6:
                        Console.WriteLine("Enter State:");
                        string State = Console.ReadLine();
                        addressBookRepo.RetrievePersonBelongingToState(State);
                        break;
                    case 7:
                        addressBookRepo.GetCountOfPersonByCity();
                        break;
                    case 8:
                        addressBookRepo.GetCountOfPersonByState();
                        break;
                    case 9:
                        return;
                }
            }
        }
    }
}
