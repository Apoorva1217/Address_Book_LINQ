using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AddressBookLinq
{
    public class AddressBookRepo
    {
        /// <summary>
        /// UC1 UC2 Ability to create Address Book Data Table 
        /// </summary>
        DataTable dataTable = new DataTable();

        public void CreateDataTable()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("ZipCode", typeof(string));
            dataTable.Columns.Add("PhoneNumber", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));

            dataTable.Rows.Add("Apoorva", "Rasal", "Kalwa", "Thane", "Maharashtra", "400605", "9876543212", "Appu12@gmail.com");
            dataTable.Rows.Add("Shreya", "Kadam", "Kharadi", "Pune", "Maharashtra", "411045", "9976543212", "Shreya11@gmail.com");
            dataTable.Rows.Add("Yash", "Rasal", "Vashi", "NaviMumbai", "Maharashtra", "422034", "9876543213", "Yash17@gmail.com");
            dataTable.Rows.Add("Swara", "Shinde", "Airoli", "Thane", "Maharashtra", "400123", "9076543212", "Swara98@gmail.com");
            dataTable.Rows.Add("Manaswi", "Patil", "Panvel", "NaviMumbai", "Maharashtra", "422935", "9876543214", "Manu00@gmail.com");
            dataTable.Rows.Add("Shubham", "Nalawade", "Bandra", "Mumbai", "Maharashtra", "400213", "9936543212", "Shubh56@gmail.com");
            dataTable.Rows.Add("Aarya", "Rasal", "Dombivali", "Thane", "Maharashtra", "400876", "9876543243", "Aarya13@gmail.com");
            dataTable.Rows.Add("Tanvi", "Kute", "Varoli", "Mumbai", "Maharashtra", "426789", "8976543212", "Tanvi10@gmail.com");
            dataTable.Rows.Add("Shefali", "Kadam", "Hadapsar", "Pune", "Maharashtra", "411735", "8776543212", "Shefali67@gmail.com");
            dataTable.Rows.Add("Aayush", "Pawar", "Aaundh", "Pune", "Maharashtra", "411985", "9176543211", "Aayush07@gmail.com");
        }

        /// <summary>
        /// Display Method to Print Data Table Values
        /// </summary>
        public void Display()
        {
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    Console.WriteLine("{0}:{1}", column.ColumnName, row[column]);
                }
                Console.WriteLine("--------------------");
            }
        }

        /// <summary>
        /// UC3 Ability to insert new contacts to Address Book
        /// </summary>
        public void InsertDataIntoAddressBook(Details details)
        {
            dataTable.Rows.Add(details.FirstName, details.LastName, details.Address, details.City,
                details.State, details.ZipCode, details.PhoneNumber, details.Email);
        }

        /// <summary>
        /// UC4 Ability to edit existing contact person using their name
        /// </summary>
        /// <param name="details"></param>
        public void EditContact(Details details)
        {
            var data = dataTable.AsEnumerable().Where(x => x.Field<string>("FirstName") == details.FirstName).FirstOrDefault();
            if (data != null)
            {
                data.SetField("LastName", details.LastName);
                data.SetField("Address", details.Address);
                data.SetField("City", details.City);
                data.SetField("State", details.State);
                data.SetField("ZipCode", details.ZipCode);
                data.SetField("PhoneNumber", details.PhoneNumber);
                data.SetField("Email", details.Email);
            }
            else
            {
                Console.WriteLine("No Data Found");
            }
        }

        /// <summary>
        /// UC5 Ability to Delete person using person's name
        /// </summary>
        /// <param name="FirstName"></param>
        public void DeleteContact(string FirstName)
        {
            var deleteData = dataTable.AsEnumerable().Where(x => x.Field<string>("FirstName").Equals(FirstName)).First();
            if (deleteData != null)
            {
                deleteData.Delete();
            }
        }
    }
}
