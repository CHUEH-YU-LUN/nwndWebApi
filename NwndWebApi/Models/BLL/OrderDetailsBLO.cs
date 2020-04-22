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
    public class OrderDetailsBLO : IOrderDetailsBLO
    {
        private IOrderDetailsDAO iOrderDetailsDAO;

        public OrderDetailsBLO(IOrderDetailsDAO _iOrderDetailsDAO)
        {
            iOrderDetailsDAO = _iOrderDetailsDAO;
        }

        public void CreateOrderDetails(inOrderDetails inOrderDetails)
        {
            try
            {
                OrderDetails orderDetails = new OrderDetails()
                {
                    OrderId = inOrderDetails.OrderId,
                    ProductId = inOrderDetails.ProductId,
                    UnitPrice = inOrderDetails.UnitPrice,
                    Quantity = inOrderDetails.Quantity,
                    Discount = inOrderDetails.Discount
                };
                iOrderDetailsDAO.CreateOrderDetails(orderDetails);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteOrderDetails(int OrderID, int ProductID)
        {
            try
            {
                iOrderDetailsDAO.DeleteOrderDetails(OrderID,ProductID);
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
                IEnumerable<OrderDetails> _OrderDetails = iOrderDetailsDAO.GetOrderDetails();

                return _OrderDetails;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateOrderDetails(inOrderDetails inOrderDetails)
        {
            try
            {
                OrderDetails OrderDetails = new OrderDetails()
                {
                    OrderId = inOrderDetails.OrderId,
                    ProductId = inOrderDetails.ProductId,
                    UnitPrice = inOrderDetails.UnitPrice,
                    Quantity = inOrderDetails.Quantity,
                    Discount = inOrderDetails.Discount
                };
                iOrderDetailsDAO.UpdateOrderDetails(OrderDetails);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
