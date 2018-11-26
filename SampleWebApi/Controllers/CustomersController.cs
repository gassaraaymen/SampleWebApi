using SampleWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SampleWebApi.Controllers
{
    public class CustomersController : ApiController
    {
        // GET: api/Customers
        public IEnumerable<Customer> GetCustomers()
        {
            return Data.MockData.CustomersList;
        }

        // GET: api/Customers
        public Customer GetCustomersByID(int id)
        {
            return Data.MockData.CustomersList.Find(x=>x.Id == id);
        }

        // Post: api/Customers
        public void PostCustomers(Customer customers)
        {
           Data.MockData.CustomersList.Add(customers);
        }

        // Put: api/Customers
        public void PutCustomers(int id , Customer customers)
        {
            var customer = Data.MockData.CustomersList.Find(x => x.Id == id);
            if (customer != null)
            {
                Data.MockData.CustomersList.Remove(customer);
                Data.MockData.CustomersList.Add(customers);
            }
        }

        public void DeleteCustomers(int id)
        {
            var customer = Data.MockData.CustomersList.Find(x => x.Id == id);
            Data.MockData.CustomersList.Remove(customer);
        }
    }
}