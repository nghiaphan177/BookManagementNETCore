using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Assessment
    {   
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime RecordDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime RecordStart { get; set; }
        [DataType(DataType.Date)]
        public DateTime RecordEnd { get; set; }
        public string RecordWhere { get; set; }
        public string RecordWho { get; set; }
        public bool Record_IsCompeleted { get; set; }
        public bool Ana_IsCompeleted { get; set; }
        public bool Fun_IsCompeleted { get; set; }
        public string Ana_Behaviour { get; set; }

        //perceived
        public virtual int? Ana_Antecedents_Perceived_Id { get; set; }
        [ForeignKey("Ana_Antecedents_Perceived_Id")]
        public virtual Ana_Antecedents_Perceived Ana_Antecedents_Perceived { get; set; }
        public string Ana_Antecedents_Perceived_Description { get; set; }

        //enviromental
        public virtual int? Ana_Antecedents_Enviromental_Id { get; set; }
        [ForeignKey("Ana_Antecedents_Enviromental_Id")]
        public virtual Ana_Antecedents_Enviromental Ana_Antecedents_Enviromental { get; set; }
        public string Ana_Antecedents_Enviromental_Description { get; set; }

        //activity
        public virtual int? Ana_Antecedents_Activity_Id { get; set; }
        [ForeignKey("Ana_Antecedents_Activity_Id")]
        public virtual Ana_Antecedents_Activity Ana_Antecedents_Activity { get; set; }
        public string Ana_Antecedents_Activity_Description { get; set; }

        //consequences
        public string Ana_Consequences_Perceived { get; set; }
        public string Ana_Consequences_Enviroment { get; set; }
        public string Ana_Consequences_Activity { get; set; }

        //function
        public string Function_Antecedents { get; set; }
        public string Function_Consequences { get; set; }

        //individual
        public virtual int IndividualId { get; set; }
        [ForeignKey("IndividualId")]
        public virtual Individual Individual { get; set; }






    }
}
