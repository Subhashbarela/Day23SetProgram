﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23CollectionProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddressBook myAddressBook = new AddressBook();
            Contacts newContact = new Contacts("Prince", "Praveen", "INDIA", "8369319177", "prince.p@example.com");
            Contacts newContact2 = new Contacts("Robert", "Downey", "USA", "888222444", "robery.downey@jr.com");
            Contacts newContact3 = new Contacts("Robert", "Downey", "USA", "888222444", "robery.downey@jr.com");

            myAddressBook.AddContact(newContact);
            myAddressBook.AddContact(newContact2);
            myAddressBook.AddContact(newContact3);
            myAddressBook.PrintContacts();
        }
    }
    
}
