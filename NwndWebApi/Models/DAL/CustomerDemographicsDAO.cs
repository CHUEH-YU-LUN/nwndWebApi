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
    public class CustomerDemographicsDAO : ICustomerDemographicsDAO
    {
        private readonly NorthwindContext _context;

        public CustomerDemographicsDAO(NorthwindContext context)
        {
            _context = context;
        }

        public void CreateCustomerDemographics(CustomerDemographics customerDemographics)
        {
            try
            {
                _context.CustomerDemographics.Add(customerDemographics);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteCustomerDemographics(int id)
        {
            try
            {
                var _CustomerDemographics = _context.CustomerDemographics.Find(id);
                _context.CustomerDemographics.Remove(_CustomerDemographics);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public IEnumerable<CustomerDemographics> GetCustomerDemographics()
        {
            try
            {
                IEnumerable<CustomerDemographics> _CustomerDemographics = from x in _context.CustomerDemographics select x;

                return _CustomerDemographics;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateCustomerDemographics(CustomerDemographics customerDemographics)
        {
            try
            {
                _context.CustomerDemographics.Update(customerDemographics);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
