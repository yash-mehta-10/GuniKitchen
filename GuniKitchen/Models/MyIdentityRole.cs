using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GuniKitchen.Models
{
    public class MyIdentityRole : IdentityRole<Guid>
    {
        public int Id { get; set; }


        [Display(Name = "Role")]
        [Required]
        public string Role { get; set; }

    }
}
