using System.ComponentModel.DataAnnotations;

namespace wd3_2024.Models
{
    public class Teacher
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Meno")]
        public string? FirstName { get; set; }
        [Required]
        [Display(Name = "Priezvisko")]
        public string? LastName { get; set; }
        //[NotMapped]
        [Display(Name = "Fotografia")]
        public string? ImageName { get; set; }
    }
}
