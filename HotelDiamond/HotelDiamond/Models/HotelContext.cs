using MySql.Data.Entity;
using System.Data.Entity;
using HotelDiamond.Models;

namespace HotelDiamond
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class HotelContext : DbContext
    {
        public HotelContext(): base("Conn") { }
        public DbSet<User> Users { get; set; }
    }
}