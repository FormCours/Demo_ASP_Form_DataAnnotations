using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo_ASP_Form.Models
{
    public class Person
    {

        public string Firstname { get; set; }

        //[Required(ErrorMessage = "Vous donnez un nom >_<")]
        [Display(Name ="Nom")]
        public string Lastname { get; set; }

        public string Message { get; set; }
    }
}