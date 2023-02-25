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
            return _context.Persons.Include("Films").Include("Сountry").Include("Professions").FirstOrDefault(person => person.Id == id);
        }

        public Persons GetObject(string FirstName, string LastName)
        {
            return _context.Persons.Include("Films").Include("Сountry").Include("Professions").Where(p => p.FirstName == FirstName && p.LastName == LastName).FirstOrDefault();
        }

        public bool ChangeObgest(Persons mainPerson, Persons changePerson)
        {
            try
            {
                if (mainPerson.FirstName != changePerson.FirstName) { mainPerson.FirstName = changePerson.FirstName; }
                if (mainPerson.LastName != changePerson.LastName) { mainPerson.LastName = changePerson.LastName; }
                if (mainPerson.BirthDate != changePerson.BirthDate) { mainPerson.BirthDate = changePerson.BirthDate; }
                if (mainPerson.PictureRef != changePerson.PictureRef) { mainPerson.PictureRef = changePerson.PictureRef; }
                if (mainPerson.Сountry != changePerson.Сountry) { mainPerson.Сountry = changePerson.Сountry; }
                if (mainPerson.Gender!= changePerson.Gender) { mainPerson.Gender = changePerson.Gender; }

                mainPerson.Professions.Clear();
                changePerson.Professions.ToList().ForEach(p => { mainPerson.Professions.Add(p); });

                _context.SaveChanges();

                return true;
            }
            catch { return false; }
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
