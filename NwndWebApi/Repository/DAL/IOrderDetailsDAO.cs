using NwndWebApi.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.DAL
{
    public interface IOrderDetailsDAO
    {
        IEnumerable<OrderDetails> GetOrderDetails();
        void CreateOrderDetails(OrderDetails orderDetails);
        void UpdateOrderDetails(OrderDetails orderDetails);
        void DeleteOrderDetails(int id);
    }
}
