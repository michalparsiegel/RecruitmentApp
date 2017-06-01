using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RecruitmentApp.Models
{
    [Table("Customer")]
    public partial class Customer
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name is too long (max: 100 characters)")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        [StringLength(100, ErrorMessage = "Surname is too long (max: 100 characters)")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Telephone number is required")]
        [StringLength(100, ErrorMessage = "Telephone number is too long (max: 100 characters)")]
        [Display(Name = "Telephone number")]
        public string TelephoneNumber { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(250, ErrorMessage = "Address is too long (max: 250 characters)")]
        public string Address { get; set; }
    }
}