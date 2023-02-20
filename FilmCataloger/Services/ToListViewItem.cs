using FilmCataloger.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmCataloger.Services
{
    public static class ToListViewItem
    {
        public static ListViewItem FromFilm(Films film)
        {
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.Text = $"{film.IMDb} {film.Name}";
            listViewItem.ImageKey = film.Id.ToString();
            return null; // TODO
        }
        public static List<ListViewItem> FromFilms(ICollection<Films> films) 
        {
            return null; // TODO
        }
    }
}
