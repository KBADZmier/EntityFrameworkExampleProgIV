using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Tabele
{
    [Table("Szkolenia")]
    public  class Szkolenia
    {
        [Key]
        public int ID_Szkolenia { get; set; }
        public int ID_Pracownika { get; set; }
        public string Nazwa_Szkolenia { get; set; }
        public DateTime Data_Szkolenia { get; set; }
        public virtual Pracownik pracownik { get; set; }

    }
}
