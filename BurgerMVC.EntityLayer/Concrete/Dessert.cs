using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.Concrete
{
    public class Dessert
    {
        public int DessertID { get; set; }
        public string DessertName { get; set; }
        public decimal DessertPrice { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime UpdatedTime { get; set; }
        public int DessertStock { get; set; }
        public bool DessertStatus { get; set; }
        
        //Nav props
        public int OrderID { get; set; }
        public virtual Dessert Order { get; set; }
    }
}
