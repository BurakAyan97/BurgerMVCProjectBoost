﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.Concrete
{
    public abstract class OrderDetails
    {
        public int OrderDetailsID { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }

        public int? SauceID { get; set; }
        public Sauce? Sauce { get; set; }

        public int? ExtraID { get; set; }
        public Extra? Extra { get; set; }

        public int MenuID { get; set; }
        public Menu? Menu { get; set; }

        public int? DessertID { get; set; }
        public Dessert? Dessert { get; set; }
    }
}
