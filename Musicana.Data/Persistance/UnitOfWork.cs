using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musicana.Data.Core.Domain;
using Musicana.Data.Core;
using Musicana.Data.Core.Repositories;
using Musicana.Data.Persistance.Repositories;
using System.Data.Entity;

namespace Musicana.Data.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        DbContext _ctx;

        public UnitOfWork(DbContext ctx)
        {
            _ctx = ctx as MusicanaEntities;
        }

        AlbumRepository albums;
        ArtistRepository artists;
        ArtistSongRepository artistSongs;
        AuthorRepository authors;
        GenreRepository genres;
        OrderDetailRepository orderDetails;
        OrderRepository orders;
        SongRepsitory songs;

        public IAlbumRepository Albums
        {
            get
            {
                if (albums == null)
                    albums = new AlbumRepository(_ctx);
                return albums;
            }

        }
        public IArtsistRepository Atrists
        {
            get
            {
                if (artists == null)
                    artists = new ArtistRepository(_ctx);
                return artists;
            }
        }
        public IArtistSongRepository ArtistSongs
        {
            get
            {
                if (artistSongs == null)
                    artistSongs = new ArtistSongRepository(_ctx);
                return artistSongs;
            }
        }
        public IAuthorRepository Authors
        {
            get
            {
                if (authors == null)
                    authors = new AuthorRepository(_ctx);
                return authors;
            }
        }
        public IGenreRepository Genres
        {
            get
            {
                if (genres == null)
                    genres = new GenreRepository(_ctx);
                return genres;
            }
        }
        public IOrderDetailRepository OrderDetails
        {
            get
            {
                if (orderDetails == null)
                    orderDetails = new OrderDetailRepository(_ctx);
                return orderDetails;
            }
        }
        public IOrderRepository Orders
        {
            get
            {
                if (orders == null)
                    orders = new OrderRepository(_ctx);
                return orders;
            }
        }
        public ISongRepository Songs
        {
            get
            {
                if (songs == null)
                    songs = new SongRepsitory(_ctx);
                return songs;
            }
        }
    }
}
