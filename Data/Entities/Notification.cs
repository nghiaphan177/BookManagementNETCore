using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ClassLibrary.Models
{
    public class Notification
    {   
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Subject { get; set; }

        public string ContentHTML { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
        public virtual Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }




    }
}
