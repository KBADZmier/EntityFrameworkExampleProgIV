using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Tabele
{
    [Table("PrzepracowanyCzas")]
    public class PrzepracowanyCzas
    {
        [Key]
        public int ID_Przpracowny { get; set; }
        public double Ilosc_Godzin { get; set; }
        public DateTime Data { get; set; }
        
        public virtual Pracownik pracownik { get; set; }

    }
}
