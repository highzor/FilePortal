using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using FilePortal.FileServiceReference;

namespace FilePortal.Models
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() : base("PortalDB") { }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
    }
}