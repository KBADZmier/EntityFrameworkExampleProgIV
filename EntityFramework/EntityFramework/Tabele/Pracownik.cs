using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Tabele
{   
    [Table("Pracownik")]
    public class Pracownik
    {
        
        [Key]
        public int ID_Pracownik { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Plec { get; set; }
        public string Adres { get; set; }
        public DateTime Data_urodzenia { get; set; }
        public string Nr_konta { get; set; }
        public string Telefon_kontaktowy { get; set; }
        public virtual ICollection<Szkolenia> szkolenia { get; set; } = new List<Szkolenia>();
        public virtual ICollection<Place> place { get; set; } = new List<Place>();
        public virtual ICollection<PrzepracowanyCzas> przepracowanyCzas { get; set; } = new List<PrzepracowanyCzas>();
        public virtual PosiadanyStatus posiadanyStatus { get; set; }
        public virtual Zatrudnienie zatrudnienie { get; set; }




    }
}
