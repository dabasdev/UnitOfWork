using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("film_actor")]
    public partial class FilmActor
    {
        [Column("actor_id")]
        public int ActorId { get; set; }
        [Column("film_id")]
        public int FilmId { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("ActorId")]
        [InverseProperty("FilmActors")]
        public virtual Actor Actor { get; set; }
        [ForeignKey("FilmId")]
        [InverseProperty("FilmActors")]
        public virtual Film Film { get; set; }
    }
}