using FilmCataloger.Model;
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
    public partial class CreatePersonForm : Form
    {
        private readonly FilmCatalogerDbContext _context;
        List<Profession> professions;
        List<Countries> countries;

        public CreatePersonForm()
        {
            InitializeComponent();
            _context = new FilmCatalogerDbContext();
            _context.Configuration.LazyLoadingEnabled = false;
            professions = _context.Professions.ToList();
            countries = _context.Countries.ToList();
            professions.ForEach(p => Professions_checkedListBox.Items.Add(p));
            countries.ForEach(c => Countries_comboBox.Items.Add(c));
        }

        private void Create_button_Click(object sender, EventArgs e)
        {
            Persons newPerson = new Persons
            {
                FirstName = FirstName_textBox.Text,
                LastName = LastName_textBox.Text,
                BirthDate = BirthDate_dateTimePicker.Value,
                PictureRef = PictureRef_textBox.Text,
                Сountry = (Countries)Countries_comboBox.SelectedItem
            };
            if (MGender_radioButton.Checked) { newPerson.Gender = 'М'; }
            else if (FGender_radioButton.Checked) { newPerson.Gender = 'F'; }
            foreach (Profession profession in Professions_checkedListBox.CheckedItems)
            {
                newPerson.Professions.Add(profession);
            }

            _context.Persons.Add(newPerson);

            _context.SaveChanges();

            MessageBox.Show("Добавление прошло успешно!");
            this.Close();
        }
    }
}
