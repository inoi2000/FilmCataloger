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
using static System.Net.WebRequestMethods;

namespace FilmCataloger.Services
{
    public static class ViewService
    {
        public static async Task FillingListView(ICollection<Films> films, ListView listView, ImageList imageList)
        {
            try
            {
                listView.LargeImageList = imageList;
                listView.LargeImageList.ImageSize = new Size(60, 90);
                await Task.Run(() =>
                {
                    foreach (Films film in films)
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.Text = $"★{film.IMDb} {film.Name}";
                        listViewItem.ImageKey = film.Id.ToString();

                        //Download the Image
                        WebClient wc = new WebClient();
                        byte[] bytes = wc.DownloadData(film.PictureRef);
                        MemoryStream ms = new MemoryStream(bytes);
                        Image img = Image.FromStream(ms);
                        ms.Dispose();
                        //Add the image to an image list
                        listView.Invoke(new Action(() =>
                        {
                            imageList.Images.Add(film.Id.ToString(), img);
                            listView.Items.Add(listViewItem);
                        }));
                    }
                });
            }
            catch (System.ObjectDisposedException) { }
            catch (System.Net.WebException) { throw new System.Net.WebException(); }
            catch { }
        }

        public static async Task FillingListView(ICollection<Persons> persons, ListView listView, ImageList imageList)
        {
            try
            {
                listView.LargeImageList = imageList;
                listView.LargeImageList.ImageSize = new Size(60, 90);
                await Task.Run(() =>
                {
                    foreach (Persons person in persons)
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.Text = $"{person.FirstName} {person.LastName}";
                        listViewItem.ImageKey = person.Id.ToString();

                        //Download the Image
                        WebClient wc = new WebClient();
                        byte[] bytes = wc.DownloadData(person.PictureRef);
                        MemoryStream ms = new MemoryStream(bytes);
                        Image img = Image.FromStream(ms);
                        ms.Dispose();
                        //Add the image to an image list
                        listView.Invoke(new Action(() =>
                        {
                            imageList.Images.Add(person.Id.ToString(), img);
                            listView.Items.Add(listViewItem);
                        }));
                    }
                });
            }
            catch (System.ObjectDisposedException) { }
            catch (System.Net.WebException) { throw new System.Net.WebException(); }
            catch { }
        }

        public static async Task FillingListView(ICollection<Categories> categories, ListView listView, ImageList imageList)
        {
            try
            {
                listView.LargeImageList = imageList;
                listView.LargeImageList.ImageSize = new Size(60, 90);
                await Task.Run(() =>
                {
                    foreach (Categories category in categories)
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.Text = $"{category.Name}";
                        listViewItem.ImageKey = category.Id.ToString();

                        //Download the Image
                        WebClient wc = new WebClient();
                        byte[] bytes = wc.DownloadData(category.PictureRef);
                        MemoryStream ms = new MemoryStream(bytes);
                        Image img = Image.FromStream(ms);
                        ms.Dispose();
                        //Add the image to an image list
                        listView.Invoke(new Action(() =>
                        {
                            imageList.Images.Add(category.Id.ToString(), img);
                            listView.Items.Add(listViewItem);
                        }));
                    }
                });
            }
            catch (System.ObjectDisposedException) { }
            catch (System.Net.WebException) { throw new System.Net.WebException(); }
            catch { }
        }
    }
}
