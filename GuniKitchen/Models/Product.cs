﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuniKitchen.Models
{
    [Table("Products")]
    public class Product
    {
        [Display(Name = "Product ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Display(Name = "Product Name")]
        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Display(Name = "Product Discription")]
        [Required]
        public string ProductDesc { get; set; }

        [Display(Name = "Product Size")]
        [Required]
        [StringLength(20)]
        [Column("varchar")]
        public string ProductSize { get; set; }

        [Display(Name = "Product Price")]
        [Required]
        public double ProductPrice { get; set; }

        [Display(Name = "Product Image")]
        [Required]
        public string ProductImage { get; set; }

        [Display(Name = "Product Type")]
        [ForeignKey("ProductTypeId")]
        public int ProductTypeId { get; set; }

        public virtual ProductType ProductType { get; set; }
    }
}
