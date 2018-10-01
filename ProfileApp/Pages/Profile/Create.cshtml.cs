using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Codehaks.Extentions.LiteDb;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProfileApp.Models;

namespace ProfileApp.Pages.Profile
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly LiteDbContext _db;
        public CreateModel(LiteDbContext db)
        {
            _db = db;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }

        public IActionResult OnPost()
        {
            var profiles=_db.Context.GetCollection<UserProfile>();

            profiles.Insert(new UserProfile()
            {
                FirstName = FirstName,
                LastName = LastName,
                CityId = CityId,
                ProvinceId = ProvinceId,
                TimeCreated = DateTime.Now
            });

            return RedirectToPage("./Index");
        }
    }
}