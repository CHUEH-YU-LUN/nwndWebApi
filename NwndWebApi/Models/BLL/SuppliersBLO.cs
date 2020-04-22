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
    public class SuppliersBLO : ISuppliersBLO
    {
        private ISuppliersDAO iSuppliersDAO;

        public SuppliersBLO(ISuppliersDAO _iSuppliersDAO)
        {
            iSuppliersDAO = _iSuppliersDAO;
        }

        public void CreateSuppliers(inSuppliers inSuppliers)
        {
            try
            {
                Suppliers suppliers = new Suppliers()
                {
                    SupplierId = inSuppliers.SupplierId,
                    CompanyName = inSuppliers.CompanyName,
                    ContactName = inSuppliers.ContactName,
                    ContactTitle = inSuppliers.ContactTitle,
                    Address = inSuppliers.Address,
                    City = inSuppliers.City,
                    Region = inSuppliers.Region,
                    PostalCode = inSuppliers.PostalCode,
                    Country = inSuppliers.Country,
                    Phone = inSuppliers.Phone,
                    Fax = inSuppliers.Fax,
                    HomePage = inSuppliers.HomePage
                };
                iSuppliersDAO.CreateSuppliers(suppliers);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteSuppliers(int id)
        {
            try
            {
                iSuppliersDAO.DeleteSuppliers(id);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public IEnumerable<Suppliers> GetSuppliers()
        {
            try
            {
                IEnumerable<Suppliers> _Suppliers = iSuppliersDAO.GetSuppliers();

                return _Suppliers;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateSuppliers(inSuppliers inSuppliers)
        {
            try
            {
                Suppliers suppliers = new Suppliers()
                {
                    SupplierId = inSuppliers.SupplierId,
                    CompanyName = inSuppliers.CompanyName,
                    ContactName = inSuppliers.ContactName,
                    ContactTitle = inSuppliers.ContactTitle,
                    Address = inSuppliers.Address,
                    City = inSuppliers.City,
                    Region = inSuppliers.Region,
                    PostalCode = inSuppliers.PostalCode,
                    Country = inSuppliers.Country,
                    Phone = inSuppliers.Phone,
                    Fax = inSuppliers.Fax,
                    HomePage = inSuppliers.HomePage
                };
                iSuppliersDAO.UpdateSuppliers(suppliers);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
