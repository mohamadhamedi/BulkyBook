using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BulkyBook.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Product Name")]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [DisplayName("Description")]
        public string Description { get; set; }
        [Required]
        [DisplayName("ISBN")]
        public string ISBN { get; set; }
        [Required]
        [DisplayName("Author")]
        public string Author { get; set; }


        [Required]
        [DisplayName("ListPrice")]
        [Range(1, 10000)]
        public double ListPrice { get; set; }

        [Required]
        [DisplayName("Price")]
        [Range(1, 10000)]
        public double Price { get; set; }

        [Required]
        [DisplayName("Price50")]
        [Range(1, 10000)]
        public double Price50 { get; set; }

        [Required]
        [DisplayName("Price100")]
        [Range(1, 10000)]
        public double Price100 { get; set; }


        [DisplayName("Product Image")]
        public string ImageURL { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [Required]
        public int CoverTypeId { get; set; }

        [ForeignKey("CoverTypeId")]
        public CoverType CoverType { get; set; }
    }
}
