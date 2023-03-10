using FilmCataloger.Model;
using FilmCataloger.Services;
using FilmCataloger.View.AdminForms;
using FilmCataloger.View.CatalogForms;
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

namespace FilmCataloger.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateData();
        }

        private void Admin_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AdminMainForm().ShowDialog();
            UpdateData();
        }

        private async void UpdateData()
        {
            await CategoryService.Instance.UpdateCatigoriesAsync();

            Persons_listView.Items.Clear();
            Films_listView.Items.Clear();
            Category_listView.Items.Clear();

            ImageList personsImagelist = new ImageList();
            ImageList filmsImagelist = new ImageList();
            ImageList categoryImagelist = new ImageList();
            try
            {
                await ViewService.FillingListView(PersonService.Instance.GetAllObjects(), Persons_listView, personsImagelist);
                await ViewService.FillingListView(FilmService.Instance.GetAllObjects(), Films_listView, filmsImagelist);
                await ViewService.FillingListView(CategoryService.Instance.GetAllObjects(), Category_listView, categoryImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FilmsCatalog_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new FilmsCatalogForm().ShowDialog();
            this.Visible = true;
        }

        private void PersonsCatalog_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new PersonsCatalogForm().ShowDialog();
            this.Visible = true;
        }

        private void CategoriesCatalog_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new CategoriesCatalogForm().ShowDialog();
            this.Visible = true;
        }

        private async void Films_listView_DoubleClick(object sender, EventArgs e)
        {
            Films film = await FilmService.Instance.GetObjectAsync(int.Parse(Films_listView.FocusedItem.ImageKey));
            new FilmInfoForm(film).Show();
        }

        private void Persons_listView_DoubleClick(object sender, EventArgs e)
        {
            Persons person = PersonService.Instance.GetObject(int.Parse(Persons_listView.FocusedItem.ImageKey));
            new PersonInfoForm(person).Show();
        }

        private void Category_listView_DoubleClick(object sender, EventArgs e)
        {
            Categories category = CategoryService.Instance.GetObject(int.Parse(Category_listView.FocusedItem.ImageKey));
            new CategoryInfoForm(category).Show();
        }
    }
}
