using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musicana.Data.Core.Domain;
using Musicana.Data.Core.Repositories;

namespace Musicana.Data.Core
{
    public interface IUnitOfWork
    {
        IAlbumRepository Albums { get; }
        IArtsistRepository Atrists { get; }
        IArtistSongRepository ArtistSongs { get; }
        IAuthorRepository Authors { get; }
        IGenreRepository Genres { get; }
        IOrderDetailRepository OrderDetails { get; }
        IOrderRepository Orders { get; }
        ISongRepository Songs { get; }
    }
}
