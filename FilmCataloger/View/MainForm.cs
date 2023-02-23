using FilmCataloger.Model;
using FilmCataloger.Services;
using FilmCataloger.View.AdminForms;
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

        private void UpdateData()
        {
            Persons_listView.Items.Clear();
            Films_listView.Items.Clear();
            Category_listView.Items.Clear();

            ImageList personsImagelist = new ImageList();
            ImageList filmsImagelist = new ImageList();
            ImageList categoryImagelist = new ImageList();
            try
            {
                ViewService.FillingListView(PersonService.Instance.GetAllObjects(), Persons_listView, personsImagelist);
                ViewService.FillingListView(FilmService.Instance.GetAllObjects(), Films_listView, filmsImagelist);
                ViewService.FillingListView(CategoryService.Instance.GetAllObjects(), Category_listView, categoryImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
