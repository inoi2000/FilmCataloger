using FilmCataloger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FilmCataloger.Services
{
    public static class SearchService
    {
        // Film Search
        public static IEnumerable<Films> NameFilmSearch(ref IEnumerable<Films> searchedFilms, string Name)
        {
            Regex regex = new Regex($"(\\w*){Name}(\\w*)", RegexOptions.IgnoreCase);
            searchedFilms = from film in searchedFilms
                            where regex.IsMatch(film.Name)
                            select film;
            return searchedFilms;
        }

        public static IEnumerable<Films> GenresFilmSearch(ref IEnumerable<Films> searchedFilms, List<Genres> genresList)
        {
            searchedFilms = from film in searchedFilms
                            where film.Genres.Intersect(genresList).Count() > 0
                            select film;
            return searchedFilms;
        }

        public static IEnumerable<Films> GenresFilmSearch(ref IEnumerable<Films> searchedFilms, Genres genre)
        {
            searchedFilms = from film in searchedFilms
                            where film.Genres.Contains(genre)
                            select film;
            return searchedFilms;
        }

        public static IEnumerable<Films> CountriesFilmSearch(ref IEnumerable<Films> searchedFilms, List<Countries> countriesList)
        {
            searchedFilms = from film in searchedFilms
                            where film.Countries.Intersect(countriesList).Count() > 0
                            select film;
            return searchedFilms;
        }

        public static IEnumerable<Films> CountriesFilmSearch(ref IEnumerable<Films> searchedFilms, Countries country)
        {
            searchedFilms = from film in searchedFilms
                            where film.Countries.Contains(country)
                            select film;
            return searchedFilms;
        }

        public static IEnumerable<Films> IMDbFilmSearch(ref IEnumerable<Films> searchedFilms, float IMDbFrom, float IMDbTo)
        {
            searchedFilms = from film in searchedFilms
                            where film.IMDb >= IMDbFrom && film.IMDb <= IMDbTo
                            select film;
            return searchedFilms;
        }

        public static IEnumerable<Films> IMDbFilmSearch(ref IEnumerable<Films> searchedFilms, float IMDbFrom)
        {
            searchedFilms = from film in searchedFilms
                            where film.IMDb >= IMDbFrom
                            select film;
            return searchedFilms;
        }

        public static IEnumerable<Films> FeesFilmSearch(ref IEnumerable<Films> searchedFilms, decimal feesFrom, decimal feesTo)
        {
            searchedFilms = from film in searchedFilms
                            where film.FurtherInfo_FK.Fees > feesFrom && film.FurtherInfo_FK.Fees <= feesTo
                            select film;
            return searchedFilms;
        }

        public static IEnumerable<Films> ProductionFilmSearch(ref IEnumerable<Films> searchedFilms, int yearFrom, int yearTo)
        {
            searchedFilms = from film in searchedFilms
                            where film.Production.Year >= yearFrom && film.Production.Year <= yearTo
                            select film;
            return searchedFilms;
        }

        public static IEnumerable<Films> ProductionFilmSearch(ref IEnumerable<Films> searchedFilms, int year)
        {
            searchedFilms = from film in searchedFilms
                            where film.Production.Year == year
                            select film;
            return searchedFilms;
        }

        public static IEnumerable<Films> AgeLimitFilmSearch(ref IEnumerable<Films> searchedFilms, string ageLimit)
        {
            searchedFilms = from film in searchedFilms
                            where film.FurtherInfo_FK.AgeLimit == ageLimit
                            select film;
            return searchedFilms;
        }

        public static IEnumerable<Films> PersonInFilmSearch(ref IEnumerable<Films> searchedFilms, List<Persons> persons)
        {
            searchedFilms = from film in searchedFilms
                            where film.Persons.Intersect(persons).Count() == persons.Count()
                            select film;
            return searchedFilms;
        }
    }
}
