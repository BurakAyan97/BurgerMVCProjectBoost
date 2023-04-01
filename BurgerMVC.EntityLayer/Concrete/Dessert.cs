using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.Concrete
{
    public class Dessert : BaseEntity
    {

        //Nav props
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public Dessert()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }
    }
}
