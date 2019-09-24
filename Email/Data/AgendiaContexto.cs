
using Email.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Email.Data
{
    public class AgendiaContexto : IdentityDbContext
    {

        public AgendiaContexto(DbContextOptions<AgendiaContexto> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuario { get; set; }

        
    }
}
