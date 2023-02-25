using FilmCataloger.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCataloger.Model
{
    public class Persons : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string PictureRef { get; set; }

        public Countries Сountry { get; set; }
        public ICollection<Profession> Professions { get; set; } = new List<Profession>();
        public ICollection<Films> Films { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
