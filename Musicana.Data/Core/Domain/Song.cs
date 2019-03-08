namespace Musicana.Data.Core.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Song")]
    public partial class Song
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Song()
        {
            ArtistSongs = new HashSet<ArtistSong>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(255)]
        public string URL { get; set; }

        public int? AuthorId { get; set; }

        public int? GenreId { get; set; }

        public int? AlbumId { get; set; }

        public virtual Album Album { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtistSong> ArtistSongs { get; set; }

        public virtual Author Author { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
