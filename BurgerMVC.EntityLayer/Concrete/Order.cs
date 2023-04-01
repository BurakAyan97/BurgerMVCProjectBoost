using BurgerMVC.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.Concrete
{
    public class Dessert
    {
        public int OrderID { get; set; }
        public string OrderName { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedTime { get; set; }
        public OrderStatus Status { get; set; }

        //Nav Prop
        public ICollection<Menu> Menus { get; set; }
        public ICollection<Extra> Extras { get; set; }
        public ICollection<Dessert> Desserts { get; set; }
        public ICollection<Sauce> Sauces { get; set; }

        public Dessert()
        {
            Menus = new HashSet<Menu>();
            Extras = new HashSet<Extra>();
            Desserts = new HashSet<Dessert>();
            Sauces = new HashSet<Sauce>();
        }

        public string UserID { get; set; }
        public virtual AppUser User { get; set; }

    }
}
