using SnappetChallenge.Model;
using System;
using System.Collections.Generic;

namespace SnappetChallenge.Service
{
    public interface IReportService
    {
        IEnumerable<ExerciseBySubject> GetExercisesBySubject(DateTime startDate, DateTime endDate)
    }
}
