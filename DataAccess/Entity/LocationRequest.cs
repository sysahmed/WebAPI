using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class LocationRequest : BaseEntity
    {
        [Required]
        [MaxLength(45)]
        public string Type { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(45)]
        public string Address { get; set; }

        [Required]
        [MaxLength(45)]
        public string City { get; set; }

        [Required]
        [MaxLength(45)]
        public string PostalCode { get; set; }

        [Required]
        [MaxLength(45)]
        public string Conutry { get; set; }

        [Required]
        public DateTime LastUpdated { get; set; }
    }
}
