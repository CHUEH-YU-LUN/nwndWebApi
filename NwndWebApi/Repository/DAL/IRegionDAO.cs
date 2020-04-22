using NwndWebApi.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.DAL
{
    public interface IRegionDAO
    {
        IEnumerable<Region> GetRegion();
        void CreateRegion(Region region);
        void UpdateRegion(Region region);
        void DeleteRegion(int id);
    }
}
