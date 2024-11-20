using System.ComponentModel.DataAnnotations;

namespace wd3_2023.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Meno { get; set; }
        [Required]
        public string Priezvisko { get; set; }
        [Display(Name = "Dátum narodenia")]
        public DateTime DatumNarodenia { get; set; }
    }
}
