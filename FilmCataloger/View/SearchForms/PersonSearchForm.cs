using FilmCataloger.Model;
using FilmCataloger.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmCataloger.View.SearchForms
{
    public partial class PersonSearchForm : Form
    {
        ListView persons_ListView;
        public PersonSearchForm(ref ListView persons_ListView)
        {
            InitializeComponent();
            this.persons_ListView= persons_ListView;
            CountryService.Instance.GetAllObjects().ToList().ForEach(obj => Countries_comboBox.Items.Add(obj));
            ProfessionService.Instance.GetAllObjects().ToList().ForEach(obj => Professions_comboBox.Items.Add(obj));
            Gender_comboBox.Items.Add(Gender.Мужской);
            Gender_comboBox.Items.Add(Gender.Женский);

            Name_textBox.Enabled= false;
            BirthDate_dateTimePicker.Enabled= false;
            Gender_comboBox.Enabled= false;
            Countries_comboBox.Enabled = false;
            Professions_comboBox.Enabled = false;


        }

        private async void StartSearch_button_Click(object sender, EventArgs e)
        {
            IEnumerable<Persons> searchPerson = PersonService.Instance.GetAllObjects();
            if (Name_checkBox.Checked)
            {
                searchPerson = SearchService.NamePersonSearch(ref searchPerson, Name_textBox.Text);
            }
            if (BirthDate_checkBox.Checked)
            {
                searchPerson = SearchService.BirthDatePersonSearch(ref searchPerson, BirthDate_dateTimePicker.Value);
            }
            if (Gender_checkBox.Checked)
            {
                if (Gender_comboBox.SelectedItem != null)
                {
                    searchPerson = SearchService.GenderPersonSearch(ref searchPerson, (Gender)Gender_comboBox.SelectedItem);
                }
            }
            if (Countries_checkBox.Checked)
            {
                if (Countries_comboBox.SelectedItem != null)
                {
                    searchPerson = SearchService.CountryPersonSearch(ref searchPerson, Countries_comboBox.SelectedItem as Countries);
                }
            }
            if (Professions_checkBox.Checked)
            {
                if (Professions_comboBox.SelectedItem != null)
                {
                    searchPerson = SearchService.ProfessionPersonSearch(ref searchPerson, Professions_comboBox.SelectedItem as Profession);
                }
            }

            if (searchPerson.ToList().Count == 0)
            {
                MessageBox.Show("Фильмов по данногму запросу не найдено!");
            }
            else
            {
                persons_ListView.Clear();
                ImageList personsImagelist = new ImageList();
                try
                {
                    await ViewService.FillingListView(searchPerson.ToList(), persons_ListView, personsImagelist);
                }
                catch (System.Net.WebException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            DialogResult = DialogResult.OK;
        }

        private void Name_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Name_checkBox.Checked)
            {
                Name_textBox.Enabled = true;
            }
            else
            {
                Name_textBox.Enabled = false;
            }
        }

        private void BirthDate_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BirthDate_checkBox.Checked)
            {
                BirthDate_dateTimePicker.Enabled = true;
            }
            else
            {
                BirthDate_dateTimePicker.Enabled = false;
            }
        }

        private void Gender_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Gender_checkBox.Checked)
            {
                Gender_comboBox.Enabled = true;
            }
            else
            {
                Gender_comboBox.Enabled = false;
            }
        }

        private void Countries_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Countries_checkBox.Checked)
            {
                Countries_comboBox.Enabled = true;
            }
            else
            {
                Countries_comboBox.Enabled = false;
            }
        }

        private void Professions_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Professions_checkBox.Checked)
            {
                Professions_comboBox.Enabled = true;
            }
            else
            {
                Professions_comboBox.Enabled = false;
            }
        }
    }
}
