using IdentityService.Persistence.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityService.Persistence.Data
{
    public class AuthDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AuthDbContext(DbContextOptions options) : base(options)
        {
        }




        protected override  void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);



            builder.Entity<AppUser>(b =>
            {
                b.HasIndex(u => u.ReferralCode).IsUnique();
            }); // todo : auto generated geri dönüp incele !!!!


        }
    }
}
