using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCataloger.Model
{
    public class Profession
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Persons> Persons { get; set; } = new List<Persons>();

        public override string ToString()
        {
            return Name;
        }
    }
}
