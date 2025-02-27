using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace DAL
{
    internal class Serializer<T>
    {
        private string fileName;

        public string FileName { get; set; }

        public Serializer()
        {

        }
    

        public Serializer(string fileName)
        {
            FileName = fileName + ".xml";
    
        }

        public void Serialize(List<T> list, string name)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            using(FileStream xmlOut = 
                new FileStream(name + ".xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(xmlOut, list);
            }
        }

        public List<T> Deserialize(string name)
        {
            List<T> listan;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            using(FileStream xmlIn = 
                new FileStream(name + ".xml", FileMode.Open, FileAccess.Read))
            {
                listan = (List<T>)xmlSerializer.Deserialize(xmlIn);
            }
            return listan;
        }
    }
}
