using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW4.Entities
{
    public class Address : IComparable<Address>
    {
        public Address(int id, string number)
        {
            Id = id;
            City = number;
        }

        public int Id { get; set; }
        public string City { get; set; }

        public int CompareTo(Address other)
        {
            return City.CompareTo(other.City);
        }

        public override string ToString()
        {
            return City;
        }
    }
}
