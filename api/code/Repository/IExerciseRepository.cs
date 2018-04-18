using SnappetChallenge.Model;
using System;
using System.Collections.Generic;

namespace SnappetChallenge.Repository
{
    public interface IExerciseRepository
    {
        IEnumerable<Exercise> Get(DateTime startDate, DateTime endDate);
    }
}
