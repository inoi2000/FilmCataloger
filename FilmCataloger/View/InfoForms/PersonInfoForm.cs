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
    public partial class PersonInfoForm : Form
    {
        public PersonInfoForm(Persons person)
        {
            InitializeComponent();
            this.Text = $"{person.FirstName} {person.LastName}";
            Films_listView.DoubleClick += Films_listView_DoubleClick;
            Person_pictureBox.Load(person.PictureRef);
            Name_label.Text = $"{person.FirstName} {person.LastName}";
            BirthDate_label.Text = person.BirthDate.ToShortDateString();
            if(person.Сountry?.Name != null) Country_label.Text = person.Сountry.Name;
            person.Professions.ToList().ForEach(p => { Professions_label.Text += $"{p} "; });

            ImageList filmsImagelist = new ImageList();
            try
            {
                ViewService.FillingListView(person.Films, Films_listView, filmsImagelist);
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Films_listView_DoubleClick(object sender, EventArgs e)
        {
            Films film = FilmService.Instance.GetObject(int.Parse(Films_listView.FocusedItem.ImageKey));
            new FilmInfoForm(film).Show();
        }
    }
}
