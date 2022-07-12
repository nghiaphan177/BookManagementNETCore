using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Intervention
    {   
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime ProfileDate { get; set; }
        public string Sumary { get; set; }
        public bool Profile_IsCompeleted { get; set; }
        public bool Manage_IsCompeleted { get; set; }
        public bool Prevent_IsCompeleted { get; set; }

        //mild
        public virtual int? Profile_Mild_Id { get; set; }
        [ForeignKey("Profile_Mild_Id")]
        public virtual Profile_Mild Profile_Mild { get; set; }
        public string Profile_Mild_Description { get; set; }

        //modaterate
        public virtual int? Profile_Moderate_Id { get; set; }
        [ForeignKey("Profile_Moderate_Id")]
        public virtual Profile_Moderate Profile_Moderate { get; set; }
        public string Profile_Moderate_Description { get; set; }

        //extreme
        public virtual int? Profile_Extreme_Id { get; set; }
        [ForeignKey("Profile_Extreme_Id")]
        public virtual Profile_Extreme Profile_Extreme { get; set; }
        public string Profile_Extreme_Description { get; set; }

        //manage
        public string Manage_Mild { get; set; }
        public string Manage_Moderate { get; set; }
        public string Manage_Extreme { get; set; }
        public string Manage_Recovery { get; set; }


        //prevent
        public string Prevent_Status { get; set; }
        public string Prevent_Activity { get; set; }
        public string Prevent_Interaction { get; set; }
        public string Prevent_Inviromental { get; set; }

        //individual
        public virtual int IndividualId { get; set; }
        [ForeignKey("IndividualId")]
        public virtual Individual Individual { get; set; }
    }
}
