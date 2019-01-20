using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("rental")]
    public partial class Rental
    {
        public Rental()
        {
            Payments = new HashSet<Payment>();
        }

        [Column("rental_id")]
        public int RentalId { get; set; }
        [Column("rental_date")]
        public DateTime RentalDate { get; set; }
        [Column("inventory_id")]
        public int InventoryId { get; set; }
        [Column("customer_id")]
        public int CustomerId { get; set; }
        [Column("return_date")]
        public DateTime? ReturnDate { get; set; }
        [Column("staff_id")]
        public byte StaffId { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("Rentals")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("InventoryId")]
        [InverseProperty("Rentals")]
        public virtual Inventory Inventory { get; set; }
        [ForeignKey("StaffId")]
        [InverseProperty("Rentals")]
        public virtual Staff Staff { get; set; }
        [InverseProperty("Rental")]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}