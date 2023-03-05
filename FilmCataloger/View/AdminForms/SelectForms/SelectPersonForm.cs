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

namespace FilmCataloger.View.AdminForms.SelectForms
{
    public partial class SelectPersonForm : Form
    {
        public SelectPersonForm()
        {
            InitializeComponent();

            UpDateForm(this, EventArgs.Empty);
            Persons_listView.DoubleClick += Persons_listView_DoubleClick;
        }

        private async void UpDateForm(object sender, EventArgs e)
        {
            ImageList personsImagelist = new ImageList();
            try
            {
                await ViewService.FillingListView(PersonService.Instance.GetAllObjects(), Persons_listView, personsImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Persons_listView_DoubleClick(object sender, EventArgs e)
        {
            Persons person = PersonService.Instance.GetObject(int.Parse(Persons_listView.FocusedItem.ImageKey));
            new ChangePersonInfoForm(person).ShowDialog();
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
                new ChangePersonInfoForm(person).ShowDialog();
            }
            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
