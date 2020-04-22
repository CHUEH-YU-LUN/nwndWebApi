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
    public class SuppliersDAO : ISuppliersDAO
    {
        private readonly NorthwindContext _context;

        public SuppliersDAO(NorthwindContext context)
        {
            _context = context;
        }

        public void CreateSuppliers(Suppliers suppliers)
        {
            try
            {
                _context.Suppliers.Add(suppliers);
                _context.SaveChanges();
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
                var _Suppliers = _context.Suppliers.Find(id);
                _context.Suppliers.Remove(_Suppliers);
                _context.SaveChanges();
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
                IEnumerable<Suppliers> _Suppliers = from x in _context.Suppliers select x;

                return _Suppliers;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateSuppliers(Suppliers suppliers)
        {
            try
            {
                _context.Suppliers.Update(suppliers);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
