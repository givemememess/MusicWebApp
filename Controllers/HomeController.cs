using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicWebApplication.Models;
using MusicWebApplication.Models.MusicModel;

namespace MusicWebApplication.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext database;

        public HomeController(ApplicationContext context)
        {
            database = context;
        }

        public async Task<IActionResult> Index()
        {
            IQueryable<Track> tracks = database.Tracks.Include(x => x.Producer);

            return View(await tracks.AsNoTracking().ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
