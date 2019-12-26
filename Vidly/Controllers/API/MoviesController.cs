using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class MoviesController : ApiController
    {
        private MyDBContext _context;

        public MoviesController()
        {
            _context = new MyDBContext();
        }


    }
}
