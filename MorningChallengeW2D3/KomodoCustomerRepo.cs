using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallengeW2D3
{
    public class KomodoCustomerRepo
    {
        //list of customers
        protected readonly List<Customer> _customerDirectory = new List<Customer>();

        //add a customer
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public bool AddCustomer(Customer customer)
        {
            int startingCount = _customerDirectory.Count;
            _customerDirectory.Add(customer);
            return _customerDirectory.Count > startingCount;
        }

        //get customer by ID
        [TestMethod]
        public Customer GetCustomerByID(int idNumber)
        {
            foreach (Customer customer in _customerDirectory)
            {
                if (customer.IDNumber == idNumber)
                {
                    return customer;
                }
            }
            return null;
        }


        //deleting a customer from directory by ID
        [TestMethod]
        public bool DeleteCustomerByID(int idNumber)
        {
            foreach (Customer customer in _customerDirectory)
            {
                if (customer.IDNumber == idNumber)
                {
                    bool deleteResult = _customerDirectory.Remove(customer);
                    return deleteResult;
                }
            }
            return false;
        }

        //deleting a customer by name
        [TestMethod]
        public bool DeleteCustomerByName(string lastName)
        {
            foreach (Customer customer in _customerDirectory)
            {
                if (customer.LastName == lastName)
                {
                    bool deleteResult = _customerDirectory.Remove(customer);
                    return deleteResult;

                }
            }
            return false;
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> allCustomers = new List<Customer>();

            foreach (Customer customer in _customerDirectory)
            {
                if (customer is Customer)
                {
                    allCustomers.Add(customer as Customer);
                }
            }

            return allCustomers;

        }
    }
}
