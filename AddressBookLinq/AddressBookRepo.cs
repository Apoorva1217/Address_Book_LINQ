using System;
using System.Collections.Generic;
using System.Data;
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
        }
    }
}
