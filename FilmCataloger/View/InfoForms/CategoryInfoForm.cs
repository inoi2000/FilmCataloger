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

namespace FilmCataloger.View.InfoForms
{
    public partial class CategoryInfoForm : Form
    {
        public CategoryInfoForm(Categories category)
        {
            InitializeComponent();
            Category_pictureBox.Load(category.PictureRef);
            Name_label.Text = category.Name;
            Description_label.Text = category.Description;

            ImageList categoryImagelist = new ImageList();
            try
            {
                ViewService.FillingListView(category.Persons, Category_listView, categoryImagelist);
                ViewService.FillingListView(category.Films, Category_listView, categoryImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
