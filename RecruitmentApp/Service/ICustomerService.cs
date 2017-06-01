using RecruitmentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentApp.Service
{
    public interface ICustomerService
    {
        IQueryable<Customer> GetAll();
        Customer Find(int? id);
        Customer Add(Customer record);
        void Update(Customer record);
        void Remove(int id);
    }
}
