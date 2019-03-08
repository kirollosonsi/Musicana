using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musicana.Data.Core.Domain;
using Musicana.Data.Core;
using Musicana.Data.Core.Repositories;

namespace Musicana.Data.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        public IAlbumRepository Albums { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IArtsistRepository Atrists { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IArtistSongRepository ArtistSongs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IAuthorRepository Authors { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IGenreRepository Genres { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IOrderDetailRepository OrderDetails { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IOrderRepository Orders { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ISongRepository Songs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
