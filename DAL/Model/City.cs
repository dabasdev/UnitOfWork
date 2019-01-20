using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("city")]
    public partial class City
    {
        public City()
        {
            Addresses = new HashSet<Address>();
        }

        [Column("city_id")]
        public int CityId { get; set; }
        [Required]
        [Column("city")]
        [StringLength(50)]
        public string City1 { get; set; }
        [Column("country_id")]
        public int CountryId { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("CountryId")]
        [InverseProperty("Cities")]
        public virtual Country Country { get; set; }
        [InverseProperty("City")]
        public virtual ICollection<Address> Addresses { get; set; }
    }
}