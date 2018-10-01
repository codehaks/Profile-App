using Codehaks.IranData;
using Codehaks.IranData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ProfileApp.ViewComponents
{
    public class SelectLocationViewComponent : ViewComponent
    {
        private readonly IranDbContext _db;

        public SelectLocationViewComponent(IranDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _db.Provinces.ToListAsync();
            return View(model);
        }
    }
}
