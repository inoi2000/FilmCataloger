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
    public partial class SelectFilmForm : Form
    {
        public SelectFilmForm()
        {
            InitializeComponent();            
            Films_listView.DoubleClick += Films_listView_DoubleClick;
            UpDateForm(this, EventArgs.Empty);
        }

        private async void UpDateForm(object sender, EventArgs e)
        {
            ImageList filmsImagelist = new ImageList();
            try
            {
                await ViewService.FillingListView(FilmService.Instance.GetAllObjects(), Films_listView, filmsImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void Films_listView_DoubleClick(object sender, EventArgs e)
        {
            Films film = await FilmService.Instance.GetObjectAsync(int.Parse(Films_listView.FocusedItem.ImageKey));
            new ChangeFilmInfoForm(film).ShowDialog();
        }
        private async void Add_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name_textBox.Text))
            {
                MessageBox.Show("Данные не заполены");
            }
            else
            {
                Films film = await FilmService.Instance.GetObjectAsync(Name_textBox.Text);
                if (film == null)
                {
                    MessageBox.Show("Такой фильм еще не добавлен в приложение");
                    return;
                }
                new ChangeFilmInfoForm(film).ShowDialog();
            }
            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
