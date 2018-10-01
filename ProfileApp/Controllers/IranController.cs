using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Codehaks.IranData;
using Microsoft.AspNetCore.Mvc;

namespace ProfileApp.Controllers
{
    public class IranController : ControllerBase
    {
        private readonly IranDbContext _db;

        public IranController(IranDbContext db)
        {
            _db = db;
        }

        [Route("iran/provinces")]
        public IActionResult GetProvinces()
        {
            return Ok(_db.Provinces);
        }

        [Route("iran/cities")]
        public IActionResult GetCities()
        {
            return Ok(_db.Cities);
        }
    }
}