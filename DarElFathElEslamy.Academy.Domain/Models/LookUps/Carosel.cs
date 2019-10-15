using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarElFathElEslamy.Academy.Domain.Models.LookUps
{
    public class Carosel
    {
        public int Id { get; set; }
        [Display(Name = "English Title")]
        public string EnTitle { get; set; }
        [Display(Name = "English Description")]
        public string EnDesc { get; set; }
        [Display(Name = "French Title")]
        public string FrTitle { get; set;}
        [Display(Name = "French Description")]
        public string FrDesc { get; set; }
        [Display(Name = "ImagePath")]
        public string ImagePath { get; set; }


    }
}
