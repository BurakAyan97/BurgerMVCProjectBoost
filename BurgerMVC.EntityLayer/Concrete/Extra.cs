using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.Concrete
{
    public class Extra : BaseEntity
    {
        //nav props
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public Extra()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }
    }
}
