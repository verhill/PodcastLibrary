using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Avsnitt
    {
        public string Titel { get; set; }

        public string Beskrivning {  get; set; }


        public Avsnitt() 
        {
            
        }
    }
}