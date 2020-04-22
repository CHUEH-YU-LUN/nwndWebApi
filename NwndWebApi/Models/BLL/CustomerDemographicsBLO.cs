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
    public class CustomerDemographicsBLO : ICustomerDemographicsBLO
    {
        private ICustomerDemographicsDAO iCustomerDemographicsDAO;

        public CustomerDemographicsBLO(ICustomerDemographicsDAO _iCustomerDemographicsDAO)
        {
            iCustomerDemographicsDAO = _iCustomerDemographicsDAO;
        }

        public void CreateCustomerDemographics(inCustomerDemographics inCustomerDemographics)
        {
            try
            {
                CustomerDemographics customerDemographics = new CustomerDemographics()
                {
                    CustomerTypeId = inCustomerDemographics.CustomerTypeID,
                    CustomerDesc = inCustomerDemographics.CustomerDesc
                };
                iCustomerDemographicsDAO.CreateCustomerDemographics(customerDemographics);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteCustomerDemographics(string id)
        {
            try
            {
                iCustomerDemographicsDAO.DeleteCustomerDemographics(id);
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
                IEnumerable<CustomerDemographics> _CustomerDemographics = iCustomerDemographicsDAO.GetCustomerDemographics();

                return _CustomerDemographics;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateCustomerDemographics(inCustomerDemographics inCustomerDemographics)
        {
            try
            {
                CustomerDemographics customerDemographics = new CustomerDemographics()
                {
                    CustomerTypeId = inCustomerDemographics.CustomerTypeID,
                    CustomerDesc = inCustomerDemographics.CustomerDesc
                };
                iCustomerDemographicsDAO.UpdateCustomerDemographics(customerDemographics);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
