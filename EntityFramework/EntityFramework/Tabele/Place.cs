using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Tabele
{
    [Table("Place")]
    public  class Place
    {
        [Key]
        public int ID_Place { get; set; }
        public int ID_Pracownika { get; set; }
        public double Stawka_Godzinowa { get; set; }
        public double Wyplata_Netto { get; set; }
        public double Wyplata_Brutto { get; set; }
        public virtual Pracownik pracownik { get; set; }
        public virtual ICollection<Skladki> skladki { get; set; } = new List<Skladki>();
    }
}
