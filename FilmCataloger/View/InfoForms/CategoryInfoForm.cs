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
        Categories category;
        public CategoryInfoForm(Categories category)
        {
            InitializeComponent();
            this.category = category;
            Category_pictureBox.Load(category.PictureRef);
            this.Text= category.Name;
            Name_label.Text = category.Name;
            Description_label.Text = category.Description;

            UpDateForm(this, EventArgs.Empty);
        }

        private async void UpDateForm(object sender, EventArgs e)
        {
            ImageList categoryImagelist = new ImageList();
            try
            {
                await ViewService.FillingListView(category.Persons, Category_listView, categoryImagelist);
                await ViewService.FillingListView(category.Films, Category_listView, categoryImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
