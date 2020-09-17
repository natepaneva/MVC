using SEDC.PizzaApp.v1.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.v1.Models.ViewModels
{
    public class OrderListViewModel
    {
        [Display(Name = "First Pizza Ordered")]
        public string FirstPizza { get; set; }
        [Display(Name = "Number of orders")]
        public int NumberOfOrders{ get; set; }
        [Display(Name = "First Customer")]
        public string FirstCustomerName { get; set; }
        [Display(Name = "List of orders")]
        public List<Order> Orders { get; set; }
    }
}
