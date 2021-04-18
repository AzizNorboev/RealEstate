using System.ComponentModel.DataAnnotations;


namespace Entities.Models
{
    public class House
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Required]
        [Range(5, 500)]
        public int Square { get; set; }

        [Required(ErrorMessage = "Number of Rooms is required")]
        [Range(1, 50)]
        public int NumOfRooms { get; set; }

        public string ImageURL { get; set; }

        [StringLength(1000, MinimumLength = 1)]
        public string Description { get; set; }

        public HouseStatus Status { get; set; }


        public int? RegionId { get; set; }

        public virtual Region Region { get; set; }
    }

    public enum HouseStatus
    {
        ForSale,
        ForRent
    }
}

