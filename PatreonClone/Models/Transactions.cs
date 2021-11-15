using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatreonClone.Models
{
     public class Transactions : BaseEntity
     {
          public Guid FromUserId { get; set; }
          public Guid ToUserId { get; set; }
          public DateTime CreatedAt { get; set; }
          public decimal Amount { get; set; }

          public User User { get; set; }
     }
}
