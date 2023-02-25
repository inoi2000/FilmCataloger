using FilmCataloger.Model;
using FilmCataloger.Services;
using FilmCataloger.View.InfoForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmCataloger.View.AdminForms.CreateFilmForms
{
    public partial class AddPersonForm : Form
    {
        ListBox person_ListBox;
        public AddPersonForm(ref ListBox person_ListBox)
        {
            InitializeComponent();
            this.person_ListBox = person_ListBox;

            ImageList personsImagelist = new ImageList();
            try
            {
                ViewService.FillingListView(PersonService.Instance.GetAllObjects(), Persons_listView, personsImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Persons_listView.DoubleClick += Persons_listView_DoubleClick;
        }

        private void Persons_listView_DoubleClick(object sender, EventArgs e)
        {
            Persons person = PersonService.Instance.GetObject(int.Parse(Persons_listView.FocusedItem.ImageKey));
            if (person_ListBox.Items.Contains(person)) 
            {
                MessageBox.Show($"Вы уже добавили {person.FirstName} {person.LastName} в список");
            }
            else 
            {
                person_ListBox.Items.Add(person);
            }            
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstName_textBox.Text) || string.IsNullOrEmpty(LastName_textBox.Text))
            {
                MessageBox.Show("Данные не заполены");
            }
            else
            {
                Persons person = PersonService.Instance.GetObject(FirstName_textBox.Text, LastName_textBox.Text);
                if (person == null)
                {
                    MessageBox.Show("Такой деятель кино еще не добавлен в приложение");
                    return;
                }
                person_ListBox.Items.Add(person);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
