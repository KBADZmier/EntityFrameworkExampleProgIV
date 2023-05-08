using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Tabele
{
    [Table("PosiadanyStatus")]
    public class PosiadanyStatus
    {
        [Key]
        public int ID_Pracownika { get; set; }
        
        public int ID_Status { get; set; }
        public DateTime Data_od { get; set; }
        public DateTime Data_do { get; set; }

        [ForeignKey("PracownikRefId")]
        public virtual Pracownik  pracownik { get; set;}
        [ForeignKey("StatusRefId")]
        public virtual Status status { get; set; }
    }
}
