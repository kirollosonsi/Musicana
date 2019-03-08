namespace Musicana.Data.Core.Domain
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MusicanaEntities : DbContext
    {
        public MusicanaEntities()
            : base("name=MusicanaEntities")
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<ArtistSong> ArtistSongs { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .Property(e => e.Price)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Album>()
                .Property(e => e.Discount)
                .HasPrecision(2, 2);

            modelBuilder.Entity<Album>()
                .Property(e => e.Pic)
                .IsUnicode(false);

            modelBuilder.Entity<Album>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Album)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Artist>()
                .HasMany(e => e.ArtistSongs)
                .WithRequired(e => e.Artist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Total)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.price)
                .HasPrecision(8, 2);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Discount)
                .HasPrecision(2, 2);

            modelBuilder.Entity<Song>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<Song>()
                .HasMany(e => e.ArtistSongs)
                .WithRequired(e => e.Song)
                .WillCascadeOnDelete(false);
        }
    }
}
