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
    [Table("Zatrudnienie")]
    public class Zatrudnienie
    {
        [Key]
        public int? ID_pracownika { get; set; }

        public int? ID_Dzial { get; set; }
        public string Stanowisko { get; set; }
        public DateTime Data_od { get; set; }
        public DateTime Data_do { get; set; }
        
        [ForeignKey("PracownikRefId")]
        public virtual Pracownik pracownik { get; set; } 
        
      [ForeignKey("DzialRefId")]
        public virtual Dzial dzial { get; set; }
    }
}
