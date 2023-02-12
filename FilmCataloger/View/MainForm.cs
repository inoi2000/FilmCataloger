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

namespace FilmCataloger.View
{
    public partial class MainForm : Form
    {
        public readonly FilmCatalogerDbContext _context;
        public MainForm()
        {
            InitializeComponent();
            _context = new FilmCatalogerDbContext();

            //заполнение списка профессий
            //_context.Professions.Add(new Profession { Name = "Режиссер" });
            //_context.Professions.Add(new Profession { Name = "Сценарист" });
            //_context.Professions.Add(new Profession { Name = "Актер" });
            //_context.SaveChanges();

            

        }
    }
}
