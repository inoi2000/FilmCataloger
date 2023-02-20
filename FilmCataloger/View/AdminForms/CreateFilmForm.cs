using FilmCataloger.Model;
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
        private readonly FilmCatalogerDbContext _context;
        List<Genres> genres;
        List<Countries> сountries;

        public CreateFilmForm()
        {
            InitializeComponent();
            _context = new FilmCatalogerDbContext();
            _context.Configuration.LazyLoadingEnabled = false;
            genres = _context.Genres.ToList();
            сountries = _context.Countries.ToList();
            genres.ForEach(gen => { Genres_checkedListBox.Items.Add(gen); });
            сountries.ForEach(cou => { Countries_checkedListBox.Items.Add(cou); });
        }

        private void CreateFilm_button_Click(object sender, EventArgs e)
        {
            Films newFilm = new Films
            {
                Name = Name_textBox.Text,
                Production = Production_dateTimePicker.Value,
                IMDb = (float)IMDb_numericUpDown.Value,
                PictureRef = PictureRef_textBox.Text
            };
            foreach (Genres item in Genres_checkedListBox.CheckedItems)
            {
                newFilm.Genres.Add(item);
            }
            foreach (Countries item in Countries_checkedListBox.CheckedItems)
            {
                newFilm.Countries.Add(item);
            }
            FurtherInfo newFurtherInfo = new FurtherInfo
            {
                Description = Description_textBox.Text,
                AgeLimit = AgeLimit_comboBox.SelectedItem.ToString(),
                Fees = Fees_numericUpDown.Value
            };
            newFilm.FurtherInfo_FK = newFurtherInfo;

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
