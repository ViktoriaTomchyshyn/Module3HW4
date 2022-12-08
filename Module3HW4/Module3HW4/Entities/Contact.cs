using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW4.Entities
{
    public class Contact : IComparable<Contact>
    {
        public Contact(int id, string name, string number)
        {
            Id = id;
            Name = name;
            PhoneNumber = number;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public int CompareTo(Contact other)
        {
            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return Name + " " + PhoneNumber + "\n";
        }
    }
}
