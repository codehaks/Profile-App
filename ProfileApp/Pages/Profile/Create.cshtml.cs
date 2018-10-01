using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProfileApp.Pages.Profile
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }

        public void OnGet()
        {

        }
    }
}