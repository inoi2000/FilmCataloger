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

namespace FilmCataloger.View.AdminForms.CreateFilmForms
{
    public partial class AddRelatedFilmForm : Form
    {
        ListBox RelatedFilm_ListBox;
        public AddRelatedFilmForm(ref ListBox RelatedFilm_ListBox)
        {
            InitializeComponent();
            this.RelatedFilm_ListBox = RelatedFilm_ListBox;

            ImageList filmsImagelist = new ImageList();
            try
            {
                ViewService.FillingListView(FilmService.Instance.GetAllObjects(), Films_listView, filmsImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Films_listView.DoubleClick += Films_listView_DoubleClick;
        }

        private void Films_listView_DoubleClick(object sender, EventArgs e)
        {
            Films film = FilmService.Instance.GetObject(int.Parse(Films_listView.FocusedItem.ImageKey));
            if (RelatedFilm_ListBox.Items.Contains(film))
            {
                MessageBox.Show($"Вы уже добавили {film.Name} в список");
            }
            else
            {
                RelatedFilm_ListBox.Items.Add(film);
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name_textBox.Text))
            {
                MessageBox.Show("Данные не заполены");
            }
            else
            {
                Films film = FilmService.Instance.GetObject(Name_textBox.Text);
                if (film == null)
                {
                    MessageBox.Show("Такой фильм еще не добавлен в приложение");
                    return;
                }
                RelatedFilm_ListBox.Items.Add(film);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
