using System;
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
            Contacts newContact = new Contacts("shiva", "barela", "INDIA", "8365649177", "barelashivabhau7@gmail.com");
            Contacts newContact2 = new Contacts("shubhash", "jadhav", "USA", "6898222444", "barelasubhash45@gmail.com");
            Contacts newContact3 = new Contacts("Tanish", "choudhri", "USA", "8768222444", "barelavinnu90@gmail.com");

            myAddressBook.AddContact(newContact);
            myAddressBook.AddContact(newContact2);
            myAddressBook.AddContact(newContact3);
            myAddressBook.PrintContacts();
        }
    }
    
}
