using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.Concrete
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Comment { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool isActive { get; set; }

        //Navigation Props
        public virtual ICollection<Dessert> Orders { get; set; }
        public AppUser()
        {
            Orders = new HashSet<Dessert>();
        }

    }
}
