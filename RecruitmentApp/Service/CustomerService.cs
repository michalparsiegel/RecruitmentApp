using RecruitmentApp.DAL;
using RecruitmentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecruitmentApp.Service
{
    public class CustomerService : ICustomerService
    {
        protected DataContext dataContext = null;

        public CustomerService()
        {
            dataContext = new DataContext();
        }


        public IQueryable<Customer> GetAll()
        {
            return dataContext.Customers;
        }

        public Customer Find(int? id)
        {
            return dataContext.Customers.FirstOrDefault(x => x.ID == id);
        }

        public Customer Add(Customer record)
        {
            dataContext.Customers.Add(record);

            dataContext.SaveChanges();

            return record;
        }


        public void Update(Customer record)
        {

            Customer dbRecord = dataContext.Customers.First(x => x.ID == record.ID);

            dbRecord.Name = record.Name;
            dbRecord.Surname = record.Surname;
            dbRecord.TelephoneNumber = record.TelephoneNumber;
            dbRecord.Address = record.Address;


            dataContext.SaveChanges();
        }


        public void Remove(int id)
        {
            dataContext.Customers.Remove(dataContext.Customers.First(x => x.ID == id));

            dataContext.SaveChanges();
        }

        
    }
}