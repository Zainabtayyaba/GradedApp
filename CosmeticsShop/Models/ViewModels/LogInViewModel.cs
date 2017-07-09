using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CosmeticsShop.Models.ViewModels
{
    [MetadataType(typeof(LoginViewModel))]
    public partial class LogInViewModel
    {
        [Display(Name = "Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "EmailID is required")]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Adresse mail non valide !")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }




        [Display(Name = "Password")]
       // [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public String Password { get; set; }

     
    }
}