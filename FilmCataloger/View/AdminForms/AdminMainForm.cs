using FilmCataloger.View.AdminForms.SelectForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmCataloger.View.AdminForms
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void CreateFilm_button_Click(object sender, EventArgs e)
        {
            new CreateFilmForm().ShowDialog();
        }

        private void CreatePerson_button_Click(object sender, EventArgs e)
        {
            new CreatePersonForm().ShowDialog();
        }

        private void ChangeFilmInfo_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new SelectFilmForm().ShowDialog();
            this.Visible = true;
        }

        private void ChangePersonInfo_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new SelectPersonForm().ShowDialog();
            this.Visible = true;
        }
    }
}
