using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Tabele
{
    [Table("Dzial")]
    public class Dzial
    {
        [Key]
        public int ID_Dzial { get; set; }
        public string Nazwa { get; set; }
       
        public virtual Zatrudnienie zatrudnienie { get; set; }


    }
}
