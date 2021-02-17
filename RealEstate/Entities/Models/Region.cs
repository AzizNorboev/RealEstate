using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Region
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Apartment> Apartments { get; set; }

        public virtual ICollection <House> Houses { get; set; }
    }
}
