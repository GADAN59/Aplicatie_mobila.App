using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie_mobila.Models
{
    class Booking
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Hour { get; set; }
        public string Comment { get; set; }

        // Foreign keys
        public int ServiceId { get; set; }
        public int PetId { get; set; }

        // Navigation properties
        public Service Service { get; set; }
        public Pet Pet { get; set; }
    }
}
