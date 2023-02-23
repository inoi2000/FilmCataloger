using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmCataloger.Services
{
    public interface IService
    {
        IEntity AddObject(IEntity entity);
        IEntity GetObject(int id);
        //ICollection<IEntity> GetAllObjects();
        bool RemoveObject(int id);
    }
}
