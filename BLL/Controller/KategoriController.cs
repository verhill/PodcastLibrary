using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.Controller
{
    public class KategoriController
    {
        IRepository<Kategori> kategoriRepository;
        KategoriRepository kategoriRepository1;

        public KategoriController()
        {
            kategoriRepository = new KategoriRepository();
            kategoriRepository1 = new KategoriRepository();
        }



        public void SkapaFardigKategori()
        {
            string path = ("Category.txt");
            if (!File.Exists(path))
            {
                KategoriRepository.kategoriPopulerare();
            }
            
        }

        public List<String>  LasAllaKategorier()
        {
            List<String> kategoriLista = KategoriRepository.HamtaAllaKategorier();
            return kategoriLista;
        }

        public void UpdateraKategori(Kategori kategori)
        {
            
             int index = kategoriRepository.GetIndex(kategori.KattNamn);
            
            
            if(index >= 0)
            {
                kategoriRepository.Update(index, kategori);
                Console.WriteLine($"Uppdaterar kategori: {kategori.KattNamn}");
            }
            else
            {
                kategoriRepository.Create(kategori);
            }
        }

        public Kategori hamtaKategoriByName (string kategoriNamn)
        {
            return kategoriRepository.GetByName(kategoriNamn);
        }

        public void LaggTillKategori(string name, List<Pod> poddLista)
        {
            Kategori nyKategori = new Kategori(name)
            {
                Pod = poddLista
            };

            kategoriRepository.Create(nyKategori);
        }

        public List<Pod> HamtaPoddarForKategori(string kategoriNamn)
        {
            var kategori = hamtaKategoriByName(kategoriNamn);
            return kategori?.Pod ?? new List<Pod>();
        }

        public void TaBortPoddFranKategori(string kategoriNamn,string poddTitel)
        {
            var kategori = hamtaKategoriByName(kategoriNamn); 

            if(kategori != null)
            {
                var poddAttTaBort = kategori.Pod.FirstOrDefault(p => p.PodTitel.Equals(poddTitel, StringComparison.OrdinalIgnoreCase));

                if(poddAttTaBort != null)
                {
                    kategori.Pod.Remove(poddAttTaBort);
                    UpdateraKategori(kategori);
                }

            }
        }

        public string HamtaKategoriForPodd(string poddTitel)
        {
            var allaKategorier = kategoriRepository.GetAll();

            foreach (var kategori in allaKategorier)
            {
                if (kategori.Pod.Any(p => p.PodTitel.Equals(poddTitel, StringComparison.OrdinalIgnoreCase)))
                {
                    return kategori.KattNamn; 
                }
            }

            return null;
        }

        public void AndraKategoriNamn(string gammaltKategoriNamn, string nyttKategoriNamn)
        {
            kategoriRepository1.AndraKategori(gammaltKategoriNamn, nyttKategoriNamn); 
        }

    }
}
