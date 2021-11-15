using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatreonClone.Models
{
     public class Subscriptions : BaseEntity
     {
          public Guid UserId { get; set; }
          public Guid PackageId { get; set; }
          public Guid CreatorId { get; set; }

          public DateTime StartAt { get; set; }
          public DateTime ExpiresAt { get; set; }

          public User User { get; set; }    
     }
}
