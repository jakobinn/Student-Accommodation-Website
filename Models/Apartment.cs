using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentApartments.Models
{
    public class Apartment
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [ForeignKey("User")]
        public string IDOwner { get; set; }
        [StringLength(600)]
        [Required]
        public string Location { get; set; }
        [StringLength(600, MinimumLength = 50)]
        [Required]
        public string Description { get; set; }
        [Range(0, 10000000)]
        [Required]
        public int Price { get; set; }
        public string Image { get; set; }
        [ForeignKey("Review")]
        public int? IDReview { get; set; }
        public virtual User User { get; set; }
        public virtual Review Review { get; set; }
	}
}