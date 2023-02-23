using FilmCataloger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCataloger.Services
{
    public class CountryService : IService<Countries>
    {
        private readonly FilmCatalogerDbContext _context;
        public static CountryService Instance { get => CountryServiceCreate.instance; }

        private CountryService() 
        {
            _context = ContextService.context;
        }

        private class CountryServiceCreate
        {
            static CountryServiceCreate() { }
            internal static CountryService instance = new CountryService();
        }

        public Countries AddObject(Countries entity)
        {
            Countries newCountry = entity;
            _context.Countries.Add(newCountry);
            int res = _context.SaveChanges();
            if (res == 0) { throw new Exception(); }
            return newCountry;
        }

        public Countries GetObject(int id)
        {
            return _context.Countries.FirstOrDefault(country => country.Id == id);
        }

        public ICollection<Countries> GetAllObjects()
        {
            return _context.Countries.ToList();
        }

        public bool RemoveObject(int id)
        {
            var res = _context.Countries.Remove(GetObject(id));
            if (res == null) { return false; }
            else return true;
        }
    }
}
