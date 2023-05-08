using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Tabele
{
    [Table("Status")]
    public  class Status
    {
        [Key]
        public int ID_Status { get; set; }
        public string Opis { get; set; }
        public virtual PosiadanyStatus posiadanyStatus {get; set; }
    }
}
