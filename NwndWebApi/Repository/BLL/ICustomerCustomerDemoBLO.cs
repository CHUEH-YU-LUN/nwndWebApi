using NwndWebApi.Models.DTO;
using NwndWebApi.ViewModels.UniForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.BLL
{
    public interface ICustomerCustomerDemoBLO
    {
        IEnumerable<CustomerCustomerDemo> GetCustomerCustomerDemo();
        void CreateCustomerCustomerDemo(inCustomerCustomerDemo inCustomerCustomerDemo);
        void UpdateCustomerCustomerDemo(inCustomerCustomerDemo inCustomerCustomerDemo);
        void DeleteCustomerCustomerDemo(string CusotmerID,string CustomerTypeID);
    }
}
