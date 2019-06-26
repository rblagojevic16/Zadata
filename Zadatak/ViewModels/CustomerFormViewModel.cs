using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zadatak.Models;

namespace Zadatak.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public Customer Customer { get; set; }
    }
}