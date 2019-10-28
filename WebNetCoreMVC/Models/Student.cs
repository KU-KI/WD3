using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebNetCoreMVC.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Meno { get; set; }
        [Required]
        public string Priezvisko { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Dátum narodenia")]
        public DateTime DatumNarodenia { get; set; }
    }
}
