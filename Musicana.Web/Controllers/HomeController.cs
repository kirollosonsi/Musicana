using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Musicana.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public FileResult Index()
        {
            return File("index.html", "text/html");
        }
    }
}