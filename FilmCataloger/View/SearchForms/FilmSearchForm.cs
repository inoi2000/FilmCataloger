using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmCataloger.View.SearchForms
{
    public partial class FilmSearchForm : Form
    {
        ListBox films_ListBox;
        public FilmSearchForm(ref ListBox films_ListBox)
        {
            InitializeComponent();
            this.films_ListBox= films_ListBox;
        }
    }
}
