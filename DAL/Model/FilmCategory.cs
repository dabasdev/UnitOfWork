using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("film_category")]
    public partial class FilmCategory
    {
        [Column("film_id")]
        public int FilmId { get; set; }
        [Column("category_id")]
        public byte CategoryId { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("CategoryId")]
        [InverseProperty("FilmCategories")]
        public virtual Category Category { get; set; }
        [ForeignKey("FilmId")]
        [InverseProperty("FilmCategories")]
        public virtual Film Film { get; set; }
    }
}