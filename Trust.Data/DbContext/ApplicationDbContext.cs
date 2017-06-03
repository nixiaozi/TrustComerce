using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Trust.Data.Entity;

namespace Trust.Data.DbContext
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser,ApplicationRole,string>
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }




    }
}
