using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CosmeticsShop.Models
{
    [MetadataType(typeof(CategoryMetaData))]
    public partial class category
    {
    }
    public class CategoryMetaData
    {

        [Display(Name = "Category ID")]
        public int catId { get; set; }
        [Display(Name = "Category Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Category Name Required")]

        public string catName { get; set; }
    }
}