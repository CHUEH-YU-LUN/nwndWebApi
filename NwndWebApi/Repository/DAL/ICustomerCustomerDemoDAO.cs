using NwndWebApi.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.DAL
{
    public interface ICustomerCustomerDemoDAO
    {
        IEnumerable<CustomerCustomerDemo> GetCustomerCustomerDemo();
        void CreateCustomerCustomerDemo(CustomerCustomerDemo customerCustomerDemo);
        void UpdateCustomerCustomerDemo(CustomerCustomerDemo customerCustomerDemo);
        void DeleteCustomerCustomerDemo(int CustomerID,int CustomerTypeID);
    }
}
