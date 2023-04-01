using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.Concrete
{
    public class Extra
    {
        public int ExtraID { get; set; }
        public string ExtraName { get; set; }
        public decimal ExtraPrice { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime UpdatedTime { get; set; }
        public int ExtraStock { get; set; }
        public bool ExtraStatus { get; set; }

        //nav props
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
    }
}
