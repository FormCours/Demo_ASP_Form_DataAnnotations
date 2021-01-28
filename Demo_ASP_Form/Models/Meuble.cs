using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo_ASP_Form.Models
{
    public class Meuble
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 3, ErrorMessage = "Le nom doit faire entre 3 et 13 caractere !")]
        [Display(Name = "Nom", Description = "Le nom du meuble")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "Catégorie")]
        public string Category { get; set; }

        [Display(Name = "Meuble de jardin")]
        public bool ForGarden { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Pas de prix negatif !")]
        [Display(Name = "Prix HTVA")]
        [DataType(DataType.Currency)]
        public double Prix { get; set; }

        [Range(2000, 2100)]
        [Display(Name= "Année de fabrication")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Merci d'encoder la référence")]
        [RegularExpression(@"^[A-Z]{3}[0-9]{5}$", ErrorMessage ="Veuillez respecter le formatage des références (Par exemple: ABC12345)")]
        [Display(Name = "Reference")]
        public string Reference { get; set; }
    }
}