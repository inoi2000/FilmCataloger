using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCataloger.Model
{
    public class Genres
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Films> Films { get; set; } = new List<Films>();

        public override string ToString()
        {
            return Name;
        }
    }
}
