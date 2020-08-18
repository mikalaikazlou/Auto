using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AutoHouse.Models
{
    public class UserContext:DbContext
    {
        public UserContext() : base("UserLogin") { }
        public DbSet<User> Users { get; set; }
    }
}