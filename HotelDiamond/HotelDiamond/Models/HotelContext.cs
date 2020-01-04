using MySql.Data.Entity;
using System.Data.Entity;
using HotelDiamond.Models;

namespace HotelDiamond
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class HotelContext : DbContext
    {
        public DbSet<User> Users
        {
            get;
            set;
        }
        public HotelContext()
            //Reference the name of your connection string ( WebAppCon )  
            : base("WebAppCon") { }
    }
}