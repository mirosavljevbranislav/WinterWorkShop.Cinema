using Microsoft.AspNetCore.Mvc;
using WinterWorkShop.Cinema.Data.Repositories;
using WinterWorkShop.Cinema.Domain.Responses;

namespace WinterWorkShop.Cinema.API.Controllers
{
    [ApiController]
    [Route("projection")]
    public class ProjectionsController : ControllerBase
    {

        public readonly IProjectionRepository _projectionRepository;

        public ProjectionsController(IProjectionRepository projectionRepository)
        {
            _projectionRepository = projectionRepository;
        }

        [HttpGet()]
        public List<GetAllProjectionsResponse> GetAllProjections()
        {
            var projections = _projectionRepository.GetAllProjections();
            var result = new List<GetAllProjectionsResponse>();
            foreach (var projection in projections)
            {
                result.Add(new GetAllProjectionsResponse { Id = projection.Id, Time = projection.Time });
            }

            return result;
        }

    }
}
