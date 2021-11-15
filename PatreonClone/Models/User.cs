using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatreonClone.Models
{
     public class User : IdentityUser
     {
          public List<Post> Posts { get; set; }
          public List<Subscriptions> Subscriptions { get; set; }
          public List<Packages> Packages { get; set; }
          public List<Transactions> Transactions { get; set; }

     }
}
