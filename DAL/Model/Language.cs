using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("language")]
    public partial class Language
    {
        public Language()
        {
            FilmLanguages = new HashSet<Film>();
            FilmOriginalLanguages = new HashSet<Film>();
        }

        [Column("language_id")]
        public byte LanguageId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(20)]
        public string Name { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [InverseProperty("Language")]
        public virtual ICollection<Film> FilmLanguages { get; set; }
        [InverseProperty("OriginalLanguage")]
        public virtual ICollection<Film> FilmOriginalLanguages { get; set; }
    }
}