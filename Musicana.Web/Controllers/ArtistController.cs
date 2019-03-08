using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Musicana.Data.Core;
using Musicana.Data.Core.Domain;
using Musicana.Data.Persistance;

namespace Musicana.Web.Controllers
{
    public class ArtistController : ApiController
    {
        private readonly IUnitOfWork _uow;

        public ArtistController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public ArtistController()
        {
            _uow = new UnitOfWork(new MusicanaEntities());
        }
        public IEnumerable<Artist> Get()
        {
            return _uow.Atrists.GetAll();
        }
    }
}
