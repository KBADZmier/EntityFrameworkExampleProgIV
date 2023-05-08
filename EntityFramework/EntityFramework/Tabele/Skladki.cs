using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Tabele
{
    [Table("Skladki")]
    public class Skladki
    {
        [Key]
        public int ID_Skladki { get; set; }
        public int ID_Place { get; set; }
        public string Rodzaj { get; set; }
        public double Wielkosc { get; set; }
        public DateTime Data { get; set; }
        public virtual Place place { get; set; }
    }
}
