using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentApartments.Models
{
    public class Review
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public bool IsApproved { get; set; }
        [Required]
        [StringLength(600, MinimumLength=50)]
        public string Feedback { get; set; }
	}
}