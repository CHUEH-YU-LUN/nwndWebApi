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
    public class OrdersDAO : IOrdersDAO
    {
        private readonly NorthwindContext _context;

        public OrdersDAO(NorthwindContext context)
        {
            _context = context;
        }

        public void CreateOrders(Orders orders)
        {
            try
            {
                _context.Orders.Add(orders);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteOrders(int id)
        {
            try
            {
                var _Orders = _context.Orders.Find(id);
                _context.Orders.Remove(_Orders);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public IEnumerable<Orders> GetOrders()
        {
            try
            {
                IEnumerable<Orders> _Orders = from x in _context.Orders select x;

                return _Orders;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateOrders(Orders orders)
        {
            try
            {
                _context.Orders.Update(orders);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
