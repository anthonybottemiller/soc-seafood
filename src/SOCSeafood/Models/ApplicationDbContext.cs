using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SOCSeafood.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationAdministrator>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
