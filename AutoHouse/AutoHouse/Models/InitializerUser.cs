using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web;

namespace AutoHouse.Models
{
    public class InitializerUser : DropCreateDatabaseIfModelChanges<UserContext> { 
        protected override void Seed(UserContext userContext)
        {
            userContext.Users.Add(new User { Name = "fact", Password = "111" });
        }
    }
}