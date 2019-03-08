using Musicana.Data.Core.Domain;
using Musicana.Data.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musicana.Data.Persistance.Repositories
{
    public class AlbumRepository:Repository<Album>, IAlbumRepository
    {
        public AlbumRepository(DbContext ctx):base(ctx)
        {

        }
    }
}
