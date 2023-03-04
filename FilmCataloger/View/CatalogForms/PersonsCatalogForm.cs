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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmCataloger.View.CatalogForms
{
    public partial class PersonsCatalogForm : Form
    {
        public PersonsCatalogForm()
        {
            InitializeComponent();
            ImageList personsImagelist = new ImageList();
            try
            {
                ViewService.FillingListView(PersonService.Instance.GetAllObjects(), Persons_listView, personsImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }

            Professions_comboBox.SelectedIndex = 0;
            Countries_comboBox.SelectedIndex = 0;
            Gender_comboBox.SelectedIndex = 0;
            Sort_comboBox.SelectedIndex = 0;

            Professions_comboBox.SelectedIndexChanged += SortPersons;
            Countries_comboBox.SelectedIndexChanged += SortPersons;
            Gender_comboBox.SelectedIndexChanged += SortPersons;
            Sort_comboBox.SelectedIndexChanged += SortPersons;

            ProfessionService.Instance.GetAllObjects().ToList().ForEach(obj => Professions_comboBox.Items.Add(obj));
            CountryService.Instance.GetAllObjects().ToList().ForEach(obj => Countries_comboBox.Items.Add(obj));

            Gender_comboBox.Items.Add(Gender.Мужской);
            Gender_comboBox.Items.Add(Gender.Женский);

            Persons_listView.DoubleClick += Persons_listView_DoubleClick;
        }

        private void SortPersons(object sender, EventArgs e)
        {
            IEnumerable<Persons> sortedPersons = PersonService.Instance.GetAllObjects();

            if (Professions_comboBox.SelectedIndex != 0)
            {
                sortedPersons = SearchService.ProfessionPersonSearch(ref sortedPersons, Professions_comboBox.SelectedItem as Profession);
            }
            if (Countries_comboBox.SelectedIndex != 0)
            {
                sortedPersons = SearchService.CountryPersonSearch(ref sortedPersons, Countries_comboBox.SelectedItem as Countries);
            }
            if (Gender_comboBox.SelectedIndex != 0)
            {
                sortedPersons = SearchService.GenderPersonSearch(ref sortedPersons, (Gender)Gender_comboBox.SelectedItem);
            }
            if (Sort_comboBox.SelectedIndex != 0)
            {
                switch (Sort_comboBox.SelectedIndex)
                {
                    case 1:
                        sortedPersons = SortService.NamePersonSort(ref sortedPersons);
                        break; 
                    case 2:
                        sortedPersons = SortService.BirthDatePersonSort(ref sortedPersons);
                        break;
                }
            }


            Persons_listView.Clear();
            ImageList personsImagelist = new ImageList();
            try
            {
                ViewService.FillingListView(sortedPersons.ToList(), Persons_listView, personsImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Persons_listView_DoubleClick(object sender, EventArgs e)
        {
            Persons person = PersonService.Instance.GetObject(int.Parse(Persons_listView.FocusedItem.ImageKey));
            new PersonInfoForm(person).Show();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            IEnumerable<Persons> searchedPersons = PersonService.Instance.GetAllObjects();
            searchedPersons = SearchService.NamePersonSearch(ref searchedPersons, SearchField_textBox.Text);

            Persons_listView.Clear();
            ImageList personsImagelist = new ImageList();
            try
            {
                ViewService.FillingListView(searchedPersons.ToList(), Persons_listView, personsImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchPlus_button_Click(object sender, EventArgs e)
        {
            new PersonSearchForm(ref Persons_listView).ShowDialog();
        }

        private void MainManu_button_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
        }
    }
}
