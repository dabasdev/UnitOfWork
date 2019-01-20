using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("store")]
    public partial class Store
    {
        public Store()
        {
            Customers = new HashSet<Customer>();
            Inventories = new HashSet<Inventory>();
            Staffs = new HashSet<Staff>();
        }

        [Column("store_id")]
        public byte StoreId { get; set; }
        [Column("manager_staff_id")]
        public byte ManagerStaffId { get; set; }
        [Column("address_id")]
        public int AddressId { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("AddressId")]
        [InverseProperty("Stores")]
        public virtual Address Address { get; set; }
        [ForeignKey("ManagerStaffId")]
        [InverseProperty("StoreNavigation")]
        public virtual Staff ManagerStaff { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<Customer> Customers { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<Inventory> Inventories { get; set; }
        [InverseProperty("Store")]
        public virtual ICollection<Staff> Staffs { get; set; }
    }
}