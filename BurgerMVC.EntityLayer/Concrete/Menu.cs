using BurgerMVC.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.Concrete
{
    public class Menu
    {
        public int MenuID { get; set; }
        public string MenuName { get; set; }
        public string MenuDescription { get; set; }
        public decimal MenuPrice { get; set; }
        public int MenuStock { get; set; }
        public bool MenuStatus { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime UpdatedTime { get; set; }
        public Size Size { get; set; }
        public Drinks Drinks { get; set; }

        //Nav Props
        public int OrderID { get; set; }
        public virtual Dessert Order { get; set; }

    }
}
