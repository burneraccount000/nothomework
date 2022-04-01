using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace Ramirez_Mackenzie_HW4.Models
{
    public class AppUser : IdentityUser
    {
        
        // FIRST NAME
        [Required]
        public String FirstName { get; set; }

        // LAST NAME
        [Required]
        public String LastName { get; set; }        

        // NAV PROPERTIES
        

    }
}
