using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
  public  class BaseEntity
    {
        [Key]
        [Required]
        [MaxLength(39)]
        public string LocationId { get; set; }
    }
}
