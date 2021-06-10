using System.ComponentModel.DataAnnotations;

namespace RememberBruce.Models
{
    public class Truck
    {
        [Key]
        public int TruckId { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Details { get; set; }

        [Required]
        public byte Image { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }

    }
}