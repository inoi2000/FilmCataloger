using FilmCataloger.Model;
using FilmCataloger.Services;
using FilmCataloger.View.InfoForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmCataloger.View.CatalogForms
{
    public partial class FilmsCatalogForm : Form
    {
        public FilmsCatalogForm()
        {
            InitializeComponent();
            ImageList filmsImagelist = new ImageList();
            try
            {
                ViewService.FillingListView(FilmService.Instance.GetAllObjects(), Films_listView, filmsImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }

            Genres_comboBox.SelectedIndex = 0;
            Countries_comboBox.SelectedIndex = 0;
            IMDb_comboBox.SelectedIndex = 0;
            Sort_comboBox.SelectedIndex = 0;

            Films_listView.DoubleClick += Films_listView_DoubleClick;
            Genres_comboBox.SelectedIndexChanged += SortFilm;
            Countries_comboBox.SelectedIndexChanged += SortFilm;
            IMDb_comboBox.SelectedIndexChanged += SortFilm;
            Year_checkBox.CheckedChanged += SortFilm;
            Year_dateTimePicker.Enabled = false;
            Year_dateTimePicker.ValueChanged += SortFilm;

            Sort_comboBox.SelectedIndexChanged += SortFilm;

            GenresService.Instance.GetAllObjects().ToList().ForEach(obj => { Genres_comboBox.Items.Add(obj); });
            CountryService.Instance.GetAllObjects().ToList().ForEach(obj => { Countries_comboBox.Items.Add(obj); });

        }

        private void SortFilm(object sender, EventArgs e)
        {
            IEnumerable<Films> sortedFilms = FilmService.Instance.GetAllObjects();


            if (Genres_comboBox.SelectedIndex != 0)
            {
                sortedFilms = from film in sortedFilms
                              where film.Genres.Contains(Genres_comboBox.SelectedItem)
                              select film;
            }
            if (Countries_comboBox.SelectedIndex != 0)
            {
                sortedFilms = from film in sortedFilms
                              where film.Countries.Contains(Countries_comboBox.SelectedItem)
                              select film;
            }
            if (IMDb_comboBox.SelectedIndex != 0)
            {
                switch (IMDb_comboBox.SelectedIndex) 
                {
                    case 1:
                        sortedFilms = from film in sortedFilms
                                      where film.IMDb >= 9.0
                                      select film;
                        break;
                    case 2:
                        sortedFilms = from film in sortedFilms
                                      where film.IMDb >= 8.0
                                      select film;
                        break;
                    case 3:
                        sortedFilms = from film in sortedFilms
                                      where film.IMDb >= 7.0
                                      select film;
                        break;
                    case 4:
                        sortedFilms = from film in sortedFilms
                                      where film.IMDb >= 6.0
                                      select film;
                        break;
                    case 5:
                        sortedFilms = from film in sortedFilms
                                      where film.IMDb >= 5.0
                                      select film;
                        break;
                    case 6:
                        sortedFilms = from film in sortedFilms
                                      where film.IMDb >= 4.0
                                      select film;
                        break;
                    case 7:
                        sortedFilms = from film in sortedFilms
                                      where film.IMDb >= 3.0
                                      select film;
                        break;
                    case 8:
                        sortedFilms = from film in sortedFilms
                                      where film.IMDb >= 2.0
                                      select film;
                        break;
                    case 9:
                        sortedFilms = from film in sortedFilms
                                      where film.IMDb >= 1.0
                                      select film;
                        break;
                    case 10:
                        sortedFilms = from film in sortedFilms
                                      where film.IMDb >= 0.0
                                      select film;
                        break;
                }
            }
            if (Year_checkBox.Checked)
            {
                Year_dateTimePicker.Enabled = true;
                sortedFilms = from film in sortedFilms
                              where film.Production.Year == Year_dateTimePicker.Value.Year
                              select film;

            }
            else { Year_dateTimePicker.Enabled = false; }

            if (Sort_comboBox.SelectedIndex != 0)
            {
                switch (Sort_comboBox.SelectedIndex)
                {
                    case 1:
                        sortedFilms = from film in sortedFilms
                                      orderby film.IMDb descending
                                      select film;
                        break;
                    case 2:
                        sortedFilms = from film in sortedFilms
                                      orderby film.Name
                                      select film;
                        break;
                    case 3:
                        sortedFilms = from film in sortedFilms
                                      orderby film.Production
                                      select film;
                        break;
                    case 4:
                        sortedFilms = from film in sortedFilms
                                      orderby film.FurtherInfo_FK.Fees
                                      select film;
                        break;
                }
            }
            

            Films_listView.Clear();
            ImageList filmsImagelist = new ImageList();
            try
            {
                ViewService.FillingListView(sortedFilms.ToList(), Films_listView, filmsImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Films_listView_DoubleClick(object sender, EventArgs e)
        {
            Films film = FilmService.Instance.GetObject(int.Parse(Films_listView.FocusedItem.ImageKey));
            new FilmInfoForm(film).Show();
        }
    }
}
