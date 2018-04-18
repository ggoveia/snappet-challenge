using SnappetChallenge.Model;
using System.Collections.Generic;

namespace SnappetChallenge.Repository
{
    public interface IExerciseRepository
    {
        IEnumerable<Exercise> Get();
    }
}
