using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musicana.Data.Core.Domain;
using Musicana.Data.Core.Repositories;

namespace Musicana.Data.Persistance.Repositories
{
    public class SongRepsitory : Repository<Song>, ISongRepository
    {
        public SongRepsitory(DbContext ctx):base(ctx)
        {

        }
    }
}
