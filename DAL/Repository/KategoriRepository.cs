using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class KategoriRepository : IRepository<Kategori>
    {
        List<Kategori> kategoriLista;
        Serializer<Kategori> kategoriSerializer;
        string className => "kategori";

        public KategoriRepository()
        {
            kategoriSerializer = new Serializer<Kategori>();
            kategoriLista = GetAll();
        }
        public void Create(Kategori entity)
        {
            kategoriLista.Add(entity);
            SaveChanges();
        }

        public void Delete(int index)
        {
            if(index >= 0 && index < kategoriLista.Count)
            {
                kategoriLista.RemoveAt(index);
                SaveChanges();
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        public List<Kategori> GetAll()
        {
            List<Kategori>deserialiseraadKategoriLista = new List<Kategori>();
            try
            {
                deserialiseraadKategoriLista = kategoriSerializer.Deserialize(className);
            }
            catch (Exception) 
            {

            }
            return deserialiseraadKategoriLista;
        }

        public Kategori GetByName(string name)
        {
            return GetAll().FirstOrDefault(p => p.KattNamn.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public int GetIndex(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Kategori kan inte vara tomt", nameof(name));
            }

            return kategoriLista.FindIndex(e => e.KattNamn.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void SaveChanges()
        {
            kategoriSerializer.Serialize(kategoriLista, className); 
        }

        public void Update(int index, Kategori theObject)
        {
            if (index < 0 || index >= kategoriLista.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
                kategoriLista[index] = theObject;
                SaveChanges();
        }

        public static void kategoriPopulerare()
        {
            string[] lines = { "Komedi", "Historia", "Dokumentär", "Verkliga brott" };

            using (FileStream fileStream = new FileStream("Category.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    foreach (string line in lines)
                        writer.WriteLine(line);
                }
            }
        }

        public void AndraKategori(string gammaltNamn, string nyttNamn)
        {
            string path = "Category.txt";

            var lines = File.ReadAllLines(path).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Equals(gammaltNamn, StringComparison.OrdinalIgnoreCase))
                {
                    lines[i] = nyttNamn;
                }
            }

            File.WriteAllLines(path, lines);
        }
        
        public static void LaggTillKategori(string nyKategori)
        {
            using(FileStream filestream = new FileStream("Category.txt", FileMode.Append, FileAccess.Write))
            {
                using(StreamWriter writer = new StreamWriter(filestream))
                {
                    writer.WriteLine(nyKategori);
                }
            }
        }

        public static List<string> HamtaKategoriLista()
        {
            List<string> kategoriLista = new List<string>();

            using(FileStream filestream = new FileStream("Category.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(filestream))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                       kategoriLista.Add(line);
                    }
                }
            }
            return kategoriLista;

        }

        public static List<String> HamtaAllaKategorier()
        {
            return HamtaKategoriLista();
        }

        public void TaBortKate(string borttagenKat)
        {
            string path = "Category.txt";
            var lines = File.ReadAllLines(path).ToList();
            for (int i = 0; i < lines.Count; i++) 
            { 
                if (lines[i].Equals(borttagenKat))
                {
                    lines.RemoveAt(i);
                }
            }
           File.WriteAllLines(path, lines);

        }


    }
}
