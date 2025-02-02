﻿using SEDC.PizzaApp.v1.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.v1.Models.ViewModels
{
    public class OrderViewModel
    {

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Display(Name = "Pizza Name")]
        public string PizzaName { get; set; }
        [Display(Name = "Pizza Size")]
        public PizzaSize Size { get; set; }
    }
}
