﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Zadatak.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}