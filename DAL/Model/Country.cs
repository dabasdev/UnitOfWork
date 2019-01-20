using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("country")]
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }

        [Column("country_id")]
        public int CountryId { get; set; }
        [Required]
        [Column("country")]
        [StringLength(50)]
        public string Country1 { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [InverseProperty("Country")]
        public virtual ICollection<City> Cities { get; set; }
    }
}