using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("inventory")]
    public partial class Inventory
    {
        public Inventory()
        {
            Rentals = new HashSet<Rental>();
        }

        [Column("inventory_id")]
        public int InventoryId { get; set; }
        [Column("film_id")]
        public int FilmId { get; set; }
        [Column("store_id")]
        public byte StoreId { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("FilmId")]
        [InverseProperty("Inventories")]
        public virtual Film Film { get; set; }
        [ForeignKey("StoreId")]
        [InverseProperty("Inventories")]
        public virtual Store Store { get; set; }
        [InverseProperty("Inventory")]
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}