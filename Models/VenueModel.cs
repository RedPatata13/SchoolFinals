using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.Models
{
    public class VenueModel
    {
        public string VenueId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Capacity { get; set; }
        public string Location { get; set; } = null!;
        public VenueModel() { }
        public DateTime Date { get; set; }
    }
}
