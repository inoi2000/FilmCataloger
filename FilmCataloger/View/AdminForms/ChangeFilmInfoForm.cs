using FilmCataloger.Model;
using FilmCataloger.Services;
using FilmCataloger.View.AdminForms.CreateFilmForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmCataloger.View.AdminForms
{
    public partial class ChangeFilmInfoForm : Form
    {
        Films film;
        public ChangeFilmInfoForm(Films film)
        {
            InitializeComponent();
            GenresService.Instance.GetAllObjects().ToList().ForEach(obj => Genres_checkedListBox.Items.Add(obj));
            CountryService.Instance.GetAllObjects().ToList().ForEach(obj => Countries_checkedListBox.Items.Add(obj));
            AgeLimit_comboBox.SelectedIndex = 0;
            this.film = film;
            Persons_listBox.DoubleClick += Persons_listBox_DoubleClick;
            RelatedFilms_listBox.DoubleClick += RelatedFilms_listBox_DoubleClick;

            // заполнение полей фомы полями объекта film
            Name_textBox.Text = film.Name;
            Production_dateTimePicker.Value = film.Production;
            IMDb_numericUpDown.Value = (decimal)film.IMDb;
            PictureRef_textBox.Text = film.PictureRef;
            Duration_dateTimePicker.Value = film.Duration;
                        
            foreach (Genres filmGenre in film.Genres)
            {
                for (int i = 0; i < Genres_checkedListBox.Items.Count; i++)
                {
                    if (Genres_checkedListBox.Items[i] == filmGenre)
                    {
                        Genres_checkedListBox.SetItemChecked(i, true);
                    }
                }
            }

            foreach (Countries filmCountry in film.Countries)
            {
                for (int i = 0; i < Countries_checkedListBox.Items.Count; i++)
                {
                    if (Countries_checkedListBox.Items[i] == filmCountry)
                    {
                        Countries_checkedListBox.SetItemChecked(i, true);
                    }
                }
            }
            foreach (Persons item in film.Persons)
            {
                Persons_listBox.Items.Add(item);
            }
            foreach (Films item in film.RelatedFilms)
            {
                RelatedFilms_listBox.Items.Add(item);
            }

            FurtherInfo furtherInfo = film.FurtherInfo_FK;
            Description_textBox.Text = furtherInfo.Description;
            foreach (string item in AgeLimit_comboBox.Items)
            {
                if (item == furtherInfo.AgeLimit)
                {
                    AgeLimit_comboBox.SelectedItem = item;
                }
            }
        }

        private void RelatedFilms_listBox_DoubleClick(object sender, EventArgs e)
        {
            if(RelatedFilms_listBox.SelectedItem != null)
            {
                RelatedFilms_listBox.Items.Remove(RelatedFilms_listBox.SelectedItem);
            }
        }

        private void Persons_listBox_DoubleClick(object sender, EventArgs e)
        {
            if (Persons_listBox.SelectedItem != null)
            {
                Persons_listBox.Items.Remove(Persons_listBox.SelectedItem);
            }
        }

        private void AddPerson_button_Click(object sender, EventArgs e)
        {
            new AddPersonForm(ref Persons_listBox).ShowDialog();
        }

        private void AddRelatedFilm_button_Click(object sender, EventArgs e)
        {
            new AddRelatedFilmForm(ref RelatedFilms_listBox).ShowDialog();
        }

        private void CreateFilm_button_Click(object sender, EventArgs e)
        {
            // проверка на соответствие полей фильма с полями формы, при несоответствии изменение полей фильма
            Films newFilm = new Films
            {
                Name = Name_textBox.Text,
                Production = Production_dateTimePicker.Value,
                IMDb = (float)IMDb_numericUpDown.Value,
                PictureRef = PictureRef_textBox.Text,
                Duration = Duration_dateTimePicker.Value
            };
            foreach (Genres item in Genres_checkedListBox.CheckedItems)
            {
                newFilm.Genres.Add(item);
            }
            foreach (Countries item in Countries_checkedListBox.CheckedItems)
            {
                newFilm.Countries.Add(item);
            }
            foreach (Persons item in Persons_listBox.Items)
            {
                newFilm.Persons.Add(item);
            }
            foreach (Films item in RelatedFilms_listBox.Items)
            {
                if (newFilm == item) { continue; }
                newFilm.RelatedFilms.Add(item);
            }
            FurtherInfo newFurtherInfo = new FurtherInfo
            {
                Description = Description_textBox.Text,
                AgeLimit = AgeLimit_comboBox.SelectedItem.ToString(),
                Fees = Fees_numericUpDown.Value
            };
            newFilm.FurtherInfo_FK = newFurtherInfo;


            if(FilmService.Instance.ChangeObgest(film, newFilm))
            {
                MessageBox.Show("Изменение прошло успешно");
            }
            else { MessageBox.Show("Ошибка изменения"); }

            this.Close();
        }
    }
}
