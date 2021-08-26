using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingRepo
{
    public class GreetingRepoSitory
    {
        public List<Customer> CustomersDirectory { get; private set; } = new List<Customer>();


        public void Add(string firstname, string lastname, CustomerType type)
        {
            if (string.IsNullOrEmpty(lastname) || string.IsNullOrWhiteSpace(lastname))
            {
                Console.WriteLine("please put in a valid last name");
            }
            else if (string.IsNullOrEmpty(firstname) || string.IsNullOrWhiteSpace(firstname))
            {
                Console.WriteLine("please put in a valid first name");
            }
            else
            {
                CustomersDirectory.Add(new Customer(firstname, lastname, type));
            }
        }
        public bool Update(int id, string firstname, string lastname, CustomerType type)
        {
            Customer oldData = GetCustomerByID(id);
            if (oldData != null)
            {
                oldData.LastName = lastname;
                oldData.FirstName = firstname;
                oldData.Type = type;
                return true;
            }
            return false;
        }
        public bool Update(int id, CustomerType type)
        {
            Customer oldData = GetCustomerByID(id);
            if (oldData != null)
            {
                oldData.Type = type;
                return true;
            }
            return false;
        }

        public Customer GetCustomerByID(int id)
        {
            foreach (Customer customer in CustomersDirectory)
            {
                if (id == customer.ID)
                {
                    return customer;
                }
            }
            return null;
        }
        public bool Delete(int id)
        {
            Customer oldData = GetCustomerByID(id);
            return CustomersDirectory.Remove(oldData);
        }
    }
}
