using NwndWebApi.Factory;
using NwndWebApi.Models.DTO;
using NwndWebApi.Repository.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Models.DAL
{
    [DependencyRegister]
    public class CustomerCustomerDemoDAO : ICustomerCustomerDemoDAO
    {
        private readonly NorthwindContext _context;

        public CustomerCustomerDemoDAO(NorthwindContext context)
        {
            _context = context;
        }

        public void CreateCustomerCustomerDemo(CustomerCustomerDemo customerCustomerDemo)
        {
            try
            {
                _context.CustomerCustomerDemo.Add(customerCustomerDemo);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteCustomerCustomerDemo(int CustomerID,int CustomerTypeID)
        {
            try
            {
                var _CustomerCustomerDemo = _context.CustomerCustomerDemo.Find(CustomerID,CustomerTypeID);
                _context.CustomerCustomerDemo.Remove(_CustomerCustomerDemo);
                _context.SaveChanges();
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
                IEnumerable<CustomerCustomerDemo> _CustomerCustomerDemo = from x in _context.CustomerCustomerDemo select x;

                return _CustomerCustomerDemo;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateCustomerCustomerDemo(CustomerCustomerDemo customerCustomerDemo)
        {
            try
            {
                _context.CustomerCustomerDemo.Update(customerCustomerDemo);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }


}
