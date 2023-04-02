using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.Concrete
{
    public class Sauce : BaseEntity
    {
        //Nav Props
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public Sauce()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }
    }
}
