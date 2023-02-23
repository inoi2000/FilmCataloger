using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCataloger.Services
{
    public interface IService<Entity>
    {
        Entity AddObject(Entity entity);
        Entity GetObject(int id);
        ICollection<Entity> GetAllObjects();
        bool RemoveObject(int id);
    }
}
