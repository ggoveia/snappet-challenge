using Microsoft.AspNetCore.Mvc;
using SnappetChallenge.Repository;

namespace SnappetChallenge.Controllers
{

    [Route("api/[controller]")]
    public class ExerciseController : Controller
    {
        private readonly IExerciseRepository _exerciseRepository;

        public ExerciseController(IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return _exerciseRepository.GetExerciseInfo();
        }

    }
}
