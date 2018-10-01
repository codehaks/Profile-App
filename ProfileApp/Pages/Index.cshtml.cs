using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Codehaks.Extentions.LiteDb;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProfileApp.Models;

namespace ProfileApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly LiteDbContext _db;
        public IndexModel(LiteDbContext db)
        {
            _db = db;
        }

        public List<UserProfile> ProfileList { get; set; }
        public void OnGet()
        {
            var profileCollection= _db.Context.GetCollection<UserProfile>();
            ProfileList = profileCollection.FindAll().ToList();
        }
    }
}