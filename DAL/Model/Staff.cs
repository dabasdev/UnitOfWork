using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("staff")]
    public partial class Staff
    {
        public Staff()
        {
            Payments = new HashSet<Payment>();
            Rentals = new HashSet<Rental>();
        }

        [Column("staff_id")]
        public byte StaffId { get; set; }
        [Required]
        [Column("first_name")]
        [StringLength(45)]
        public string FirstName { get; set; }
        [Required]
        [Column("last_name")]
        [StringLength(45)]
        public string LastName { get; set; }
        [Column("address_id")]
        public int AddressId { get; set; }
        [Column("picture")]
        public byte[] Picture { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("store_id")]
        public byte StoreId { get; set; }
        [Column("active")]
        public short Active { get; set; }
        [Required]
        [Column("username")]
        [StringLength(16)]
        public string Username { get; set; }
        [Column("password")]
        [StringLength(40)]
        public string Password { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("AddressId")]
        [InverseProperty("Staffs")]
        public virtual Address Address { get; set; }
        [ForeignKey("StoreId")]
        [InverseProperty("Staffs")]
        public virtual Store Store { get; set; }
        [InverseProperty("ManagerStaff")]
        public virtual Store StoreNavigation { get; set; }
        [InverseProperty("Staff")]
        public virtual ICollection<Payment> Payments { get; set; }
        [InverseProperty("Staff")]
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}