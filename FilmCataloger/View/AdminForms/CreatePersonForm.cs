using FilmCataloger.Model;
using FilmCataloger.Services;
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
        public CreatePersonForm()
        {
            InitializeComponent();
            List<Profession> professions;
            List<Countries> countries;
            professions = ProfessionService.Instance.GetAllObjects().ToList();
            professions.ForEach(obj => Professions_checkedListBox.Items.Add(obj));
            countries = CountryService.Instance.GetAllObjects().ToList();
            countries.ForEach(obj => Countries_comboBox.Items.Add(obj));
        }

        private void Create_button_Click(object sender, EventArgs e)
        {
            // Creating new Person
            Persons newPerson = new Persons
            {
                FirstName = FirstName_textBox.Text,
                LastName = LastName_textBox.Text,
                BirthDate = BirthDate_dateTimePicker.Value,
                PictureRef = PictureRef_textBox.Text,
                Сountry = (Countries)Countries_comboBox.SelectedItem
            };
            if (MGender_radioButton.Checked) { newPerson.Gender = Gender.Мужской; }
            else if (FGender_radioButton.Checked) { newPerson.Gender = Gender.Женский; }
            foreach (Profession profession in Professions_checkedListBox.CheckedItems)
            {
                newPerson.Professions.Add(profession);
            }
            // Adding new Person
            PersonService.Instance.AddObject(newPerson);

            this.Close();
        }
    }
}
