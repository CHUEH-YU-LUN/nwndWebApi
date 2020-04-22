using NwndWebApi.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.DAL
{
    public interface ICustomerDemographicsDAO
    {
        IEnumerable<CustomerDemographics> GetCustomerDemographics();
        void CreateCustomerDemographics(CustomerDemographics customerDemographics);
        void UpdateCustomerDemographics(CustomerDemographics customerDemographics);
        void DeleteCustomerDemographics(int id);
    }
}
