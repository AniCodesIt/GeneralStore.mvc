using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStore.mvc.Models
{
    public class Product
    {
        [Key]
        public int ProductId;
        [Required]
        [Display(Name = "Product Name")]
        public string Name;
        [Required]
        [Display(Name = "# In Stock")]
        public int InventoryCount;
        [Required]
        public decimal Price;
        [Required]
        [Display(Name = "It is food")]
        public bool IsFood;
    }
}