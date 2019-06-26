using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zadatak.Models;

namespace Zadatak.ViewModels
{
    public class RandomCarViewModel
    {
        public Car Car { get; set; }
        public List<Customer> Customers { get; set; }
    }
}