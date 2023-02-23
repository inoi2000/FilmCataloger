using FilmCataloger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCataloger.Services
{
    public static class ContextService // класс обеспечивающий единую точку долступа к контекстному классу
    {
        public static readonly FilmCatalogerDbContext context;
        static ContextService()
        {
            context = new FilmCatalogerDbContext();
            context.Configuration.LazyLoadingEnabled = false;
        }
    }
}
