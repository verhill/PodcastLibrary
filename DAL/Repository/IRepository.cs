using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        void Create (T entity);
        void Update(int index, T theObject);
        void Delete(int index);
        int GetIndex(string name);
        T GetByName(string name);
        void SaveChanges();

    }
}
