using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.Concrete
{
    public class Sauce
    {
        public int SauceID { get; set; }
        public string SauceName { get; set; }
        public decimal SaucePrice { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime UpdatedTime { get; set; }
        public int SauceStock { get; set; }
        public bool SauceStatus { get; set; }

        //Nav Props
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
    }
}
