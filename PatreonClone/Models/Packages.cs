using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatreonClone.Models
{
     public class Packages : BaseEntity
     {
          public Guid UserId { get; set; }
          public string  Title { get; set; }
          public string Description { get; set; }
          public decimal Price { get; set; }
          public DateTime CreatedAt { get; set; }
          public DateTime UpdatedAt { get; set; }
          public DateTime DeletedAt { get; set; }
          public int Tier { get; set; }

          public User User { get; set; }
          public List<Subscriptions> Subscriptions { get; set; }
     }
}
