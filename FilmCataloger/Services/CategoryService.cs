using FilmCataloger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCataloger.Services
{
    public class CategoryService : IService<Categories>
    {
        private readonly FilmCatalogerDbContext _context;
        public static CategoryService Instance { get => CategoryServiceCreate.instance; }

        private CategoryService()
        {
            _context = ContextService.context;
        }

        private class CategoryServiceCreate
        {
            static CategoryServiceCreate() { }
            internal static CategoryService instance = new CategoryService();
        }

        public Categories AddObject(Categories entity)
        {
            Categories newCategory = entity;
            _context.Categories.Add(newCategory);
            int res = _context.SaveChanges();
            if (res == 0) { throw new Exception(); }
            return newCategory;
        }

        public Categories GetObject(int id)
        {
            return _context.Categories.FirstOrDefault(film => film.Id == id);
        }

        public ICollection<Categories> GetAllObjects()
        {
            return _context.Categories.ToList();
        }

        public bool RemoveObject(int id)
        {
            var res = _context.Categories.Remove(GetObject(id));
            if (res == null) { return false; }
            else return true;
        }
    }
}
