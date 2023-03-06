using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Domain.Common
{
    public class Database
    {
        public List<MovieModel> GetAllMoviesResponses = new List<MovieModel> 
        { 
            new MovieModel { Id = 1, Name = "Spuderman" },
            new MovieModel { Id = 2, Name = "Spuderman 2"}
        };
        internal List<ProjectionModel> getAllProjectionsResponse;
    }
}
