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

namespace FilmCataloger.View.CatalogForms
{
    public partial class CategoriesCatalogForm : Form
    {
        public CategoriesCatalogForm()
        {
            InitializeComponent();
            ImageList categoryImagelist = new ImageList();
            try
            {
                ViewService.FillingListView(CategoryService.Instance.GetAllObjects(), Category_listView, categoryImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
