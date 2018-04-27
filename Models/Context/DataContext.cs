using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalBlog.Models.Context
{
    public class DataContext: IdentityDbContext<ApplicationUser>
    {
        public DataContext(): base("DefaultConnection") { }

        public DbSet<Models.Noticias> Noticias { get; set; }
    }
}