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
    public class CustomersDAO : ICustomersDAO
    {
        private readonly NorthwindContext _context;

        public CustomersDAO(NorthwindContext context)
        {
            _context = context;
        }

        public void CreateCustomers(Customers customers)
        {
            try
            {
                _context.Customers.Add(customers);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteCustomers(string id)
        {
            try
            {
                var _Customers = _context.Customers.Find(id);
                _context.Customers.Remove(_Customers);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public IEnumerable<Customers> GetCustomers()
        {
            try
            {
                IEnumerable<Customers> _Customers = from x in _context.Customers select x;

                return _Customers;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateCustomers(Customers customers)
        {
            try
            {
                _context.Customers.Update(customers);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
