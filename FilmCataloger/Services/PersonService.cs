using FilmCataloger.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCataloger.Services
{
    public class PersonService : IService<Persons>
    {
        private readonly FilmCatalogerDbContext _context;
        public static PersonService Instance { get => PersonServiceCreate.instance; }

        private PersonService() 
        {
            _context = ContextService.context;
        }

        private class PersonServiceCreate
        {
            static PersonServiceCreate() { }
            internal static PersonService instance = new PersonService();
        }

        public Persons AddObject(Persons entity)
        {
            Persons newPerson = entity;
            _context.Persons.Add(newPerson);
            int res = _context.SaveChanges();
            if (res == 0) { throw new Exception(); }
            return newPerson;
        }

        public Persons GetObject(int id)
        {
            return _context.Persons.FirstOrDefault(person => person.Id == id);
        }

        public Persons GetObject(string FirstName, string LastName)
        {
            return _context.Persons.Where(p => p.FirstName == FirstName && p.LastName == LastName).FirstOrDefault();
        }

        public ICollection<Persons> GetAllObjects()
        {
            return _context.Persons.ToList();
        }

        public bool RemoveObject(int id)
        {
            var res = _context.Persons.Remove(GetObject(id));
            if (res == null) { return false; }
            else return true;
        }
    }

}
