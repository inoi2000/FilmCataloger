using FilmCataloger.Model;
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
    public partial class AddPersonForm : Form
    {
        readonly FilmCatalogerDbContext _context;
        ListBox person_ListBox;
        public AddPersonForm(ref ListBox person_ListBox)
        {
            InitializeComponent();
            this.person_ListBox = person_ListBox;
            _context = new FilmCatalogerDbContext();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstName_textBox.Text) || string.IsNullOrEmpty(LastName_textBox.Text))
            {
                MessageBox.Show("Данные не заполены");
            }
            else
            {
                Persons person = _context.Persons.Where(p => (p.FirstName == FirstName_textBox.Text && p.LastName == LastName_textBox.Text)).FirstOrDefault();
                if (person == null)
                {
                    MessageBox.Show("Такой деятель кино еще не добавлен в приложение");
                    return;
                }
                person_ListBox.Items.Add(person);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
