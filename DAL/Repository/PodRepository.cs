using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class PodRepository : IRepository<Pod>
    {
        List<Pod> poddLista;
        Serializer<Pod> poddSerializer;
        string className => "pod";

        public PodRepository()
        {
            poddLista = new List<Pod>();
            poddSerializer = new Serializer<Pod>();   
        }

        public void Create(Pod pod)
        {
            if(!poddLista.Any(p => p.PodTitel.Equals(pod.PodTitel, StringComparison.OrdinalIgnoreCase)))
            {
                poddLista.Add(pod);
                SaveChanges();
            }
        }

        public void Delete(int index)
        {
            poddLista.RemoveAt(index);
            SaveChanges();
        }

        public List<Pod> GetAll()
        {
            try
            {
                poddLista = poddSerializer.Deserialize(className);

            }
            catch (Exception)
            {
                poddLista = new List<Pod>();
            }
            return poddLista;
        }

        public Pod GetByName(string name)
        {
            return GetAll().FirstOrDefault(p => p.PodTitel.Equals(name));
        }

        public int GetIndex(string name)
        {
            return GetAll().FindIndex(e => e.PodTitel.Equals(name));
        }

        public void SaveChanges()
        {
            poddSerializer.Serialize(poddLista, className);
        }

        public void Update(int index, Pod theObject)
        {
            if(index >= 0)
            {
                poddLista[index] = theObject;
            }
            SaveChanges();
        }

    }
}
