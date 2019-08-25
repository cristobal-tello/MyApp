using System.Collections.Generic;

namespace MyApp.Models
{
    public class Country
    {
        public Country()
        {
            Locations = new List<Location>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string IsoCode { get; set; }
        public bool IsRepublic { get; set; }
        public List<Location> Locations { get; set; }

    }
}
