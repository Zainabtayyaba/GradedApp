using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CosmeticsShop.Models
{
    public partial class product
    {
        public string CategoryName { get; set; }
    }
    public class ProductMetaData
    {


        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [MaxLength(45, ErrorMessage = "The maximum length must be upto 45 characters only")]
        public string pName { get; set; }

        


        [DisplayName("Description")]
        public string description { get; set; }


        [DisplayName("Image")]
        public string pImage { get; set; }

        [DisplayName("Price")]
        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Has to be decimal with two decimal points")]
        [Range(0, 5, ErrorMessage = "The maximum possible value should be upto 5 digits")]
        public decimal price { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Category name is required")]

        public string CategoryName { get; set; }



    }
}