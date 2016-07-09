using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp
{
    class Customer : IComparable<Customer> , IEquatable<Customer>
    {
        public string name;
        public int ID;
        public string Address;
        
        public Customer (string name, int ID, string Address)
        {
            this.name = name;
            this.ID = ID;
            this.Address = Address; 
        }

        public int CompareTo(Customer other)
        {
            if (other == null) return 1;
            string s1 = other.name.ToLower();
            string s2 = this.name.ToLower();
            return s1.CompareTo(s2);
        }

        public bool Equals(Customer other)
        {
            if (other == null) return false;
            if(other.name == this.name)
            {
                if(other.ID == this.ID)
                {
                    return true;
                }
            }
            return false;
        }

        

    }
}
