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

namespace FilmCataloger.View.CatalogForms
{
    public partial class CategoriesCatalogForm : Form
    {
        public CategoriesCatalogForm()
        {
            InitializeComponent();
            UpDateForm(this, EventArgs.Empty);
            Category_listView.DoubleClick += Category_listView_DoubleClick;
        }

        private void Category_listView_DoubleClick(object sender, EventArgs e)
        {
            Categories category = CategoryService.Instance.GetObject(int.Parse(Category_listView.FocusedItem.ImageKey));
            new CategoryInfoForm(category).Show();
        }

        private async void UpDateForm(object sender, EventArgs e)
        {
            ImageList categoryImagelist = new ImageList();
            try
            {
                await ViewService.FillingListView(CategoryService.Instance.GetAllObjects(), Category_listView, categoryImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
