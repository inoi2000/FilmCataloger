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
    public class PersonService : IService
    {
        private readonly FilmCatalogerDbContext _context;
        public static PersonService Instance { get => PersonServiceCreate.instance; }

        private PersonService() { _context = new FilmCatalogerDbContext(); }

        private class PersonServiceCreate
        {
            static PersonServiceCreate() { }
            internal static PersonService instance = new PersonService();
        }

        public IEntity AddObject(IEntity entity)
        {
            Persons newPerson = (Persons)entity;
            _context.Persons.Add(newPerson);
            int res = _context.SaveChanges();
            if (res == 0) { throw new Exception(); }
            return newPerson;
        }

        public IEntity GetObject(int id)
        {
            return _context.Persons.FirstOrDefault(person => person.Id == id);
        }

        public ICollection<Persons> GetAllObjects()
        {
            return _context.Persons.ToList();
        }

        public bool RemoveObject(int id)
        {
            throw new NotImplementedException();
        }
    }

}
