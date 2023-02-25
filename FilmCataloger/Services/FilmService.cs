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
            //entity.RelatedFilms.ToList().ForEach(rf => { rf.RelatedFilms.Add(entity); });
            //res = _context.SaveChanges();
            //if (res == 0) { throw new Exception(); }
            return newFilm;
        }

        public Films GetObject(int id)
        {
            return _context.Films.Include("FurtherInfo_FK").Include("Persons").Include("Genres").Include("Countries").FirstOrDefault(film => film.Id == id);
        }

        public Films GetObject(string Name)
        {
            return _context.Films.Include("FurtherInfo_FK").Include("Persons").Include("Genres").Include("Countries").FirstOrDefault(film => film.Name == Name);
        }

        public bool ChangeObgest(Films mainFilm, Films changeFilm)
        {
            try
            {
                if (mainFilm.Name != changeFilm.Name) { mainFilm.Name = changeFilm.Name; }
                if (mainFilm.Production != changeFilm.Production) { mainFilm.Production = changeFilm.Production; }
                if (mainFilm.IMDb != changeFilm.IMDb) { mainFilm.IMDb = changeFilm.IMDb; }
                if (mainFilm.PictureRef != changeFilm.PictureRef) { mainFilm.PictureRef = changeFilm.PictureRef; }
                if (mainFilm.Duration != changeFilm.Duration) { mainFilm.Duration = changeFilm.Duration; }

                mainFilm.Genres.Clear();
                foreach (Genres item in changeFilm.Genres)
                {
                    mainFilm.Genres.Add(item);
                }

                mainFilm.Countries.Clear();
                foreach (Countries item in changeFilm.Countries)
                {
                    mainFilm.Countries.Add(item);
                }

                FurtherInfo mainfurtherInfo = mainFilm.FurtherInfo_FK;
                FurtherInfo changefurtherInfo = changeFilm.FurtherInfo_FK;

                if (mainfurtherInfo.Description != changefurtherInfo.Description) { mainfurtherInfo.Description = changefurtherInfo.Description; }
                if (mainfurtherInfo.AgeLimit != changefurtherInfo.AgeLimit) { mainfurtherInfo.AgeLimit = changefurtherInfo.AgeLimit; }

                mainFilm.Persons.Clear();
                foreach (Persons item in changeFilm.Persons)
                {
                    mainFilm.Persons.Add(item);
                }

                //mainFilm.RelatedFilms.ToList().ForEach(rf =>
                //{
                //    if (rf.RelatedFilms.Contains(mainFilm)) { rf.RelatedFilms.Remove(mainFilm); }
                //});

                mainFilm.RelatedFilms.Clear();
                foreach (Films item in changeFilm.RelatedFilms)
                {
                    if (mainFilm == item) { continue; }
                    mainFilm.RelatedFilms.Add(item);
                }
                //mainFilm.RelatedFilms.ToList().ForEach(rf => 
                //{
                //    if (!rf.RelatedFilms.Contains(mainFilm))
                //    {
                //        rf.RelatedFilms.Add(mainFilm);
                //    }
                //});
                
                _context.SaveChanges();

                return true;
            }
            catch { return false; }
        }

        public ICollection<Films> GetAllObjects()
        {
            return _context.Films.Include("FurtherInfo_FK").Include("Persons").Include("Genres").Include("Countries").ToList();
        }

        public bool RemoveObject(int id)
        {
            var res = _context.Films.Remove(GetObject(id));
            if (res == null) { return false; }
            else return true;
        }
    }
}
