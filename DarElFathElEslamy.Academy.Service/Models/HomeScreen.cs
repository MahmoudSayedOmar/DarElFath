using DarElFathElEslamy.Academy.Service.LocalResource;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DarElFathElEslamy.Academy.Service.Models
{
    public class HomeScreen
    {
        [Display(Name = "Home", ResourceType = typeof(Resource))]
        public string Home { get; set; }

       
    }
}