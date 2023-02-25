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
        }
    }
}
