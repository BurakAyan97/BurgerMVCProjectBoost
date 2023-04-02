using BurgerMVC.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.DataLayer.Configuration
{
    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.HasKey(x => x.OrderDetailsID);

            builder.HasOne(x => x.Sauce).WithMany(x => x.OrderDetails).HasForeignKey(x => x.SauceID).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasOne(x => x.Dessert).WithMany(x => x.OrderDetails).HasForeignKey(x => x.DessertID).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasOne(x => x.Extra).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ExtraID).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasOne(x => x.Menu).WithMany(x => x.OrderDetails).HasForeignKey(x => x.MenuID).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasOne(x => x.Order).WithMany(x => x.OrderDetails).HasForeignKey(x => x.OrderID).OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}
