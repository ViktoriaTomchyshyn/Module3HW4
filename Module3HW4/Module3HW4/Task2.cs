using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module3HW4.Entities;

namespace Module3HW4
{
    public class Task2
    {
        public Task2()
        {
            Contacts = new List<Contact>();
            Addresses = new List<Address>();
        }

        public List<Contact> Contacts { get; set; }

        public List<Address> Addresses { get; set; }

        public List<string> GetNames()
        {
            return Contacts.Select(c => c.Name).ToList();
        }

        public List<Contact> GetNamesStartsWith(string prefix)
        {
            return Contacts.Where(c => c.Name.StartsWith(prefix)).OrderBy(c => c.Name).Select(c => c).Distinct().ToList();
        }

        public Contact GetFirstA()
        {
            if (Contacts.Any(c => c.Name.StartsWith("A")))
            {
                return Contacts.Where(c => c.Name.StartsWith("A")).FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        public string GetAllData()
        {
            string res = string.Empty;
            var data = Contacts.Select(c => c).Join(
                Addresses, c => c.Id, a => a.Id, (c, a) => new { Name = c.Name, Number = c.PhoneNumber, City = a.City });
            foreach (var item in data)
            {
                res += item.Name + " " + item.Number + " " + item.City + "\n";
            }

            return res;
        }

        public bool IfContains(Contact c)
        {
            if (Contacts.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetCountOfNumberEnds(string postfix)
        {
            return Contacts.Count(c => c.PhoneNumber.EndsWith(postfix));
        }

        public void FillContacts()
        {
            Contacts.Add(new Contact(1, "Oleg", "+380945628901"));
            Contacts.Add(new Contact(3, "Sasha", "+380763389032"));
            Contacts.Add(new Contact(4, "Volodymyr", "+380960067332"));
            Contacts.Add(new Contact(5, "Yulia", "+380967867890"));
            Contacts.Add(new Contact(6, "Galyna", "+380932279199"));
            Contacts.Add(new Contact(2, "Vita", "+380635689204"));
            Contacts.Add(new Contact(7, "Anna", "+380932279199"));
            Contacts.Add(new Contact(8, "Denys", "+380763389032"));
        }

        public void FillAddresses()
        {
            Addresses.Add(new Address(1, "Lviv"));
            Addresses.Add(new Address(3, "Komarno"));
            Addresses.Add(new Address(4, "Gorodok"));
            Addresses.Add(new Address(5, "Kyiv"));
            Addresses.Add(new Address(6, "Ternopil"));
            Addresses.Add(new Address(2, "Morshyn"));
            Addresses.Add(new Address(7, "Lviv"));
            Addresses.Add(new Address(8, "Skole"));
        }
    }
}
