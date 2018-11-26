using SampleWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApi.Data
{
    public static class MockData
    {
        public static List<Customer> CustomersList { get; set; } = new List<Customer>()
        {
            new Customer {Id = 0, Adress="Sfax 5 august", FirstName="Ayman" , LastName ="Gassara" },
             new Customer {Id = 1, Adress="Sfax 5 august", FirstName="Ayman" , LastName ="Gassara" },
              new Customer {Id = 2, Adress="Sfax 5 august", FirstName="Ayman" , LastName ="Gassara" },
               new Customer {Id = 3, Adress="Sfax 5 august", FirstName="Ayman" , LastName ="Gassara" },
                new Customer {Id = 4, Adress="Sfax 5 august", FirstName="Ayman" , LastName ="Gassara" },
                 new Customer {Id = 5, Adress="Sfax 5 august", FirstName="Ayman" , LastName ="Gassara" },
        };
    }
}