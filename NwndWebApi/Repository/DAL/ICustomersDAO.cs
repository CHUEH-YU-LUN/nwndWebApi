using NwndWebApi.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.DAL
{
    public interface ICustomersDAO
    {
        IEnumerable<Customers> GetCustomers();
        void CreateCustomers(Customers customers);
        void UpdateCustomers(Customers customers);
        void DeleteCustomers(int id);
    }
}
