using NwndWebApi.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.DAL
{
    public interface IShippersDAO
    {
        IEnumerable<Shippers> GetShippers();
        void CreateShippers(Shippers shippers);
        void UpdateShippers(Shippers shippers);
        void DeleteShippers(int id);
    }
}
