using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("address")]
    public partial class Address
    {
        public Address()
        {
            Customers = new HashSet<Customer>();
            Staffs = new HashSet<Staff>();
            Stores = new HashSet<Store>();
        }

        [Column("address_id")]
        public int AddressId { get; set; }
        [Required]
        [Column("address")]
        [StringLength(50)]
        public string Address1 { get; set; }
        [Column("address2")]
        [StringLength(50)]
        public string Address2 { get; set; }
        [Required]
        [Column("district")]
        [StringLength(20)]
        public string District { get; set; }
        [Column("city_id")]
        public int CityId { get; set; }
        [Column("postal_code")]
        [StringLength(10)]
        public string PostalCode { get; set; }
        [Required]
        [Column("phone")]
        [StringLength(20)]
        public string Phone { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("CityId")]
        [InverseProperty("Addresses")]
        public virtual City City { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<Customer> Customers { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<Staff> Staffs { get; set; }
        [InverseProperty("Address")]
        public virtual ICollection<Store> Stores { get; set; }
    }
}