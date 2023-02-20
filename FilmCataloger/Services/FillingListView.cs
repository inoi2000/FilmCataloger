using FilmCataloger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmCataloger.Services
{
    public static class FillingListView
    {
        public static bool ByFilms(ICollection<Films> films, ListView listView)
        {
            try
            {
                foreach (Films film in films)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = $"{film.IMDb} {film.Name}";
                    listViewItem.ImageKey = film.Id.ToString();

                    // TODO
                    // listView.LargeImageList.Images.Add()

                }
                return true;
            }
            catch { return false; }
        }

        public static bool  ByPerson(ICollection<Persons> persons, ListView listView) 
        {
            try
            {
                foreach (Persons person in persons)
                {

                }
                return true;
            }
            catch { return false; }
        }

        public static bool ByCategories(ICollection<Categories> categories, ListView listView)
        {
            try
            {
                foreach (Categories category in categories)
                {

                }
                return true;
            }
            catch { return false; }
        }
    }
}
