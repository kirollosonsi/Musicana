using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musicana.Data.Core.Domain;
using Musicana.Data.Core.Repositories;

namespace Musicana.Data.Core
{
    interface IUnitOfWork
    {
        IAlbumRepository Albums { get; set; }
        IArtsistRepository Atrists { get; set; }
        IArtistSongRepository ArtistSongs { get; set; }
        IAuthorRepository Authors { get; set; }
        IGenreRepository Genres { get; set; }
        IOrderDetailRepository OrderDetails { get; set; }
        IOrderRepository Orders { get; set; }
        ISongRepository Songs { get; set; }
    }
}
