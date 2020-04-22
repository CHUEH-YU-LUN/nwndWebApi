using NwndWebApi.Models.DTO;
using NwndWebApi.ViewModels.UniForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.BLL
{
    public interface ICustomerDemographicsBLO
    {
        IEnumerable<CustomerDemographics> GetCustomerDemographics();
        void CreateCustomerDemographics(inCustomerDemographics inCustomerDemographics);
        void UpdateCustomerDemographics(inCustomerDemographics inCustomerDemographics);
        void DeleteCustomerDemographics(string id);
    }
}
