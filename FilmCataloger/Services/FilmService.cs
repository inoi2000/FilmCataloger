using FilmCataloger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCataloger.Services
{
    public class FilmService : IService<Films>
    {
        private readonly FilmCatalogerDbContext _context;
        public static FilmService Instance { get => FilmServiceCreate.instance; }

        private FilmService()
        {
            _context = ContextService.context;
        }

        private class FilmServiceCreate
        {
            static FilmServiceCreate() { }
            internal static FilmService instance = new FilmService();
        }

        public Films AddObject(Films entity)
        {
            Films newFilm = entity;
            _context.Films.Add(newFilm);
            int res = _context.SaveChanges();
            if (res == 0) { throw new Exception(); }
            return newFilm;
        }

        public Films GetObject(int id)
        {
            return _context.Films.FirstOrDefault(film => film.Id == id);
        }

        public Films GetObject(string Name)
        {
            return _context.Films.FirstOrDefault(film => film.Name == Name);
        }

        public ICollection<Films> GetAllObjects()
        {
            return _context.Films.ToList();
        }

        public bool RemoveObject(int id)
        {
            var res = _context.Films.Remove(GetObject(id));
            if (res == null) { return false; }
            else return true;
        }
    }
}
