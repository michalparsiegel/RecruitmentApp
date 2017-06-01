using RecruitmentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecruitmentApp.DAL
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer() { Name = "Name1",Surname = "Surname1", Address = "Address1", TelephoneNumber = "111 222 333"  },
                new Customer() { Name = "Name2",Surname = "Surname2", Address = "Address2", TelephoneNumber = "111 222 333"  },
                new Customer() { Name = "Name3",Surname = "Surname3", Address = "Address3", TelephoneNumber = "111 222 333"  },
                new Customer() { Name = "Name4",Surname = "Surname4", Address = "Address4", TelephoneNumber = "111 222 333"  }
            };

            customers.ForEach(x => context.Customers.Add(x));

            context.SaveChanges();
        }
    }
}