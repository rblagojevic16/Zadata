using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Zadatak.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Category Category { get; set; }

        [Display(Name = "Vozacka dozvola")]
        public byte CategoryId { get; set; }
    }
}