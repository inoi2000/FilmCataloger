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
    public partial class CreateFilmForm : Form
    {
        public CreateFilmForm()
        {
            InitializeComponent();
            GenresService.Instance.GetAllObjects().ToList().ForEach(obj => Genres_checkedListBox.Items.Add(obj));
            CountryService.Instance.GetAllObjects().ToList().ForEach(obj => Countries_checkedListBox.Items.Add(obj));
            AgeLimit_comboBox.SelectedIndex= 0;
            Persons_listBox.DoubleClick += Persons_listBox_DoubleClick;
            RelatedFilms_listBox.DoubleClick += RelatedFilms_listBox_DoubleClick;
        }
        private void RelatedFilms_listBox_DoubleClick(object sender, EventArgs e)
        {
            if (RelatedFilms_listBox.SelectedItem != null)
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
        private void CreateFilm_button_Click(object sender, EventArgs e)
        {
            // Creating new Film
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

            // Adding new Film
            FilmService.Instance.AddObject(newFilm);

            this.Close();
        }

        private void AddPerson_button_Click(object sender, EventArgs e)
        {
            new AddPersonForm(ref Persons_listBox).ShowDialog();
        }

        private void AddRelatedFilm_button_Click(object sender, EventArgs e)
        {
            new AddRelatedFilmForm(ref RelatedFilms_listBox).ShowDialog();
        }
    }
}
