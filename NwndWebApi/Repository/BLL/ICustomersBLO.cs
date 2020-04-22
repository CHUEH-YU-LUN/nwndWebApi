using NwndWebApi.Models.DTO;
using NwndWebApi.ViewModels.UniForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.BLL
{
    public interface ICustomersBLO
    {
        IEnumerable<Customers> GetCustomers();
        void CreateCustomers(inCustomers inCustomers);
        void UpdateCustomers(inCustomers inCustomers);
        void DeleteCustomers(string id);
    }
}
