using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCataloger.Model
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PictureRef { get; set; }
        public string Description { get; set; }


        public ICollection<Films> Films { get; set; } = new List<Films>();
        public ICollection<Persons> Persons { get; set; } = new List<Persons>();
    }
}
