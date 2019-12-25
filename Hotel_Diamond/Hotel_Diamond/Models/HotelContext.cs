using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Hotel_Diamond.Models
{
    public class HotelContext:DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}