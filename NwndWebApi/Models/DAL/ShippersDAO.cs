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
    public class ShippersDAO : IShippersDAO
    {
        private readonly NorthwindContext _context;

        public ShippersDAO(NorthwindContext context)
        {
            _context = context;
        }

        public void CreateShippers(Shippers shippers)
        {
            try
            {
                _context.Shippers.Add(shippers);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteShippers(int id)
        {
            try
            {
                var _Shippers = _context.Shippers.Find(id);
                _context.Shippers.Remove(_Shippers);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public IEnumerable<Shippers> GetShippers()
        {
            try
            {
                IEnumerable<Shippers> _Shippers = from x in _context.Shippers select x;

                return _Shippers;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateShippers(Shippers shippers)
        {
            try
            {
                _context.Shippers.Update(shippers);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
