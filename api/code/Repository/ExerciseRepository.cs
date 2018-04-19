using SnappetChallenge.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SnappetChallenge.Repository
{
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly IEnumerable<Exercise> _cachedExerciseData;

        public ExerciseRepository()
        {
            _cachedExerciseData = CachedData.Data;
        }

        public IEnumerable<Exercise> Get(DateTime startDate, DateTime endDate)
        {
            return _cachedExerciseData.Where(c => c.SubmitDateTime > startDate && c.SubmitDateTime < endDate);
        }
    }
}
