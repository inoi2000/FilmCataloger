using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCataloger.Model
{
    public class Films
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Production { get; set; }
        public float IMDb { get; set; }
        public string PictureRef { get; set; }
        public FurtherInfo FurtherInfo_FK { get; set; }

        public ICollection<Films> RelatedFilms { get; set; }
        public ICollection<Genres> Genres { get; set; }
        public ICollection<Persons> Persons  { get; set; }
        public ICollection<Countries> Countries { get; set; }
        public ICollection<Categories> Categories { get; set; }
    }
}
