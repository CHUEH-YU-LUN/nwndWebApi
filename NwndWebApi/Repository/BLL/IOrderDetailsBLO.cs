using NwndWebApi.Models.DTO;
using NwndWebApi.ViewModels.UniForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.BLL
{
    public interface IOrderDetailsBLO
    {
        IEnumerable<OrderDetails> GetOrderDetails();
        void CreateOrderDetails(inOrderDetails inOrderDetails);
        void UpdateOrderDetails(inOrderDetails inOrderDetails);
        void DeleteOrderDetails(int OrderID,int ProductID);
    }
}
