using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AcmeStockModel
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        

        [Required]
        [StringLength(10)]
        public string? ProductId { get; set; }

        [StringLength(100)]
        [Required]
        public string? ProductName { get; set; }

        [Required]
        [Range(0, 99999)]
        public int ProductQuantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        [Range(0, 999.99)]
        public decimal ProductPrice { get; set; }

        public DateOnly ProductManufactured { get; set; }

    }
}
