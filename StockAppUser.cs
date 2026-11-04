using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AcmeStockModel
{
    public class StockAppUser
    {
        [Key]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter Valid email")]
        [StringLength(30)]
        public string? UserEmail { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Enter user name")]
       
        public string? UserName { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[0-9])(?=.*[._+?/,!@#$%^&*-])[A-Za-z0-9._+?/,!@#$%^&*-]{8,}$", ErrorMessage = "Minimum password length 8, Password must contain one capital letter, one number, one special character")]
        public string? UserPassword { get; set; }

        [StringLength(10)]
        [Required]
        public string? UserType { get; set; }

        public bool RememberMe { get; set; }
    }
}
