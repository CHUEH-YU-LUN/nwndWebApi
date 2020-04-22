using NwndWebApi.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.DAL
{
    public interface IOrdersDAO
    {
        IEnumerable<Orders> GetOrders();
        void CreateOrders(Orders orders);
        void UpdateOrders(Orders orders);
        void DeleteOrders(int id);
    }
}
