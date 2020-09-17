using SEDC.PizzaApp.v1.Models.Domain;
using SEDC.PizzaApp.v1.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.v1.Models.ViewModels
{
    public class OrderDetailsModel
    {
        [Display(Name ="Name")]
        public string OrderName { get; set; }
        [Display(Name ="Phone")]
        public string OrderPhone { get; set; }
        [Display(Name = "Pizza Name")]
        public string  PizzaName { get; set; }
        [Display(Name = "Total Price")]
        public double Price { get; set; }
    }
}
