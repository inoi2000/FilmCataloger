using FilmCataloger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCataloger.Services
{
    public class GenresService : IService<Genres>
    {
        private readonly FilmCatalogerDbContext _context;
        public static GenresService Instance { get => GenresServiceCreate.instance; }

        private GenresService()
        {
            _context = ContextService.context;
        }

        private class GenresServiceCreate
        {
            static GenresServiceCreate() { }
            internal static GenresService instance = new GenresService();
        }

        public Genres AddObject(Genres entity)
        {
            Genres newGenre = entity;
            _context.Genres.Add(newGenre);
            int res = _context.SaveChanges();
            if (res == 0) { throw new Exception(); }
            return newGenre;
        }

        public Genres GetObject(int id)
        {
            return _context.Genres.FirstOrDefault(genre => genre.Id == id);
        }

        public ICollection<Genres> GetAllObjects()
        {
            return _context.Genres.ToList();
        }

        public bool RemoveObject(int id)
        {
            var res = _context.Genres.Remove(GetObject(id));
            if (res == null) { return false; }
            else return true;
        }
    }
}
