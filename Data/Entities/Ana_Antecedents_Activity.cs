using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{   
    public class Ana_Antecedents_Activity
    {   
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
    }
}
