using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Repository;

namespace MovieManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ActorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult Get() 
        {
            var actors = _unitOfWork.Actor.GetAll();

            return Ok(actors);
        }

        [HttpGet("GetWithMovies")]
        public ActionResult GetActorWithMovies()
        {
            var actors = _unitOfWork.Actor.GetActorsWithMovies();

            return Ok(actors);
        }
    }
}
