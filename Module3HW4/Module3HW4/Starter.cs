using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Module3HW4.Entities;

namespace Module3HW4
{
    public class Starter
    {
        public static void Run()
        {
            Console.WriteLine("--- Task1 ---");
            var task1 = new Task1();

            task1.Wrapper();
            Console.WriteLine("\n--- Task2 ---");
            var task2 = new Task2();
            task2.FillContacts();
            task2.FillAddresses();
            string contacts = string.Empty;
            foreach (var contact in task2.Contacts)
            {
                contacts += contact;
            }

            Console.WriteLine("\nAll contacts: \n" + contacts);

            var namesList = task2.GetNames();
            var names = string.Empty;
            foreach (var item in namesList)
            {
                names += item + " ";
            }

            Console.WriteLine("Names: \n" + names);

            string prefix = "V";
            var prefixContactsList = task2.GetNamesStartsWith(prefix);
            var prefixContacts = string.Empty;
            foreach (var item in prefixContactsList)
            {
                prefixContacts += item;
            }

            Console.WriteLine("\nContacts that start with: " + prefix + "\n" + prefixContacts);

            var postfix = "032";
            Console.WriteLine("Count of contacts with last numbers in Phone number \"" + postfix + "\" : " + task2.GetCountOfNumberEnds(postfix));

            Console.WriteLine("\nFirst contact with name that starts with A :" + task2.GetFirstA().ToString());
            Console.WriteLine("Joined data from 2 tables: \n" + task2.GetAllData());

            Console.WriteLine("\nCheck if there is certain contact in list: \n" + task2.IfContains(task2.Contacts.ElementAtOrDefault(1)));

            var newContacts = new List<Contact>();
            newContacts.Add(new Contact(9, "Nastia", "+380932279199"));
            newContacts.Add(new Contact(10, "Petro", "+380763389032"));

            Console.WriteLine("\nInterselect between old and new contacts: \n (if there is no contact it means that there are no matches between collections)\n");
            foreach (var item in task2.Contacts.Intersect(newContacts))
            {
                Console.WriteLine(item);
            }

            task2.Contacts = task2.Contacts.Union(newContacts).ToList();

            contacts = string.Empty;
            foreach (var contact in task2.Contacts.Skip(5).Take(5))
            {
                contacts += contact;
            }

            Console.WriteLine("\nSkipped 5 contacts and taken 5 after addind new ones: \n" + contacts);

            task2.Contacts = task2.Contacts.Except(newContacts).ToList();

            contacts = string.Empty;
            foreach (var contact in task2.Contacts)
            {
                contacts += contact;
            }

            Console.WriteLine("\nAll contacts without new ones: \n" + contacts);
        }
    }
}
