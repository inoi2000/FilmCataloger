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
    public partial class ChangePersonInfoForm : Form
    {
        Persons person;
        public ChangePersonInfoForm(Persons person)
        {
            InitializeComponent();
            this.person = person;
            FirstName_textBox.Text = person.FirstName;
            LastName_textBox.Text = person.LastName;
            PictureRef_textBox.Text = person.PictureRef;
            BirthDate_dateTimePicker.Value= person.BirthDate;

            ProfessionService.Instance.GetAllObjects().ToList().ForEach(obj => Professions_checkedListBox.Items.Add(obj));
            CountryService.Instance.GetAllObjects().ToList().ForEach(obj => Countries_comboBox.Items.Add(obj));

            if (person.Gender == Gender.Мужской) { MGender_radioButton.Checked = true; }
            else if (person.Gender == Gender.Женский) { FGender_radioButton.Checked = true; }

            foreach (Profession profession in person.Professions)
            {
                for (int i = 0; i < Professions_checkedListBox.Items.Count; i++)
                {
                    if (Professions_checkedListBox.Items[i] == profession)
                    {
                        Professions_checkedListBox.SetItemChecked(i, true);
                    }
                }
            }
            Countries_comboBox.SelectedItem = person.Сountry;
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
            if (MGender_radioButton.Checked) { newPerson.Gender = Gender.Мужской; }
            else if (FGender_radioButton.Checked) { newPerson.Gender = Gender.Женский; }
            foreach (Profession profession in Professions_checkedListBox.CheckedItems)
            {
                newPerson.Professions.Add(profession);
            }

            PersonService.Instance.ChangeObgest(person, newPerson);

            this.Close();
        }
    }
}
