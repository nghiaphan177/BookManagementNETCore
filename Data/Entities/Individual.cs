using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Individual
    {   
        
        public int Id { get; set; }
        public string RecordIncident { get; set; }
        public string Organization { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime UpdateDate { get; set; }
        public virtual Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
