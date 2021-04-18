using System.ComponentModel.DataAnnotations;


namespace Entities.Models
{
    public class Apartment
    {

        public int Id { get; set; }


        //As my Lecturer says for the sake of simplicity
        //I've used double instead of decimal for price
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Number of rooms is required")]
        [Range(1, 10)]
        public int NumOfRooms { get; set; }

        [Range(1, int.MaxValue)]
        public int FloorNo { get; set; }

        [Required]
        [Range(5, 300)]
        public int Square { get; set; }

        [StringLength(1000, MinimumLength = 1)]
        public string Description { get; set; }

        public ApartmentStatus Status { get; set; }

        public string ImageURL { get; set; }


        public int? RegionId { get; set; }

        public virtual Region Region { get; set; }
    }
    public enum ApartmentStatus
    {
        ForSale,
        ForRent
    }
}
