using FilmCataloger.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmCataloger.Services
{
    public static class ViewService
    {
        public static bool FillingListView(ICollection<Films> films, ListView listView)
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

        public static bool FillingListView(ICollection<Persons> persons, ListView listView, ImageList imageList)
        {
            //try
            {
                listView.LargeImageList = imageList;
                listView.LargeImageList.ImageSize = new Size(60, 90);
                foreach (Persons person in persons)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = $"{person.FirstName} {person.LastName}";
                    listViewItem.ImageKey = person.Id.ToString();

                    //Download the Image
                    WebClient wc = new WebClient();
                    byte[] bytes = wc.DownloadData(person.PictureRef);
                    MemoryStream ms = new MemoryStream(bytes);
                    System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                    ms.Dispose();

                    //Add the image to an image list
                    imageList.Images.Add(person.Id.ToString(), img);
                    
                    listView.Items.Add(listViewItem);
                }
                return true;
            }
            //catch { return false; }
        }

        public static bool FillingListView(ICollection<Categories> categories, ListView listView)
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
