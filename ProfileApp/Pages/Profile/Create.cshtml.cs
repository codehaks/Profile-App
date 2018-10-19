using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public UserProfile Input { get; set; }



        public IActionResult OnPost()
        {
            var profiles=_db.Context.GetCollection<UserProfile>();

            profiles.Insert(Input);

            return RedirectToPage("/Index");
        }
    }
}