namespace Musicana.Data.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArtistSong")]
    public partial class ArtistSong
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ArtistId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SongId { get; set; }

        [StringLength(150)]
        public string Note { get; set; }

        public virtual Artist Artist { get; set; }

        public virtual Song Song { get; set; }
    }
}
