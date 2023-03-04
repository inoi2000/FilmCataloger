using FilmCataloger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FilmCataloger.Services
{
    public static class SortService
    {
        // Film Sort
        public static IEnumerable<Films> IMDbFilmSort(ref IEnumerable<Films> sortedFilms)
        {
            sortedFilms = from film in sortedFilms
                          orderby film.IMDb descending
                          select film;
            return sortedFilms;
        }

        public static IEnumerable<Films> NameFilmSort(ref IEnumerable<Films> sortedFilms)
        {
            sortedFilms = from film in sortedFilms
                          orderby film.Name
                          select film;
            return sortedFilms;
        }

        public static IEnumerable<Films> ProductionFilmSort(ref IEnumerable<Films> sortedFilms)
        {
            sortedFilms = from film in sortedFilms
                          orderby film.Production
                          select film;
            return sortedFilms;
        }

        public static IEnumerable<Films> FeesFilmSort(ref IEnumerable<Films> sortedFilms)
        {
            sortedFilms = from film in sortedFilms
                          orderby film.FurtherInfo_FK.Fees
                          select film;
            return sortedFilms;
        }

        // Person Sort
        public static IEnumerable<Persons> NamePersonSort(ref IEnumerable<Persons> sortedPersons)
        {
            sortedPersons = from persons in sortedPersons
                            orderby persons.FirstName
                            select persons;
            return sortedPersons;
        }

        public static IEnumerable<Persons> BirthDatePersonSort(ref IEnumerable<Persons> sortedPersons)
        {
            sortedPersons = from persons in sortedPersons
                            orderby persons.BirthDate
                            select persons;
            return sortedPersons;
        }
    }
}
