using System;
using System.ComponentModel.DataAnnotations;

namespace Ramirez_Mackenzie_HW4.Models
{
    // PRODUCT TYPE
    public enum ProductType { Hot, Cold, Packaged, Drink, Other }

    public class Product
    {
        // PRODUCT ID
        [Key]
        [Required]
        public Int32 ProductID { get; set; }

        // PRODUCT NAME
        [Required(ErrorMessage = "Product name is required!")]
        [Display(Name = "Product Name:")]
        public String Name { get; set; }

        // DESCRIPTION
        [Display(Name = "Product Description:")]
        public String Description { get; set; }

        // PRICE
        [Display(Name = "Product Price:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Price { get; set; }

        [Display(Name = "Product Type:")]
        public ProductType productType { get; set; }


    }
}
