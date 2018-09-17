using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace StudentApartments.Models
{
    public class User : IdentityUser
    {        
        [Required]
        [Range(0,2)]
        //0: student, 1: landlord, 2: admin
        public int Role { get; set; } 
    }
}

