using NwndWebApi.Models.DTO;
using NwndWebApi.Repository.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NwndWebApi.Models.DAL
{
    public class TerritoriesDAO : ITerritoriesDAO
    {
        private readonly NorthwindContext _context;

        public TerritoriesDAO(NorthwindContext context)
        {
            _context = context;
        }

        public void CreateTerritories(Territories territories)
        {
            try
            {
                _context.Territories.Add(territories);
                _context.SaveChanges();
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
                var _Territories = _context.Territories.Find(id);
                _context.Territories.Remove(_Territories);
                _context.SaveChanges();
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
                IEnumerable<Territories> _Territories = from x in _context.Territories select x;

                return _Territories;
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }

        public void UpdateTerritories(Territories territories)
        {
            try
            {
                _context.Territories.Update(territories);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
