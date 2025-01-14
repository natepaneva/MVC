﻿using SEDC.PizzaApp.v1.Models.Domain;
using SEDC.PizzaApp.v1.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.v1.DB
{
    public static class StaticDb
    {
        public static List<Order> Orders;
        public static List<Pizza> Menu;
        public static List<User> Users;
        public static int OrderId;
        public static int UserId;

        static StaticDb()
        {
            Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Bobsky",
                    Address = "Bob Street",
                    Phone = "070222333"
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Jill",
                    LastName = "Wayne",
                    Address = "Jill Street",
                    Phone = "070222444"
                }
            };

            Menu = new List<Pizza>()
            {
                new Pizza()
                {
                    Id = 1,
                    Name = "Kapri",
                    Price = 7,
                    Size = PizzaSize.Medium
                },
                new Pizza()
                {
                    Id = 2,
                    Name = "Kapri",
                    Price = 8,
                    Size = PizzaSize.Large
                },
                new Pizza()
                {
                    Id = 3,
                    Name = "Kapri",
                    Price = 9,
                    Size = PizzaSize.Family
                },
                new Pizza()
                {
                    Id = 4,
                    Name = "Peperoni",
                    Price = 9,
                    Size = PizzaSize.Medium
                },
                new Pizza()
                {
                    Id = 5,
                    Name = "Peperoni",
                    Price = 10,
                    Size = PizzaSize.Large
                },
                new Pizza()
                {
                    Id = 6,
                    Name = "Peperoni",
                    Price = 11,
                    Size = PizzaSize.Family
                },
                new Pizza()
                {
                    Id = 7,
                    Name = "Margarita",
                    Price = 6,
                    Size = PizzaSize.Medium
                },
                new Pizza()
                {
                    Id = 8,
                    Name = "Margarita",
                    Price = 7,
                    Size = PizzaSize.Large
                },
                new Pizza()
                {
                    Id = 9,
                    Name = "Margarita",
                    Price = 8,
                    Size = PizzaSize.Family
                },
                new Pizza()
                {
                    Id = 10,
                    Name = "Siciliana",
                    Price = 6.5,
                    Size = PizzaSize.Medium
                },
                new Pizza()
                {
                    Id = 11,
                    Name = "Siciliana",
                    Price = 9.5,
                    Size = PizzaSize.Large
                },
                new Pizza()
                {
                    Id = 12,
                    Name = "Siciliana",
                    Price = 9.5,
                    Size = PizzaSize.Family
                }
            };

            Orders = new List<Order>()
            {
                new Order()
                {
                    Id = 1,
                    User = Users[0],
                    Pizza = Menu[0],
                    Delivered = false,
                    Price = Menu[0].Price + 2
                },
                 new Order()
                {
                    Id = 2,
                    User = Users[0],
                    Pizza = Menu[1],
                    Delivered = true,
                    Price = Menu[1].Price + 2
                },
                  new Order()
                {
                    Id = 3,
                    User = Users[1],
                    Pizza = Menu[2],
                    Delivered = false,
                    Price = Menu[2].Price + 2
                }
            };
            OrderId = 3;
            UserId = 2;
        }
    }
}
