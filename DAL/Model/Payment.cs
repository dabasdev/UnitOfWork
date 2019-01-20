using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("payment")]
    public partial class Payment
    {
        [Column("payment_id")]
        public int PaymentId { get; set; }
        [Column("customer_id")]
        public int CustomerId { get; set; }
        [Column("staff_id")]
        public byte StaffId { get; set; }
        [Column("rental_id")]
        public int? RentalId { get; set; }
        [Column("amount", TypeName = "decimal(5, 2)")]
        public decimal Amount { get; set; }
        [Column("payment_date")]
        public DateTime PaymentDate { get; set; }
        [Column("last_update")]
        public DateTime? LastUpdate { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("Payments")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("RentalId")]
        [InverseProperty("Payments")]
        public virtual Rental Rental { get; set; }
        [ForeignKey("StaffId")]
        [InverseProperty("Payments")]
        public virtual Staff Staff { get; set; }
    }
}