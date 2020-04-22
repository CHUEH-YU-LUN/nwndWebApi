using NwndWebApi.Factory;
using NwndWebApi.Models.DTO;
using NwndWebApi.Repository.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Models.DAL
{
    [DependencyRegister]
    public class RegionDAO : IRegionDAO
    {
        private readonly NorthwindContext _context;

        public RegionDAO(NorthwindContext context)
        {
            _context = context;
        }

        public void CreateRegion(Region region)
        {
            try
            {
                _context.Region.Add(region);
                _context.SaveChanges();
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
                var _Region = _context.Region.Find(id);
                _context.Region.Remove(_Region);
                _context.SaveChanges();
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
                IEnumerable<Region> _Region = from x in _context.Region select x;

                return _Region;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateRegion(Region region)
        {
            try
            {
                _context.Region.Update(region);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
