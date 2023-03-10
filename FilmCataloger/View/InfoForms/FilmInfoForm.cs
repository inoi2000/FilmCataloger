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
    public partial class FilmInfoForm : Form
    {
        Films film;
        public FilmInfoForm(Films film)
        {
            InitializeComponent();

            this.film = film;

            this.Text = film.Name;

            Persons_listView.DoubleClick += Persons_listView_DoubleClick;
            RelatedFilms_listView.DoubleClick += RelatedFilms_listView_DoubleClick;


            Film_pictureBox.Load(film.PictureRef);
            Name_label.Text = film.Name;
            IMDb_label.Text = film.IMDb.ToString();
            Year_label.Text = film.Production.Year.ToString();
            film.Countries.ToList().ForEach(c => Country_label.Text += c.ToString() + " ");
            film.Genres.ToList().ForEach(g => Genres_label.Text += g.ToString() + " ");
            Duration_label.Text = $"{film.Duration.Hour} часов {film.Duration.Minute} минут";
            Fees_label.Text = $"{film.FurtherInfo_FK.Fees} $";
            AgeLimit_label.Text = film.FurtherInfo_FK.AgeLimit;

            Description_label.Text = film.FurtherInfo_FK.Description;

            UpDateForm(this, EventArgs.Empty);

        }

        private async void UpDateForm(object sender, EventArgs e)
        {
            ImageList personsImagelist = new ImageList();
            ImageList filmsImagelist = new ImageList();
            try
            {
                await ViewService.FillingListView(film.Persons, Persons_listView, personsImagelist);
                await ViewService.FillingListView(film.RelatedFilms, RelatedFilms_listView, filmsImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void RelatedFilms_listView_DoubleClick(object sender, EventArgs e)
        {
            Films film = await FilmService.Instance.GetObjectAsync(int.Parse(RelatedFilms_listView.FocusedItem.ImageKey));
            new FilmInfoForm(film).Show();
        }

        private void Persons_listView_DoubleClick(object sender, EventArgs e)
        {
            Persons person = PersonService.Instance.GetObject(int.Parse(Persons_listView.FocusedItem.ImageKey));
            new PersonInfoForm(person).Show();
        }
    }
}
