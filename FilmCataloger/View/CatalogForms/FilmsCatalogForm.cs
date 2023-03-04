using FilmCataloger.Model;
using FilmCataloger.Services;
using FilmCataloger.View.InfoForms;
using FilmCataloger.View.SearchForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                sortedFilms = SearchService.GenresFilmSearch(ref sortedFilms, Genres_comboBox.SelectedItem as Genres);
            }
            if (Countries_comboBox.SelectedIndex != 0)
            {
                sortedFilms = SearchService.CountriesFilmSearch(ref sortedFilms, Countries_comboBox.SelectedItem as Countries);
            }
            if (IMDb_comboBox.SelectedIndex != 0)
            {
                switch (IMDb_comboBox.SelectedIndex) 
                {
                    case 1:
                        sortedFilms = SearchService.IMDbFilmSearch(ref sortedFilms, (float)9.0);
                        break;
                    case 2:
                        sortedFilms = SearchService.IMDbFilmSearch(ref sortedFilms, (float)8.0);
                        break;
                    case 3:
                        sortedFilms = SearchService.IMDbFilmSearch(ref sortedFilms, (float)7.0);
                        break;
                    case 4:
                        sortedFilms = SearchService.IMDbFilmSearch(ref sortedFilms, (float)6.0);
                        break;
                    case 5:
                        sortedFilms = SearchService.IMDbFilmSearch(ref sortedFilms, (float)5.0);
                        break;
                    case 6:
                        sortedFilms = SearchService.IMDbFilmSearch(ref sortedFilms, (float)4.0);
                        break;
                    case 7:
                        sortedFilms = SearchService.IMDbFilmSearch(ref sortedFilms, (float)3.0);
                        break;
                    case 8:
                        sortedFilms = SearchService.IMDbFilmSearch(ref sortedFilms, (float)2.0);
                        break;
                    case 9:
                        sortedFilms = SearchService.IMDbFilmSearch(ref sortedFilms, (float)1.0);
                        break;
                }
            }
            if (Year_checkBox.Checked)
            {
                Year_dateTimePicker.Enabled = true;
                sortedFilms = SearchService.ProductionFilmSearch(ref sortedFilms, Year_dateTimePicker.Value.Year);
            }
            else { Year_dateTimePicker.Enabled = false; }

            if (Sort_comboBox.SelectedIndex != 0)
            {
                switch (Sort_comboBox.SelectedIndex)
                {
                    case 1:
                        sortedFilms = SortService.IMDbFilmSort(ref sortedFilms);
                        break;
                    case 2:
                        sortedFilms = SortService.NameFilmSort(ref sortedFilms);
                        break;
                    case 3:
                        sortedFilms = SortService.ProductionFilmSort(ref sortedFilms);
                        break;
                    case 4:
                        sortedFilms = SortService.FeesFilmSort(ref sortedFilms);
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

        private void SearchPlus_button_Click(object sender, EventArgs e)
        {
            new FilmSearchForm(ref Films_listView).ShowDialog();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            IEnumerable<Films> searchedFilms = FilmService.Instance.GetAllObjects();
            searchedFilms = SearchService.NameFilmSearch(ref searchedFilms, SearchField_textBox.Text);

            Films_listView.Clear();
            ImageList filmsImagelist = new ImageList();
            try
            {
                ViewService.FillingListView(searchedFilms.ToList(), Films_listView, filmsImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MainMenu_button_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
        }
    }
}
