using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Zadatak.Models;

namespace Zadatak.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
       
        public CategoryDto Category { get; set; }

        public byte CategoryId { get; set; }
    }
}