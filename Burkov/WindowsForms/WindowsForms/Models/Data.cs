using System;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsForms.Models
{
    [Serializable]
    public class Data
    {
        public string FullName { get; set; }
        public string Raiting { get; set; }
        public string Rank { get; set; }
        public DateTime BirthDate { get; set; }
        public string[][] Tournamets { get; set; }
    }
}
