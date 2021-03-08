using System;
using System.Collections.Generic;


namespace AddressBook
{
    class AddressBook
    {
        private Dictionary<string, Contact> AddressDictionary;
        public void AddContact(Contact person)
        {
            try
            {
                // Dot notation to access the Email property
                AddressDictionary.Add(person.Email, person);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        public Contact GetByEmail(string email)
        {
            return AddressDictionary[email];

        }
        public AddressBook()
        {
            AddressDictionary = new Dictionary<string, Contact>();
        }

    }
}