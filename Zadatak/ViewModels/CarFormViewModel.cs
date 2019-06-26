using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Zadatak.Models;

namespace Zadatak.ViewModels
{
    public class CarFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Car" : "New Car";
            }
        }

        public CarFormViewModel()
        {
            Id = 0;
        }

        public CarFormViewModel(Car car)
        {
            Id = car.Id;
            Name = car.Name;
            GenreId = car.GenreId;
        }
    }
}