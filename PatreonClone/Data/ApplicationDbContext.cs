using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PatreonClone.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatreonClone.Data
{
     public class ApplicationDbContext : IdentityDbContext
     {
          public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
              : base(options)
          {
          }

          public virtual DbSet<Packages> Packages { get; set; }
          public virtual DbSet<Post> Posts { get; set; }
          public virtual DbSet<Subscriptions> Subscriptions { get; set; }
          public virtual DbSet<Transactions> Transactions { get; set; }
          public virtual DbSet<User> Users { get; set; }
     }
}
