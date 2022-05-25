using System;
using System.Collections.Generic;

namespace AddressBookProject
{
    public class AddressBook
    {
        public Dictionary<string, Contact> Contacts { get; set; } = new Dictionary<string, Contact>();

        public void AddContact(Contact contactArgument)
        {
            try
            {
                Contacts.Add(contactArgument.Email, contactArgument);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"{contactArgument.FullName} is already in contacts");
            }
        }

        public Contact GetByEmail(string emailArgument)
        {
            return Contacts[emailArgument];
        }
    }
}