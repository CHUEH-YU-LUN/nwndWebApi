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
    public class RegionBLO : IRegionBLO
    {
        private IRegionDAO iRegionDAO;

        public RegionBLO(IRegionDAO _iRegionDAO)
        {
            iRegionDAO = _iRegionDAO;
        }

        public void CreateRegion(inRegion inRegion)
        {
            try
            {
                Region region = new Region()
                {
                    RegionId = inRegion.RegionId,
                    RegionDescription = inRegion.RegionDescription
                };
                iRegionDAO.CreateRegion(region);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void DeleteRegion(int id)
        {
            try
            {
                iRegionDAO.DeleteRegion(id);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public IEnumerable<Region> GetRegion()
        {
            try
            {
                IEnumerable<Region> _Region = iRegionDAO.GetRegion();

                return _Region;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateRegion(inRegion inRegion)
        {
            try
            {
                Region region = new Region()
                {
                    RegionId = inRegion.RegionId,
                    RegionDescription = inRegion.RegionDescription
                };
                iRegionDAO.UpdateRegion(region);
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
