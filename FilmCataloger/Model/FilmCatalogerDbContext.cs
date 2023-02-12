using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCataloger.Model
{
    public class FilmCatalogerDbContext : DbContext
    {
        public FilmCatalogerDbContext() : base("DefaultConnection") { }

        public DbSet<Films> Films { get; set; }
        public DbSet<FurtherInfo> FurtherInfo { get; set;}
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Persons> Persons { get; set; }
        public DbSet<Profession> Professions { get; set; }
    }
}
