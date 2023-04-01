﻿using BurgerMVC.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.Concrete
{
    public class Menu : BaseEntity
    {
        public string Description { get; set; }
        public Size Size { get; set; }
        public Drinks Drinks { get; set; }

        //Nav Props
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public Menu()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

    }
}
