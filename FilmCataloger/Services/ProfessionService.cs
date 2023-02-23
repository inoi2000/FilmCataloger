using FilmCataloger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCataloger.Services
{
    public class ProfessionService : IService<Profession>
    {
        private readonly FilmCatalogerDbContext _context;
        public static ProfessionService Instance { get => ProfessionServiceCreate.instance; }

        private ProfessionService() 
        {
            _context = ContextService.context;
        }

        private class ProfessionServiceCreate
        {
            static ProfessionServiceCreate() { }
            internal static ProfessionService instance = new ProfessionService();
        }

        public Profession AddObject(Profession entity)
        {
            Profession newProfession = entity;
            _context.Professions.Add(newProfession);
            int res = _context.SaveChanges();
            if (res == 0) { throw new Exception(); }
            return newProfession;
        }

        public Profession GetObject(int id)
        {
            return _context.Professions.FirstOrDefault(profession => profession.Id == id);
        }

        public ICollection<Profession> GetAllObjects()
        {
            return _context.Professions.ToList();
        }

        public bool RemoveObject(int id)
        {
            var res = _context.Professions.Remove(GetObject(id));
            if (res == null) { return false; }
            else return true;
        }
    }
}
