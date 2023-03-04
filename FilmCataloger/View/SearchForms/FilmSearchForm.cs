using FilmCataloger.Model;
using FilmCataloger.Services;
using FilmCataloger.View.AdminForms.CreateFilmForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmCataloger.View.SearchForms
{
    public partial class FilmSearchForm : Form
    {
        ListView films_ListView;
        public FilmSearchForm(ref ListView films_ListView)
        {
            InitializeComponent();
            GenresService.Instance.GetAllObjects().ToList().ForEach(obj => Genres_checkedListBox.Items.Add(obj));
            CountryService.Instance.GetAllObjects().ToList().ForEach(obj => Countries_checkedListBox.Items.Add(obj));
            Persons_listBox.DoubleClick += Persons_listBox_DoubleClick;
            this.films_ListView = films_ListView;
            Name_textBox.Enabled = false;
            Genres_checkedListBox.Enabled = false;
            Countries_checkedListBox.Enabled = false;
            FeesFrom_numericUpDown.Enabled = false;
            FeesTo_numericUpDown.Enabled = false;
            YearForm_dateTimePicker.Enabled = false;
            YearTo_dateTimePicker.Enabled = false;
            AgeLimit_comboBox.Enabled = false;
            IMDbFrom_numericUpDown.Enabled = false;
            IMDbTo_numericUpDown.Enabled = false;
            Persons_listBox.Enabled = false;
            AddPerson_button.Enabled = false;
        }

        private void Persons_listBox_DoubleClick(object sender, EventArgs e)
        {
            if (Persons_listBox.SelectedItem != null) { Persons_listBox.Items.Remove(Persons_listBox.SelectedItem); }
        }

        private void Name_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Name_checkBox.Checked) { Name_textBox.Enabled = true; }
            else { Name_textBox.Enabled = false; }
        }

        private void Genres_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Genres_checkBox.Checked) { Genres_checkedListBox.Enabled= true; }
            else { Genres_checkedListBox.Enabled = false; }
        }

        private void Countries_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Countries_checkBox.Checked) { Countries_checkedListBox.Enabled = true; }
            else { Countries_checkedListBox.Enabled = false; }
        }

        private void Fees_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Fees_checkBox.Checked)
            {
                FeesFrom_numericUpDown.Enabled = true;
                FeesTo_numericUpDown.Enabled = true;
            }
            else
            {
                FeesFrom_numericUpDown.Enabled = false;
                FeesTo_numericUpDown.Enabled = false;
            }
        }

        private void Production_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Production_checkBox.Checked)
            {
                YearForm_dateTimePicker.Enabled = true;
                YearTo_dateTimePicker.Enabled = true;
            }
            else
            {
                YearForm_dateTimePicker.Enabled = false;
                YearTo_dateTimePicker.Enabled = false;
            }
        }

        private void AgeLimit_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AgeLimit_checkBox.Checked) { AgeLimit_comboBox.Enabled = true; }
            else { AgeLimit_comboBox.Enabled = false; }
        }

        private void Persons_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Persons_checkBox.Checked)
            {
                Persons_listBox.Enabled = true;
                AddPerson_button.Enabled = true;
            }
            else
            {
                Persons_listBox.Enabled = false;
                AddPerson_button.Enabled = false;
            }
        }

        private void IMDb_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IMDb_checkBox.Checked)
            {
                IMDbFrom_numericUpDown.Enabled = true;
                IMDbTo_numericUpDown.Enabled = true;
            }
            else
            {
                IMDbFrom_numericUpDown.Enabled = false;
                IMDbTo_numericUpDown.Enabled = false;
            }
        }
        private void AddPerson_button_Click(object sender, EventArgs e)
        {
            new AddPersonForm(ref Persons_listBox).ShowDialog();
        }

        private void StartSearch_button_Click(object sender, EventArgs e)
        {
            IEnumerable<Films> searchedFilms = FilmService.Instance.GetAllObjects();
            if (Name_checkBox.Checked) 
            {
                searchedFilms = SearchService.NameFilmSearch(ref searchedFilms, Name_textBox.Text);
            }
            if (Genres_checkBox.Checked) 
            {
                List<Genres> tempGenres = new List<Genres>();
                foreach (Genres item in Genres_checkedListBox.CheckedItems) { tempGenres.Add(item); }
                searchedFilms = SearchService.GenresFilmSearch(ref searchedFilms, tempGenres);
            }
            if (Countries_checkBox.Checked) 
            {
                List<Countries> tempCountries = new List<Countries>();
                foreach (Countries item in Countries_checkedListBox.CheckedItems) { tempCountries.Add(item); }
                searchedFilms = SearchService.CountriesFilmSearch(ref searchedFilms, tempCountries);
            }
            if (Fees_checkBox.Checked)
            {
                searchedFilms = SearchService.FeesFilmSearch(ref searchedFilms, FeesFrom_numericUpDown.Value, FeesTo_numericUpDown.Value);
            }
            if (Production_checkBox.Checked)
            {
                searchedFilms = SearchService.ProductionFilmSearch(ref searchedFilms, YearForm_dateTimePicker.Value.Year, YearTo_dateTimePicker.Value.Year);
            }
            if (IMDb_checkBox.Checked)
            {
                searchedFilms = SearchService.IMDbFilmSearch(ref searchedFilms, (float)IMDbFrom_numericUpDown.Value, (float)IMDbTo_numericUpDown.Value);
            }

            if (AgeLimit_checkBox.Checked)
            {
                if (AgeLimit_comboBox.SelectedItem != null)
                {
                    searchedFilms = SearchService.AgeLimitFilmSearch(ref searchedFilms, AgeLimit_comboBox.SelectedItem.ToString());
                }
            }
            if (Persons_checkBox.Checked)
            {
                if (Persons_listBox.Items.Count > 0)
                {
                    List<Persons> tempPersons = new List<Persons>();
                    foreach (Persons item in Persons_listBox.Items) { tempPersons.Add(item); }
                    searchedFilms = SearchService.PersonInFilmSearch(ref searchedFilms, tempPersons);
                }
            }

            if (searchedFilms.ToList().Count == 0)
            {
                MessageBox.Show("Фильмов по данногму запросу не найдено!");
            }
            else
            {
                films_ListView.Clear();
                ImageList filmsImagelist = new ImageList();
                try
                {
                    ViewService.FillingListView(searchedFilms.ToList(), films_ListView, filmsImagelist);
                }
                catch (System.Net.WebException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            DialogResult = DialogResult.OK;
        }

        
    }
}
