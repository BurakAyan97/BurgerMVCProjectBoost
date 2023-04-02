using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.Concrete
{
    public class Drink : BaseEntity
    {
        //Nav Props
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public Drink()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }
    }
}
