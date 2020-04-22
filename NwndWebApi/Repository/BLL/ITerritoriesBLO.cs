using NwndWebApi.Models.DTO;
using NwndWebApi.ViewModels.UniForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.BLL
{
    public interface ITerritoriesBLO
    {
        IEnumerable<Territories> GetTerritories();
        void CreateTerritories(inTerritories inTerritories);
        void UpdateTerritories(inTerritories inTerritories);
        void DeleteTerritories(string id);
    }
}
