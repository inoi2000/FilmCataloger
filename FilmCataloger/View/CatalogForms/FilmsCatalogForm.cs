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
    public partial class FilmsCatalogForm : Form
    {
        public FilmsCatalogForm()
        {
            InitializeComponent();
            ImageList filmsImagelist = new ImageList();
            try
            {
                ViewService.FillingListView(FilmService.Instance.GetAllObjects(), Films_listView, filmsImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
