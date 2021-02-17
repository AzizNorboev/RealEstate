using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class House
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Required]
        [Range(5, 500)]
        public int Square { get; set; }

        [Required(ErrorMessage = "Number of Rooms is required")]
        [Range(1, 50)]
        public int NumOfRooms { get; set; }

        public string ImageURL { get; set; }

        [StringLength(50, MinimumLength = 1)]
        public string Description { get; set; }

        
        public int? RegionId { get; set; }

        public virtual Region Region { get; set; }
    }
}
