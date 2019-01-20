using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("film")]
    public partial class Film
    {
        public Film()
        {
            FilmActors = new HashSet<FilmActor>();
            FilmCategories = new HashSet<FilmCategory>();
            Inventories = new HashSet<Inventory>();
        }

        [Column("film_id")]
        public int FilmId { get; set; }
        [Required]
        [Column("title")]
        [StringLength(255)]
        public string Title { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("release_year")]
        public int? ReleaseYear { get; set; }
        [Column("language_id")]
        public byte LanguageId { get; set; }
        [Column("original_language_id")]
        public byte? OriginalLanguageId { get; set; }
        [Column("rental_duration")]
        public byte RentalDuration { get; set; }
        [Column("rental_rate", TypeName = "decimal(4, 2)")]
        public decimal RentalRate { get; set; }
        [Column("length")]
        public int? Length { get; set; }
        [Column("replacement_cost", TypeName = "decimal(5, 2)")]
        public decimal ReplacementCost { get; set; }
        [Column("rating")]
        [StringLength(255)]
        public string Rating { get; set; }
        [Column("special_features")]
        [StringLength(255)]
        public string SpecialFeatures { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("LanguageId")]
        [InverseProperty("FilmLanguages")]
        public virtual Language Language { get; set; }
        [ForeignKey("OriginalLanguageId")]
        [InverseProperty("FilmOriginalLanguages")]
        public virtual Language OriginalLanguage { get; set; }
        [InverseProperty("Film")]
        public virtual ICollection<FilmActor> FilmActors { get; set; }
        [InverseProperty("Film")]
        public virtual ICollection<FilmCategory> FilmCategories { get; set; }
        [InverseProperty("Film")]
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}