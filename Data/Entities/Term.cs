using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary.Models
{
    public class Term
    {   
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
    }
}
