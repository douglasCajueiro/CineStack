using CineStack.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace CineStack.Api.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class MoviesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Title = "Modern Times", Year = 1936, PosterUrl = "https://images.fanart.tv/fanart/modern-times-5d42f0bd269d4.jpg" },
                new Movie { Id = 2, Title = "The Sound of Music", Year = 1965, PosterUrl = "https://images.fanart.tv/fanart/the-sound-of-music-52688f6bd9046.jpg" },
                new Movie { Id = 3, Title = "The Circus", Year = 1928, PosterUrl = "https://images.fanart.tv/fanart/the-circus-65b6ca5265103.jpg" },
                new Movie { Id = 3, Title = "Singin' in the Rain", Year = 1952, PosterUrl = "https://images.fanart.tv/fanart/singin-in-the-rain-522a37f7561cf.jpg" }
            };

            return Ok(movies);
        }
    }
}
