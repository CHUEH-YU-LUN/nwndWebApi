using NwndWebApi.Factory;
using NwndWebApi.Models.DTO;
using NwndWebApi.Repository.BLL;
using NwndWebApi.Repository.DAL;
using NwndWebApi.ViewModels.UniForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Models.BLL
{
    [DependencyRegister]
    public class CustomerCustomerDemoBLO : ICustomerCustomerDemoBLO
    {
        private ICustomerCustomerDemoDAO iCustomerCustomerDemoDAO;

        public CustomerCustomerDemoBLO(ICustomerCustomerDemoDAO _iCustomerCustomerDemoDAO)
        {
            iCustomerCustomerDemoDAO = _iCustomerCustomerDemoDAO;
        }

        public void CreateCustomerCustomerDemo(inCustomerCustomerDemo inCustomerCustomerDemo)
        {
            try
            {
                CustomerCustomerDemo customerCustomerDemo = new CustomerCustomerDemo()
                {
                    CustomerId = inCustomerCustomerDemo.CustomerID,
                    CustomerTypeId = inCustomerCustomerDemo.CustomerTypeID
                };
                iCustomerCustomerDemoDAO.CreateCustomerCustomerDemo(customerCustomerDemo);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteCustomerCustomerDemo(string CustomerID,string CustomerTypeID)
        {
            try
            {
                iCustomerCustomerDemoDAO.DeleteCustomerCustomerDemo(CustomerID,CustomerTypeID);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public IEnumerable<CustomerCustomerDemo> GetCustomerCustomerDemo()
        {
            try
            {
                IEnumerable<CustomerCustomerDemo> _CustomerCustomerDemo = iCustomerCustomerDemoDAO.GetCustomerCustomerDemo();

                return _CustomerCustomerDemo;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateCustomerCustomerDemo(inCustomerCustomerDemo inCustomerCustomerDemo)
        {
            try
            {
                CustomerCustomerDemo customerCustomerDemo = new CustomerCustomerDemo()
                {
                    CustomerId = inCustomerCustomerDemo.CustomerID,
                    CustomerTypeId = inCustomerCustomerDemo.CustomerTypeID
                };
                iCustomerCustomerDemoDAO.UpdateCustomerCustomerDemo(customerCustomerDemo);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
