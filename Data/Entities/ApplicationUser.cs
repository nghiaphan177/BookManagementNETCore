using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [MaxLength(100)]
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }
        public string Activity { get; set; }
        [DataType(DataType.Date)]
        public DateTime ActivityDate { get; set; }
        public virtual List<Individual> Individuals { get; set; }
    }
}
