using NwndWebApi.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.DAL
{
    public interface ITerritoriesDAO
    {
        IEnumerable<Territories> GetTerritories();
        void CreateTerritories(Territories territories);
        void UpdateTerritories(Territories territories);
        void DeleteTerritories(int id);
    }
}
