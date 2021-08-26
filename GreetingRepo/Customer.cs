using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingRepo
{
    public class Customer
    {
        public int ID { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public CustomerType Type {get; set;}

        
        public Customer(string firstname, string lastname, CustomerType type)
        {
            FirstName = firstname;
            LastName = lastname;
            Type = type;
            Random randy = new Random();
            ID = randy.Next(1, 30001);
        }

    }
    public enum CustomerType {Current, Past, Potential }
}
