using FilmCataloger.Model;
using FilmCataloger.View.AdminForms;
using FilmCataloger.View.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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

            //заполнение списка стран
            //_context.Countries.Add(new Countries { Name = "Россия"});
            //_context.Countries.Add(new Countries { Name = "США"});
            //_context.Countries.Add(new Countries { Name = "СССР"});
            //_context.Countries.Add(new Countries { Name = "Франция"});
            //_context.Countries.Add(new Countries { Name = "Великобритания"});
            //_context.Countries.Add(new Countries { Name = "Италия"});
            //_context.Countries.Add(new Countries { Name = "Германия"});
            //_context.Countries.Add(new Countries { Name = "Канада"});
            //_context.Countries.Add(new Countries { Name = "Индия"});
            //_context.Countries.Add(new Countries { Name = "Япония"});
            //_context.Countries.Add(new Countries { Name = "Испания"});
            //_context.Countries.Add(new Countries { Name = "Гонконг"});
            //_context.Countries.Add(new Countries { Name = "Корея Южная"});
            //_context.Countries.Add(new Countries { Name = "Китай"});
            //_context.Countries.Add(new Countries { Name = "Бельгия"});
            //_context.Countries.Add(new Countries { Name = "Австралия"});
            //_context.Countries.Add(new Countries { Name = "Швеция"});
            //_context.Countries.Add(new Countries { Name = "Польша"});
            //_context.Countries.Add(new Countries { Name = "Дания"});
            //_context.Countries.Add(new Countries { Name = "Мексика"});
            //_context.Countries.Add(new Countries { Name = "Чехия"});
            //_context.Countries.Add(new Countries { Name = "Нидерланды"});
            //_context.Countries.Add(new Countries { Name = "Украина"});
            //_context.Countries.Add(new Countries { Name = "Ирландия"});
            //_context.Countries.Add(new Countries { Name = "Норвегия"});
            //_context.Countries.Add(new Countries { Name = "Швейцария"});
            //_context.Countries.Add(new Countries { Name = "Аргентина"});
            //_context.Countries.Add(new Countries { Name = "Венгрия"});
            //_context.Countries.Add(new Countries { Name = "Австрия"});
            //_context.Countries.Add(new Countries { Name = "Сербия"});
            //_context.Countries.Add(new Countries { Name = "Румыния"});
            //_context.SaveChanges();

            //добавление жанров
            //_context.Genres.Add(new Genres { Name = "драма" });
            //_context.Genres.Add(new Genres { Name = "комедия" });
            //_context.Genres.Add(new Genres { Name = "триллер" });
            //_context.Genres.Add(new Genres { Name = "мелодрама" });
            //_context.Genres.Add(new Genres { Name = "боевик" });
            //_context.Genres.Add(new Genres { Name = "криминал" });
            //_context.Genres.Add(new Genres { Name = "ужасы" });
            //_context.Genres.Add(new Genres { Name = "приключения" });
            //_context.Genres.Add(new Genres { Name = "фантастика" });
            //_context.Genres.Add(new Genres { Name = "фэнтези" });
            //_context.Genres.Add(new Genres { Name = "детектив" });
            //_context.Genres.Add(new Genres { Name = "семейный" });
            //_context.Genres.Add(new Genres { Name = "мультфильм" });
            //_context.Genres.Add(new Genres { Name = "военный" });
            //_context.Genres.Add(new Genres { Name = "история" });
            //_context.Genres.Add(new Genres { Name = "бионгафия" });
            //_context.Genres.Add(new Genres { Name = "короткометражка" });
            //_context.Genres.Add(new Genres { Name = "документальный" });
            //_context.Genres.Add(new Genres { Name = "мюзикл" });
            //_context.Genres.Add(new Genres { Name = "вестерн" });
            //_context.Genres.Add(new Genres { Name = "музыка" });
            //_context.Genres.Add(new Genres { Name = "спорт" });
            //_context.Genres.Add(new Genres { Name = "аниме" });
            //_context.Genres.Add(new Genres { Name = "детский" });
            //_context.Genres.Add(new Genres { Name = "фильм-нуар" });
            //_context.SaveChanges();

        }

        private void Admin_button_Click(object sender, EventArgs e)
        {
            new AdminMainForm().ShowDialog();
        }

        private void User_button_Click(object sender, EventArgs e)
        {
            new UserMainForm().ShowDialog();
        }
    }
}
