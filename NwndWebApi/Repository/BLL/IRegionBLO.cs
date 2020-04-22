using NwndWebApi.Models.DTO;
using NwndWebApi.ViewModels.UniForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Repository.BLL
{
    public interface IRegionBLO
    {
        IEnumerable<Region> GetRegion();
        void CreateRegion(inRegion inRegion);
        void UpdateRegion(inRegion inRegion);
        void DeleteRegion(int id);
    }
}
