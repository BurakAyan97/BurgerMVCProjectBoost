using BurgerMVC.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderID { get; set; }
        public string OrderName { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedTime { get; set; }
        public OrderStatus Status { get; set; }

        //Nav Prop
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public Order()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public string AppUserID { get; set; }
        public virtual AppUser User { get; set; }

    }
}
