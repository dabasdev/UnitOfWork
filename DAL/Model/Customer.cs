using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("customer")]
    public partial class Customer
    {
        public Customer()
        {
            Payments = new HashSet<Payment>();
            Rentals = new HashSet<Rental>();
        }

        [Column("customer_id")]
        public int CustomerId { get; set; }
        [Column("store_id")]
        public byte StoreId { get; set; }
        [Required]
        [Column("first_name")]
        [StringLength(45)]
        public string FirstName { get; set; }
        [Required]
        [Column("last_name")]
        [StringLength(45)]
        public string LastName { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("address_id")]
        public int AddressId { get; set; }
        [Column("active")]
        public short Active { get; set; }
        [Column("create_date")]
        public DateTime CreateDate { get; set; }
        [Column("last_update")]
        public DateTime? LastUpdate { get; set; }

        [ForeignKey("AddressId")]
        [InverseProperty("Customers")]
        public virtual Address Address { get; set; }
        [ForeignKey("StoreId")]
        [InverseProperty("Customers")]
        public virtual Store Store { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<Payment> Payments { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}