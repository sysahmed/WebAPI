using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
  public  class ChargePoint:BaseEntity
    {
        [Key]
        [Required]
        [MaxLength(39)]
        public string ChangePointId { get; set; }
        [Required]
        [MaxLength(39)]
        public string Status { get; set; }
        [MaxLength(4)]
        public string FloorLevel { get; set; }
        [Required]
        public DateTime LastUpdate { get; set; }
    }
}
