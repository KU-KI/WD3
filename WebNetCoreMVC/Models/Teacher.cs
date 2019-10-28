using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebNetCoreMVC.Models
{
    public class Teacher
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Meno")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Priezvisko")]
        public string LastName { get; set; }
        //[NotMapped]
        [Display(Name = "Fotografia")]
        public string ImageName
        {
            get; set;
            //get { return _imageNames.Split(delimiter); }
            //set
            //{
            //    _imageNames = string.Join($"{delimiter}", value);
            //}
        }
    }
}
