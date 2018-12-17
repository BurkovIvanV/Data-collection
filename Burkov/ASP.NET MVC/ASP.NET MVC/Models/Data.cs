using System;

namespace ASP.NET_MVC.Models
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