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
    public class OrderDetailsDAO : IOrderDetailsDAO
    {
        private readonly NorthwindContext _context;

        public OrderDetailsDAO(NorthwindContext context)
        {
            _context = context;
        }

        public void CreateOrderDetails(OrderDetails orderDetails)
        {
            try
            {
                _context.OrderDetails.Add(orderDetails);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteOrderDetails(int OrderID,int ProductID)
        {
            try
            {
                var _OrderDetails = _context.OrderDetails.Find(OrderID,ProductID);
                _context.OrderDetails.Remove(_OrderDetails);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public IEnumerable<OrderDetails> GetOrderDetails()
        {
            try
            {
                IEnumerable<OrderDetails> _OrderDetails = from x in _context.OrderDetails select x;

                return _OrderDetails;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateOrderDetails(OrderDetails orderDetails)
        {
            try
            {
                _context.OrderDetails.Update(orderDetails);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
