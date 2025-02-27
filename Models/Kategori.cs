using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
    


{
    [Serializable]
    public class Kategori
    {

        public string KattNamn { get; set; }
        public List<Pod>Pod {  get; set; }  

        public Kategori(string kattNamn)
        {
            KattNamn = kattNamn;
            Pod = new List<Pod>();

        }

        public Kategori() 
        {
            Pod = new List<Pod>();
        }

        public void UppdateraPodNamn(string gammaltNamn, string nyttNamn)
        {
            foreach (var podar in Pod)
            {
                if (podar.PodTitel.Equals(gammaltNamn, StringComparison.OrdinalIgnoreCase))
                {
                    podar.PodTitel = nyttNamn;
                }
            }
        }
    }
    

}
