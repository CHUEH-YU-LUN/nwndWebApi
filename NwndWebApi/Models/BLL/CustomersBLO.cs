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
    public class CustomersBLO : ICustomersBLO
    {
        private ICustomersDAO iCustomersDAO;

        public CustomersBLO(ICustomersDAO _iCustomersDAO)
        {
            iCustomersDAO = _iCustomersDAO;
        }

        public void CreateCustomers(inCustomers inCustomers)
        {
            try
            {
                Customers customers = new Customers()
                {
                    CustomerId = inCustomers.CustomerId,
                    CompanyName = inCustomers.CompanyName,
                    ContactName = inCustomers.ContactName,
                    ContactTitle = inCustomers.ContactTitle,
                    Address = inCustomers.Address,
                    City = inCustomers.City,
                    Region = inCustomers.Region,
                    PostalCode = inCustomers.PostalCode,
                    Country = inCustomers.Country,
                    Phone = inCustomers.Phone,
                    Fax = inCustomers.Fax
                };
                iCustomersDAO.CreateCustomers(customers);
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
                iCustomersDAO.DeleteCustomers(id);
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
                IEnumerable<Customers> _Customers = iCustomersDAO.GetCustomers();

                return _Customers;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateCustomers(inCustomers inCustomers)
        {
            try
            {
                Customers customers = new Customers()
                {
                    CustomerId = inCustomers.CustomerId,
                    CompanyName = inCustomers.CompanyName,
                    ContactName = inCustomers.ContactName,
                    ContactTitle = inCustomers.ContactTitle,
                    Address = inCustomers.Address,
                    City = inCustomers.City,
                    Region = inCustomers.Region,
                    PostalCode = inCustomers.PostalCode,
                    Country = inCustomers.Country,
                    Phone = inCustomers.Phone,
                    Fax = inCustomers.Fax
                };
                iCustomersDAO.UpdateCustomers(customers);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
