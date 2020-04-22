using NwndWebApi.Factory;
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
    [DependencyRegister]
    public class TerritoriesBLO : ITerritoriesBLO
    {
        private ITerritoriesDAO iTerritoriesDAO;

        public TerritoriesBLO(ITerritoriesDAO _iTerritoriesDAO)
        {
            iTerritoriesDAO = _iTerritoriesDAO;
        }

        public void CreateTerritories(inTerritories inTerritories)
        {
            try
            {
                Territories territories = new Territories()
                {
                    TerritoryId = inTerritories.TerritoryId,
                    TerritoryDescription = inTerritories.TerritoryDescription,
                    RegionId = inTerritories.RegionId
                };
                iTerritoriesDAO.CreateTerritories(territories);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteTerritories(string id)
        {
            try
            {
                iTerritoriesDAO.DeleteTerritories(id);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public IEnumerable<Territories> GetTerritories()
        {
            try
            {
                IEnumerable<Territories> _Territories = iTerritoriesDAO.GetTerritories();

                return _Territories;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateTerritories(inTerritories inTerritories)
        {
            try
            {
                Territories territories = new Territories()
                {
                    TerritoryId = inTerritories.TerritoryId,
                    TerritoryDescription = inTerritories.TerritoryDescription,
                    RegionId = inTerritories.RegionId
                };
                iTerritoriesDAO.UpdateTerritories(territories);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
