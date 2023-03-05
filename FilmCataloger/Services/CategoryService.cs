using FilmCataloger.Migrations;
using FilmCataloger.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCataloger.Services
{
    public class CategoryService : IService<Categories>
    {
        private readonly FilmCatalogerDbContext _context;
        event Action UpdateAllCatigories;
        public static CategoryService Instance { get => CategoryServiceCreate.instance; }

        private CategoryService()
        {
            _context = ContextService.context;
            UpdateAllCatigories += CategoryRequest1;
            UpdateAllCatigories += CategoryRequest2;
            UpdateAllCatigories += CategoryRequest5;
            UpdateAllCatigories += CategoryRequest6;
            UpdateAllCatigories += CategoryRequest7;
            UpdateAllCatigories += CategoryRequest9;
            UpdateAllCatigories += CategoryRequest10;
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
            return _context.Categories.Include("Films").Include("Persons").FirstOrDefault(film => film.Id == id);
        }

        public ICollection<Categories> GetAllObjects()
        {
            return _context.Categories.Include("Films").Include("Persons").ToList();
        }

        public bool RemoveObject(int id)
        {
            var res = _context.Categories.Remove(GetObject(id));
            if (res == null) { return false; }
            else return true;
        }

        public async Task UpdateCatigoriesAsync()
        {
            try
            {
                // отчистка связующих таблиц
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;

                        command.CommandText = "delete from FilmsCategories;";
                        command.ExecuteNonQuery();

                        command.CommandText = "delete from PersonsCategories";
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }

                // перезаполнение категорий
                await Task.Run(UpdateAllCatigories);
                await _context.SaveChangesAsync();
            }
            catch { }
        }

        private void CategoryRequest1()
        {
            Categories category = _context.Categories.Include("Films").FirstOrDefault(c => c.Name == "Самый самый");
            if (category != null)
            {
                category.Films.Clear();

                //самый высокий по рейтингу
                var mostRatingFilm = _context.Films.OrderByDescending(f => f.IMDb).FirstOrDefault();
                if (!category.Films.Contains(mostRatingFilm) && mostRatingFilm != null) { category.Films.Add(mostRatingFilm); }
                //самый высокий по сборам
                var mostExpensiveFilm = _context.Films.Include("FurtherInfo_FK").OrderByDescending(f => f.FurtherInfo_FK.Fees).FirstOrDefault();
                if (!category.Films.Contains(mostExpensiveFilm) && mostExpensiveFilm != null) { category.Films.Add(mostExpensiveFilm); }
                //самый старый по дате выхода
                var mostOlderFilm = _context.Films.OrderBy(f => f.Production).FirstOrDefault();
                if (!category.Films.Contains(mostOlderFilm) && mostOlderFilm != null) { category.Films.Add(mostOlderFilm); }
            }
        }

        private void CategoryRequest2()
        {
            Categories category = _context.Categories.Include("Films").FirstOrDefault(c => c.Name == "Лучше чем \"Властелин колец: Возвращение короля\"");
            if (category != null)
            {
                category.Films.Clear();

                var lordOfTheRing = _context.Films.FirstOrDefault(fl => fl.Name == "Властелин колец: Возвращение короля");
                var Films = _context.Films.Where(f => f.IMDb > lordOfTheRing.IMDb);
                if (Films.Count() > 0) Films.ToList().ForEach(f => category.Films.Add(f));
            }
        }

        private void CategoryRequest5()
        {
            Categories category = _context.Categories.Include("Films").FirstOrDefault(c => c.Name == "Страна рекордсмен по съемкам");
            if (category != null)
            {
                category.Films.Clear();

                var res = _context.Countries.Include("Films").OrderByDescending(c => c.Films.Count()).FirstOrDefault();
                if (res != null)
                {
                    res.Films.ToList().ForEach(f => category.Films.Add(f));
                }
            }
        }

        private void CategoryRequest6()
        {
            Categories category = _context.Categories.Include("Persons").FirstOrDefault(c => c.Name == "Звезды Франции");
            if (category != null)
            {
                category.Persons.Clear();

                var res = _context.Persons.Include("Сountry").Where(p => p.Сountry.Name == "Франция" && p.Gender == Gender.Мужской);
                if (res != null)
                {
                    res.ToList().ForEach(p => category.Persons.Add(p));
                }
            }
        }

        private void CategoryRequest7()
        {
            Categories category = _context.Categories.Include("Persons").FirstOrDefault(c => c.Name == "На все руки Актрисы");
            if (category != null)
            {
                category.Persons.Clear();

                var res = _context.Persons.Include("Professions").Where(p => p.Professions.Contains(_context.Professions.FirstOrDefault(prof => prof.Name == "Актер")) && p.Professions.Count > 1 && p.Gender == Gender.Женский);
                if (res != null)
                {
                    res.ToList().ForEach(p => category.Persons.Add(p));
                }
            }
        }

        private void CategoryRequest9()
        {
            Categories category = _context.Categories.Include("Persons").FirstOrDefault(c => c.Name == "Звезды 1995");
            if (category != null)
            {
                category.Persons.Clear();

                var res = _context.Persons.Include("Films").Where(p => p.Films.Any(f => f.Production.Year == 1995));
                if (res != null)
                {
                    res.ToList().ForEach(p => category.Persons.Add(p));
                }
            }
        }

        private void CategoryRequest10()
        {
            Categories category = _context.Categories.Include("Persons").FirstOrDefault(c => c.Name == "Сам себе режисер");
            if (category != null)
            {
                category.Persons.Clear();

                var res = _context.Persons.Include("Professions").Where(p => p.Professions.Contains(_context.Professions.FirstOrDefault(prof => prof.Name == "Режиссер")) && p.Professions.Contains(_context.Professions.FirstOrDefault(prof => prof.Name == "Актер")));
                if (res != null)
                {
                    res.ToList().ForEach(p => category.Persons.Add(p));
                }
            }
        }
    }
}
