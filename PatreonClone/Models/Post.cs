using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatreonClone.Models
{
     public class Post : BaseEntity
     {
          public Guid UserId { get; set; }
          public string Title { get; set; }
          public string Content { get; set; }
          public DateTime Date { get; set; }
          public int Tier { get; set; }

          public User User { get; set; }
     }
}
